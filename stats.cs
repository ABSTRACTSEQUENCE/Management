using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
	public partial class stats : Form
	{
		public stats(Player[] pl)
		{
			InitializeComponent();
			l_id.Text = "";
			l_money.Text = "";
			l_egp.Text = "";
			l_esm.Text = "";
			for(int i = 0; i < pl.Length;i++)
			{
				l_id.Text +=pl[i].ID.ToString() + "\n";
				l_esm.Text += pl[i].raw.ToString() + "\n";
				l_egp.Text += pl[i].ready.ToString() + "\n";
				l_money.Text += pl[i].money.ToString() + "\n";
			}
		}
	}
}
