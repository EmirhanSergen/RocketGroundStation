namespace Rocket_ground_station
{
    partial class AliciTest
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
            this.aliciPortAyarlarıButton = new FontAwesome.Sharp.IconButton();
            this.aliciPortAcButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // aliciPortAyarlarıButton
            // 
            this.aliciPortAyarlarıButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aliciPortAyarlarıButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.aliciPortAyarlarıButton.IconColor = System.Drawing.Color.Black;
            this.aliciPortAyarlarıButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aliciPortAyarlarıButton.Location = new System.Drawing.Point(384, 307);
            this.aliciPortAyarlarıButton.Name = "aliciPortAyarlarıButton";
            this.aliciPortAyarlarıButton.Size = new System.Drawing.Size(184, 69);
            this.aliciPortAyarlarıButton.TabIndex = 0;
            this.aliciPortAyarlarıButton.Text = "ALICI PORT AYARLARI";
            this.aliciPortAyarlarıButton.UseVisualStyleBackColor = true;
            // 
            // aliciPortAcButton
            // 
            this.aliciPortAcButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aliciPortAcButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.aliciPortAcButton.IconColor = System.Drawing.Color.Black;
            this.aliciPortAcButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aliciPortAcButton.Location = new System.Drawing.Point(678, 307);
            this.aliciPortAcButton.Name = "aliciPortAcButton";
            this.aliciPortAcButton.Size = new System.Drawing.Size(184, 69);
            this.aliciPortAcButton.TabIndex = 1;
            this.aliciPortAcButton.Text = "ALICI PORT AÇ";
            this.aliciPortAcButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1202, 734);
            this.Controls.Add(this.aliciPortAcButton);
            this.Controls.Add(this.aliciPortAyarlarıButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton aliciPortAyarlarıButton;
        private FontAwesome.Sharp.IconButton aliciPortAcButton;
    }
}