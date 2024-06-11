namespace Project_Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.close_connection = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.send_message = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.messages = new System.Windows.Forms.RichTextBox();
            this.status = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ask_file = new System.Windows.Forms.Button();
            this.dirs = new System.Windows.Forms.ListView();
            this.ask_dir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ask_stream = new System.Windows.Forms.Button();
            this.m_player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.m_player)).BeginInit();
            this.SuspendLayout();
            // 
            // close_connection
            // 
            this.close_connection.Location = new System.Drawing.Point(885, 485);
            this.close_connection.Name = "close_connection";
            this.close_connection.Size = new System.Drawing.Size(115, 51);
            this.close_connection.TabIndex = 19;
            this.close_connection.Text = "Close Connection";
            this.close_connection.UseVisualStyleBackColor = true;
            this.close_connection.Click += new System.EventHandler(this.close_connection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Messages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Write Message OR Directory Path OR File Path";
            // 
            // send_message
            // 
            this.send_message.Location = new System.Drawing.Point(342, 466);
            this.send_message.Name = "send_message";
            this.send_message.Size = new System.Drawing.Size(115, 35);
            this.send_message.TabIndex = 14;
            this.send_message.Text = "Send Message";
            this.send_message.UseVisualStyleBackColor = true;
            this.send_message.Click += new System.EventHandler(this.send_message_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(12, 485);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(324, 51);
            this.message.TabIndex = 13;
            // 
            // messages
            // 
            this.messages.Location = new System.Drawing.Point(12, 28);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(324, 435);
            this.messages.TabIndex = 12;
            this.messages.Text = "";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(772, 28);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(228, 69);
            this.status.TabIndex = 11;
            this.status.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Directory";
            // 
            // ask_file
            // 
            this.ask_file.Location = new System.Drawing.Point(342, 501);
            this.ask_file.Name = "ask_file";
            this.ask_file.Size = new System.Drawing.Size(115, 35);
            this.ask_file.TabIndex = 22;
            this.ask_file.Text = "Ask For File";
            this.ask_file.UseVisualStyleBackColor = true;
            this.ask_file.Click += new System.EventHandler(this.ask_file_Click);
            // 
            // dirs
            // 
            this.dirs.HideSelection = false;
            this.dirs.Location = new System.Drawing.Point(342, 28);
            this.dirs.Name = "dirs";
            this.dirs.Size = new System.Drawing.Size(228, 435);
            this.dirs.TabIndex = 24;
            this.dirs.UseCompatibleStateImageBehavior = false;
            // 
            // ask_dir
            // 
            this.ask_dir.Location = new System.Drawing.Point(463, 501);
            this.ask_dir.Name = "ask_dir";
            this.ask_dir.Size = new System.Drawing.Size(130, 35);
            this.ask_dir.TabIndex = 25;
            this.ask_dir.Text = "Ask For Dir";
            this.ask_dir.UseVisualStyleBackColor = true;
            this.ask_dir.Click += new System.EventHandler(this.ask_dir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Video";
            // 
            // ask_stream
            // 
            this.ask_stream.Location = new System.Drawing.Point(463, 466);
            this.ask_stream.Name = "ask_stream";
            this.ask_stream.Size = new System.Drawing.Size(130, 35);
            this.ask_stream.TabIndex = 28;
            this.ask_stream.Text = "Ask For Stream";
            this.ask_stream.UseVisualStyleBackColor = true;
            this.ask_stream.Click += new System.EventHandler(this.ask_stream_Click);
            // 
            // m_player
            // 
            this.m_player.Enabled = true;
            this.m_player.Location = new System.Drawing.Point(579, 114);
            this.m_player.Name = "m_player";
            this.m_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("m_player.OcxState")));
            this.m_player.Size = new System.Drawing.Size(421, 349);
            this.m_player.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 548);
            this.Controls.Add(this.ask_stream);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_player);
            this.Controls.Add(this.ask_dir);
            this.Controls.Add(this.dirs);
            this.Controls.Add(this.ask_file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close_connection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.send_message);
            this.Controls.Add(this.message);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.m_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_connection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button send_message;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.RichTextBox messages;
        private System.Windows.Forms.RichTextBox status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ask_file;
        private System.Windows.Forms.ListView dirs;
        private System.Windows.Forms.Button ask_dir;
        private AxWMPLib.AxWindowsMediaPlayer m_player;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ask_stream;
    }
}

