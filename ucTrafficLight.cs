using my_Traffic_Light.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_Traffic_Light
{
    public partial class ucTrafficLight : UserControl
    {
        public enum enTrafficLightColor { red, orangeToRed, orangeToGreen, green };
        CancellationTokenSource cts = new CancellationTokenSource();
        struct stTrafficLight
        {
            public enTrafficLightColor trafficLightColor;
            public ushort redDuration, orangeDuration, greenDuration;
            public TimeSpan duration;
        }
        stTrafficLight trafficLight;

        #region "Designer Properties"

        [
            Category("Traffic Light Settings"),
            Description("The duration in seconds for the red light."),
            DefaultValue((ushort)7)
        ]
        public ushort RedDuration
        {
            get { return trafficLight.redDuration; }
            set { trafficLight.redDuration = value; }
        }

        [
            Category("Traffic Light Settings"),
            Description("The duration in seconds for the orange light."),
            DefaultValue((ushort)1)
        ]
        public ushort OrangeDuration
        {
            get { return trafficLight.orangeDuration; }
            set { trafficLight.orangeDuration = value; }
        }

        [
            Category("Traffic Light Settings"),
            Description("The duration in seconds for the green light."),
            DefaultValue((ushort)5)
        ]
        public ushort GreenDuration
        {
            get { return trafficLight.greenDuration; }
            set { trafficLight.greenDuration = value; }
        }

        [
            Category("Traffic Light Settings"),
            Description("Sets the current or initial color of the traffic light.")
        ]
        public enTrafficLightColor CurrentColor
        {
            get { return trafficLight.trafficLightColor; }
            set
            {
                trafficLight.trafficLightColor = value;
                // This line ensures the image updates in the designer when you change the color
                UpdateTrafficStatus();
            }
        }

        #endregion

        public class ColorEventArgs
        {
            public enTrafficLightColor trafficLightColor { get; }
            public ColorEventArgs(enTrafficLightColor trafficLightColor)
            {
                this.trafficLightColor = trafficLightColor;
            }
        }
        public delegate void delColorChange(object sender, ColorEventArgs e);
        public event delColorChange OnColorChange;

        protected virtual void RaiseColorChange(ColorEventArgs e)
        {
            OnColorChange?.Invoke(this, e);
        }

        public ucTrafficLight()
        {
            InitializeComponent();
            trafficLight.trafficLightColor = enTrafficLightColor.red;
            trafficLight.redDuration = 6;
            trafficLight.orangeDuration = 2;
            trafficLight.greenDuration = 4;
        }

        public ucTrafficLight(enTrafficLightColor TrafficColor, ushort redDuration,
            ushort orangeDuration, ushort greenDuration)
        {
            InitializeComponent();
            trafficLight.trafficLightColor = TrafficColor;
            trafficLight.redDuration = redDuration;
            trafficLight.orangeDuration = orangeDuration;
            trafficLight.greenDuration = greenDuration;
        }

        void UpdateTrafficStatus()
        {
            // update traffic image and reset seconds duration.
            switch (trafficLight.trafficLightColor)
            {
                case enTrafficLightColor.red:
                    pbTrafficLight.Image = Resources.Red;
                    trafficLight.duration = TimeSpan.FromSeconds(trafficLight.redDuration);
                    tbSecondsDuration.ForeColor = Color.Red;
                    break;
                case enTrafficLightColor.orangeToGreen:
                case enTrafficLightColor.orangeToRed:
                    pbTrafficLight.Image = Resources.Orange;
                    trafficLight.duration = TimeSpan.FromSeconds(trafficLight.orangeDuration);
                    tbSecondsDuration.ForeColor = Color.Orange;
                    break;
                case enTrafficLightColor.green:
                    pbTrafficLight.Image = Resources.Green;
                    trafficLight.duration = TimeSpan.FromSeconds(trafficLight.greenDuration);
                    tbSecondsDuration.ForeColor = Color.Green;
                    break;
            }
            // start traffic duration
            StartTrafficDurationAsync();
        }

        async void StartTrafficDurationAsync()
        {
            try
            {
                while (trafficLight.duration.Seconds > 0 && !cts.Token.IsCancellationRequested)
                {
                    tbSecondsDuration.Text = trafficLight.duration.ToString();
                    await Task.Delay(1000, cts.Token);
                    trafficLight.duration = trafficLight.duration.Subtract(TimeSpan.FromSeconds(1));
                }
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            if (!cts.Token.IsCancellationRequested)
                SwitchTrafficStatus();
        }

        void SwitchTrafficStatus()
        {
            switch (trafficLight.trafficLightColor)
            {
                case enTrafficLightColor.red:
                    trafficLight.trafficLightColor = enTrafficLightColor.orangeToGreen;
                    break;
                case enTrafficLightColor.orangeToRed:
                    trafficLight.trafficLightColor = enTrafficLightColor.red;
                    break;
                case enTrafficLightColor.orangeToGreen:
                    trafficLight.trafficLightColor = enTrafficLightColor.green;
                    break;
                case enTrafficLightColor.green:
                    trafficLight.trafficLightColor = enTrafficLightColor.orangeToRed;
                    break;
            }
            UpdateTrafficStatus();
            RaiseColorChange(new ColorEventArgs(trafficLight.trafficLightColor));
        }

        public void Start()
        {
            cts = new CancellationTokenSource();
            UpdateTrafficStatus();
        }

        public void Stop()
        {
            cts.Cancel();
            tbSecondsDuration.ForeColor = Color.Black;
        }
    }
}
