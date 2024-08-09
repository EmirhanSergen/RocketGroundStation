namespace Rocket_ground_station
{
    partial class HIZ
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
            this.zedGraphControlHiz = new ZedGraph.ZedGraphControl();
            this.comPortCombobox = new System.Windows.Forms.ComboBox();
            this.baudrateCombobox = new System.Windows.Forms.ComboBox();
            this.comPortLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ArduinoHizGroupBox = new System.Windows.Forms.GroupBox();
            this.baglanButton = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cizmeyeBaslaButton = new FontAwesome.Sharp.IconButton();
            this.gelenVeriHızButton = new System.Windows.Forms.Label();
            this.ArduinoHizGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControlHiz
            // 
            this.zedGraphControlHiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zedGraphControlHiz.Location = new System.Drawing.Point(503, 49);
            this.zedGraphControlHiz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControlHiz.Name = "zedGraphControlHiz";
            this.zedGraphControlHiz.ScrollGrace = 0D;
            this.zedGraphControlHiz.ScrollMaxX = 0D;
            this.zedGraphControlHiz.ScrollMaxY = 0D;
            this.zedGraphControlHiz.ScrollMaxY2 = 0D;
            this.zedGraphControlHiz.ScrollMinX = 0D;
            this.zedGraphControlHiz.ScrollMinY = 0D;
            this.zedGraphControlHiz.ScrollMinY2 = 0D;
            this.zedGraphControlHiz.Size = new System.Drawing.Size(662, 606);
            this.zedGraphControlHiz.TabIndex = 0;
            this.zedGraphControlHiz.UseExtendedPrintDialog = true;
            this.zedGraphControlHiz.Load += new System.EventHandler(this.zedGraphControlHiz_Load);
            // 
            // comPortCombobox
            // 
            this.comPortCombobox.FormattingEnabled = true;
            this.comPortCombobox.Location = new System.Drawing.Point(126, 36);
            this.comPortCombobox.Name = "comPortCombobox";
            this.comPortCombobox.Size = new System.Drawing.Size(176, 25);
            this.comPortCombobox.TabIndex = 1;
            // 
            // baudrateCombobox
            // 
            this.baudrateCombobox.FormattingEnabled = true;
            this.baudrateCombobox.Location = new System.Drawing.Point(126, 92);
            this.baudrateCombobox.Name = "baudrateCombobox";
            this.baudrateCombobox.Size = new System.Drawing.Size(176, 25);
            this.baudrateCombobox.TabIndex = 2;
            // 
            // comPortLabel
            // 
            this.comPortLabel.AutoSize = true;
            this.comPortLabel.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comPortLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comPortLabel.Location = new System.Drawing.Point(4, 36);
            this.comPortLabel.Name = "comPortLabel";
            this.comPortLabel.Size = new System.Drawing.Size(109, 24);
            this.comPortLabel.TabIndex = 3;
            this.comPortLabel.Text = "COM Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(4, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate:";
            // 
            // ArduinoHizGroupBox
            // 
            this.ArduinoHizGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArduinoHizGroupBox.Controls.Add(this.baglanButton);
            this.ArduinoHizGroupBox.Controls.Add(this.label2);
            this.ArduinoHizGroupBox.Controls.Add(this.comPortLabel);
            this.ArduinoHizGroupBox.Controls.Add(this.baudrateCombobox);
            this.ArduinoHizGroupBox.Controls.Add(this.comPortCombobox);
            this.ArduinoHizGroupBox.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArduinoHizGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ArduinoHizGroupBox.Location = new System.Drawing.Point(114, 49);
            this.ArduinoHizGroupBox.Name = "ArduinoHizGroupBox";
            this.ArduinoHizGroupBox.Size = new System.Drawing.Size(322, 198);
            this.ArduinoHizGroupBox.TabIndex = 5;
            this.ArduinoHizGroupBox.TabStop = false;
            this.ArduinoHizGroupBox.Text = "Arduino COMPORT";
            // 
            // baglanButton
            // 
            this.baglanButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.baglanButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.baglanButton.IconColor = System.Drawing.Color.Black;
            this.baglanButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.baglanButton.Location = new System.Drawing.Point(74, 137);
            this.baglanButton.Name = "baglanButton";
            this.baglanButton.Size = new System.Drawing.Size(171, 40);
            this.baglanButton.TabIndex = 5;
            this.baglanButton.Text = "Bağlan";
            this.baglanButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(114, 290);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 304);
            this.textBox1.TabIndex = 6;
            // 
            // cizmeyeBaslaButton
            // 
            this.cizmeyeBaslaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cizmeyeBaslaButton.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cizmeyeBaslaButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cizmeyeBaslaButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cizmeyeBaslaButton.IconColor = System.Drawing.Color.Black;
            this.cizmeyeBaslaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cizmeyeBaslaButton.Location = new System.Drawing.Point(188, 615);
            this.cizmeyeBaslaButton.Name = "cizmeyeBaslaButton";
            this.cizmeyeBaslaButton.Size = new System.Drawing.Size(171, 40);
            this.cizmeyeBaslaButton.TabIndex = 5;
            this.cizmeyeBaslaButton.Text = "Çizmeye Başla";
            this.cizmeyeBaslaButton.UseVisualStyleBackColor = true;
            // 
            // gelenVeriHızButton
            // 
            this.gelenVeriHızButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gelenVeriHızButton.AutoSize = true;
            this.gelenVeriHızButton.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelenVeriHızButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gelenVeriHızButton.Location = new System.Drawing.Point(118, 263);
            this.gelenVeriHızButton.Name = "gelenVeriHızButton";
            this.gelenVeriHızButton.Size = new System.Drawing.Size(131, 24);
            this.gelenVeriHızButton.TabIndex = 6;
            this.gelenVeriHızButton.Text = "Gelen Veri:";
            // 
            // HIZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1202, 734);
            this.Controls.Add(this.gelenVeriHızButton);
            this.Controls.Add(this.cizmeyeBaslaButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ArduinoHizGroupBox);
            this.Controls.Add(this.zedGraphControlHiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HIZ";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.HIZ_Load);
            this.ArduinoHizGroupBox.ResumeLayout(false);
            this.ArduinoHizGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControlHiz;
        private System.Windows.Forms.ComboBox comPortCombobox;
        private System.Windows.Forms.ComboBox baudrateCombobox;
        private System.Windows.Forms.Label comPortLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox ArduinoHizGroupBox;
        private FontAwesome.Sharp.IconButton baglanButton;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton cizmeyeBaslaButton;
        private System.Windows.Forms.Label gelenVeriHızButton;
    }
}