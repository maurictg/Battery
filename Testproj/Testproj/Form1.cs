using System;
using System.Drawing;
using System.Windows.Forms;

namespace Testproj
{
    public partial class Batterij : Form
    {
        public Batterij()
        {
            InitializeComponent();
        }

        int battery = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();
            PowerStatus pwr = SystemInformation.PowerStatus;
            var bat = pwr.BatteryLifePercent * 100;
            battery = int.Parse(bat.ToString());
            lblPercent.Text = battery.ToString() + "%";
            batery.Value = battery;
            timer1.Start();
            string time = TimeSpan.FromSeconds(pwr.BatteryLifeRemaining).ToString();
            var t = time.Split(':');
            string tijd = "Nog " + t[0] + " uur, " + t[1] + " min";
            lbltime.Text = tijd;
            ltime.Text = DateTime.Now.ToShortTimeString();
            tijde.Start();
            colorize();
            PlaceLowerRight();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tijd = "Opladen...";
            PowerStatus pwr = SystemInformation.PowerStatus;
            var bat = pwr.BatteryLifePercent * 100;
            battery = int.Parse(bat.ToString());
            lblPercent.Text = battery.ToString() + "%";
            batery.Value = battery;
            if(pwr.BatteryChargeStatus != BatteryChargeStatus.Charging)
            {
                string time = TimeSpan.FromSeconds(pwr.BatteryLifeRemaining).ToString();
                var t = time.Split(':');
                tijd = "Nog " + t[0] + " uur, " + t[1] + " min";
            }
            lbltime.Text = tijd;
            colorize();
            
        }

        private void colorize()
        {
            if(battery > 90)
            {
                batery.ForeColor = Color.SpringGreen;
                lblPercent.ForeColor = Color.SpringGreen;

            }
            else if(battery > 79 && battery < 90)
            {
                batery.ForeColor = Color.Lime;
                lblPercent.ForeColor = Color.Lime;

            }
            else if(battery > 69 && battery < 80)
            {
                batery.ForeColor = Color.LimeGreen;
                lblPercent.ForeColor = Color.LimeGreen;

            }
            else if (battery > 59 && battery < 70)
            {
                batery.ForeColor = Color.Green;
                lblPercent.ForeColor = Color.Green;

            }
            else if (battery > 44 && battery < 60)
            {
                batery.ForeColor = Color.LightGreen ;
                lblPercent.ForeColor = Color.LightGreen;
            }
            else if (battery > 39 && battery < 45)
            {
                batery.ForeColor = Color.GreenYellow;
                lblPercent.ForeColor = Color.GreenYellow;
            }
            else if (battery > 34 && battery < 40)
            {
                batery.ForeColor = Color.Yellow;
                lblPercent.ForeColor = Color.Yellow;
            }
            else if (battery > 29 && battery < 35)
            {
                batery.ForeColor = Color.Gold;
                lblPercent.ForeColor = Color.Gold;
            }
            else if (battery > 24 && battery < 30)
            {
                batery.ForeColor = Color.Orange;
                lblPercent.ForeColor = Color.Orange;
            }
            else if (battery > 19 && battery < 25)
            {
                batery.ForeColor = Color.DarkOrange;
                lblPercent.ForeColor = Color.DarkOrange;
            }
            else if (battery > 14 && battery < 20)
            {
                batery.ForeColor = Color.OrangeRed;
                lblPercent.ForeColor = Color.OrangeRed;
            }
            else if (battery > 10 && battery < 15)
            {
                batery.ForeColor = Color.Red;
                lblPercent.ForeColor = Color.Red;
            }
            else if (battery < 10)
            {
                batery.ForeColor = Color.Maroon;
                lblPercent.ForeColor = Color.Maroon;
            }

        }

        private void tijde_Tick(object sender, EventArgs e)
        {
            ltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void PlaceLowerRight()
        {
            //Determine "rightmost" screen
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = rightmost.WorkingArea.Right - this.Width;
            this.Top = rightmost.WorkingArea.Bottom - this.Height;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                changeicon.Start();
                this.ShowInTaskbar = true;
                this.ShowIcon = true;
                changeicontje();
            }
            else
            {
                changeicon.Stop();
                this.ShowInTaskbar = false;
            }
        }

        private void changeicon_Tick(object sender, EventArgs e)
        {
            changeicontje();
        }

        void changeicontje()
        {
            PowerStatus pwr = SystemInformation.PowerStatus;
            if (pwr.BatteryChargeStatus == BatteryChargeStatus.Charging)
            {
                this.Icon = Testproj.Properties.Resources.icons8_Charging_Battery;
            }
            else if (battery > 60)
            {
                this.Icon = Testproj.Properties.Resources.icons8_Full_Battery;
            }
            else if (battery > 36 && battery < 61)
            {
                this.Icon = Testproj.Properties.Resources.icons8_Battery_Level;
            }
            else if (battery > 11 && battery < 35)
            {
                this.Icon = Testproj.Properties.Resources.icons8_Low_Battery;
            }
            else if (battery < 11)
            {
                this.Icon = Testproj.Properties.Resources.icons8_Empty_Battery;
            }
            else
            {
                this.Icon = Testproj.Properties.Resources.icons8_No_Battery;
            }
        }
    }
}
