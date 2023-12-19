namespace WisejWebApplication1
{
	partial class ModalPopup
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

		#region Wisej.NET Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new Wisej.Web.Label();
			this.textBox1 = new Wisej.Web.TextBox();
			this.textBox2 = new Wisej.Web.TextBox();
			this.textBox3 = new Wisej.Web.TextBox();
			this.textBox4 = new Wisej.Web.TextBox();
			this.textBox5 = new Wisej.Web.TextBox();
			this.button1 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(89, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// textBox1
			// 
			this.textBox1.LabelText = "Name";
			this.textBox1.Location = new System.Drawing.Point(14, 27);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(404, 53);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.LabelText = "Street";
			this.textBox2.Location = new System.Drawing.Point(14, 86);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(404, 53);
			this.textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.LabelText = "Zip";
			this.textBox3.Location = new System.Drawing.Point(14, 145);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(404, 53);
			this.textBox3.TabIndex = 3;
			// 
			// textBox4
			// 
			this.textBox4.LabelText = "City";
			this.textBox4.Location = new System.Drawing.Point(14, 204);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(404, 53);
			this.textBox4.TabIndex = 4;
			// 
			// textBox5
			// 
			this.textBox5.LabelText = "Country";
			this.textBox5.Location = new System.Drawing.Point(14, 263);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(404, 53);
			this.textBox5.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(138, 322);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 37);
			this.button1.TabIndex = 6;
			this.button1.Text = "Submit";
			// 
			// ModalPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 373);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "ModalPopup";
			this.Text = "ModalPopup";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label label1;
		private Wisej.Web.TextBox textBox1;
		private Wisej.Web.TextBox textBox2;
		private Wisej.Web.TextBox textBox3;
		private Wisej.Web.TextBox textBox4;
		private Wisej.Web.TextBox textBox5;
		private Wisej.Web.Button button1;
	}
}