namespace Project_Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.RichTextBox();
            this.messages = new System.Windows.Forms.RichTextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.send_message = new System.Windows.Forms.Button();
            this.clients = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.close_connection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(609, 28);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(179, 165);
            this.status.TabIndex = 1;
            this.status.Text = "";
            // 
            // messages
            // 
            this.messages.Location = new System.Drawing.Point(12, 28);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(591, 335);
            this.messages.TabIndex = 2;
            this.messages.Text = "";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(12, 387);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(470, 51);
            this.message.TabIndex = 3;
            // 
            // send_message
            // 
            this.send_message.Location = new System.Drawing.Point(488, 394);
            this.send_message.Name = "send_message";
            this.send_message.Size = new System.Drawing.Size(115, 35);
            this.send_message.TabIndex = 4;
            this.send_message.Text = "Send Message";
            this.send_message.UseVisualStyleBackColor = true;
            this.send_message.Click += new System.EventHandler(this.send_message_Click);
            // 
            // clients
            // 
            this.clients.FormattingEnabled = true;
            this.clients.ItemHeight = 16;
            this.clients.Location = new System.Drawing.Point(609, 215);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(179, 148);
            this.clients.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Write Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Messages";
            // 
            // close_connection
            // 
            this.close_connection.Location = new System.Drawing.Point(673, 387);
            this.close_connection.Name = "close_connection";
            this.close_connection.Size = new System.Drawing.Size(115, 51);
            this.close_connection.TabIndex = 9;
            this.close_connection.Text = "Close Connection";
            this.close_connection.UseVisualStyleBackColor = true;
            this.close_connection.Click += new System.EventHandler(this.close_connection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close_connection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.send_message);
            this.Controls.Add(this.message);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox status;
        private System.Windows.Forms.RichTextBox messages;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button send_message;
        private System.Windows.Forms.ListBox clients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button close_connection;
    }
}

