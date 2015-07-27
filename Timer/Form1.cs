using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int hours;
        int minutes;
        int seconds;

        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (setHours.Text == "" && SetMinutes.Text == "" && setSeconds.Text == "")
            {
                MessageBox.Show("Make sure you filled everything");
            }

            #region Hours

            try
            {
                hours = Int32.Parse(setHours.Text);
            }

            catch 
            {
                if (setHours.Text != null)
                {
                    Shours.Visible = true;
                    Shours.ForeColor = Color.Red;
                    Shours.Text = "You must Write a number";
                }
                
            }

            if (hours > 24)
            {
                Shours.Visible = true;
                Shours.ForeColor = Color.Red;
                Shours.Text = "The maximum number of hours is 24";
            }


            #endregion

            #region Minutes

            try
            {
                minutes = Int32.Parse(SetMinutes.Text);
            }

            catch
            {
                Sminutes.Visible = true;
                Sminutes.ForeColor = Color.Red;
                Sminutes.Text = "You must Write a number";
            }

            if (minutes % 60 >= 1)
            {
                setHours.Text += minutes % 60;
                
                minutes = (60 * (minutes % 60));
                SetMinutes.Text = minutes.ToString();
            }

            #endregion
        }
    }
}
