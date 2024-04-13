using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class GameTimer: UserControl
    {
        int sec;
        public DateTime date1;
        public GameTimer()
        {          
            InitializeComponent();
            sec = 0;
            date1 = new DateTime(2015, 7, 20, 0, 0, 0);
        }
        public void Start()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            sec = 0;
            display.Text = "Время : 00:00:00";
            date1 = new DateTime(2015, 7, 20, 0, 0, 0);
            timer.Enabled = true;
            
        }
        public void Stop()
        {
            timer.Enabled = false;  
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            sec++;
            date1 = date1.AddSeconds(+1);
            display.Text ="Время : " + date1.ToLongTimeString();
        }
    }
}
