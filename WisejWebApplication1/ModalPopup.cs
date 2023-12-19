using System;
using Wisej.Web;

namespace WisejWebApplication1
{
	public partial class ModalPopup : Form
	{
		public ModalPopup(int rowIndex)
		{
			InitializeComponent();
			AlertBox.Show(rowIndex.ToString());
		}
	}
}
