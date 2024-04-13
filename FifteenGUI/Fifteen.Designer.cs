namespace FifteenGUI
{
    partial class Fifteen
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yfxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьХодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gameTimer = new WindowsFormsControlLibrary1.GameTimer();
            this.myButtons16 = new FifteenGUI.MyButtons();
            this.myButtons15 = new FifteenGUI.MyButtons();
            this.myButtons14 = new FifteenGUI.MyButtons();
            this.myButtons13 = new FifteenGUI.MyButtons();
            this.myButtons12 = new FifteenGUI.MyButtons();
            this.myButtons11 = new FifteenGUI.MyButtons();
            this.myButtons10 = new FifteenGUI.MyButtons();
            this.myButtons9 = new FifteenGUI.MyButtons();
            this.myButtons8 = new FifteenGUI.MyButtons();
            this.myButtons7 = new FifteenGUI.MyButtons();
            this.myButtons6 = new FifteenGUI.MyButtons();
            this.myButtons5 = new FifteenGUI.MyButtons();
            this.myButtons4 = new FifteenGUI.MyButtons();
            this.myButtons3 = new FifteenGUI.MyButtons();
            this.myButtons2 = new FifteenGUI.MyButtons();
            this.myButtons1 = new FifteenGUI.MyButtons();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yfxToolStripMenuItem,
            this.отменитьХодToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "StartMenu";
            // 
            // yfxToolStripMenuItem
            // 
            this.yfxToolStripMenuItem.Name = "yfxToolStripMenuItem";
            this.yfxToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.yfxToolStripMenuItem.Text = "Начать игру";
            this.yfxToolStripMenuItem.Click += new System.EventHandler(this.yfxToolStripMenuItem_Click);
            // 
            // отменитьХодToolStripMenuItem
            // 
            this.отменитьХодToolStripMenuItem.Name = "отменитьХодToolStripMenuItem";
            this.отменитьХодToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.отменитьХодToolStripMenuItem.Text = "Отменить ход";
            this.отменитьХодToolStripMenuItem.Click += new System.EventHandler(this.отменитьХодToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.myButtons16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.myButtons15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.myButtons14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.myButtons13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.myButtons12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.myButtons11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.myButtons10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.myButtons9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.myButtons8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.myButtons7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.myButtons6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.myButtons5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.myButtons4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.myButtons3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.myButtons2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.myButtons1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 500);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(785, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "Кол-во ходов:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Location = new System.Drawing.Point(199, 6);
            this.gameTimer.Name = "gameTimer";
            this.gameTimer.Size = new System.Drawing.Size(163, 18);
            this.gameTimer.TabIndex = 4;
            this.gameTimer.Load += new System.EventHandler(this.gameTimer1_Load_1);
            // 
            // myButtons16
            // 
            this.myButtons16.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons16.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButtons16.ForeColor = System.Drawing.Color.Black;
            this.myButtons16.Location = new System.Drawing.Point(591, 378);
            this.myButtons16.Name = "myButtons16";
            this.myButtons16.Size = new System.Drawing.Size(191, 119);
            this.myButtons16.TabIndex = 15;
            this.myButtons16.Text = "myButtons16";
            this.myButtons16.Click += new System.EventHandler(this.myButtons16_Click);
            // 
            // myButtons15
            // 
            this.myButtons15.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons15.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons15.ForeColor = System.Drawing.Color.Black;
            this.myButtons15.Location = new System.Drawing.Point(395, 378);
            this.myButtons15.Name = "myButtons15";
            this.myButtons15.Size = new System.Drawing.Size(190, 119);
            this.myButtons15.TabIndex = 14;
            this.myButtons15.Text = "myButtons15";
            this.myButtons15.Click += new System.EventHandler(this.myButtons15_Click);
            // 
            // myButtons14
            // 
            this.myButtons14.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons14.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons14.ForeColor = System.Drawing.Color.Black;
            this.myButtons14.Location = new System.Drawing.Point(199, 378);
            this.myButtons14.Name = "myButtons14";
            this.myButtons14.Size = new System.Drawing.Size(190, 119);
            this.myButtons14.TabIndex = 13;
            this.myButtons14.Text = "myButtons14";
            this.myButtons14.Click += new System.EventHandler(this.myButtons14_Click);
            // 
            // myButtons13
            // 
            this.myButtons13.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons13.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons13.ForeColor = System.Drawing.Color.Black;
            this.myButtons13.Location = new System.Drawing.Point(3, 378);
            this.myButtons13.Name = "myButtons13";
            this.myButtons13.Size = new System.Drawing.Size(190, 119);
            this.myButtons13.TabIndex = 12;
            this.myButtons13.Text = "myButtons13";
            this.myButtons13.Click += new System.EventHandler(this.myButtons13_Click);
            // 
            // myButtons12
            // 
            this.myButtons12.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons12.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons12.ForeColor = System.Drawing.Color.Black;
            this.myButtons12.Location = new System.Drawing.Point(591, 253);
            this.myButtons12.Name = "myButtons12";
            this.myButtons12.Size = new System.Drawing.Size(191, 119);
            this.myButtons12.TabIndex = 11;
            this.myButtons12.Text = "myButtons12";
            this.myButtons12.Click += new System.EventHandler(this.myButtons12_Click);
            // 
            // myButtons11
            // 
            this.myButtons11.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons11.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons11.ForeColor = System.Drawing.Color.Black;
            this.myButtons11.Location = new System.Drawing.Point(395, 253);
            this.myButtons11.Name = "myButtons11";
            this.myButtons11.Size = new System.Drawing.Size(190, 119);
            this.myButtons11.TabIndex = 10;
            this.myButtons11.Text = "myButtons11";
            this.myButtons11.Click += new System.EventHandler(this.myButtons11_Click);
            // 
            // myButtons10
            // 
            this.myButtons10.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons10.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons10.ForeColor = System.Drawing.Color.Black;
            this.myButtons10.Location = new System.Drawing.Point(199, 253);
            this.myButtons10.Name = "myButtons10";
            this.myButtons10.Size = new System.Drawing.Size(190, 119);
            this.myButtons10.TabIndex = 9;
            this.myButtons10.Text = "myButtons10";
            this.myButtons10.Click += new System.EventHandler(this.myButtons10_Click);
            // 
            // myButtons9
            // 
            this.myButtons9.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons9.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons9.ForeColor = System.Drawing.Color.Black;
            this.myButtons9.Location = new System.Drawing.Point(3, 253);
            this.myButtons9.Name = "myButtons9";
            this.myButtons9.Size = new System.Drawing.Size(190, 119);
            this.myButtons9.TabIndex = 8;
            this.myButtons9.Text = "myButtons9";
            this.myButtons9.Click += new System.EventHandler(this.myButtons9_Click);
            // 
            // myButtons8
            // 
            this.myButtons8.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons8.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons8.ForeColor = System.Drawing.Color.Black;
            this.myButtons8.Location = new System.Drawing.Point(591, 128);
            this.myButtons8.Name = "myButtons8";
            this.myButtons8.Size = new System.Drawing.Size(191, 119);
            this.myButtons8.TabIndex = 7;
            this.myButtons8.Text = "myButtons8";
            this.myButtons8.Click += new System.EventHandler(this.myButtons8_Click);
            // 
            // myButtons7
            // 
            this.myButtons7.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons7.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons7.ForeColor = System.Drawing.Color.Black;
            this.myButtons7.Location = new System.Drawing.Point(395, 128);
            this.myButtons7.Name = "myButtons7";
            this.myButtons7.Size = new System.Drawing.Size(190, 119);
            this.myButtons7.TabIndex = 6;
            this.myButtons7.Text = "myButtons7";
            this.myButtons7.Click += new System.EventHandler(this.myButtons7_Click);
            // 
            // myButtons6
            // 
            this.myButtons6.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons6.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons6.ForeColor = System.Drawing.Color.Black;
            this.myButtons6.Location = new System.Drawing.Point(199, 128);
            this.myButtons6.Name = "myButtons6";
            this.myButtons6.Size = new System.Drawing.Size(190, 119);
            this.myButtons6.TabIndex = 5;
            this.myButtons6.Text = "myButtons6";
            this.myButtons6.Click += new System.EventHandler(this.myButtons6_Click);
            // 
            // myButtons5
            // 
            this.myButtons5.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons5.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons5.ForeColor = System.Drawing.Color.Black;
            this.myButtons5.Location = new System.Drawing.Point(3, 128);
            this.myButtons5.Name = "myButtons5";
            this.myButtons5.Size = new System.Drawing.Size(190, 119);
            this.myButtons5.TabIndex = 4;
            this.myButtons5.Text = "myButtons5";
            this.myButtons5.Click += new System.EventHandler(this.myButtons5_Click);
            // 
            // myButtons4
            // 
            this.myButtons4.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons4.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons4.ForeColor = System.Drawing.Color.Black;
            this.myButtons4.Location = new System.Drawing.Point(591, 3);
            this.myButtons4.Name = "myButtons4";
            this.myButtons4.Size = new System.Drawing.Size(191, 119);
            this.myButtons4.TabIndex = 3;
            this.myButtons4.Text = "myButtons4";
            this.myButtons4.Click += new System.EventHandler(this.myButtons4_Click);
            // 
            // myButtons3
            // 
            this.myButtons3.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons3.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons3.ForeColor = System.Drawing.Color.Black;
            this.myButtons3.Location = new System.Drawing.Point(395, 3);
            this.myButtons3.Name = "myButtons3";
            this.myButtons3.Size = new System.Drawing.Size(190, 119);
            this.myButtons3.TabIndex = 2;
            this.myButtons3.Text = "myButtons3";
            this.myButtons3.Click += new System.EventHandler(this.myButtons3_Click);
            // 
            // myButtons2
            // 
            this.myButtons2.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons2.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons2.ForeColor = System.Drawing.Color.Black;
            this.myButtons2.Location = new System.Drawing.Point(199, 3);
            this.myButtons2.Name = "myButtons2";
            this.myButtons2.Size = new System.Drawing.Size(190, 119);
            this.myButtons2.TabIndex = 1;
            this.myButtons2.Text = "myButtons2";
            this.myButtons2.Click += new System.EventHandler(this.myButtons2_Click);
            // 
            // myButtons1
            // 
            this.myButtons1.BackColor = System.Drawing.Color.AliceBlue;
            this.myButtons1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButtons1.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F);
            this.myButtons1.ForeColor = System.Drawing.Color.Black;
            this.myButtons1.Location = new System.Drawing.Point(3, 3);
            this.myButtons1.Name = "myButtons1";
            this.myButtons1.Size = new System.Drawing.Size(190, 119);
            this.myButtons1.TabIndex = 0;
            this.myButtons1.Text = "myButtons1";
            this.myButtons1.Click += new System.EventHandler(this.myButtons1_Click);
            // 
            // Fifteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 524);
            this.Controls.Add(this.gameTimer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fifteen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.Fifteen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yfxToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem отменитьХодToolStripMenuItem;
        private WindowsFormsControlLibrary1.GameTimer gameTimer;
        private MyButtons myButtons16;
        private MyButtons myButtons15;
        private MyButtons myButtons14;
        private MyButtons myButtons13;
        private MyButtons myButtons12;
        private MyButtons myButtons11;
        private MyButtons myButtons10;
        private MyButtons myButtons9;
        private MyButtons myButtons8;
        private MyButtons myButtons7;
        private MyButtons myButtons6;
        private MyButtons myButtons5;
        private MyButtons myButtons4;
        private MyButtons myButtons3;
        private MyButtons myButtons2;
        private MyButtons myButtons1;
    }
}

