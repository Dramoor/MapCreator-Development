namespace MapCreator
{
    partial class userPlugins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userPlugins));
            this.userPlugins_pictureBox_topDivider = new System.Windows.Forms.PictureBox();
            this.userPlugins_statusStrip = new System.Windows.Forms.StatusStrip();
            this.userPlugins_statusStrip_sizeElevenSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.userPlugins_pictureBox_bottomDivider = new System.Windows.Forms.PictureBox();
            this.userPlugins_statusStrip_label_mapCreatorVersioning = new System.Windows.Forms.Label();
            this.userPlugins_statusStrip_label_mapCreatorBuildDate = new System.Windows.Forms.Label();
            this.userPlugins_pictureBox_backDrop = new System.Windows.Forms.PictureBox();
            this.userPlugins_panel_formLauncher_button_createTileTransitions = new System.Windows.Forms.Button();
            this.userPlugins_panel_formLauncher_button_createTerrainTypes = new System.Windows.Forms.Button();
            this.userPlugins_panel_formLauncher = new System.Windows.Forms.Panel();
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet = new System.Windows.Forms.Button();
            this.userPlugins_panel_formLauncher_button_fileTypeConverters = new System.Windows.Forms.Button();
            this.userPlugins_pictureBox_vDivider = new System.Windows.Forms.PictureBox();
            this.userPlugins_menuStrip_button_facetBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.userPlugins_menuStrip_button_information = new System.Windows.Forms.ToolStripMenuItem();
            this.userPlugins_menuStrip = new System.Windows.Forms.MenuStrip();
            this.userPlugins_pictureBox_pluginDescriptionDisplay = new System.Windows.Forms.PictureBox();
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions = new System.Windows.Forms.PictureBox();
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes = new System.Windows.Forms.PictureBox();
            this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet = new System.Windows.Forms.PictureBox();
            this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_topDivider)).BeginInit();
            this.userPlugins_statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_bottomDivider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_backDrop)).BeginInit();
            this.userPlugins_panel_formLauncher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_vDivider)).BeginInit();
            this.userPlugins_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_pluginDescriptionDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters)).BeginInit();
            this.SuspendLayout();
            // 
            // userPlugins_pictureBox_topDivider
            // 
            this.userPlugins_pictureBox_topDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userPlugins_pictureBox_topDivider.Image = ((System.Drawing.Image)(resources.GetObject("userPlugins_pictureBox_topDivider.Image")));
            this.userPlugins_pictureBox_topDivider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userPlugins_pictureBox_topDivider.Location = new System.Drawing.Point(0, 28);
            this.userPlugins_pictureBox_topDivider.Name = "userPlugins_pictureBox_topDivider";
            this.userPlugins_pictureBox_topDivider.Size = new System.Drawing.Size(773, 12);
            this.userPlugins_pictureBox_topDivider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPlugins_pictureBox_topDivider.TabIndex = 5;
            this.userPlugins_pictureBox_topDivider.TabStop = false;
            // 
            // userPlugins_statusStrip
            // 
            this.userPlugins_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userPlugins_statusStrip_sizeElevenSpacer});
            this.userPlugins_statusStrip.Location = new System.Drawing.Point(0, 419);
            this.userPlugins_statusStrip.Name = "userPlugins_statusStrip";
            this.userPlugins_statusStrip.Size = new System.Drawing.Size(773, 25);
            this.userPlugins_statusStrip.TabIndex = 6;
            this.userPlugins_statusStrip.Text = "statusStrip1";
            // 
            // userPlugins_statusStrip_sizeElevenSpacer
            // 
            this.userPlugins_statusStrip_sizeElevenSpacer.BackColor = System.Drawing.SystemColors.Control;
            this.userPlugins_statusStrip_sizeElevenSpacer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPlugins_statusStrip_sizeElevenSpacer.Name = "userPlugins_statusStrip_sizeElevenSpacer";
            this.userPlugins_statusStrip_sizeElevenSpacer.Size = new System.Drawing.Size(13, 20);
            this.userPlugins_statusStrip_sizeElevenSpacer.Text = " ";
            // 
            // userPlugins_pictureBox_bottomDivider
            // 
            this.userPlugins_pictureBox_bottomDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userPlugins_pictureBox_bottomDivider.Image = ((System.Drawing.Image)(resources.GetObject("userPlugins_pictureBox_bottomDivider.Image")));
            this.userPlugins_pictureBox_bottomDivider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userPlugins_pictureBox_bottomDivider.Location = new System.Drawing.Point(0, 410);
            this.userPlugins_pictureBox_bottomDivider.Name = "userPlugins_pictureBox_bottomDivider";
            this.userPlugins_pictureBox_bottomDivider.Size = new System.Drawing.Size(773, 12);
            this.userPlugins_pictureBox_bottomDivider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPlugins_pictureBox_bottomDivider.TabIndex = 7;
            this.userPlugins_pictureBox_bottomDivider.TabStop = false;
            // 
            // userPlugins_statusStrip_label_mapCreatorVersioning
            // 
            this.userPlugins_statusStrip_label_mapCreatorVersioning.AutoSize = true;
            this.userPlugins_statusStrip_label_mapCreatorVersioning.BackColor = System.Drawing.SystemColors.Control;
            this.userPlugins_statusStrip_label_mapCreatorVersioning.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPlugins_statusStrip_label_mapCreatorVersioning.ForeColor = System.Drawing.Color.SlateGray;
            this.userPlugins_statusStrip_label_mapCreatorVersioning.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userPlugins_statusStrip_label_mapCreatorVersioning.Location = new System.Drawing.Point(12, 424);
            this.userPlugins_statusStrip_label_mapCreatorVersioning.Name = "userPlugins_statusStrip_label_mapCreatorVersioning";
            this.userPlugins_statusStrip_label_mapCreatorVersioning.Size = new System.Drawing.Size(158, 19);
            this.userPlugins_statusStrip_label_mapCreatorVersioning.TabIndex = 12;
            this.userPlugins_statusStrip_label_mapCreatorVersioning.Text = "MapCreator: Version 3.0";
            // 
            // userPlugins_statusStrip_label_mapCreatorBuildDate
            // 
            this.userPlugins_statusStrip_label_mapCreatorBuildDate.AutoSize = true;
            this.userPlugins_statusStrip_label_mapCreatorBuildDate.BackColor = System.Drawing.SystemColors.Control;
            this.userPlugins_statusStrip_label_mapCreatorBuildDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPlugins_statusStrip_label_mapCreatorBuildDate.ForeColor = System.Drawing.Color.SlateGray;
            this.userPlugins_statusStrip_label_mapCreatorBuildDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userPlugins_statusStrip_label_mapCreatorBuildDate.Location = new System.Drawing.Point(640, 424);
            this.userPlugins_statusStrip_label_mapCreatorBuildDate.Name = "userPlugins_statusStrip_label_mapCreatorBuildDate";
            this.userPlugins_statusStrip_label_mapCreatorBuildDate.Size = new System.Drawing.Size(117, 19);
            this.userPlugins_statusStrip_label_mapCreatorBuildDate.TabIndex = 13;
            this.userPlugins_statusStrip_label_mapCreatorBuildDate.Text = "Build: 11262022a";
            // 
            // userPlugins_pictureBox_backDrop
            // 
            this.userPlugins_pictureBox_backDrop.BackColor = System.Drawing.Color.Black;
            this.userPlugins_pictureBox_backDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPlugins_pictureBox_backDrop.Image = ((System.Drawing.Image)(resources.GetObject("userPlugins_pictureBox_backDrop.Image")));
            this.userPlugins_pictureBox_backDrop.Location = new System.Drawing.Point(0, 0);
            this.userPlugins_pictureBox_backDrop.Name = "userPlugins_pictureBox_backDrop";
            this.userPlugins_pictureBox_backDrop.Size = new System.Drawing.Size(773, 444);
            this.userPlugins_pictureBox_backDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPlugins_pictureBox_backDrop.TabIndex = 14;
            this.userPlugins_pictureBox_backDrop.TabStop = false;
            // 
            // userPlugins_panel_formLauncher_button_createTileTransitions
            // 
            this.userPlugins_panel_formLauncher_button_createTileTransitions.BackColor = System.Drawing.Color.Transparent;
            this.userPlugins_panel_formLauncher_button_createTileTransitions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPlugins_panel_formLauncher_button_createTileTransitions.BackgroundImage")));
            this.userPlugins_panel_formLauncher_button_createTileTransitions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPlugins_panel_formLauncher_button_createTileTransitions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPlugins_panel_formLauncher_button_createTileTransitions.ForeColor = System.Drawing.Color.SlateGray;
            this.userPlugins_panel_formLauncher_button_createTileTransitions.Location = new System.Drawing.Point(16, 22);
            this.userPlugins_panel_formLauncher_button_createTileTransitions.Name = "userPlugins_panel_formLauncher_button_createTileTransitions";
            this.userPlugins_panel_formLauncher_button_createTileTransitions.Size = new System.Drawing.Size(186, 43);
            this.userPlugins_panel_formLauncher_button_createTileTransitions.TabIndex = 1;
            this.userPlugins_panel_formLauncher_button_createTileTransitions.Text = "Create Tile Transitions";
            this.userPlugins_panel_formLauncher_button_createTileTransitions.UseVisualStyleBackColor = false;
            this.userPlugins_panel_formLauncher_button_createTileTransitions.Click += new System.EventHandler(this.userPlugins_panel_formLauncher_button_createTileTransitions_Click);
            this.userPlugins_panel_formLauncher_button_createTileTransitions.MouseEnter += new System.EventHandler(this.userPlugins_panel_formLauncher_button_createTileTransitions_MouseEnter);
            this.userPlugins_panel_formLauncher_button_createTileTransitions.MouseLeave += new System.EventHandler(this.userPlugins_panel_formLauncher_button_createTileTransitions_MouseLeave);
            // 
            // userPlugins_panel_formLauncher_button_createTerrainTypes
            // 
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.BackColor = System.Drawing.Color.Transparent;
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPlugins_panel_formLauncher_button_createTerrainTypes.BackgroundImage")));
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.ForeColor = System.Drawing.Color.SlateGray;
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.Location = new System.Drawing.Point(16, 79);
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.Name = "userPlugins_panel_formLauncher_button_createTerrainTypes";
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.Size = new System.Drawing.Size(186, 43);
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.TabIndex = 0;
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.Text = "Create Terrain Types";
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.UseVisualStyleBackColor = false;
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.Click += new System.EventHandler(this.userPlugins_panel_formLauncher_button_createTerrainTypes_Click);
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.MouseEnter += new System.EventHandler(this.userPlugins_panel_formLauncher_button_createTerrainTypes_MouseEnter);
            this.userPlugins_panel_formLauncher_button_createTerrainTypes.MouseLeave += new System.EventHandler(this.userPlugins_panel_formLauncher_button_createTerrainTypes_MouseLeave);
            // 
            // userPlugins_panel_formLauncher
            // 
            this.userPlugins_panel_formLauncher.AutoScroll = true;
            this.userPlugins_panel_formLauncher.BackColor = System.Drawing.Color.Black;
            this.userPlugins_panel_formLauncher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPlugins_panel_formLauncher.BackgroundImage")));
            this.userPlugins_panel_formLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPlugins_panel_formLauncher.Controls.Add(this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet);
            this.userPlugins_panel_formLauncher.Controls.Add(this.userPlugins_panel_formLauncher_button_fileTypeConverters);
            this.userPlugins_panel_formLauncher.Controls.Add(this.userPlugins_panel_formLauncher_button_createTileTransitions);
            this.userPlugins_panel_formLauncher.Controls.Add(this.userPlugins_panel_formLauncher_button_createTerrainTypes);
            this.userPlugins_panel_formLauncher.Location = new System.Drawing.Point(0, 35);
            this.userPlugins_panel_formLauncher.Name = "userPlugins_panel_formLauncher";
            this.userPlugins_panel_formLauncher.Size = new System.Drawing.Size(236, 374);
            this.userPlugins_panel_formLauncher.TabIndex = 16;
            // 
            // userPlugins_panel_formLauncher_button_viewFacetAsPlanet
            // 
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.BackColor = System.Drawing.Color.Transparent;
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPlugins_panel_formLauncher_button_viewFacetAsPlanet.BackgroundImage")));
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.ForeColor = System.Drawing.Color.SlateGray;
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.Location = new System.Drawing.Point(16, 137);
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.Name = "userPlugins_panel_formLauncher_button_viewFacetAsPlanet";
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.Size = new System.Drawing.Size(186, 43);
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.TabIndex = 4;
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.Text = "View Facet As Planet";
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.UseVisualStyleBackColor = false;
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.Click += new System.EventHandler(this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet_Click);
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.MouseEnter += new System.EventHandler(this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet_MouseEnter);
            this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet.MouseLeave += new System.EventHandler(this.userPlugins_panel_formLauncher_button_viewFacetAsPlanet_MouseLeave);
            // 
            // userPlugins_panel_formLauncher_button_fileTypeConverters
            // 
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.BackColor = System.Drawing.Color.Transparent;
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPlugins_panel_formLauncher_button_fileTypeConverters.BackgroundImage")));
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.ForeColor = System.Drawing.Color.SlateGray;
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.Location = new System.Drawing.Point(16, 194);
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.Name = "userPlugins_panel_formLauncher_button_fileTypeConverters";
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.Size = new System.Drawing.Size(186, 43);
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.TabIndex = 2;
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.Text = "File Type Converters";
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.UseVisualStyleBackColor = false;
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.Click += new System.EventHandler(this.userPlugins_panel_formLauncher_button_fileTypeConverters_Click);
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.MouseEnter += new System.EventHandler(this.userPlugins_panel_formLauncher_button_fileTypeConverters_MouseEnter);
            this.userPlugins_panel_formLauncher_button_fileTypeConverters.MouseLeave += new System.EventHandler(this.userPlugins_panel_formLauncher_button_fileTypeConverters_MouseLeave);
            // 
            // userPlugins_pictureBox_vDivider
            // 
            this.userPlugins_pictureBox_vDivider.Image = ((System.Drawing.Image)(resources.GetObject("userPlugins_pictureBox_vDivider.Image")));
            this.userPlugins_pictureBox_vDivider.Location = new System.Drawing.Point(764, 0);
            this.userPlugins_pictureBox_vDivider.Name = "userPlugins_pictureBox_vDivider";
            this.userPlugins_pictureBox_vDivider.Size = new System.Drawing.Size(10, 444);
            this.userPlugins_pictureBox_vDivider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPlugins_pictureBox_vDivider.TabIndex = 19;
            this.userPlugins_pictureBox_vDivider.TabStop = false;
            // 
            // userPlugins_menuStrip_button_facetBuilder
            // 
            this.userPlugins_menuStrip_button_facetBuilder.Image = ((System.Drawing.Image)(resources.GetObject("userPlugins_menuStrip_button_facetBuilder.Image")));
            this.userPlugins_menuStrip_button_facetBuilder.Margin = new System.Windows.Forms.Padding(679, 0, 0, 0);
            this.userPlugins_menuStrip_button_facetBuilder.Name = "userPlugins_menuStrip_button_facetBuilder";
            this.userPlugins_menuStrip_button_facetBuilder.Size = new System.Drawing.Size(32, 24);
            this.userPlugins_menuStrip_button_facetBuilder.Click += new System.EventHandler(this.userPlugins_menuStrip_button_facetBuilder_Click);
            // 
            // userPlugins_menuStrip_button_information
            // 
            this.userPlugins_menuStrip_button_information.Image = ((System.Drawing.Image)(resources.GetObject("userPlugins_menuStrip_button_information.Image")));
            this.userPlugins_menuStrip_button_information.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.userPlugins_menuStrip_button_information.Name = "userPlugins_menuStrip_button_information";
            this.userPlugins_menuStrip_button_information.Size = new System.Drawing.Size(32, 24);
            this.userPlugins_menuStrip_button_information.Click += new System.EventHandler(this.userPlugins_menuStrip_button_information_Click);
            // 
            // userPlugins_menuStrip
            // 
            this.userPlugins_menuStrip.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPlugins_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userPlugins_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userPlugins_menuStrip_button_facetBuilder,
            this.userPlugins_menuStrip_button_information});
            this.userPlugins_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.userPlugins_menuStrip.Name = "userPlugins_menuStrip";
            this.userPlugins_menuStrip.Size = new System.Drawing.Size(773, 28);
            this.userPlugins_menuStrip.TabIndex = 0;
            this.userPlugins_menuStrip.Text = "menuStrip1";
            // 
            // userPlugins_pictureBox_pluginDescriptionDisplay
            // 
            this.userPlugins_pictureBox_pluginDescriptionDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPlugins_pictureBox_pluginDescriptionDisplay.Image = ((System.Drawing.Image)(resources.GetObject("userPlugins_pictureBox_pluginDescriptionDisplay.Image")));
            this.userPlugins_pictureBox_pluginDescriptionDisplay.Location = new System.Drawing.Point(253, 54);
            this.userPlugins_pictureBox_pluginDescriptionDisplay.Name = "userPlugins_pictureBox_pluginDescriptionDisplay";
            this.userPlugins_pictureBox_pluginDescriptionDisplay.Size = new System.Drawing.Size(493, 338);
            this.userPlugins_pictureBox_pluginDescriptionDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPlugins_pictureBox_pluginDescriptionDisplay.TabIndex = 20;
            this.userPlugins_pictureBox_pluginDescriptionDisplay.TabStop = false;
            // 
            // userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions
            // 
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions.Image = ((System.Drawing.Image)(resources.GetObject("userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions.Image")));
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions.Location = new System.Drawing.Point(253, 54);
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions.Name = "userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions";
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions.Size = new System.Drawing.Size(493, 338);
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions.TabIndex = 21;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions.TabStop = false;
            // 
            // userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes
            // 
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes.Image = ((System.Drawing.Image)(resources.GetObject("userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes.Image")));
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes.Location = new System.Drawing.Point(253, 54);
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes.Name = "userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes";
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes.Size = new System.Drawing.Size(493, 338);
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes.TabIndex = 22;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes.TabStop = false;
            // 
            // userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet
            // 
            this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet.Image = ((System.Drawing.Image)(resources.GetObject("userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet.Image")));
            this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet.Location = new System.Drawing.Point(253, 54);
            this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet.Name = "userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet";
            this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet.Size = new System.Drawing.Size(493, 338);
            this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet.TabIndex = 23;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet.TabStop = false;
            // 
            // userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters
            // 
            this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters.Image = ((System.Drawing.Image)(resources.GetObject("userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters.Image")));
            this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters.Location = new System.Drawing.Point(253, 54);
            this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters.Name = "userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters";
            this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters.Size = new System.Drawing.Size(493, 338);
            this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters.TabIndex = 24;
            this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters.TabStop = false;
            // 
            // userPlugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(773, 444);
            this.Controls.Add(this.userPlugins_pictureBox_bottomDivider);
            this.Controls.Add(this.userPlugins_pictureBox_topDivider);
            this.Controls.Add(this.userPlugins_panel_formLauncher);
            this.Controls.Add(this.userPlugins_statusStrip_label_mapCreatorBuildDate);
            this.Controls.Add(this.userPlugins_statusStrip_label_mapCreatorVersioning);
            this.Controls.Add(this.userPlugins_statusStrip);
            this.Controls.Add(this.userPlugins_menuStrip);
            this.Controls.Add(this.userPlugins_pictureBox_vDivider);
            this.Controls.Add(this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters);
            this.Controls.Add(this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet);
            this.Controls.Add(this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes);
            this.Controls.Add(this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions);
            this.Controls.Add(this.userPlugins_pictureBox_pluginDescriptionDisplay);
            this.Controls.Add(this.userPlugins_pictureBox_backDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.userPlugins_menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userPlugins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapCreator: User Plugins";
            this.Load += new System.EventHandler(this.userPlugins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_topDivider)).EndInit();
            this.userPlugins_statusStrip.ResumeLayout(false);
            this.userPlugins_statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_bottomDivider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_backDrop)).EndInit();
            this.userPlugins_panel_formLauncher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_vDivider)).EndInit();
            this.userPlugins_menuStrip.ResumeLayout(false);
            this.userPlugins_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_pluginDescriptionDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox userPlugins_pictureBox_topDivider;
        private StatusStrip userPlugins_statusStrip;
        private PictureBox userPlugins_pictureBox_bottomDivider;
        private ToolStripStatusLabel userPlugins_statusStrip_sizeElevenSpacer;
        private Label userPlugins_statusStrip_label_mapCreatorVersioning;
        private Label userPlugins_statusStrip_label_mapCreatorBuildDate;
        private PictureBox userPlugins_pictureBox_backDrop;
        private Button userPlugins_panel_formLauncher_button_createTerrainTypes;
        private Button userPlugins_panel_formLauncher_button_createTileTransitions;
        private Panel userPlugins_panel_formLauncher;
        private Button userPlugins_panel_formLauncher_button_fileTypeConverters;
        private PictureBox userPlugins_pictureBox_vDivider;
        private Button userPlugins_panel_formLauncher_button_viewFacetAsPlanet;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private ToolStripMenuItem userPlugins_menuStrip_button_facetBuilder;
        private ToolStripMenuItem userPlugins_menuStrip_button_information;
        private MenuStrip userPlugins_menuStrip;
        private PictureBox userPlugins_pictureBox_pluginDescriptionDisplay;
        private PictureBox userPlugins_pictureBox_pluginDescriptionDisplay_createTileTransitions;
        private PictureBox userPlugins_pictureBox_pluginDescriptionDisplay_createTerrainTypes;
        private PictureBox userPlugins_pictureBox_pluginDescriptionDisplay_viewFacetAsPlanet;
        private PictureBox userPlugins_pictureBox_pluginDescriptionDisplay_fileTypeConverters;
    }
}