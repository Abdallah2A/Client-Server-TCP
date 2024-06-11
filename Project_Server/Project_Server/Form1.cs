using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Project_Server
{
    public partial class Form1 : Form
    {
        private TcpListener listener;

        List<TcpClient> connectedClients = new List<TcpClient>();
        List<StreamWriter> writers = new List<StreamWriter>();

        private bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
            try
            {
                // Start server listener and wait clients to connect
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 5000);
                listener.Start();
                isRunning = true;
                status.Text += "Server Started\n";
                serverListen();
            }
            catch
            {
                status.Text += "Error in server connetion\n";
            }

        }

        // Accept clients async and save it in list
        async private void serverListen()
        {
            try
            {
                while (true)
                {
                    TcpClient client = await listener.AcceptTcpClientAsync();

                    NetworkStream stream = client.GetStream();
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    StreamWriter writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };

                    if (!connectedClients.Contains(client))
                    {
                        connectedClients.Add(client);
                        writers.Add(writer);
                        clients.Items.Add(client.Client.RemoteEndPoint.ToString());
                    }
                    receiveMessage(client, stream, reader, writer);
                }
            }
            catch { }
        }

        // Handle incomming messages
        async private void receiveMessage(TcpClient client, NetworkStream stream, StreamReader reader, StreamWriter writer)
        {
            try
            {
                while (isRunning)
                {
                    string msg = await reader.ReadLineAsync();
                    // Check if client disconnected 
                    if (msg == null)
                    {
                        status.Text += $"Client {client.Client.RemoteEndPoint} disconnected\n";

                        int index = clients.FindStringExact(client.Client.RemoteEndPoint.ToString());
                        connectedClients.RemoveAt(index);
                        writers.RemoveAt(index);
                        clients.Items.RemoveAt(index);
                        reader.Close();
                        writer.Close();
                        stream.Close();
                        client.Close();
                        return;
                    }

                    // splite message to know what client want
                    string[] msg2 = msg.Split('|');

                    // If client need dir check if it exist send it's info
                    if (msg2.Length != 1 && msg2[msg2.Length - 1] == "d")
                    {
                        if (Directory.Exists(msg2[0]))
                        {
                            string[] directories = Directory.GetDirectories(msg2[0]);
                            string joinedDirs = string.Join(",", directories);

                            string[] files = Directory.GetFiles(msg2[0]);
                            string joinedFiles = string.Join(",", files);

                            string mergedString = joinedDirs + ";" + joinedFiles;

                            await writer.WriteLineAsync(mergedString);
                            messages.Text += $"From {client.Client.RemoteEndPoint.ToString()} asked for dir and sent\n";
                        }
                        else
                        {
                            await writer.WriteLineAsync("Not Found Or path not correct");
                        }

                    }

                    // If client need file check if it exist comparss and send it
                    else if (msg2.Length != 1 && (msg2[msg2.Length - 1] == "f" || msg2[msg2.Length - 1] == "v"))
                    {
                        if (File.Exists(msg2[0]))
                        {
                            byte[] compressed;
                            using (MemoryStream inMemoryStream = new MemoryStream(File.ReadAllBytes(msg2[0])))
                            {
                                using (MemoryStream outMemoryStream = new MemoryStream())
                                {
                                    using (GZipStream compress = new GZipStream(outMemoryStream, CompressionMode.Compress))
                                    {
                                        inMemoryStream.CopyTo(compress);
                                    }
                                    compressed = outMemoryStream.ToArray();
                                }
                            }

                            await writer.WriteLineAsync(compressed.Length.ToString());
                            await stream.WriteAsync(compressed, 0, compressed.Length);

                            /*// if don't need to compress
                            await writer.WriteLineAsync(File.ReadAllBytes(msg2[0]).Length.ToString());
                            await stream.WriteAsync(File.ReadAllBytes(msg2[0]), 0, File.ReadAllBytes(msg2[0]).Length);*/

                            messages.Text += $"From {client.Client.RemoteEndPoint.ToString()} asked for file and sent\n";
                        }
                        else
                        {
                            await writer.WriteLineAsync("Not Found Or path not correct");
                        }
                    }

                    // if not need dir or file it mean it is normal message
                    else
                    {
                        messages.Text += $"From {client.Client.RemoteEndPoint.ToString()}: {msg}\n";
                    }
                }
            }
            catch { }
        }

        private async void send_message_Click(object sender, EventArgs e)
        {
            // get client selected index and send the message to it
            if (clients.SelectedIndex != -1)
            {
                TcpClient selectedClient = connectedClients[clients.SelectedIndex];
                StreamWriter selctedWriter = writers[clients.SelectedIndex];
                await selctedWriter.WriteLineAsync(message.Text);
                messages.Text += $"Me to {selectedClient.Client.RemoteEndPoint.ToString()}: {message.Text}\n";
                message.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Select a client to send the message to.");
            }
        }

        // that stop listen to anther clients and disconnect with all connected clients
        private void close_connection_Click(object sender, EventArgs e)
        {
            try
            {
                listener.Stop();
                isRunning = false;

                foreach (TcpClient client in connectedClients)
                {
                    client.Close();
                }

                connectedClients.Clear();
                writers.Clear();
                clients.Items.Clear();

                status.Text += "Server stopped. All connections closed.\n";
            }
            catch
            {
                status.Text += "Error in closing server\n";
            }
        }
    }
}
