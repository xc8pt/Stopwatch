namespace TraficLigthEasy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRED = new System.Windows.Forms.Button();
            this.buttonYELLOW = new System.Windows.Forms.Button();
            this.buttonGREEN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(243, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 149);
            this.panel1.TabIndex = 0;
            // 
            // buttonRED
            // 
            this.buttonRED.Location = new System.Drawing.Point(67, 351);
            this.buttonRED.Name = "buttonRED";
            this.buttonRED.Size = new System.Drawing.Size(109, 50);
            this.buttonRED.TabIndex = 0;
            this.buttonRED.Text = "button1";
            this.buttonRED.UseVisualStyleBackColor = true;
            this.buttonRED.Click += new System.EventHandler(this.buttonRED_Click);
            // 
            // buttonYELLOW
            // 
            this.buttonYELLOW.Location = new System.Drawing.Point(368, 351);
            this.buttonYELLOW.Name = "buttonYELLOW";
            this.buttonYELLOW.Size = new System.Drawing.Size(109, 50);
            this.buttonYELLOW.TabIndex = 0;
            this.buttonYELLOW.Text = "button1";
            this.buttonYELLOW.UseVisualStyleBackColor = true;
            this.buttonYELLOW.Click += new System.EventHandler(this.buttonYELLOW_Click);
            // 
            // buttonGREEN
            // 
            this.buttonGREEN.Location = new System.Drawing.Point(665, 351);
            this.buttonGREEN.Name = "buttonGREEN";
            this.buttonGREEN.Size = new System.Drawing.Size(109, 50);
            this.buttonGREEN.TabIndex = 0;
            this.buttonGREEN.Text = "button1";
            this.buttonGREEN.UseVisualStyleBackColor = true;
            this.buttonGREEN.Click += new System.EventHandler(this.buttonGREEN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGREEN);
            this.Controls.Add(this.buttonYELLOW);
            this.Controls.Add(this.buttonRED);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRED;
        private System.Windows.Forms.Button buttonYELLOW;
        private System.Windows.Forms.Button buttonGREEN;
        private System.Windows.Forms.Label label1;
    }
}

