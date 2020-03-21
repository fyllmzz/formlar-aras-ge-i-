using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SİLİNCEK
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
		}

	

		private void button1_Click(object sender, EventArgs e)
		{
			string kad, sifre;
			kad = textBox1.Text;
			sifre = textBox2.Text;
			if (kad == "admin" && sifre == "123456")
			{
				MessageBox.Show("Giriş Başarılı...");
				HOŞGELDİNİZ fr3 = new HOŞGELDİNİZ();
				fr3.Show();

			}
			
		}
	}
}
