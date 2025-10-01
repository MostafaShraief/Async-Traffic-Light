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
    public partial class CustomControl1 : TextBox
    {
        public CustomControl1()
        {
            InitializeComponent();
            this.ForeColor = Color.White;
            this.BackColor = Color.Purple;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
