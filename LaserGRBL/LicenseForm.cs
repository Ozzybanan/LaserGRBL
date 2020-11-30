﻿//Copyright (c) 2016-2020 Diego Settimi - https://github.com/arkypita/

// This program is free software; you can redistribute it and/or modify  it under the terms of the GPLv3 General Public License as published by  the Free Software Foundation; either version 3 of the License, or (at  your option) any later version.
// This program is distributed in the hope that it will be useful, but  WITHOUT ANY WARRANTY; without even the implied warranty of  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GPLv3  General Public License for more details.
// You should have received a copy of the GPLv3 General Public License  along with this program; if not, write to the Free Software  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307,  USA. using System;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaserGRBL
{
	public partial class LicenseForm : Form
	{
		public LicenseForm()
		{
			InitializeComponent();
		}

		private void BtnContinue_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"https://paypal.me/pools/c/8cQ1Lo4sRA");
		}

		internal static void CreateAndShowDialog()
		{
			using (LicenseForm f = new LicenseForm())
				f.ShowDialog();
		}

		private void RTBLinkClick(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
	}
}
