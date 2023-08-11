namespace MapCreator
{
    partial class colorTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(colorTables));
            this.colorTables_menuStrip = new System.Windows.Forms.MenuStrip();
            this.colorTables_menuStrip_button_getAdobePhotoshop = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTables_menuStrip_button_openExportLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTables_menuStrip_button_export = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTables_menuStrip_button_export_terrain = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTables_menuStrip_button_export_terrain_adobeColorTableACT = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTables_menuStrip_button_export_terrain_adobeSwatchFileACO = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTables_menuStrip_button_export_altitude = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTables_menuStrip_button_export_altitude_adobeColorTableACT = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTables_menuStrip_button_export_altitude_adobeSwatchFileACO = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTables_menuStrip_button_facetBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTables_menuStrip_button_information = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTables_pictureBox_topDivider = new System.Windows.Forms.PictureBox();
            this.colorTables_pictureBox_bottomDivider = new System.Windows.Forms.PictureBox();
            this.colorTables_statusStrip = new System.Windows.Forms.StatusStrip();
            this.colorTables_statusStrip_sizeElevenSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorTables_pictureBox_backDrop = new System.Windows.Forms.PictureBox();
            this.colorTables_label_adobePhotoshopColorPalette = new System.Windows.Forms.Label();
            this.colorTables_listBox_colorTableList = new System.Windows.Forms.ListBox();
            this.colorTables_propertyGrid_colorTableProperties = new System.Windows.Forms.PropertyGrid();
            this.colorTables_statusStrip_label_mapCreatorBuildDate = new System.Windows.Forms.Label();
            this.colorTables_statusStrip_label_mapCreatorVersioning = new System.Windows.Forms.Label();
            this.colorTables_pictureBox_notificationBox = new System.Windows.Forms.PictureBox();
            this.colorTables_pictureBox_notificationBox_label_fileUsability = new System.Windows.Forms.Label();
            this.colorTables_pictureBox_notificationBox_label_altitudeGradient = new System.Windows.Forms.Label();
            this.colorTables_pictureBox_altitudeDisplay = new System.Windows.Forms.PictureBox();
            this.colorTables_pictureBox_colorPalette = new System.Windows.Forms.PictureBox();
            this.colorTables_pictureBox_tileDisplay = new System.Windows.Forms.PictureBox();
            this.colorTables_button_loadTerrainColorTables = new System.Windows.Forms.Button();
            this.colorTables_button_loadAltitudeColorTables = new System.Windows.Forms.Button();
            this.colorTables_button_loadTerrainColorTables_label = new System.Windows.Forms.Label();
            this.colorTables_button_loadAltitudeColorTables_label = new System.Windows.Forms.Label();
            this.colorTables_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_topDivider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_bottomDivider)).BeginInit();
            this.colorTables_statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_backDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_notificationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_altitudeDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_colorPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_tileDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // colorTables_menuStrip
            // 
            this.colorTables_menuStrip.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTables_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.colorTables_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTables_menuStrip_button_getAdobePhotoshop,
            this.colorTables_menuStrip_button_openExportLocation,
            this.colorTables_menuStrip_button_export,
            this.colorTables_menuStrip_button_facetBuilder,
            this.colorTables_menuStrip_button_information});
            this.colorTables_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.colorTables_menuStrip.Name = "colorTables_menuStrip";
            this.colorTables_menuStrip.Size = new System.Drawing.Size(773, 28);
            this.colorTables_menuStrip.TabIndex = 0;
            this.colorTables_menuStrip.Text = "menuStrip1";
            // 
            // colorTables_menuStrip_button_getAdobePhotoshop
            // 
            this.colorTables_menuStrip_button_getAdobePhotoshop.Image = ((System.Drawing.Image)(resources.GetObject("colorTables_menuStrip_button_getAdobePhotoshop.Image")));
            this.colorTables_menuStrip_button_getAdobePhotoshop.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.colorTables_menuStrip_button_getAdobePhotoshop.Name = "colorTables_menuStrip_button_getAdobePhotoshop";
            this.colorTables_menuStrip_button_getAdobePhotoshop.Size = new System.Drawing.Size(32, 24);
            this.colorTables_menuStrip_button_getAdobePhotoshop.Click += new System.EventHandler(this.colorTables_menuStrip_button_getAdobePhotoshop_Click);
            // 
            // colorTables_menuStrip_button_openExportLocation
            // 
            this.colorTables_menuStrip_button_openExportLocation.Image = ((System.Drawing.Image)(resources.GetObject("colorTables_menuStrip_button_openExportLocation.Image")));
            this.colorTables_menuStrip_button_openExportLocation.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.colorTables_menuStrip_button_openExportLocation.Name = "colorTables_menuStrip_button_openExportLocation";
            this.colorTables_menuStrip_button_openExportLocation.Size = new System.Drawing.Size(32, 24);
            this.colorTables_menuStrip_button_openExportLocation.Click += new System.EventHandler(this.colorTables_menuStrip_button_openExportLocation_Click);
            // 
            // colorTables_menuStrip_button_export
            // 
            this.colorTables_menuStrip_button_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTables_menuStrip_button_export_terrain,
            this.colorTables_menuStrip_button_export_altitude});
            this.colorTables_menuStrip_button_export.Image = ((System.Drawing.Image)(resources.GetObject("colorTables_menuStrip_button_export.Image")));
            this.colorTables_menuStrip_button_export.Margin = new System.Windows.Forms.Padding(568, 0, 0, 0);
            this.colorTables_menuStrip_button_export.Name = "colorTables_menuStrip_button_export";
            this.colorTables_menuStrip_button_export.Size = new System.Drawing.Size(32, 24);
            // 
            // colorTables_menuStrip_button_export_terrain
            // 
            this.colorTables_menuStrip_button_export_terrain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTables_menuStrip_button_export_terrain_adobeColorTableACT,
            this.colorTables_menuStrip_button_export_terrain_adobeSwatchFileACO});
            this.colorTables_menuStrip_button_export_terrain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTables_menuStrip_button_export_terrain.Name = "colorTables_menuStrip_button_export_terrain";
            this.colorTables_menuStrip_button_export_terrain.Size = new System.Drawing.Size(203, 26);
            this.colorTables_menuStrip_button_export_terrain.Text = "Save Terrain As...";
            // 
            // colorTables_menuStrip_button_export_terrain_adobeColorTableACT
            // 
            this.colorTables_menuStrip_button_export_terrain_adobeColorTableACT.Name = "colorTables_menuStrip_button_export_terrain_adobeColorTableACT";
            this.colorTables_menuStrip_button_export_terrain_adobeColorTableACT.Size = new System.Drawing.Size(260, 26);
            this.colorTables_menuStrip_button_export_terrain_adobeColorTableACT.Text = "Adobe™ Color Table (.act)";
            this.colorTables_menuStrip_button_export_terrain_adobeColorTableACT.Click += new System.EventHandler(this.colorTables_menuStrip_button_export_terrain_adobeColorTableACT_Click);
            // 
            // colorTables_menuStrip_button_export_terrain_adobeSwatchFileACO
            // 
            this.colorTables_menuStrip_button_export_terrain_adobeSwatchFileACO.Name = "colorTables_menuStrip_button_export_terrain_adobeSwatchFileACO";
            this.colorTables_menuStrip_button_export_terrain_adobeSwatchFileACO.Size = new System.Drawing.Size(260, 26);
            this.colorTables_menuStrip_button_export_terrain_adobeSwatchFileACO.Text = "Adobe™ Swatch File (.aco)";
            this.colorTables_menuStrip_button_export_terrain_adobeSwatchFileACO.Click += new System.EventHandler(this.colorTables_menuStrip_button_export_terrain_adobeSwatchFileACO_Click);
            // 
            // colorTables_menuStrip_button_export_altitude
            // 
            this.colorTables_menuStrip_button_export_altitude.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTables_menuStrip_button_export_altitude_adobeColorTableACT,
            this.colorTables_menuStrip_button_export_altitude_adobeSwatchFileACO});
            this.colorTables_menuStrip_button_export_altitude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTables_menuStrip_button_export_altitude.Name = "colorTables_menuStrip_button_export_altitude";
            this.colorTables_menuStrip_button_export_altitude.Size = new System.Drawing.Size(203, 26);
            this.colorTables_menuStrip_button_export_altitude.Text = "Save Altitude As...";
            // 
            // colorTables_menuStrip_button_export_altitude_adobeColorTableACT
            // 
            this.colorTables_menuStrip_button_export_altitude_adobeColorTableACT.Name = "colorTables_menuStrip_button_export_altitude_adobeColorTableACT";
            this.colorTables_menuStrip_button_export_altitude_adobeColorTableACT.Size = new System.Drawing.Size(260, 26);
            this.colorTables_menuStrip_button_export_altitude_adobeColorTableACT.Text = "Adobe™ Color Table (.act)";
            this.colorTables_menuStrip_button_export_altitude_adobeColorTableACT.Click += new System.EventHandler(this.colorTables_menuStrip_button_export_altitude_adobeColorTableACT_Click);
            // 
            // colorTables_menuStrip_button_export_altitude_adobeSwatchFileACO
            // 
            this.colorTables_menuStrip_button_export_altitude_adobeSwatchFileACO.Name = "colorTables_menuStrip_button_export_altitude_adobeSwatchFileACO";
            this.colorTables_menuStrip_button_export_altitude_adobeSwatchFileACO.Size = new System.Drawing.Size(260, 26);
            this.colorTables_menuStrip_button_export_altitude_adobeSwatchFileACO.Text = "Adobe™ Swatch File (.aco)";
            this.colorTables_menuStrip_button_export_altitude_adobeSwatchFileACO.Click += new System.EventHandler(this.colorTables_menuStrip_button_export_altitude_adobeSwatchFileACO_Click);
            // 
            // colorTables_menuStrip_button_facetBuilder
            // 
            this.colorTables_menuStrip_button_facetBuilder.Image = ((System.Drawing.Image)(resources.GetObject("colorTables_menuStrip_button_facetBuilder.Image")));
            this.colorTables_menuStrip_button_facetBuilder.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.colorTables_menuStrip_button_facetBuilder.Name = "colorTables_menuStrip_button_facetBuilder";
            this.colorTables_menuStrip_button_facetBuilder.Size = new System.Drawing.Size(32, 24);
            this.colorTables_menuStrip_button_facetBuilder.Click += new System.EventHandler(this.colorTables_menuStrip_button_facetBuilder_Click);
            // 
            // colorTables_menuStrip_button_information
            // 
            this.colorTables_menuStrip_button_information.Image = ((System.Drawing.Image)(resources.GetObject("colorTables_menuStrip_button_information.Image")));
            this.colorTables_menuStrip_button_information.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.colorTables_menuStrip_button_information.Name = "colorTables_menuStrip_button_information";
            this.colorTables_menuStrip_button_information.Size = new System.Drawing.Size(32, 24);
            this.colorTables_menuStrip_button_information.Click += new System.EventHandler(this.colorTables_menuStrip_button_information_Click);
            // 
            // colorTables_pictureBox_topDivider
            // 
            this.colorTables_pictureBox_topDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorTables_pictureBox_topDivider.Image = ((System.Drawing.Image)(resources.GetObject("colorTables_pictureBox_topDivider.Image")));
            this.colorTables_pictureBox_topDivider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colorTables_pictureBox_topDivider.Location = new System.Drawing.Point(0, 28);
            this.colorTables_pictureBox_topDivider.Name = "colorTables_pictureBox_topDivider";
            this.colorTables_pictureBox_topDivider.Size = new System.Drawing.Size(773, 12);
            this.colorTables_pictureBox_topDivider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorTables_pictureBox_topDivider.TabIndex = 4;
            this.colorTables_pictureBox_topDivider.TabStop = false;
            // 
            // colorTables_pictureBox_bottomDivider
            // 
            this.colorTables_pictureBox_bottomDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorTables_pictureBox_bottomDivider.Image = ((System.Drawing.Image)(resources.GetObject("colorTables_pictureBox_bottomDivider.Image")));
            this.colorTables_pictureBox_bottomDivider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colorTables_pictureBox_bottomDivider.Location = new System.Drawing.Point(0, 410);
            this.colorTables_pictureBox_bottomDivider.Name = "colorTables_pictureBox_bottomDivider";
            this.colorTables_pictureBox_bottomDivider.Size = new System.Drawing.Size(773, 12);
            this.colorTables_pictureBox_bottomDivider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorTables_pictureBox_bottomDivider.TabIndex = 5;
            this.colorTables_pictureBox_bottomDivider.TabStop = false;
            // 
            // colorTables_statusStrip
            // 
            this.colorTables_statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.colorTables_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTables_statusStrip_sizeElevenSpacer});
            this.colorTables_statusStrip.Location = new System.Drawing.Point(0, 419);
            this.colorTables_statusStrip.Name = "colorTables_statusStrip";
            this.colorTables_statusStrip.Size = new System.Drawing.Size(773, 25);
            this.colorTables_statusStrip.TabIndex = 6;
            this.colorTables_statusStrip.Text = "statusStrip1";
            // 
            // colorTables_statusStrip_sizeElevenSpacer
            // 
            this.colorTables_statusStrip_sizeElevenSpacer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTables_statusStrip_sizeElevenSpacer.Name = "colorTables_statusStrip_sizeElevenSpacer";
            this.colorTables_statusStrip_sizeElevenSpacer.Size = new System.Drawing.Size(13, 20);
            this.colorTables_statusStrip_sizeElevenSpacer.Text = " ";
            // 
            // colorTables_pictureBox_backDrop
            // 
            this.colorTables_pictureBox_backDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorTables_pictureBox_backDrop.Image = ((System.Drawing.Image)(resources.GetObject("colorTables_pictureBox_backDrop.Image")));
            this.colorTables_pictureBox_backDrop.Location = new System.Drawing.Point(0, 0);
            this.colorTables_pictureBox_backDrop.Name = "colorTables_pictureBox_backDrop";
            this.colorTables_pictureBox_backDrop.Size = new System.Drawing.Size(773, 444);
            this.colorTables_pictureBox_backDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorTables_pictureBox_backDrop.TabIndex = 7;
            this.colorTables_pictureBox_backDrop.TabStop = false;
            // 
            // colorTables_label_adobePhotoshopColorPalette
            // 
            this.colorTables_label_adobePhotoshopColorPalette.AutoSize = true;
            this.colorTables_label_adobePhotoshopColorPalette.BackColor = System.Drawing.Color.Transparent;
            this.colorTables_label_adobePhotoshopColorPalette.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTables_label_adobePhotoshopColorPalette.ForeColor = System.Drawing.Color.Lavender;
            this.colorTables_label_adobePhotoshopColorPalette.Location = new System.Drawing.Point(13, 48);
            this.colorTables_label_adobePhotoshopColorPalette.Name = "colorTables_label_adobePhotoshopColorPalette";
            this.colorTables_label_adobePhotoshopColorPalette.Size = new System.Drawing.Size(291, 25);
            this.colorTables_label_adobePhotoshopColorPalette.TabIndex = 8;
            this.colorTables_label_adobePhotoshopColorPalette.Text = "Adobe Photoshop™ Color Palette";
            // 
            // colorTables_listBox_colorTableList
            // 
            this.colorTables_listBox_colorTableList.FormattingEnabled = true;
            this.colorTables_listBox_colorTableList.ItemHeight = 15;
            this.colorTables_listBox_colorTableList.Location = new System.Drawing.Point(12, 84);
            this.colorTables_listBox_colorTableList.Name = "colorTables_listBox_colorTableList";
            this.colorTables_listBox_colorTableList.Size = new System.Drawing.Size(335, 229);
            this.colorTables_listBox_colorTableList.TabIndex = 9;
            this.colorTables_listBox_colorTableList.SelectedIndexChanged += new System.EventHandler(this.colorTables_listBox_colorTableList_SelectedIndexChanged);
            // 
            // colorTables_propertyGrid_colorTableProperties
            // 
            this.colorTables_propertyGrid_colorTableProperties.HelpVisible = false;
            this.colorTables_propertyGrid_colorTableProperties.Location = new System.Drawing.Point(398, 59);
            this.colorTables_propertyGrid_colorTableProperties.Name = "colorTables_propertyGrid_colorTableProperties";
            this.colorTables_propertyGrid_colorTableProperties.Size = new System.Drawing.Size(362, 254);
            this.colorTables_propertyGrid_colorTableProperties.TabIndex = 10;
            // 
            // colorTables_statusStrip_label_mapCreatorBuildDate
            // 
            this.colorTables_statusStrip_label_mapCreatorBuildDate.AutoSize = true;
            this.colorTables_statusStrip_label_mapCreatorBuildDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTables_statusStrip_label_mapCreatorBuildDate.ForeColor = System.Drawing.Color.SlateGray;
            this.colorTables_statusStrip_label_mapCreatorBuildDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colorTables_statusStrip_label_mapCreatorBuildDate.Location = new System.Drawing.Point(640, 424);
            this.colorTables_statusStrip_label_mapCreatorBuildDate.Name = "colorTables_statusStrip_label_mapCreatorBuildDate";
            this.colorTables_statusStrip_label_mapCreatorBuildDate.Size = new System.Drawing.Size(117, 19);
            this.colorTables_statusStrip_label_mapCreatorBuildDate.TabIndex = 12;
            this.colorTables_statusStrip_label_mapCreatorBuildDate.Text = "Build: 11262022a";
            // 
            // colorTables_statusStrip_label_mapCreatorVersioning
            // 
            this.colorTables_statusStrip_label_mapCreatorVersioning.AutoSize = true;
            this.colorTables_statusStrip_label_mapCreatorVersioning.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTables_statusStrip_label_mapCreatorVersioning.ForeColor = System.Drawing.Color.SlateGray;
            this.colorTables_statusStrip_label_mapCreatorVersioning.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colorTables_statusStrip_label_mapCreatorVersioning.Location = new System.Drawing.Point(12, 424);
            this.colorTables_statusStrip_label_mapCreatorVersioning.Name = "colorTables_statusStrip_label_mapCreatorVersioning";
            this.colorTables_statusStrip_label_mapCreatorVersioning.Size = new System.Drawing.Size(158, 19);
            this.colorTables_statusStrip_label_mapCreatorVersioning.TabIndex = 11;
            this.colorTables_statusStrip_label_mapCreatorVersioning.Text = "MapCreator: Version 3.0";
            // 
            // colorTables_pictureBox_notificationBox
            // 
            this.colorTables_pictureBox_notificationBox.BackColor = System.Drawing.Color.Transparent;
            this.colorTables_pictureBox_notificationBox.Image = ((System.Drawing.Image)(resources.GetObject("colorTables_pictureBox_notificationBox.Image")));
            this.colorTables_pictureBox_notificationBox.Location = new System.Drawing.Point(12, 326);
            this.colorTables_pictureBox_notificationBox.Name = "colorTables_pictureBox_notificationBox";
            this.colorTables_pictureBox_notificationBox.Size = new System.Drawing.Size(335, 77);
            this.colorTables_pictureBox_notificationBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorTables_pictureBox_notificationBox.TabIndex = 13;
            this.colorTables_pictureBox_notificationBox.TabStop = false;
            // 
            // colorTables_pictureBox_notificationBox_label_fileUsability
            // 
            this.colorTables_pictureBox_notificationBox_label_fileUsability.AutoSize = true;
            this.colorTables_pictureBox_notificationBox_label_fileUsability.BackColor = System.Drawing.Color.Black;
            this.colorTables_pictureBox_notificationBox_label_fileUsability.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTables_pictureBox_notificationBox_label_fileUsability.ForeColor = System.Drawing.Color.Ivory;
            this.colorTables_pictureBox_notificationBox_label_fileUsability.Location = new System.Drawing.Point(31, 341);
            this.colorTables_pictureBox_notificationBox_label_fileUsability.Name = "colorTables_pictureBox_notificationBox_label_fileUsability";
            this.colorTables_pictureBox_notificationBox_label_fileUsability.Size = new System.Drawing.Size(282, 51);
            this.colorTables_pictureBox_notificationBox_label_fileUsability.TabIndex = 14;
            this.colorTables_pictureBox_notificationBox_label_fileUsability.Text = "This Program Exports Adobe Photoshop™\r\n(.act) And (.aco) File Types\r\nThese Files " +
    "May Not Work WIth Other Software";
            this.colorTables_pictureBox_notificationBox_label_fileUsability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorTables_pictureBox_notificationBox_label_altitudeGradient
            // 
            this.colorTables_pictureBox_notificationBox_label_altitudeGradient.AutoSize = true;
            this.colorTables_pictureBox_notificationBox_label_altitudeGradient.BackColor = System.Drawing.Color.Black;
            this.colorTables_pictureBox_notificationBox_label_altitudeGradient.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTables_pictureBox_notificationBox_label_altitudeGradient.ForeColor = System.Drawing.Color.Ivory;
            this.colorTables_pictureBox_notificationBox_label_altitudeGradient.Location = new System.Drawing.Point(44, 341);
            this.colorTables_pictureBox_notificationBox_label_altitudeGradient.Name = "colorTables_pictureBox_notificationBox_label_altitudeGradient";
            this.colorTables_pictureBox_notificationBox_label_altitudeGradient.Size = new System.Drawing.Size(254, 51);
            this.colorTables_pictureBox_notificationBox_label_altitudeGradient.TabIndex = 15;
            this.colorTables_pictureBox_notificationBox_label_altitudeGradient.Text = "Altitude Colors Will Be Used On The \r\n** Altitude Bitmap (.bmp) File **\r\nAltitude" +
    "s Should Gradient By Five (5) Pixels";
            this.colorTables_pictureBox_notificationBox_label_altitudeGradient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorTables_pictureBox_altitudeDisplay
            // 
            this.colorTables_pictureBox_altitudeDisplay.Image = ((System.Drawing.Image)(resources.GetObject("colorTables_pictureBox_altitudeDisplay.Image")));
            this.colorTables_pictureBox_altitudeDisplay.Location = new System.Drawing.Point(400, 326);
            this.colorTables_pictureBox_altitudeDisplay.Name = "colorTables_pictureBox_altitudeDisplay";
            this.colorTables_pictureBox_altitudeDisplay.Size = new System.Drawing.Size(90, 77);
            this.colorTables_pictureBox_altitudeDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorTables_pictureBox_altitudeDisplay.TabIndex = 16;
            this.colorTables_pictureBox_altitudeDisplay.TabStop = false;
            // 
            // colorTables_pictureBox_colorPalette
            // 
            this.colorTables_pictureBox_colorPalette.Image = ((System.Drawing.Image)(resources.GetObject("colorTables_pictureBox_colorPalette.Image")));
            this.colorTables_pictureBox_colorPalette.Location = new System.Drawing.Point(400, 326);
            this.colorTables_pictureBox_colorPalette.Name = "colorTables_pictureBox_colorPalette";
            this.colorTables_pictureBox_colorPalette.Size = new System.Drawing.Size(90, 77);
            this.colorTables_pictureBox_colorPalette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.colorTables_pictureBox_colorPalette.TabIndex = 17;
            this.colorTables_pictureBox_colorPalette.TabStop = false;
            // 
            // colorTables_pictureBox_tileDisplay
            // 
            this.colorTables_pictureBox_tileDisplay.BackColor = System.Drawing.Color.LightGray;
            this.colorTables_pictureBox_tileDisplay.Location = new System.Drawing.Point(400, 326);
            this.colorTables_pictureBox_tileDisplay.Name = "colorTables_pictureBox_tileDisplay";
            this.colorTables_pictureBox_tileDisplay.Size = new System.Drawing.Size(90, 77);
            this.colorTables_pictureBox_tileDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorTables_pictureBox_tileDisplay.TabIndex = 18;
            this.colorTables_pictureBox_tileDisplay.TabStop = false;
            // 
            // colorTables_button_loadTerrainColorTables
            // 
            this.colorTables_button_loadTerrainColorTables.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorTables_button_loadTerrainColorTables.BackgroundImage")));
            this.colorTables_button_loadTerrainColorTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorTables_button_loadTerrainColorTables.Location = new System.Drawing.Point(575, 326);
            this.colorTables_button_loadTerrainColorTables.Name = "colorTables_button_loadTerrainColorTables";
            this.colorTables_button_loadTerrainColorTables.Size = new System.Drawing.Size(35, 35);
            this.colorTables_button_loadTerrainColorTables.TabIndex = 19;
            this.colorTables_button_loadTerrainColorTables.UseVisualStyleBackColor = true;
            this.colorTables_button_loadTerrainColorTables.Click += new System.EventHandler(this.colorTables_button_loadTerrainColorTables_Click);
            // 
            // colorTables_button_loadAltitudeColorTables
            // 
            this.colorTables_button_loadAltitudeColorTables.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorTables_button_loadAltitudeColorTables.BackgroundImage")));
            this.colorTables_button_loadAltitudeColorTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorTables_button_loadAltitudeColorTables.Location = new System.Drawing.Point(575, 369);
            this.colorTables_button_loadAltitudeColorTables.Name = "colorTables_button_loadAltitudeColorTables";
            this.colorTables_button_loadAltitudeColorTables.Size = new System.Drawing.Size(35, 35);
            this.colorTables_button_loadAltitudeColorTables.TabIndex = 20;
            this.colorTables_button_loadAltitudeColorTables.UseVisualStyleBackColor = true;
            this.colorTables_button_loadAltitudeColorTables.Click += new System.EventHandler(this.colorTables_button_loadAltitudeColorTables_Click);
            // 
            // colorTables_button_loadTerrainColorTables_label
            // 
            this.colorTables_button_loadTerrainColorTables_label.AutoSize = true;
            this.colorTables_button_loadTerrainColorTables_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTables_button_loadTerrainColorTables_label.ForeColor = System.Drawing.Color.Ivory;
            this.colorTables_button_loadTerrainColorTables_label.Location = new System.Drawing.Point(617, 335);
            this.colorTables_button_loadTerrainColorTables_label.Name = "colorTables_button_loadTerrainColorTables_label";
            this.colorTables_button_loadTerrainColorTables_label.Size = new System.Drawing.Size(134, 17);
            this.colorTables_button_loadTerrainColorTables_label.TabIndex = 21;
            this.colorTables_button_loadTerrainColorTables_label.Text = "Load Terrain Colors";
            // 
            // colorTables_button_loadAltitudeColorTables_label
            // 
            this.colorTables_button_loadAltitudeColorTables_label.AutoSize = true;
            this.colorTables_button_loadAltitudeColorTables_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTables_button_loadAltitudeColorTables_label.ForeColor = System.Drawing.Color.Ivory;
            this.colorTables_button_loadAltitudeColorTables_label.Location = new System.Drawing.Point(616, 378);
            this.colorTables_button_loadAltitudeColorTables_label.Name = "colorTables_button_loadAltitudeColorTables_label";
            this.colorTables_button_loadAltitudeColorTables_label.Size = new System.Drawing.Size(135, 17);
            this.colorTables_button_loadAltitudeColorTables_label.TabIndex = 22;
            this.colorTables_button_loadAltitudeColorTables_label.Text = "Load Altitude Colors";
            // 
            // colorTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 444);
            this.Controls.Add(this.colorTables_button_loadAltitudeColorTables_label);
            this.Controls.Add(this.colorTables_button_loadTerrainColorTables_label);
            this.Controls.Add(this.colorTables_button_loadAltitudeColorTables);
            this.Controls.Add(this.colorTables_button_loadTerrainColorTables);
            this.Controls.Add(this.colorTables_pictureBox_tileDisplay);
            this.Controls.Add(this.colorTables_pictureBox_colorPalette);
            this.Controls.Add(this.colorTables_pictureBox_altitudeDisplay);
            this.Controls.Add(this.colorTables_pictureBox_notificationBox_label_altitudeGradient);
            this.Controls.Add(this.colorTables_statusStrip_label_mapCreatorBuildDate);
            this.Controls.Add(this.colorTables_statusStrip_label_mapCreatorVersioning);
            this.Controls.Add(this.colorTables_propertyGrid_colorTableProperties);
            this.Controls.Add(this.colorTables_listBox_colorTableList);
            this.Controls.Add(this.colorTables_label_adobePhotoshopColorPalette);
            this.Controls.Add(this.colorTables_pictureBox_bottomDivider);
            this.Controls.Add(this.colorTables_pictureBox_topDivider);
            this.Controls.Add(this.colorTables_menuStrip);
            this.Controls.Add(this.colorTables_statusStrip);
            this.Controls.Add(this.colorTables_pictureBox_notificationBox_label_fileUsability);
            this.Controls.Add(this.colorTables_pictureBox_notificationBox);
            this.Controls.Add(this.colorTables_pictureBox_backDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.colorTables_menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "colorTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapCreator: Create Color Tables";
            this.Load += new System.EventHandler(this.colorTables_Load);
            this.colorTables_menuStrip.ResumeLayout(false);
            this.colorTables_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_topDivider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_bottomDivider)).EndInit();
            this.colorTables_statusStrip.ResumeLayout(false);
            this.colorTables_statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_backDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_notificationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_altitudeDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_colorPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTables_pictureBox_tileDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip colorTables_menuStrip;
        private ToolStripMenuItem colorTables_menuStrip_button_getAdobePhotoshop;
        private ToolStripMenuItem colorTables_menuStrip_button_export;
        private ToolStripMenuItem colorTables_menuStrip_button_openExportLocation;
        private ToolStripMenuItem colorTables_menuStrip_button_facetBuilder;
        private PictureBox colorTables_pictureBox_topDivider;
        private PictureBox colorTables_pictureBox_bottomDivider;
        private StatusStrip colorTables_statusStrip;
        private ToolStripStatusLabel colorTables_statusStrip_sizeElevenSpacer;
        private ToolStripMenuItem colorTables_menuStrip_button_export_terrain;
        private ToolStripMenuItem colorTables_menuStrip_button_export_terrain_adobeColorTableACT;
        private ToolStripMenuItem colorTables_menuStrip_button_export_terrain_adobeSwatchFileACO;
        private ToolStripMenuItem colorTables_menuStrip_button_export_altitude;
        private ToolStripMenuItem colorTables_menuStrip_button_export_altitude_adobeColorTableACT;
        private ToolStripMenuItem colorTables_menuStrip_button_export_altitude_adobeSwatchFileACO;
        private PictureBox colorTables_pictureBox_backDrop;
        private Label colorTables_label_adobePhotoshopColorPalette;
        private ListBox colorTables_listBox_colorTableList;
        private PropertyGrid colorTables_propertyGrid_colorTableProperties;
        private Label colorTables_statusStrip_label_mapCreatorBuildDate;
        private Label colorTables_statusStrip_label_mapCreatorVersioning;
        private ToolStripMenuItem colorTables_menuStrip_button_information;
        private PictureBox colorTables_pictureBox_notificationBox;
        private Label colorTables_pictureBox_notificationBox_label_fileUsability;
        private Label colorTables_pictureBox_notificationBox_label_altitudeGradient;
        private PictureBox colorTables_pictureBox_altitudeDisplay;
        private PictureBox colorTables_pictureBox_colorPalette;
        private PictureBox colorTables_pictureBox_tileDisplay;
        private Button colorTables_button_loadTerrainColorTables;
        private Button colorTables_button_loadAltitudeColorTables;
        private Label colorTables_button_loadTerrainColorTables_label;
        private Label colorTables_button_loadAltitudeColorTables_label;
    }
}