namespace my_Traffic_Light
{
    partial class ucTrafficLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbTrafficLight = new System.Windows.Forms.PictureBox();
            this.tbSecondsDuration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTrafficLight
            // 
            this.pbTrafficLight.Image = global::my_Traffic_Light.Properties.Resources.Red;
            this.pbTrafficLight.Location = new System.Drawing.Point(0, 0);
            this.pbTrafficLight.Name = "pbTrafficLight";
            this.pbTrafficLight.Size = new System.Drawing.Size(109, 222);
            this.pbTrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrafficLight.TabIndex = 0;
            this.pbTrafficLight.TabStop = false;
            // 
            // tbSecondsDuration
            // 
            this.tbSecondsDuration.BackColor = System.Drawing.Color.White;
            this.tbSecondsDuration.Location = new System.Drawing.Point(4, 228);
            this.tbSecondsDuration.Name = "tbSecondsDuration";
            this.tbSecondsDuration.Size = new System.Drawing.Size(100, 22);
            this.tbSecondsDuration.TabIndex = 1;
            this.tbSecondsDuration.Text = "0";
            this.tbSecondsDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbSecondsDuration);
            this.Controls.Add(this.pbTrafficLight);
            this.Name = "ucTrafficLight";
            this.Size = new System.Drawing.Size(107, 262);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrafficLight;
        private System.Windows.Forms.TextBox tbSecondsDuration;
    }
}
