using System;
using Wisej.Web;

namespace WisejWebApplication1
{
	public partial class ModalPopup : Form
	{
		public string CompanyName1 { get; private set; }
		public string Street { get; private set; }
		public int Zip { get; private set; }
		public string City { get; private set; }
		public string Country { get; private set; }
		public ModalPopup(int rowIndex)
		{
			InitializeComponent();
			label1.Text = "You are editing row: " + rowIndex.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CompanyName1 = textBox1.Text;
			Street = textBox2.Text;
			Zip = 5;//fix this so it reads from textbox and converts to int
			City = textBox3.Text;
			Country = textBox4.Text;
			this.Close();
		}
	}
}
