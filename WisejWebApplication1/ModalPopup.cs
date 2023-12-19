using System;
using Wisej.Web;

namespace WisejWebApplication1
{
	public partial class ModalPopup : Form
	{
		public ModalPopup(int rowIndex)
		{
			InitializeComponent();
			label1.Text = "You are editing row: " + rowIndex.ToString();
		}
	}
}
