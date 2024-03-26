namespace Client
{
    partial class Client
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
            this.tbIPHost = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbIPHost
            // 
            this.tbIPHost.Location = new System.Drawing.Point(143, 24);
            this.tbIPHost.Name = "tbIPHost";
            this.tbIPHost.Size = new System.Drawing.Size(177, 26);
            this.tbIPHost.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(143, 97);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(177, 26);
            this.tbName.TabIndex = 0;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(500, 30);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(109, 26);
            this.tbPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(53, 170);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(613, 180);
            this.rtbMessage.TabIndex = 3;
            this.rtbMessage.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(53, 382);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(613, 39);
            this.tbMessage.TabIndex = 5;
            this.tbMessage.Text = "";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbIPHost);
            this.Name = "Client";
            this.Text = "Client";           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIPHost;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox tbMessage;
    }
}

