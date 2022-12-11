using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
	public class Factory
	{
		public int cost { get; private set; }
		public bool super { get; set; }
		public Factory(bool super = false)
		{
			if (super) cost = 1500;
			else cost = 1000;
		}
	}
}
