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
			for(int i = 0; i < pl.Length;i++)
			{
				l_stats.Text +=pl[i].ToString();
			}
		}

	}
}
