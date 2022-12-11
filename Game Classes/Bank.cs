using System;
using System.Collections.Generic;
namespace Management
{
	public class Bank
	{
		public Dictionary<int, int> raw, ready;
		public int lvl = 3;
		public int _ready, _raw;
		Player[] players;
		public Bank(Player[] pls)
		{
			raw = new Dictionary<int, int>
				{
					{1, 800},
					{2, 650 },
					{3, 500 },
					{4, 400 },
					{5, 300 }
				};
			ready = new Dictionary<int, int>
				{
					{1, 6500 },
					{2, 6000 },
					{3, 5500 },
					{4, 5000 },
					{5, 4500 }
				};
			players = pls;
		}
		public void rand()
		{
			int[] chance = new int[12];
			switch (lvl)
			{
				case 1:
					chance = new[] { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 4, 5 };
					break;
				case 2:
					chance = new[] { 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 4, 5 };
					break;
				case 3:
					chance = new[] { 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 5 };
					break;
				case 4:
					chance = new[] { 1, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5 };
					break;
				case 5:
					chance = new[] { 1, 2, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5 };
					break;
			}
			lvl = chance[new Random().Next(1, chance.Length)];
			switch (lvl)
			{
				case 1:
					_raw = 1 * players.Length; _ready = 3 * players.Length;
					break;
				case 2:
					_raw = Convert.ToInt32(Math.Floor(1.5 * players.Length)); 
					_ready = Convert.ToInt32(Math.Floor(2.5 * players.Length));
					break;
				case 3:
					_raw = 2 * players.Length; _ready = _raw;
					break;
				case 4:
					_raw = Convert.ToInt32(Math.Floor(2.5 * players.Length));
					_ready = Convert.ToInt32(Math.Floor(1.5 * players.Length));
					break;
			}
		}
		public override string ToString()
		{
			return $@"Уровень {lvl}
ЕГП покупается по цене {ready[lvl]}
-------------------------------
ЕСМ продаётся по цене {raw[lvl]}
Количество ЕСМ {_raw}
Количество ЕГП {_ready}";
		}
	}
}
