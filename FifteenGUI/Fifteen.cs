using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;


namespace FifteenGUI
{
    public partial class Fifteen : Form
    {
        Game game;
     
     
        int count = 0;
        int timerSec = 0;
        int timerMin = 0;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Fifteen()
        {
            InitializeComponent();
            game = new Game(16);
            
         
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
        }
        
        private void Gamestart()
        {
            count = 0;
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + count).ToString();
            timerSec = 0;
            timerMin = 0;
            game = new Game(16);
            game.Start();
            gameTimer.Start();
            
            
            for (int i = 0; i < 100; i++)
                game.ShiftRandom();
            RefreshButtonField();
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (timerSec < 60)
                timerSec++;
            else
            {
                timerSec = 0;
                timerMin++;
            }

            toolStripStatusLabel2.Text = ("Время : " + timerMin +" : " + timerSec).ToString();
            
        }
        private MyButtons GetButton(int index)
        {
            switch (index)
            {
                case 0: return myButtons1;
                case 1: return myButtons2;
                case 2: return myButtons3;
                case 3: return myButtons4;
                case 4: return myButtons5;
                case 5: return myButtons6;
                case 6: return myButtons7;
                case 7: return myButtons8;
                case 8: return myButtons9;
                case 9: return myButtons10;
                case 10: return myButtons11;
                case 11: return myButtons12;
                case 12: return myButtons13;
                case 13: return myButtons14;
                case 14: return myButtons15;
                case 15: return myButtons16;

                default:
                    return null;
            }
        }
        private void RefreshButtonField()
        {
            for (int position = 0; position < 16; position++)
            {
                // int number = GetNumber(position);
                MyButtons but = GetButton(position);
                but.Text = game.GetNumber(position).ToString();
                if(Convert.ToInt32(but.Text) > 0) 
                    but.Visible = true;
                else if(Convert.ToInt32(but.Text) == 0)
                    but.Visible=false;
                //GetButton(position).Text = game.GetNumber(position).ToString();

            }

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yfxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gamestart();
        }

        private void Fifteen_Load(object sender, EventArgs e)
        {
            Gamestart();

        }
       
        #region usseles
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Cancel
        private void отменитьХодToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (count > 0)
            {
                count--;
                toolStripStatusLabel1.Text = ("Кол-во ходов:" + count).ToString();
                game.Undo();
            }
            RefreshButtonField();
        }
        #endregion
        private void gameTimer1_Load_1(object sender, EventArgs e)
        {

        }
        #region Buttons
        private void myButtons1_Click(object sender, EventArgs e)
        {
            int position = 0;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons2_Click(object sender, EventArgs e)
        {
            int position = 1;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons3_Click(object sender, EventArgs e)
        {
            int position = 2;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons4_Click(object sender, EventArgs e)
        {
            int position = 3;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons5_Click(object sender, EventArgs e)
        {
            int position = 4;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons6_Click(object sender, EventArgs e)
        {
            int position = 5;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons7_Click(object sender, EventArgs e)
        {
            int position = 6;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons8_Click(object sender, EventArgs e)
        {
            int position = 7;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons9_Click(object sender, EventArgs e)
        {
            int position = 8;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons10_Click(object sender, EventArgs e)
        {
            int position = 9;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons11_Click(object sender, EventArgs e)
        {
            int position = 10;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons12_Click(object sender, EventArgs e)
        {
            int position = 11;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons13_Click(object sender, EventArgs e)
        {
            int position = 12;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons14_Click(object sender, EventArgs e)
        {
            int position = 13;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons15_Click(object sender, EventArgs e)
        {
            int position = 14;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void myButtons16_Click(object sender, EventArgs e)
        {
            int position = 15;
            game.Shift(position);
            RefreshButtonField();
            toolStripStatusLabel1.Text = ("Кол-во ходов:" + ++count).ToString();


            if (game.Check())
            {
                MessageBox.Show("Поздравляю, победа!!!!!!!!!! \n Вы прошли игру за :" + count + " ходов и " +
                    gameTimer.date1.Hour + " часов" + gameTimer.date1.Minute + " минут" + gameTimer.date1.Second + " секунд", "Вы победили ", MessageBoxButtons.OK);
                DialogResult result = MessageBox.Show("Начать новую игру?", "Новая игра", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Gamestart();
                }
                else
                {
                    Close();
                }
            }
        }
        #endregion
    }
}
