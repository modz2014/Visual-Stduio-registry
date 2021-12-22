using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{


		public Form1()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{

			{
				RegistryKey rKey;

				rKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\VisualStudio", true);
				rKey.CreateSubKey("16.0_605c3485");
				rKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\VisualStudio\\16.0_605c3485", true);
				rKey.CreateSubKey("license");
				rKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\VisualStudio\\16.0_605c3485\\license", true);
				rKey.CreateSubKey("715f10eb-9e99-11d2-bfc2-00c04f990235");
				rKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\VisualStudio\\16.0_605c3485\\license\\715f10eb-9e99-11d2-bfc2-00c04f990235", true);



				try
				{
					rKey.SetValue("715f10eb-9e99-11d2-bfc2-00c04f990235", new byte[] { 0x66, 0x30, 0x61, 0x33, 0x64, 0x66, 0x31, 0x35, 0x2d, 0x66, 0x30, 0x32, 0x61, 0x2d, 0x34, 0x30, 0x38, 0x36, 0x2d, 0x62, 0x64, 0x63, 0x31, 0x2d, 0x34, 0x65, 0x34, 0x30, 0x30, 0x36, 0x38, 0x35, 0x30, 0x39, 0x64, 0x39 }, RegistryValueKind.Binary);
					rKey.Close();
				}

				catch (Exception ex)
				{

					MessageBox.Show("Registered Visual Studio");
					return;

				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			{
				RegistryKey rKey;

				rKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\VisualStudio", true);
				rKey.CreateSubKey("17.0_ff77d216");
				rKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\VisualStudio\\17.0_ff77d216", true);
				rKey.CreateSubKey("license");
				rKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\VisualStudio\\17.0_ff77d216\\license", true);
				rKey.CreateSubKey("715f10eb-9e99-11d2-bfc2-00c04f990235");
				rKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\VisualStudio\\17.0_ff77d216\\license\\715f10eb-9e99-11d2-bfc2-00c04f990235", true);



				try
				{
					rKey.SetValue("715f10eb-9e99-11d2-bfc2-00c04f990235", new byte[] { 0x39, 0x64, 0x31, 0x39, 0x65, 0x66, 0x36, 0x37, 0x2d, 0x33, 0x61, 0x37, 0x62, 0x2d, 0x34, 0x35, 0x65, 0x33, 0x2d, 0x62, 0x38, 0x36, 0x32, 0x2d, 0x39, 0x33, 0x30, 0x32, 0x31, 0x30, 0x62, 0x62, 0x62, 0x62, 0x35, 0x34 }, RegistryValueKind.Binary);
					rKey.Close();
				}

				catch (Exception ex)
				{

					MessageBox.Show("Registered Visual Studio");
					return;

				}
			}
		}
	}
}