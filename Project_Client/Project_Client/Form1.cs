using System;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Project_Client
{
    public partial class Form1 : Form
    {
        TcpClient client;
        NetworkStream stream;
        StreamReader reader;
        StreamWriter writer;

        private bool isRunning = false;
        private bool askedFile = false;
        private bool askedDir = false;
        private bool askedStream = false;
        private string fileName;

        public Form1()
        {
            InitializeComponent();
            try
            {
                client = new TcpClient("127.0.0.1", 5000);

                stream = client.GetStream();
                reader = new StreamReader(stream, Encoding.UTF8);
                writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };
                
                status.Text += "Connected To Server\n";
                isRunning = true;
                receiveMessage();
            }
            catch {
                status.Text += "Error in connection\n";
            }
        }

        // handle incomming messages from server
        private async void receiveMessage()
        {
            while (isRunning)
            {
                try
                {
                    string message = await reader.ReadLineAsync();
                    // check if server is still connected
                    if (message == null)
                    {
                        close_Connection();
                        return;
                    }

                    // if me asked for file check if it valid and get it
                    if ((askedFile || askedStream) && message != "Not Found Or path not correct")
                    {
                        int fileSize = int.Parse(message);
                        byte[] fileData = new byte[fileSize];
                        await stream.ReadAsync(fileData, 0, fileData.Length);

                        // if don't need to compress
                        // File.WriteAllBytes(fileName, fileData);

                        using (MemoryStream fileStream = new MemoryStream(fileData))
                        {
                            using (MemoryStream decompressedStream = new MemoryStream())
                            {
                                using (GZipStream decompressionStream = new GZipStream(fileStream, CompressionMode.Decompress))
                                {
                                    await decompressionStream.CopyToAsync(decompressedStream);
                                }

                                File.WriteAllBytes(fileName, decompressedStream.ToArray());
                            }
                        }

                        if (askedStream)
                        {
                            m_player.URL = fileName;
                            askedStream = false;
                        }

                        messages.Text += "File received and saved\n";
                        askedFile = false;
                    }
                    // if me asked for dir check if it valid and get it info
                    else if (askedDir && message != "Not Found Or path not correct")
                    {
                        // handle the view
                        dirs.Items.Clear();
                        dirs.Columns.Clear();

                        dirs.View = View.Details;
                        dirs.FullRowSelect = true;
                        dirs.GridLines = true;

                        dirs.Columns.Add("Name", 200);
                        dirs.Columns.Add("Type", 100);

                        string[] splitted = message.Split(';');

                        foreach (string dir in splitted[0].Split(','))
                        {
                            if (!string.IsNullOrWhiteSpace(dir))
                            {
                                string[] temp = dir.Split('\\');
                                string dirName = temp[temp.Length - 1];
                                ListViewItem item = new ListViewItem(dirName);
                                item.SubItems.Add("Directory");
                                dirs.Items.Add(item);
                            }
                        }

                        foreach (string dir in splitted[1].Split(','))
                        {
                            if (!string.IsNullOrWhiteSpace(dir))
                            {
                                string[] temp = dir.Split('\\');
                                string fileName = temp[temp.Length - 1];
                                ListViewItem item = new ListViewItem(fileName);
                                item.SubItems.Add("File");
                                dirs.Items.Add(item);
                            }
                        }
                        messages.Text += "Directory Files Received\n";
                        askedDir = false;
                    }
                    // normal message
                    else
                    {
                        askedFile = false;
                        askedDir = false;
                        askedStream = false;

                        messages.Text += $"Server: {message}\n";
                    }

                }
                catch { }
            }
        }

        async private void send_message_Click(object sender, EventArgs e)
        {
            await writer.WriteLineAsync(message.Text);
            messages.Text += $"Me to Server: {message.Text}\n";
            message.Text = string.Empty;
        }

        private void close_connection_Click(object sender, EventArgs e)
        {
            close_Connection();
        }

        private void close_Connection()
        {
            try
            {
                reader.Close();
                writer.Close();
                stream.Close();
                client.Close();

                isRunning = false;
                status.Text += "Connection closed.\n";
            }
            catch (Exception ex)
            {
                status.Text += $"Error closing connection: {ex.Message}\n";
            }
        }

        async private void ask_file_Click(object sender, EventArgs e)
        {
            await writer.WriteLineAsync((message.Text + "|f"));
            askedFile = true;
            string[] splitted = message.Text.Split('\\');
            fileName = splitted[splitted.Length-1];
            message.Text = string.Empty;
        }

        async private void ask_dir_Click(object sender, EventArgs e)
        {
            await writer.WriteLineAsync((message.Text + "|d"));
            askedDir = true;
            message.Text = string.Empty;
        }

        async private void ask_stream_Click(object sender, EventArgs e)
        {
            await writer.WriteLineAsync((message.Text + "|v"));
            askedStream = true;
            string[] splitted = message.Text.Split('\\');
            fileName = splitted[splitted.Length - 1];
            message.Text = string.Empty;
        }
    }
}
