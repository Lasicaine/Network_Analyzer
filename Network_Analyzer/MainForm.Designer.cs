/*
 * Created by SharpDevelop.
 * User: aau
 * Date: 26.07.2011
 * Time: 16:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Network_Analyzer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonGetIP = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.labelDNS_IP = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonPing = new System.Windows.Forms.Button();
            this.buttonGetDNS = new System.Windows.Forms.Button();
            this.buttonPortScanner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetIP
            // 
            this.buttonGetIP.Location = new System.Drawing.Point(400, 12);
            this.buttonGetIP.Name = "buttonGetIP";
            this.buttonGetIP.Size = new System.Drawing.Size(90, 23);
            this.buttonGetIP.TabIndex = 1;
            this.buttonGetIP.Text = "Get IP";
            this.buttonGetIP.UseVisualStyleBackColor = true;
            this.buttonGetIP.Click += new System.EventHandler(this.ButtonGetIPClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 0;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(74, 48);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(305, 160);
            this.listBoxResult.TabIndex = 4;
            // 
            // labelDNS_IP
            // 
            this.labelDNS_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDNS_IP.Location = new System.Drawing.Point(15, 17);
            this.labelDNS_IP.Name = "labelDNS_IP";
            this.labelDNS_IP.Size = new System.Drawing.Size(53, 18);
            this.labelDNS_IP.TabIndex = 5;
            this.labelDNS_IP.Text = "DNS/IP :";
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(15, 48);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(48, 23);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result :";
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(400, 84);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(90, 23);
            this.buttonPing.TabIndex = 3;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.ButtonPingClick);
            // 
            // buttonGetDNS
            // 
            this.buttonGetDNS.Location = new System.Drawing.Point(400, 48);
            this.buttonGetDNS.Name = "buttonGetDNS";
            this.buttonGetDNS.Size = new System.Drawing.Size(90, 23);
            this.buttonGetDNS.TabIndex = 2;
            this.buttonGetDNS.Text = "Get DNS";
            this.buttonGetDNS.UseVisualStyleBackColor = true;
            this.buttonGetDNS.Click += new System.EventHandler(this.ButtonGetDNSClick);
            // 
            // buttonPortScanner
            // 
            this.buttonPortScanner.Location = new System.Drawing.Point(400, 169);
            this.buttonPortScanner.Name = "buttonPortScanner";
            this.buttonPortScanner.Size = new System.Drawing.Size(89, 39);
            this.buttonPortScanner.TabIndex = 7;
            this.buttonPortScanner.Text = "Port Scanner";
            this.buttonPortScanner.UseVisualStyleBackColor = true;
            this.buttonPortScanner.Click += new System.EventHandler(this.ButtonPortScannerClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 225);
            this.Controls.Add(this.buttonPortScanner);
            this.Controls.Add(this.buttonGetDNS);
            this.Controls.Add(this.buttonPing);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelDNS_IP);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonGetIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button buttonPortScanner;
		private System.Windows.Forms.Button buttonGetDNS;
		private System.Windows.Forms.Button buttonPing;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Label labelDNS_IP;
		private System.Windows.Forms.ListBox listBoxResult;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonGetIP;
	}
}
