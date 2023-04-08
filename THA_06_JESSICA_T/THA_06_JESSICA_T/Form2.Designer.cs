namespace THA_06_JESSICA_T
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_nyontek = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(910, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // button_nyontek
            // 
            this.button_nyontek.Location = new System.Drawing.Point(792, 378);
            this.button_nyontek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_nyontek.Name = "button_nyontek";
            this.button_nyontek.Size = new System.Drawing.Size(111, 35);
            this.button_nyontek.TabIndex = 1;
            this.button_nyontek.Text = "nyontek?!";
            this.button_nyontek.UseVisualStyleBackColor = true;
            this.button_nyontek.Click += new System.EventHandler(this.button_nyontek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(721, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "WORDLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 12F);
            this.label3.Location = new System.Drawing.Point(616, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(481, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selamat bermain kaka, kalo capek nyontek aja itu ada tombol di bawah";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1292, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_nyontek);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_nyontek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}