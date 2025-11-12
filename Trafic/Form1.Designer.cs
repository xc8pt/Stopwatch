namespace Trafic
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
            this.components = new System.ComponentModel.Container();
            this.panelGREEN = new System.Windows.Forms.Panel();
            this.panelYELLOW = new System.Windows.Forms.Panel();
            this.panelRED = new System.Windows.Forms.Panel();
            this.buttonSTART = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelGREEN
            // 
            this.panelGREEN.Location = new System.Drawing.Point(12, 12);
            this.panelGREEN.Name = "panelGREEN";
            this.panelGREEN.Size = new System.Drawing.Size(200, 100);
            this.panelGREEN.TabIndex = 0;
            // 
            // panelYELLOW
            // 
            this.panelYELLOW.Location = new System.Drawing.Point(12, 118);
            this.panelYELLOW.Name = "panelYELLOW";
            this.panelYELLOW.Size = new System.Drawing.Size(200, 100);
            this.panelYELLOW.TabIndex = 0;
            // 
            // panelRED
            // 
            this.panelRED.Location = new System.Drawing.Point(12, 224);
            this.panelRED.Name = "panelRED";
            this.panelRED.Size = new System.Drawing.Size(200, 100);
            this.panelRED.TabIndex = 0;
            // 
            // buttonSTART
            // 
            this.buttonSTART.Location = new System.Drawing.Point(12, 348);
            this.buttonSTART.Name = "buttonSTART";
            this.buttonSTART.Size = new System.Drawing.Size(200, 90);
            this.buttonSTART.TabIndex = 1;
            this.buttonSTART.Text = "START";
            this.buttonSTART.UseVisualStyleBackColor = true;
            this.buttonSTART.Click += new System.EventHandler(this.buttonSTART_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 450);
            this.Controls.Add(this.buttonSTART);
            this.Controls.Add(this.panelRED);
            this.Controls.Add(this.panelYELLOW);
            this.Controls.Add(this.panelGREEN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGREEN;
        private System.Windows.Forms.Panel panelYELLOW;
        private System.Windows.Forms.Panel panelRED;
        private System.Windows.Forms.Button buttonSTART;
        private System.Windows.Forms.Timer timer1;
    }
}

