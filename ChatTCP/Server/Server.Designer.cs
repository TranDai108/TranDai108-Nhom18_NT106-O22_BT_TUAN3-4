
namespace Server
{
    partial class Server
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
            this.lbIP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btListen = new System.Windows.Forms.Button();
            this.tbIPServer = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.rtbView = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(59, 57);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(85, 20);
            this.lbIP.TabIndex = 0;
            this.lbIP.Text = "IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // btListen
            // 
            this.btListen.Location = new System.Drawing.Point(363, 57);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(274, 100);
            this.btListen.TabIndex = 2;
            this.btListen.Text = "Start listening";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // tbIPServer
            // 
            this.tbIPServer.Location = new System.Drawing.Point(145, 51);
            this.tbIPServer.Name = "tbIPServer";
            this.tbIPServer.Size = new System.Drawing.Size(100, 26);
            this.tbIPServer.TabIndex = 3;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(145, 128);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 26);
            this.tbPort.TabIndex = 4;
            // 
            // rtbView
            // 
            this.rtbView.Location = new System.Drawing.Point(63, 201);
            this.rtbView.Name = "rtbView";
            this.rtbView.Size = new System.Drawing.Size(601, 196);
            this.rtbView.TabIndex = 5;
            this.rtbView.Text = "";
            
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbView);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIPServer);
            this.Controls.Add(this.btListen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbIP);
            this.Name = "Server";
            this.Text = "Server";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.TextBox tbIPServer;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.RichTextBox rtbView;
    }
}

