using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicktime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            rest.Visible = false;
            error.Visible = false;
            point.Visible = false;
            click.Visible = false;
            end.Visible = false;
        }
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(number.Text);

            if (num < 1)
            {
                rest.Visible = true;
                error.Visible = true;
                point.Visible = false;
                click.Visible = false;
            }
            else
            {
                if (time < num)
                {
                    time++;
                    if (time <= num)
                    {
                        vrema.Text = time.ToString();
                    }
                    else
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    click.Visible = false;
                    rest.Visible = true;
                    end.Visible = true;
                    time = 0;
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(number.Text);
                    timer1.Enabled = true;
            text1.Visible = false;
            text2.Visible = false;
            number.Visible = false;
            start.Visible = false;
            point.Visible = true;
            click.Visible = true;
            end.Visible = false;
            money = "0";
        }

        private void rest_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            rest.Visible = false;
            error.Visible = false;
            text1.Visible = true;
            text2.Visible = true;
            number.Visible = true;
            start.Visible = true;
        }
        public string money = "0";
        private void click_Click(object sender, EventArgs e)
        {
            int intbalance = Convert.ToInt32(money);
            int result = intbalance + 1;
            string bank = Convert.ToString(result);
            point.Text = bank;
            money = bank;
        }
    }
}
