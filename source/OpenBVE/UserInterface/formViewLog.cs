﻿using System.Windows.Forms;

namespace OpenBve.UserInterface
{
	public partial class formViewLog : Form
	{
		public formViewLog(string text)
		{
			InitializeComponent();

			this.Shown += (sender, e) => textBoxLog.Text = text;
		}

		private void buttonClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}