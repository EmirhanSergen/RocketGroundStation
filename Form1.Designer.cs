namespace Rocket_ground_station
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.yerIstasyonuButton = new FontAwesome.Sharp.IconButton();
            this.takimHakkindaButton = new FontAwesome.Sharp.IconButton();
            this.hızTestButton = new FontAwesome.Sharp.IconButton();
            this.vericiTestButton = new FontAwesome.Sharp.IconButton();
            this.aliciTestButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.salgurLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.kapamaIconButton = new FontAwesome.Sharp.IconButton();
            this.homeTextLabel = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.ataturkImzaPictureBox = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salgurLogoPictureBox)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataturkImzaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.ataturkImzaPictureBox);
            this.panelMenu.Controls.Add(this.yerIstasyonuButton);
            this.panelMenu.Controls.Add(this.takimHakkindaButton);
            this.panelMenu.Controls.Add(this.hızTestButton);
            this.panelMenu.Controls.Add(this.vericiTestButton);
            this.panelMenu.Controls.Add(this.aliciTestButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 717);
            this.panelMenu.TabIndex = 0;
            // 
            // yerIstasyonuButton
            // 
            this.yerIstasyonuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.yerIstasyonuButton.FlatAppearance.BorderSize = 0;
            this.yerIstasyonuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yerIstasyonuButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.yerIstasyonuButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.yerIstasyonuButton.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.yerIstasyonuButton.IconColor = System.Drawing.Color.Silver;
            this.yerIstasyonuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.yerIstasyonuButton.IconSize = 40;
            this.yerIstasyonuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yerIstasyonuButton.Location = new System.Drawing.Point(0, 414);
            this.yerIstasyonuButton.Name = "yerIstasyonuButton";
            this.yerIstasyonuButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.yerIstasyonuButton.Size = new System.Drawing.Size(220, 66);
            this.yerIstasyonuButton.TabIndex = 4;
            this.yerIstasyonuButton.Text = "Yer İstasyonu";
            this.yerIstasyonuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yerIstasyonuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.yerIstasyonuButton.UseVisualStyleBackColor = true;
            this.yerIstasyonuButton.Click += new System.EventHandler(this.yerIstasyonuButton_Click);
            // 
            // takimHakkindaButton
            // 
            this.takimHakkindaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.takimHakkindaButton.FlatAppearance.BorderSize = 0;
            this.takimHakkindaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takimHakkindaButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.takimHakkindaButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.takimHakkindaButton.IconChar = FontAwesome.Sharp.IconChar.Invision;
            this.takimHakkindaButton.IconColor = System.Drawing.Color.Silver;
            this.takimHakkindaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.takimHakkindaButton.IconSize = 40;
            this.takimHakkindaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.takimHakkindaButton.Location = new System.Drawing.Point(0, 348);
            this.takimHakkindaButton.Name = "takimHakkindaButton";
            this.takimHakkindaButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.takimHakkindaButton.Size = new System.Drawing.Size(220, 66);
            this.takimHakkindaButton.TabIndex = 3;
            this.takimHakkindaButton.Text = "Takım Hakkında";
            this.takimHakkindaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.takimHakkindaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.takimHakkindaButton.UseVisualStyleBackColor = true;
            this.takimHakkindaButton.Click += new System.EventHandler(this.takimHakkindaButton_Click);
            // 
            // hızTestButton
            // 
            this.hızTestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.hızTestButton.FlatAppearance.BorderSize = 0;
            this.hızTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hızTestButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.hızTestButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.hızTestButton.IconChar = FontAwesome.Sharp.IconChar.Vine;
            this.hızTestButton.IconColor = System.Drawing.Color.Silver;
            this.hızTestButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.hızTestButton.IconSize = 40;
            this.hızTestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hızTestButton.Location = new System.Drawing.Point(0, 282);
            this.hızTestButton.Name = "hızTestButton";
            this.hızTestButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.hızTestButton.Size = new System.Drawing.Size(220, 66);
            this.hızTestButton.TabIndex = 2;
            this.hızTestButton.Text = "Hız Test";
            this.hızTestButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hızTestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hızTestButton.UseVisualStyleBackColor = true;
            this.hızTestButton.Click += new System.EventHandler(this.hızTestButton_Click);
            // 
            // vericiTestButton
            // 
            this.vericiTestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.vericiTestButton.FlatAppearance.BorderSize = 0;
            this.vericiTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vericiTestButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.vericiTestButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.vericiTestButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsToDot;
            this.vericiTestButton.IconColor = System.Drawing.Color.Silver;
            this.vericiTestButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vericiTestButton.IconSize = 40;
            this.vericiTestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vericiTestButton.Location = new System.Drawing.Point(0, 216);
            this.vericiTestButton.Name = "vericiTestButton";
            this.vericiTestButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vericiTestButton.Size = new System.Drawing.Size(220, 66);
            this.vericiTestButton.TabIndex = 1;
            this.vericiTestButton.Text = "Verici Test";
            this.vericiTestButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vericiTestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vericiTestButton.UseVisualStyleBackColor = true;
            this.vericiTestButton.Click += new System.EventHandler(this.vericiTestButton_Click);
            // 
            // aliciTestButton
            // 
            this.aliciTestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aliciTestButton.FlatAppearance.BorderSize = 0;
            this.aliciTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aliciTestButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.aliciTestButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.aliciTestButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsTurnToDots;
            this.aliciTestButton.IconColor = System.Drawing.Color.Silver;
            this.aliciTestButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aliciTestButton.IconSize = 40;
            this.aliciTestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aliciTestButton.Location = new System.Drawing.Point(0, 150);
            this.aliciTestButton.Name = "aliciTestButton";
            this.aliciTestButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.aliciTestButton.Size = new System.Drawing.Size(220, 66);
            this.aliciTestButton.TabIndex = 0;
            this.aliciTestButton.Text = "Alıcı Test";
            this.aliciTestButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aliciTestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aliciTestButton.UseVisualStyleBackColor = true;
            this.aliciTestButton.Click += new System.EventHandler(this.aliciTestButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.salgurLogoPictureBox);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 150);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // salgurLogoPictureBox
            // 
            this.salgurLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("salgurLogoPictureBox.Image")));
            this.salgurLogoPictureBox.Location = new System.Drawing.Point(-54, -35);
            this.salgurLogoPictureBox.Name = "salgurLogoPictureBox";
            this.salgurLogoPictureBox.Size = new System.Drawing.Size(306, 231);
            this.salgurLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.salgurLogoPictureBox.TabIndex = 0;
            this.salgurLogoPictureBox.TabStop = false;
            this.salgurLogoPictureBox.Click += new System.EventHandler(this.salgurLogoPictureBox_Click);
            this.salgurLogoPictureBox.MouseEnter += new System.EventHandler(this.salgurLogoPictureBox_MouseEnter);
            this.salgurLogoPictureBox.MouseLeave += new System.EventHandler(this.salgurLogoPictureBox_MouseLeave);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.kapamaIconButton);
            this.panelTitleBar.Controls.Add(this.homeTextLabel);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // kapamaIconButton
            // 
            this.kapamaIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kapamaIconButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kapamaIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.kapamaIconButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.kapamaIconButton.IconColor = System.Drawing.Color.Firebrick;
            this.kapamaIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kapamaIconButton.IconSize = 27;
            this.kapamaIconButton.Location = new System.Drawing.Point(901, 15);
            this.kapamaIconButton.Name = "kapamaIconButton";
            this.kapamaIconButton.Size = new System.Drawing.Size(40, 39);
            this.kapamaIconButton.TabIndex = 3;
            this.kapamaIconButton.UseVisualStyleBackColor = false;
            this.kapamaIconButton.Click += new System.EventHandler(this.kapamaIconButton_Click);
            this.kapamaIconButton.MouseEnter += new System.EventHandler(this.kapamaIconButton_MouseEnter);
            this.kapamaIconButton.MouseLeave += new System.EventHandler(this.kapamaIconButton_MouseLeave);
            // 
            // homeTextLabel
            // 
            this.homeTextLabel.AutoSize = true;
            this.homeTextLabel.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.homeTextLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.homeTextLabel.Location = new System.Drawing.Point(56, 29);
            this.homeTextLabel.Name = "homeTextLabel";
            this.homeTextLabel.Size = new System.Drawing.Size(77, 25);
            this.homeTextLabel.TabIndex = 1;
            this.homeTextLabel.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 22);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(964, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(964, 633);
            this.panelDesktop.TabIndex = 3;
            // 
            // ataturkImzaPictureBox
            // 
            this.ataturkImzaPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ataturkImzaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ataturkImzaPictureBox.Image")));
            this.ataturkImzaPictureBox.Location = new System.Drawing.Point(0, 663);
            this.ataturkImzaPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.ataturkImzaPictureBox.Name = "ataturkImzaPictureBox";
            this.ataturkImzaPictureBox.Padding = new System.Windows.Forms.Padding(2);
            this.ataturkImzaPictureBox.Size = new System.Drawing.Size(220, 54);
            this.ataturkImzaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ataturkImzaPictureBox.TabIndex = 5;
            this.ataturkImzaPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 717);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salgurLogoPictureBox)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataturkImzaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton aliciTestButton;
        private FontAwesome.Sharp.IconButton hızTestButton;
        private FontAwesome.Sharp.IconButton vericiTestButton;
        private FontAwesome.Sharp.IconButton takimHakkindaButton;
        private FontAwesome.Sharp.IconButton yerIstasyonuButton;
        private System.Windows.Forms.PictureBox salgurLogoPictureBox;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label homeTextLabel;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton kapamaIconButton;
        private System.Windows.Forms.PictureBox ataturkImzaPictureBox;
    }
}

