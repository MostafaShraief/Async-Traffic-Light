using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_Traffic_Light
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ucTrafficLight1.Start();
            ucTrafficLight2.Start();
            ucTrafficLight3.Start();
            //stop(ucTrafficLight1);
        }

        async void stop(ucTrafficLight ucTrafficLight)
        {
            await Task.Delay(2000);
            ucTrafficLight.Stop();
            await Task.Delay(2000);
            ucTrafficLight.Start();
        }

        private void ucTrafficLight2_OnColorChange(object sender, ucTrafficLight.ColorEventArgs e)
        {
            MessageBox.Show(e.trafficLightColor.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucTrafficLight3.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucTrafficLight3.Stop();
        }
    }
}
