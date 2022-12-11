using System.Threading;
using System.Windows.Forms;
namespace Management
{
	public partial class Form1 : Form
	{
		Player[] players;
		Bank bank;
		int costs_ready = 500;
		int costs_raw = 300;
		int month = 1;
		int i = 0;
		public enum Request
		{
			buy,
			sell
		}
		Request rq;
		public Form1(int Players) //Players будет принимать кол-во игроков
		{
			InitializeComponent();
			players = new Player[Players];
			for (int i = 0; i < Players; i++)
			{
				players[i] = new Player(i);
			}
			bank = new Bank(players);


			l_lvl.Font = new System.Drawing.Font("Georgia", 10);

			l_lvl.Text = bank.ToString(); //Отображение уровня цен
			l_month.Text = month.ToString();
		}

		private void bt_continue_Click(object sender, System.EventArgs e)
		{
			l_status.Text = "";
			switch (l_stage.Text.ToLower())
			{
				case "":
					l_stage.Text = "Определение старшего";
					LeadCalc();
					break;
				case "определение старшего":
					MonthlyCost(players[i]);
					l_stage.Text = "Снятие издержек";
					break;
				case "снятие издержек":
					l_stage.Text = "Приём заявок на сырьё";
					if (i < players.Length)
					{
						rq = Request.buy;
						num_price.Minimum = bank.raw[bank.lvl];
						num_price.Maximum = (decimal)players[i].money;
						MakeRequest();
					}
					break;
				case "приём заявок на сырьё":
					if (rq == Request.buy)
					{
						if (i >= players.Length) i = 0;
						num_price.Minimum = bank.raw[bank.lvl];
						num_price.Maximum = (decimal)players[i].money;
						MakeRequest();
					}
					else if (rq == Request.sell)
					{
						l_stage.Text = "Заявки на продажу готовой продукции";
						MakeRequest();
					}
					break;
				case "заявки на продажу готовой продукции":
					l_stage.Text = "Подведение итогов";
					Results();
					break;
			}
		}
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		public Player LeadCalc()
		{
			Player lead = new Player();
			for (int i = 0; i < players.Length; i++)
			{
				if (month == 1)
				{
					players[0].lead = true;
					lead = players[0];
					break;
				}
				if (players[i].lead)
				{
					for (int j = i + 1; true; j++)
					{
						if (j > players.Length - 1)
						{
							j = 0;
						}
						if (players[j].bankrupt) continue;
						players[i].lead = false;
						players[j].lead = true;
						lead = players[j];
						break;
					}
					break;
				}
			}
			l_status.Text += $"Игрок {lead.ID} становится старшим в этом месяце\n";
			return lead;
			//Console.WriteLine($"Игрок {lead.ID} в этом месяце старший");
			/////////////////////////
		}
		public void MonthlyCost(Player p)
		{
			calculate(p); //надо убрать этот метод
			//Метод calculate вычисляет издержки переданного в параметры игрока
			void calculate(Player player)
			{
				//Метод BankruptCheck проверяет банкрот ли игрок
				int total = 0;
				l_status.Text += $"Игрок {player.ID}:\nНаличность: {player.money}\n";
				if (player.bankrupt)
				{
					l_status.Text += "Этот игрок является банкротом";
					return;
				}
				l_status.Text += $"Единиц сырой продукции: { player.raw}\nЦена за штуку: { costs_raw}$({ costs_raw * player.raw}$ итого)\n\n";
				total += costs_raw * player.raw;
				l_status.Text += $"Единиц готовой продукции: {player.ready}\nЦена за штуку: {costs_ready}$ (итого {player.ready * costs_ready}$)\n\n";
				total += costs_ready * player.ready;
				l_status.Text += $"Итого к оплате {total}\n$";
				player.money -= total;
				BankruptCheck(player);
			}

		}
		//В методе ниже нужно сделать очерёдность (первый лидер, дальше по убыванию)
		public void RequestVisibility(bool on)
		{
			if (on)
			{
				num_price.Visible = true;
				num_amount.Visible = true;
				num_amount_bt_OK.Visible = true;
				l_price.Visible = true;
				l_amount.Visible = true;
				bt_continue.Enabled = false;
			}
			else
			{
				num_price.Visible = false;
				num_amount.Visible = false;
				num_amount_bt_OK.Visible = false;
				l_price.Visible = false;
				l_amount.Visible = false;
				bt_continue.Enabled = true;
			}
		}
		public void MakeRequest()
		{
			RequestVisibility(true);
			if (rq == Request.buy)
				l_status.Text = "Введите количество желаемого сырья и цену";

			else if (rq == Request.sell)
				l_status.Text = "Введите количество продаваемого продукта и желаемую цену";
		}
		public void BankruptCheck(Player player)
		{
			if (player.money <= 0)
			{
				player.bankrupt = true;
			}
		}
		private void Results()
		{
			foreach(Player p in players)
			{
				
				if (p.bankrupt) continue;
				if(p.requested_raw_amount * p.requested_raw_price >= bank.raw[bank.lvl])
				{
					p.money -= p.requested_raw_amount * p.requested_raw_price;
					l_status.Text = $"Игрок {p.ID}:\nЗаказано {p.requested_raw_amount} единиц сырья по запрошенной цене {p.requested_raw_price}\nОставшийся баланс: {p.money}";
					if (bank._raw >= (int)num_amount.Value)
						bank._raw -= (int)num_amount.Value;
					else
						l_status.Text += "\nВ банке недостаточно сырья для продажи";
				}
				if(p.requested_ready_amount * p.requested_ready_price <= bank.ready[bank.lvl])
				{
					p.money += p.requested_ready_price * p.requested_ready_amount;
					l_status.Text = $"Игрок {p.ID}:\nЗапрошено {p.requested_ready_price}$ за единицу готовой продукции в количестве {p.requested_ready_amount}\nОставшийся баланс: {p.money}";

				}
			}
		}

		private void num_amount_bt_OK_Click(object sender, System.EventArgs e)
		{
			if (i > players.Length) return;
			switch (rq)
			{
				case Request.buy:
					if (System.Convert.ToInt32(num_price.Value * num_amount.Value) > players[i].money)
					{
						MessageBox.Show($"Сумма запрошенного сырья {num_amount.Value} превышает количество денег игрока {players[i].money}");
						return;
					}
					players[i].requested_raw_amount = (int)num_amount.Value;
					players[i].requested_raw_price = (int)num_price.Value;
					l_status.Text += $"\nЗаказано {num_amount.Value} единиц сырья, будет заплачено {num_price.Value * num_amount.Value}$";
					rq = Request.sell;
					break;
				case Request.sell:
						players[0].requested_ready_amount = (int)num_amount.Value;
						players[0].requested_ready_price = (int)num_price.Value;
						l_status.Text += $"\nБудет продано {num_amount.Value} продукта по цене {num_price.Value}";
					
					break;
			}
			i++;
			RequestVisibility(false);
		}

		private void bt_stats_Click(object sender, System.EventArgs e)
		{
			this.Visible = false;
			stats st = new stats(players);
			st.ShowDialog();
		}
	}
}
