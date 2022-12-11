
namespace Management
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.l_stage = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.l_month = new System.Windows.Forms.Label();
			this.l_lvl = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.l_status = new System.Windows.Forms.Label();
			this.bt_continue = new System.Windows.Forms.Button();
			this.num_price = new System.Windows.Forms.NumericUpDown();
			this.num_amount_bt_OK = new System.Windows.Forms.Button();
			this.num_amount = new System.Windows.Forms.NumericUpDown();
			this.l_amount = new System.Windows.Forms.Label();
			this.l_price = new System.Windows.Forms.Label();
			this.bt_stats = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_amount)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(12, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Уровень цен:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(108, 580);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 34);
			this.label3.TabIndex = 4;
			this.label3.Text = "Стадия:";
			// 
			// l_stage
			// 
			this.l_stage.AutoSize = true;
			this.l_stage.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_stage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.l_stage.Location = new System.Drawing.Point(236, 583);
			this.l_stage.Name = "l_stage";
			this.l_stage.Size = new System.Drawing.Size(0, 31);
			this.l_stage.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(643, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 31);
			this.label4.TabIndex = 6;
			this.label4.Text = "Месяц:";
			// 
			// l_month
			// 
			this.l_month.AutoSize = true;
			this.l_month.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_month.ForeColor = System.Drawing.SystemColors.ControlText;
			this.l_month.Location = new System.Drawing.Point(752, 55);
			this.l_month.Name = "l_month";
			this.l_month.Size = new System.Drawing.Size(59, 31);
			this.l_month.TabIndex = 7;
			this.l_month.Text = "666";
			// 
			// l_lvl
			// 
			this.l_lvl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.l_lvl.Location = new System.Drawing.Point(196, 138);
			this.l_lvl.MaximumSize = new System.Drawing.Size(200, 200);
			this.l_lvl.MinimumSize = new System.Drawing.Size(100, 50);
			this.l_lvl.Multiline = true;
			this.l_lvl.Name = "l_lvl";
			this.l_lvl.ReadOnly = true;
			this.l_lvl.Size = new System.Drawing.Size(200, 107);
			this.l_lvl.TabIndex = 12;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.Controls.Add(this.l_status);
			this.panel1.Location = new System.Drawing.Point(488, 127);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(599, 253);
			this.panel1.TabIndex = 13;
			// 
			// l_status
			// 
			this.l_status.AutoSize = true;
			this.l_status.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_status.ForeColor = System.Drawing.SystemColors.ControlText;
			this.l_status.Location = new System.Drawing.Point(15, 6);
			this.l_status.Name = "l_status";
			this.l_status.Size = new System.Drawing.Size(224, 23);
			this.l_status.TabIndex = 14;
			this.l_status.Text = "Нажмите \"продолжить\"";
			// 
			// bt_continue
			// 
			this.bt_continue.Location = new System.Drawing.Point(114, 632);
			this.bt_continue.Name = "bt_continue";
			this.bt_continue.Size = new System.Drawing.Size(217, 39);
			this.bt_continue.TabIndex = 14;
			this.bt_continue.Text = "Продолжить";
			this.bt_continue.UseVisualStyleBackColor = true;
			this.bt_continue.Click += new System.EventHandler(this.bt_continue_Click);
			// 
			// num_price
			// 
			this.num_price.Location = new System.Drawing.Point(360, 67);
			this.num_price.Name = "num_price";
			this.num_price.Size = new System.Drawing.Size(120, 20);
			this.num_price.TabIndex = 15;
			this.num_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.num_price.Visible = false;
			// 
			// num_amount_bt_OK
			// 
			this.num_amount_bt_OK.Location = new System.Drawing.Point(360, 93);
			this.num_amount_bt_OK.Name = "num_amount_bt_OK";
			this.num_amount_bt_OK.Size = new System.Drawing.Size(120, 23);
			this.num_amount_bt_OK.TabIndex = 16;
			this.num_amount_bt_OK.Text = "OK";
			this.num_amount_bt_OK.UseVisualStyleBackColor = true;
			this.num_amount_bt_OK.Visible = false;
			this.num_amount_bt_OK.Click += new System.EventHandler(this.num_amount_bt_OK_Click);
			// 
			// num_amount
			// 
			this.num_amount.Location = new System.Drawing.Point(360, 41);
			this.num_amount.Name = "num_amount";
			this.num_amount.ReadOnly = true;
			this.num_amount.Size = new System.Drawing.Size(120, 20);
			this.num_amount.TabIndex = 17;
			this.num_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.num_amount.Visible = false;
			// 
			// l_amount
			// 
			this.l_amount.AutoSize = true;
			this.l_amount.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_amount.ForeColor = System.Drawing.SystemColors.ControlText;
			this.l_amount.Location = new System.Drawing.Point(240, 38);
			this.l_amount.Name = "l_amount";
			this.l_amount.Size = new System.Drawing.Size(114, 23);
			this.l_amount.TabIndex = 18;
			this.l_amount.Text = "Количество";
			this.l_amount.Visible = false;
			// 
			// l_price
			// 
			this.l_price.AutoSize = true;
			this.l_price.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_price.ForeColor = System.Drawing.SystemColors.ControlText;
			this.l_price.Location = new System.Drawing.Point(298, 67);
			this.l_price.Name = "l_price";
			this.l_price.Size = new System.Drawing.Size(56, 23);
			this.l_price.TabIndex = 19;
			this.l_price.Text = "Цена";
			this.l_price.Visible = false;
			// 
			// bt_stats
			// 
			this.bt_stats.Location = new System.Drawing.Point(1274, 281);
			this.bt_stats.Name = "bt_stats";
			this.bt_stats.Size = new System.Drawing.Size(134, 46);
			this.bt_stats.TabIndex = 20;
			this.bt_stats.Text = "Список игроков";
			this.bt_stats.UseVisualStyleBackColor = true;
			this.bt_stats.Click += new System.EventHandler(this.bt_stats_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(1491, 700);
			this.Controls.Add(this.bt_stats);
			this.Controls.Add(this.l_price);
			this.Controls.Add(this.l_amount);
			this.Controls.Add(this.num_amount);
			this.Controls.Add(this.num_amount_bt_OK);
			this.Controls.Add(this.num_price);
			this.Controls.Add(this.bt_continue);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.l_lvl);
			this.Controls.Add(this.l_month);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.l_stage);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_amount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label l_stage;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label l_month;
		private System.Windows.Forms.TextBox l_lvl;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label l_status;
		private System.Windows.Forms.Button bt_continue;
		private System.Windows.Forms.NumericUpDown num_price;
		private System.Windows.Forms.Button num_amount_bt_OK;
		private System.Windows.Forms.NumericUpDown num_amount;
		private System.Windows.Forms.Label l_amount;
		private System.Windows.Forms.Label l_price;
		private System.Windows.Forms.Button bt_stats;
	}
}

