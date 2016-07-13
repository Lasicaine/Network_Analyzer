/*
 * Created by SharpDevelop.
 * User: aau
 * Date: 26.07.2011
 * Time: 16:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Network_Analyzer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		private void Button1Click(object sender, EventArgs e)
		{
			try {
			listBox1.Items.Clear();
			System.Net.IPHostEntry host;
			host = System.Net.Dns.GetHostEntry(textBox1.Text);
			
			foreach (System.Net.IPAddress ip in host.AddressList)
			{
				listBox1.Items.Add(ip.ToString());
			}
			}
			catch (Exception err) 
			{ 
			// Выводим сообщение об ошибке 
			MessageBox.Show("Адрес не достижим"); 
			return; 
					}
		}
		
		 private void Button2Click(object sender, EventArgs e)
		{
		 	try {
		 	Ping pingSender = new Ping();
			PingReply reply = pingSender.Send(textBox1.Text);
			listBox1.Items.Clear();
			if (reply.Status == IPStatus.Success)
			{
				listBox1.Items.Add("Adress: " + reply.Address.ToString());
				listBox1.Items.Add("RoundTrip time: " + reply.RoundtripTime);
				listBox1.Items.Add("Time to live: " + reply.Options.Ttl);
				listBox1.Items.Add("Don't fragment: " + reply.Options.DontFragment);
				listBox1.Items.Add("Buffer size: " + reply.Buffer.Length);
			}
			else
			{ 
				listBox1.Items.Add(reply.Status);
			} 
		 	}
			catch (Exception err) 
			{ 
			// Выводим сообщение об ошибке 
			MessageBox.Show("Адрес не достижим"); 
			return; 
					}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			try {
			listBox1.Items.Clear();
			string name = "Неизвестно";
			
			name = Dns.GetHostEntry(textBox1.Text).HostName;
			
				listBox1.Items.Add(name);
		
			}
			catch (Exception err) 
			{ 
			// Выводим сообщение об ошибке 
			MessageBox.Show("Адрес не достижим"); 
			return; 
					}
		}
/* // Делаем прозрачной форму при перемещении		
		protected override void WndProc(ref Message m) 
		{ 
				const int WM_NCLBUTTONDOWN = 0x00A1; 
				const int WM_NCMOUSEMOVE = 0x00A0; 
				if (m.Msg == WM_NCLBUTTONDOWN) 
					{ 
					this.Opacity = 0.5; 
					} 
						if (m.Msg == WM_NCMOUSEMOVE) 
							{ 
							this.Opacity = 1.0; 
							}
					base.WndProc(ref m); 
		} */
	
		
		void Button4Click(object sender, EventArgs e)
		{
			ProcessStartInfo stInfo =
  			new ProcessStartInfo("PortScan");
 
			stInfo.UseShellExecute = false;
			stInfo.CreateNoWindow = true;
 
			//создаем новый процесс
			Process proc = new Process();
			proc.StartInfo = stInfo;
			//Запускаем процесс
			proc.Start();
			 
			//Ждем, пока блокнот запущен
			proc.WaitForExit();
		}
	}
}
