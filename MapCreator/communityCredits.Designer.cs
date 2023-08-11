namespace MapCreator
{
    partial class communityCredits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disables The Close [X] Button In The Titlebar
        /// </summary>
        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(communityCredits));
            this.communityCredits_pictureBox_backDrop = new System.Windows.Forms.PictureBox();
            this.communityCredits_label_thankDeveloper = new System.Windows.Forms.Label();
            this.communityCredits_label_thankSubmitter = new System.Windows.Forms.Label();
            this.communityCredits_pictureBox_mapCreatorLogo = new System.Windows.Forms.PictureBox();
            this.communityCredits_label_thankDeveloper_textBox = new System.Windows.Forms.TextBox();
            this.communityCredits_label_thankSubmitter_textBox = new System.Windows.Forms.TextBox();
            this.communityCredits_pictureBox_dividerBottom = new System.Windows.Forms.PictureBox();
            this.communityCredits_pictureBox_dividerTop = new System.Windows.Forms.PictureBox();
            this.communityCredits_label_mapCreator = new System.Windows.Forms.Label();
            this.communityCredits_label_mapCreatorVersioning = new System.Windows.Forms.Label();
            this.communityCredits_label_mapCreatorBuildDate = new System.Windows.Forms.Label();
            this.communityCredits_linkLabel_uoAvocation = new System.Windows.Forms.LinkLabel();
            this.communityCredits_button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.communityCredits_pictureBox_backDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityCredits_pictureBox_mapCreatorLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityCredits_pictureBox_dividerBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityCredits_pictureBox_dividerTop)).BeginInit();
            this.SuspendLayout();
            // 
            // communityCredits_pictureBox_backDrop
            // 
            this.communityCredits_pictureBox_backDrop.Image = ((System.Drawing.Image)(resources.GetObject("communityCredits_pictureBox_backDrop.Image")));
            this.communityCredits_pictureBox_backDrop.Location = new System.Drawing.Point(0, 0);
            this.communityCredits_pictureBox_backDrop.Name = "communityCredits_pictureBox_backDrop";
            this.communityCredits_pictureBox_backDrop.Size = new System.Drawing.Size(246, 360);
            this.communityCredits_pictureBox_backDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.communityCredits_pictureBox_backDrop.TabIndex = 1;
            this.communityCredits_pictureBox_backDrop.TabStop = false;
            // 
            // communityCredits_label_thankDeveloper
            // 
            this.communityCredits_label_thankDeveloper.AutoSize = true;
            this.communityCredits_label_thankDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.communityCredits_label_thankDeveloper.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.communityCredits_label_thankDeveloper.ForeColor = System.Drawing.Color.LightSlateGray;
            this.communityCredits_label_thankDeveloper.Location = new System.Drawing.Point(4, 14);
            this.communityCredits_label_thankDeveloper.Name = "communityCredits_label_thankDeveloper";
            this.communityCredits_label_thankDeveloper.Size = new System.Drawing.Size(300, 20);
            this.communityCredits_label_thankDeveloper.TabIndex = 2;
            this.communityCredits_label_thankDeveloper.Text = "Thank You To The Developer(s) Who Assited\r\n";
            // 
            // communityCredits_label_thankSubmitter
            // 
            this.communityCredits_label_thankSubmitter.AutoSize = true;
            this.communityCredits_label_thankSubmitter.BackColor = System.Drawing.Color.Transparent;
            this.communityCredits_label_thankSubmitter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.communityCredits_label_thankSubmitter.ForeColor = System.Drawing.Color.LightSlateGray;
            this.communityCredits_label_thankSubmitter.Location = new System.Drawing.Point(6, 187);
            this.communityCredits_label_thankSubmitter.Name = "communityCredits_label_thankSubmitter";
            this.communityCredits_label_thankSubmitter.Size = new System.Drawing.Size(298, 20);
            this.communityCredits_label_thankSubmitter.TabIndex = 3;
            this.communityCredits_label_thankSubmitter.Text = "Thank You To Those Who Submitted Plugins";
            // 
            // communityCredits_pictureBox_mapCreatorLogo
            // 
            this.communityCredits_pictureBox_mapCreatorLogo.Image = ((System.Drawing.Image)(resources.GetObject("communityCredits_pictureBox_mapCreatorLogo.Image")));
            this.communityCredits_pictureBox_mapCreatorLogo.Location = new System.Drawing.Point(257, 51);
            this.communityCredits_pictureBox_mapCreatorLogo.Name = "communityCredits_pictureBox_mapCreatorLogo";
            this.communityCredits_pictureBox_mapCreatorLogo.Size = new System.Drawing.Size(83, 83);
            this.communityCredits_pictureBox_mapCreatorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.communityCredits_pictureBox_mapCreatorLogo.TabIndex = 4;
            this.communityCredits_pictureBox_mapCreatorLogo.TabStop = false;
            // 
            // communityCredits_label_thankDeveloper_textBox
            // 
            this.communityCredits_label_thankDeveloper_textBox.BackColor = System.Drawing.Color.LightGray;
            this.communityCredits_label_thankDeveloper_textBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.communityCredits_label_thankDeveloper_textBox.ForeColor = System.Drawing.Color.Navy;
            this.communityCredits_label_thankDeveloper_textBox.Location = new System.Drawing.Point(10, 51);
            this.communityCredits_label_thankDeveloper_textBox.Multiline = true;
            this.communityCredits_label_thankDeveloper_textBox.Name = "communityCredits_label_thankDeveloper_textBox";
            this.communityCredits_label_thankDeveloper_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.communityCredits_label_thankDeveloper_textBox.Size = new System.Drawing.Size(225, 122);
            this.communityCredits_label_thankDeveloper_textBox.TabIndex = 5;
            this.communityCredits_label_thankDeveloper_textBox.TabStop = false;
            this.communityCredits_label_thankDeveloper_textBox.Text = "☺ aasr-sva\r\n--------------\r\n☺ dknight\r\n--------------\r\n☺ Deragon\r\n--------------\r" +
    "\n☺ KARASHO\'\r\n--------------\r\n☺ Praxiiz\r\n--------------\r\n☺ Punt\r\n--------------\r\n" +
    "☺ Voxpire";
            // 
            // communityCredits_label_thankSubmitter_textBox
            // 
            this.communityCredits_label_thankSubmitter_textBox.BackColor = System.Drawing.Color.LightGray;
            this.communityCredits_label_thankSubmitter_textBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.communityCredits_label_thankSubmitter_textBox.ForeColor = System.Drawing.Color.Navy;
            this.communityCredits_label_thankSubmitter_textBox.Location = new System.Drawing.Point(10, 223);
            this.communityCredits_label_thankSubmitter_textBox.Multiline = true;
            this.communityCredits_label_thankSubmitter_textBox.Name = "communityCredits_label_thankSubmitter_textBox";
            this.communityCredits_label_thankSubmitter_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.communityCredits_label_thankSubmitter_textBox.Size = new System.Drawing.Size(225, 122);
            this.communityCredits_label_thankSubmitter_textBox.TabIndex = 6;
            this.communityCredits_label_thankSubmitter_textBox.TabStop = false;
            this.communityCredits_label_thankSubmitter_textBox.Text = "☺ deccer\r\n--------------\r\n☺ dknight";
            // 
            // communityCredits_pictureBox_dividerBottom
            // 
            this.communityCredits_pictureBox_dividerBottom.Image = ((System.Drawing.Image)(resources.GetObject("communityCredits_pictureBox_dividerBottom.Image")));
            this.communityCredits_pictureBox_dividerBottom.Location = new System.Drawing.Point(10, 208);
            this.communityCredits_pictureBox_dividerBottom.Name = "communityCredits_pictureBox_dividerBottom";
            this.communityCredits_pictureBox_dividerBottom.Size = new System.Drawing.Size(345, 10);
            this.communityCredits_pictureBox_dividerBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.communityCredits_pictureBox_dividerBottom.TabIndex = 7;
            this.communityCredits_pictureBox_dividerBottom.TabStop = false;
            // 
            // communityCredits_pictureBox_dividerTop
            // 
            this.communityCredits_pictureBox_dividerTop.Image = ((System.Drawing.Image)(resources.GetObject("communityCredits_pictureBox_dividerTop.Image")));
            this.communityCredits_pictureBox_dividerTop.Location = new System.Drawing.Point(10, 35);
            this.communityCredits_pictureBox_dividerTop.Name = "communityCredits_pictureBox_dividerTop";
            this.communityCredits_pictureBox_dividerTop.Size = new System.Drawing.Size(345, 10);
            this.communityCredits_pictureBox_dividerTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.communityCredits_pictureBox_dividerTop.TabIndex = 9;
            this.communityCredits_pictureBox_dividerTop.TabStop = false;
            // 
            // communityCredits_label_mapCreator
            // 
            this.communityCredits_label_mapCreator.AutoSize = true;
            this.communityCredits_label_mapCreator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.communityCredits_label_mapCreator.ForeColor = System.Drawing.Color.LightSlateGray;
            this.communityCredits_label_mapCreator.Location = new System.Drawing.Point(256, 290);
            this.communityCredits_label_mapCreator.Name = "communityCredits_label_mapCreator";
            this.communityCredits_label_mapCreator.Size = new System.Drawing.Size(88, 20);
            this.communityCredits_label_mapCreator.TabIndex = 10;
            this.communityCredits_label_mapCreator.Text = "MapCreator";
            // 
            // communityCredits_label_mapCreatorVersioning
            // 
            this.communityCredits_label_mapCreatorVersioning.AutoSize = true;
            this.communityCredits_label_mapCreatorVersioning.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.communityCredits_label_mapCreatorVersioning.ForeColor = System.Drawing.Color.LightSlateGray;
            this.communityCredits_label_mapCreatorVersioning.Location = new System.Drawing.Point(266, 310);
            this.communityCredits_label_mapCreatorVersioning.Name = "communityCredits_label_mapCreatorVersioning";
            this.communityCredits_label_mapCreatorVersioning.Size = new System.Drawing.Size(72, 17);
            this.communityCredits_label_mapCreatorVersioning.TabIndex = 11;
            this.communityCredits_label_mapCreatorVersioning.Text = "Version 3.0";
            // 
            // communityCredits_label_mapCreatorBuildDate
            // 
            this.communityCredits_label_mapCreatorBuildDate.AutoSize = true;
            this.communityCredits_label_mapCreatorBuildDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.communityCredits_label_mapCreatorBuildDate.ForeColor = System.Drawing.Color.LightSlateGray;
            this.communityCredits_label_mapCreatorBuildDate.Location = new System.Drawing.Point(248, 328);
            this.communityCredits_label_mapCreatorBuildDate.Name = "communityCredits_label_mapCreatorBuildDate";
            this.communityCredits_label_mapCreatorBuildDate.Size = new System.Drawing.Size(106, 17);
            this.communityCredits_label_mapCreatorBuildDate.TabIndex = 12;
            this.communityCredits_label_mapCreatorBuildDate.Text = "Build: 12082022a";
            // 
            // communityCredits_linkLabel_uoAvocation
            // 
            this.communityCredits_linkLabel_uoAvocation.AutoSize = true;
            this.communityCredits_linkLabel_uoAvocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.communityCredits_linkLabel_uoAvocation.ForeColor = System.Drawing.Color.LightSlateGray;
            this.communityCredits_linkLabel_uoAvocation.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.communityCredits_linkLabel_uoAvocation.Location = new System.Drawing.Point(257, 127);
            this.communityCredits_linkLabel_uoAvocation.Name = "communityCredits_linkLabel_uoAvocation";
            this.communityCredits_linkLabel_uoAvocation.Size = new System.Drawing.Size(86, 19);
            this.communityCredits_linkLabel_uoAvocation.TabIndex = 13;
            this.communityCredits_linkLabel_uoAvocation.TabStop = true;
            this.communityCredits_linkLabel_uoAvocation.Text = "uoAvocation";
            this.communityCredits_linkLabel_uoAvocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.communityCredits_linkLabel_uoAvocation_LinkClicked);
            // 
            // communityCredits_button_close
            // 
            this.communityCredits_button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("communityCredits_button_close.BackgroundImage")));
            this.communityCredits_button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.communityCredits_button_close.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.communityCredits_button_close.ForeColor = System.Drawing.Color.SlateGray;
            this.communityCredits_button_close.Location = new System.Drawing.Point(249, 240);
            this.communityCredits_button_close.Name = "communityCredits_button_close";
            this.communityCredits_button_close.Size = new System.Drawing.Size(101, 36);
            this.communityCredits_button_close.TabIndex = 14;
            this.communityCredits_button_close.Text = "Close";
            this.communityCredits_button_close.UseVisualStyleBackColor = true;
            this.communityCredits_button_close.Click += new System.EventHandler(this.communityCredits_button_close_Click);
            this.communityCredits_button_close.MouseEnter += new System.EventHandler(this.communityCredits_button_close_MouseEnter);
            this.communityCredits_button_close.MouseLeave += new System.EventHandler(this.communityCredits_button_close_MouseLeave);
            // 
            // communityCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(361, 358);
            this.Controls.Add(this.communityCredits_button_close);
            this.Controls.Add(this.communityCredits_linkLabel_uoAvocation);
            this.Controls.Add(this.communityCredits_label_mapCreatorBuildDate);
            this.Controls.Add(this.communityCredits_label_mapCreatorVersioning);
            this.Controls.Add(this.communityCredits_label_mapCreator);
            this.Controls.Add(this.communityCredits_pictureBox_dividerTop);
            this.Controls.Add(this.communityCredits_pictureBox_dividerBottom);
            this.Controls.Add(this.communityCredits_label_thankSubmitter_textBox);
            this.Controls.Add(this.communityCredits_label_thankDeveloper_textBox);
            this.Controls.Add(this.communityCredits_pictureBox_mapCreatorLogo);
            this.Controls.Add(this.communityCredits_label_thankSubmitter);
            this.Controls.Add(this.communityCredits_label_thankDeveloper);
            this.Controls.Add(this.communityCredits_pictureBox_backDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "communityCredits";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapCreator: Credits";
            ((System.ComponentModel.ISupportInitialize)(this.communityCredits_pictureBox_backDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityCredits_pictureBox_mapCreatorLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityCredits_pictureBox_dividerBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityCredits_pictureBox_dividerTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox communityCredits_pictureBox_backDrop;
        private Label communityCredits_label_thankDeveloper;
        private Label communityCredits_label_thankSubmitter;
        private PictureBox communityCredits_pictureBox_mapCreatorLogo;
        private TextBox communityCredits_label_thankDeveloper_textBox;
        private TextBox communityCredits_label_thankSubmitter_textBox;
        private PictureBox communityCredits_pictureBox_dividerBottom;
        private PictureBox communityCredits_pictureBox_dividerTop;
        private Label communityCredits_label_mapCreator;
        private Label communityCredits_label_mapCreatorVersioning;
        private Label communityCredits_label_mapCreatorBuildDate;
        private LinkLabel communityCredits_linkLabel_uoAvocation;
        private Button communityCredits_button_close;
    }
}