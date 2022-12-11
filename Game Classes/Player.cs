using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
	public class Player
	{
		public int ID { get; private set; }
		public bool lead = false;
		public Factory[] factories;
		public int raw = 4;
		public int ready = 2;
		public double money = 10000;
		public bool bankrupt = false;
		public int requested_raw_price, requested_raw_amount, requested_ready_amount, requested_ready_price;
		public Player(int ID)
		{
			this.ID = ID;
			factories = new Factory[]
			{
				new Factory(), new Factory()
			};
		}
		public override string ToString()
		{
			if (bankrupt) return "Данный игрок является банкротом";
			return $"ID: {ID}\n\nСырьё: {raw}\n\nГотовая продукция: {ready}\n\nДеньги: {money}$\n\nКол-во фабрик {factories.Length}\n\nСтарший: {lead}";
		}
		public Player(){}
	}
}
