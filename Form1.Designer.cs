namespace my_Traffic_Light
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userControl11 = new Class_for_test.UserControl1();
            this.ucTrafficLight3 = new my_Traffic_Light.ucTrafficLight();
            this.ucTrafficLight2 = new my_Traffic_Light.ucTrafficLight();
            this.ucTrafficLight1 = new my_Traffic_Light.ucTrafficLight();
            this.customControl11 = new my_Traffic_Light.CustomControl1();
            this.customControl12 = new my_Traffic_Light.CustomControl1();
            this.customControl13 = new my_Traffic_Light.CustomControl1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(95, 338);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(229, 100);
            this.userControl11.TabIndex = 5;
            // 
            // ucTrafficLight3
            // 
            this.ucTrafficLight3.BackColor = System.Drawing.Color.White;
            this.ucTrafficLight3.CurrentColor = my_Traffic_Light.ucTrafficLight.enTrafficLightColor.green;
            this.ucTrafficLight3.GreenDuration = ((ushort)(2));
            this.ucTrafficLight3.Location = new System.Drawing.Point(607, 29);
            this.ucTrafficLight3.Name = "ucTrafficLight3";
            this.ucTrafficLight3.OrangeDuration = ((ushort)(1));
            this.ucTrafficLight3.RedDuration = ((ushort)(3));
            this.ucTrafficLight3.Size = new System.Drawing.Size(107, 262);
            this.ucTrafficLight3.TabIndex = 2;
            // 
            // ucTrafficLight2
            // 
            this.ucTrafficLight2.BackColor = System.Drawing.Color.White;
            this.ucTrafficLight2.CurrentColor = my_Traffic_Light.ucTrafficLight.enTrafficLightColor.red;
            this.ucTrafficLight2.GreenDuration = ((ushort)(4));
            this.ucTrafficLight2.Location = new System.Drawing.Point(433, 29);
            this.ucTrafficLight2.Name = "ucTrafficLight2";
            this.ucTrafficLight2.OrangeDuration = ((ushort)(2));
            this.ucTrafficLight2.RedDuration = ((ushort)(6));
            this.ucTrafficLight2.Size = new System.Drawing.Size(107, 262);
            this.ucTrafficLight2.TabIndex = 1;
            this.ucTrafficLight2.OnColorChange += new my_Traffic_Light.ucTrafficLight.delColorChange(this.ucTrafficLight2_OnColorChange);
            // 
            // ucTrafficLight1
            // 
            this.ucTrafficLight1.BackColor = System.Drawing.Color.White;
            this.ucTrafficLight1.CurrentColor = my_Traffic_Light.ucTrafficLight.enTrafficLightColor.green;
            this.ucTrafficLight1.GreenDuration = ((ushort)(4));
            this.ucTrafficLight1.Location = new System.Drawing.Point(265, 29);
            this.ucTrafficLight1.Name = "ucTrafficLight1";
            this.ucTrafficLight1.OrangeDuration = ((ushort)(2));
            this.ucTrafficLight1.RedDuration = ((ushort)(6));
            this.ucTrafficLight1.Size = new System.Drawing.Size(107, 262);
            this.ucTrafficLight1.TabIndex = 0;
            // 
            // customControl11
            // 
            this.customControl11.BackColor = System.Drawing.Color.Purple;
            this.customControl11.ForeColor = System.Drawing.Color.White;
            this.customControl11.Location = new System.Drawing.Point(61, 166);
            this.customControl11.Name = "customControl11";
            this.customControl11.Size = new System.Drawing.Size(100, 22);
            this.customControl11.TabIndex = 6;
            // 
            // customControl12
            // 
            this.customControl12.BackColor = System.Drawing.Color.Purple;
            this.customControl12.ForeColor = System.Drawing.Color.White;
            this.customControl12.Location = new System.Drawing.Point(61, 211);
            this.customControl12.Name = "customControl12";
            this.customControl12.Size = new System.Drawing.Size(100, 22);
            this.customControl12.TabIndex = 7;
            // 
            // customControl13
            // 
            this.customControl13.BackColor = System.Drawing.Color.Purple;
            this.customControl13.ForeColor = System.Drawing.Color.White;
            this.customControl13.Location = new System.Drawing.Point(61, 252);
            this.customControl13.Name = "customControl13";
            this.customControl13.Size = new System.Drawing.Size(100, 22);
            this.customControl13.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customControl13);
            this.Controls.Add(this.customControl12);
            this.Controls.Add(this.customControl11);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucTrafficLight3);
            this.Controls.Add(this.ucTrafficLight2);
            this.Controls.Add(this.ucTrafficLight1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucTrafficLight ucTrafficLight1;
        private ucTrafficLight ucTrafficLight2;
        private ucTrafficLight ucTrafficLight3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Class_for_test.UserControl1 userControl11;
        private CustomControl1 customControl11;
        private CustomControl1 customControl12;
        private CustomControl1 customControl13;
    }
}

