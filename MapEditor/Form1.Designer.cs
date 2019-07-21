namespace MapEditor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_NewNameSave = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.해상도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MapArea = new System.Windows.Forms.GroupBox();
            this.Map_Edit_Area = new System.Windows.Forms.GroupBox();
            this.PathPrint = new System.Windows.Forms.Label();
            this.Map_Edit_Pannel = new System.Windows.Forms.FlowLayoutPanel();
            this.Tile_Select_Area = new System.Windows.Forms.GroupBox();
            this.Selected_Type_Print = new System.Windows.Forms.Label();
            this.Type_Changer = new System.Windows.Forms.ComboBox();
            this.Tile_Select_Pannel = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip.SuspendLayout();
            this.MapArea.SuspendLayout();
            this.Map_Edit_Area.SuspendLayout();
            this.Tile_Select_Area.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.옵션ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(671, 27);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Add,
            this.Menu_Open,
            this.Menu_Save,
            this.Menu_NewNameSave});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(49, 23);
            this.Menu_File.Text = "파일";
            // 
            // Menu_Add
            // 
            this.Menu_Add.Name = "Menu_Add";
            this.Menu_Add.Size = new System.Drawing.Size(195, 24);
            this.Menu_Add.Text = "새로 만들기";
            this.Menu_Add.Click += new System.EventHandler(this.Menu_Add_Click);
            // 
            // Menu_Open
            // 
            this.Menu_Open.Name = "Menu_Open";
            this.Menu_Open.Size = new System.Drawing.Size(195, 24);
            this.Menu_Open.Text = "열기";
            this.Menu_Open.Click += new System.EventHandler(this.Menu_Open_Click);
            // 
            // Menu_Save
            // 
            this.Menu_Save.Name = "Menu_Save";
            this.Menu_Save.Size = new System.Drawing.Size(195, 24);
            this.Menu_Save.Text = "저장";
            this.Menu_Save.Click += new System.EventHandler(this.Menu_Save_Click);
            // 
            // Menu_NewNameSave
            // 
            this.Menu_NewNameSave.Name = "Menu_NewNameSave";
            this.Menu_NewNameSave.Size = new System.Drawing.Size(195, 24);
            this.Menu_NewNameSave.Text = "다른이름으로 저장";
            this.Menu_NewNameSave.Click += new System.EventHandler(this.Menu_NewNameSave_Click);
            // 
            // 옵션ToolStripMenuItem
            // 
            this.옵션ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.해상도ToolStripMenuItem});
            this.옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
            this.옵션ToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.옵션ToolStripMenuItem.Text = "옵션";
            // 
            // 해상도ToolStripMenuItem
            // 
            this.해상도ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem,
            this.dToolStripMenuItem});
            this.해상도ToolStripMenuItem.Name = "해상도ToolStripMenuItem";
            this.해상도ToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.해상도ToolStripMenuItem.Text = "해상도";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.aToolStripMenuItem.Text = "A";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.AToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.bToolStripMenuItem.Text = "B";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.BToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cToolStripMenuItem.Text = "C";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.CToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.dToolStripMenuItem.Text = "D";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.DToolStripMenuItem_Click);
            // 
            // MapArea
            // 
            this.MapArea.AutoSize = true;
            this.MapArea.Controls.Add(this.Map_Edit_Area);
            this.MapArea.Controls.Add(this.Tile_Select_Area);
            this.MapArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.MapArea.Location = new System.Drawing.Point(0, 27);
            this.MapArea.Margin = new System.Windows.Forms.Padding(2);
            this.MapArea.Name = "MapArea";
            this.MapArea.Padding = new System.Windows.Forms.Padding(2);
            this.MapArea.Size = new System.Drawing.Size(667, 574);
            this.MapArea.TabIndex = 2;
            this.MapArea.TabStop = false;
            this.MapArea.Text = "Edit";
            // 
            // Map_Edit_Area
            // 
            this.Map_Edit_Area.AutoSize = true;
            this.Map_Edit_Area.Controls.Add(this.PathPrint);
            this.Map_Edit_Area.Controls.Add(this.Map_Edit_Pannel);
            this.Map_Edit_Area.Dock = System.Windows.Forms.DockStyle.Left;
            this.Map_Edit_Area.Location = new System.Drawing.Point(2, 16);
            this.Map_Edit_Area.Margin = new System.Windows.Forms.Padding(2);
            this.Map_Edit_Area.Name = "Map_Edit_Area";
            this.Map_Edit_Area.Padding = new System.Windows.Forms.Padding(2);
            this.Map_Edit_Area.Size = new System.Drawing.Size(470, 556);
            this.Map_Edit_Area.TabIndex = 3;
            this.Map_Edit_Area.TabStop = false;
            this.Map_Edit_Area.Text = "MAP";
            // 
            // PathPrint
            // 
            this.PathPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.PathPrint.Location = new System.Drawing.Point(2, 16);
            this.PathPrint.Name = "PathPrint";
            this.PathPrint.Size = new System.Drawing.Size(466, 12);
            this.PathPrint.TabIndex = 1;
            this.PathPrint.Text = "Path";
            // 
            // Map_Edit_Pannel
            // 
            this.Map_Edit_Pannel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Map_Edit_Pannel.Location = new System.Drawing.Point(5, 31);
            this.Map_Edit_Pannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Map_Edit_Pannel.Name = "Map_Edit_Pannel";
            this.Map_Edit_Pannel.Size = new System.Drawing.Size(460, 368);
            this.Map_Edit_Pannel.TabIndex = 0;
            this.Map_Edit_Pannel.SizeChanged += new System.EventHandler(this.Map_Edit_Pannel_SizeChanged);
            // 
            // Tile_Select_Area
            // 
            this.Tile_Select_Area.AutoSize = true;
            this.Tile_Select_Area.Controls.Add(this.Selected_Type_Print);
            this.Tile_Select_Area.Controls.Add(this.Type_Changer);
            this.Tile_Select_Area.Controls.Add(this.Tile_Select_Pannel);
            this.Tile_Select_Area.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tile_Select_Area.Location = new System.Drawing.Point(472, 16);
            this.Tile_Select_Area.Name = "Tile_Select_Area";
            this.Tile_Select_Area.Size = new System.Drawing.Size(193, 556);
            this.Tile_Select_Area.TabIndex = 2;
            this.Tile_Select_Area.TabStop = false;
            this.Tile_Select_Area.Text = "Type";
            // 
            // Selected_Type_Print
            // 
            this.Selected_Type_Print.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Selected_Type_Print.Dock = System.Windows.Forms.DockStyle.Top;
            this.Selected_Type_Print.Location = new System.Drawing.Point(3, 37);
            this.Selected_Type_Print.Name = "Selected_Type_Print";
            this.Selected_Type_Print.Size = new System.Drawing.Size(187, 22);
            this.Selected_Type_Print.TabIndex = 2;
            this.Selected_Type_Print.Text = "label1";
            // 
            // Type_Changer
            // 
            this.Type_Changer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Type_Changer.FormattingEnabled = true;
            this.Type_Changer.Items.AddRange(new object[] {
            "Bog",
            "Dirt",
            "Block",
            "Cobble",
            "Crystal",
            "Floor_nerves",
            "Floor_sand_stone",
            "Floor_vines",
            "Grey_dirt",
            "Hive",
            "Ice",
            "Lair",
            "Lava",
            "Marble_floor",
            "Mesh",
            "Pebble_brown",
            "Pedestal",
            "Rect_gray",
            "Rough_red",
            "Sandstone_floor",
            "Snake",
            "Swamp",
            "Tomb",
            "ETC",
            "Volcanic_floor"});
            this.Type_Changer.Location = new System.Drawing.Point(3, 17);
            this.Type_Changer.Margin = new System.Windows.Forms.Padding(2);
            this.Type_Changer.Name = "Type_Changer";
            this.Type_Changer.Size = new System.Drawing.Size(187, 20);
            this.Type_Changer.TabIndex = 1;
            this.Type_Changer.Text = "All";
            this.Type_Changer.SelectedIndexChanged += new System.EventHandler(this.Type_Changer_SelectedIndexChanged);
            // 
            // Tile_Select_Pannel
            // 
            this.Tile_Select_Pannel.AutoScroll = true;
            this.Tile_Select_Pannel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tile_Select_Pannel.Location = new System.Drawing.Point(3, 61);
            this.Tile_Select_Pannel.Margin = new System.Windows.Forms.Padding(2);
            this.Tile_Select_Pannel.Name = "Tile_Select_Pannel";
            this.Tile_Select_Pannel.Padding = new System.Windows.Forms.Padding(2);
            this.Tile_Select_Pannel.Size = new System.Drawing.Size(185, 338);
            this.Tile_Select_Pannel.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "block.png");
            this.imageList1.Images.SetKeyName(1, "bog_green0.png");
            this.imageList1.Images.SetKeyName(2, "bog_green1.png");
            this.imageList1.Images.SetKeyName(3, "bog_green2.png");
            this.imageList1.Images.SetKeyName(4, "bog_green3.png");
            this.imageList1.Images.SetKeyName(5, "cobble_blood1.png");
            this.imageList1.Images.SetKeyName(6, "cobble_blood2.png");
            this.imageList1.Images.SetKeyName(7, "cobble_blood3.png");
            this.imageList1.Images.SetKeyName(8, "cobble_blood4.png");
            this.imageList1.Images.SetKeyName(9, "cobble_blood5.png");
            this.imageList1.Images.SetKeyName(10, "cobble_blood6.png");
            this.imageList1.Images.SetKeyName(11, "cobble_blood7.png");
            this.imageList1.Images.SetKeyName(12, "cobble_blood8.png");
            this.imageList1.Images.SetKeyName(13, "cobble_blood9.png");
            this.imageList1.Images.SetKeyName(14, "cobble_blood10.png");
            this.imageList1.Images.SetKeyName(15, "cobble_blood11.png");
            this.imageList1.Images.SetKeyName(16, "cobble_blood12.png");
            this.imageList1.Images.SetKeyName(17, "crystal_floor0.png");
            this.imageList1.Images.SetKeyName(18, "crystal_floor1.png");
            this.imageList1.Images.SetKeyName(19, "crystal_floor2.png");
            this.imageList1.Images.SetKeyName(20, "crystal_floor3.png");
            this.imageList1.Images.SetKeyName(21, "crystal_floor4.png");
            this.imageList1.Images.SetKeyName(22, "crystal_floor5.png");
            this.imageList1.Images.SetKeyName(23, "dirt_e.png");
            this.imageList1.Images.SetKeyName(24, "dirt_full.png");
            this.imageList1.Images.SetKeyName(25, "dirt_n.png");
            this.imageList1.Images.SetKeyName(26, "dirt_ne.png");
            this.imageList1.Images.SetKeyName(27, "dirt_nw.png");
            this.imageList1.Images.SetKeyName(28, "dirt_s.png");
            this.imageList1.Images.SetKeyName(29, "dirt_se.png");
            this.imageList1.Images.SetKeyName(30, "dirt_sw.png");
            this.imageList1.Images.SetKeyName(31, "dirt_w.png");
            this.imageList1.Images.SetKeyName(32, "dirt0.png");
            this.imageList1.Images.SetKeyName(33, "dirt1.png");
            this.imageList1.Images.SetKeyName(34, "dirt2.png");
            this.imageList1.Images.SetKeyName(35, "floor_nerves0.png");
            this.imageList1.Images.SetKeyName(36, "floor_nerves1.png");
            this.imageList1.Images.SetKeyName(37, "floor_nerves2.png");
            this.imageList1.Images.SetKeyName(38, "floor_nerves3.png");
            this.imageList1.Images.SetKeyName(39, "floor_nerves4.png");
            this.imageList1.Images.SetKeyName(40, "floor_nerves5.png");
            this.imageList1.Images.SetKeyName(41, "floor_nerves6.png");
            this.imageList1.Images.SetKeyName(42, "floor_sand_stone0.png");
            this.imageList1.Images.SetKeyName(43, "floor_sand_stone1.png");
            this.imageList1.Images.SetKeyName(44, "floor_sand_stone2.png");
            this.imageList1.Images.SetKeyName(45, "floor_sand_stone3.png");
            this.imageList1.Images.SetKeyName(46, "floor_sand_stone4.png");
            this.imageList1.Images.SetKeyName(47, "floor_sand_stone5.png");
            this.imageList1.Images.SetKeyName(48, "floor_sand_stone6.png");
            this.imageList1.Images.SetKeyName(49, "floor_sand_stone7.png");
            this.imageList1.Images.SetKeyName(50, "floor_vines0.png");
            this.imageList1.Images.SetKeyName(51, "floor_vines1.png");
            this.imageList1.Images.SetKeyName(52, "floor_vines2.png");
            this.imageList1.Images.SetKeyName(53, "floor_vines3.png");
            this.imageList1.Images.SetKeyName(54, "floor_vines4.png");
            this.imageList1.Images.SetKeyName(55, "floor_vines5.png");
            this.imageList1.Images.SetKeyName(56, "floor_vines6.png");
            this.imageList1.Images.SetKeyName(57, "grey_dirt0.png");
            this.imageList1.Images.SetKeyName(58, "grey_dirt1.png");
            this.imageList1.Images.SetKeyName(59, "grey_dirt2.png");
            this.imageList1.Images.SetKeyName(60, "grey_dirt3.png");
            this.imageList1.Images.SetKeyName(61, "grey_dirt4.png");
            this.imageList1.Images.SetKeyName(62, "grey_dirt5.png");
            this.imageList1.Images.SetKeyName(63, "grey_dirt6.png");
            this.imageList1.Images.SetKeyName(64, "grey_dirt7.png");
            this.imageList1.Images.SetKeyName(65, "hive0.png");
            this.imageList1.Images.SetKeyName(66, "hive1.png");
            this.imageList1.Images.SetKeyName(67, "hive2.png");
            this.imageList1.Images.SetKeyName(68, "hive3.png");
            this.imageList1.Images.SetKeyName(69, "ice0.png");
            this.imageList1.Images.SetKeyName(70, "ice1.png");
            this.imageList1.Images.SetKeyName(71, "ice2.png");
            this.imageList1.Images.SetKeyName(72, "ice3.png");
            this.imageList1.Images.SetKeyName(73, "lair0.png");
            this.imageList1.Images.SetKeyName(74, "lair1.png");
            this.imageList1.Images.SetKeyName(75, "lair2.png");
            this.imageList1.Images.SetKeyName(76, "lair3.png");
            this.imageList1.Images.SetKeyName(77, "lava0.png");
            this.imageList1.Images.SetKeyName(78, "lava1.png");
            this.imageList1.Images.SetKeyName(79, "lava2.png");
            this.imageList1.Images.SetKeyName(80, "lava3.png");
            this.imageList1.Images.SetKeyName(81, "marble_floor1.png");
            this.imageList1.Images.SetKeyName(82, "marble_floor2.png");
            this.imageList1.Images.SetKeyName(83, "marble_floor3.png");
            this.imageList1.Images.SetKeyName(84, "marble_floor4.png");
            this.imageList1.Images.SetKeyName(85, "marble_floor5.png");
            this.imageList1.Images.SetKeyName(86, "marble_floor6.png");
            this.imageList1.Images.SetKeyName(87, "mesh0.png");
            this.imageList1.Images.SetKeyName(88, "mesh1.png");
            this.imageList1.Images.SetKeyName(89, "mesh2.png");
            this.imageList1.Images.SetKeyName(90, "mesh3.png");
            this.imageList1.Images.SetKeyName(91, "pebble_brown0.png");
            this.imageList1.Images.SetKeyName(92, "pebble_brown1.png");
            this.imageList1.Images.SetKeyName(93, "pebble_brown2.png");
            this.imageList1.Images.SetKeyName(94, "pebble_brown3.png");
            this.imageList1.Images.SetKeyName(95, "pebble_brown4.png");
            this.imageList1.Images.SetKeyName(96, "pebble_brown5.png");
            this.imageList1.Images.SetKeyName(97, "pebble_brown6.png");
            this.imageList1.Images.SetKeyName(98, "pebble_brown7.png");
            this.imageList1.Images.SetKeyName(99, "pebble_brown8.png");
            this.imageList1.Images.SetKeyName(100, "pedestal_e.png");
            this.imageList1.Images.SetKeyName(101, "pedestal_full.png");
            this.imageList1.Images.SetKeyName(102, "pedestal_n.png");
            this.imageList1.Images.SetKeyName(103, "pedestal_ne.png");
            this.imageList1.Images.SetKeyName(104, "pedestal_nw.png");
            this.imageList1.Images.SetKeyName(105, "pedestal_s.png");
            this.imageList1.Images.SetKeyName(106, "pedestal_se.png");
            this.imageList1.Images.SetKeyName(107, "pedestal_sw.png");
            this.imageList1.Images.SetKeyName(108, "pedestal_w.png");
            this.imageList1.Images.SetKeyName(109, "rect_gray0.png");
            this.imageList1.Images.SetKeyName(110, "rect_gray1.png");
            this.imageList1.Images.SetKeyName(111, "rect_gray2.png");
            this.imageList1.Images.SetKeyName(112, "rect_gray3.png");
            this.imageList1.Images.SetKeyName(113, "rough_red0.png");
            this.imageList1.Images.SetKeyName(114, "rough_red1.png");
            this.imageList1.Images.SetKeyName(115, "rough_red2.png");
            this.imageList1.Images.SetKeyName(116, "rough_red3.png");
            this.imageList1.Images.SetKeyName(117, "sandstone_floor0.png");
            this.imageList1.Images.SetKeyName(118, "sandstone_floor1.png");
            this.imageList1.Images.SetKeyName(119, "sandstone_floor2.png");
            this.imageList1.Images.SetKeyName(120, "sandstone_floor3.png");
            this.imageList1.Images.SetKeyName(121, "sandstone_floor4.png");
            this.imageList1.Images.SetKeyName(122, "sandstone_floor5.png");
            this.imageList1.Images.SetKeyName(123, "sandstone_floor6.png");
            this.imageList1.Images.SetKeyName(124, "sandstone_floor7.png");
            this.imageList1.Images.SetKeyName(125, "sandstone_floor8.png");
            this.imageList1.Images.SetKeyName(126, "sandstone_floor9.png");
            this.imageList1.Images.SetKeyName(127, "snake0.png");
            this.imageList1.Images.SetKeyName(128, "snake1.png");
            this.imageList1.Images.SetKeyName(129, "snake2.png");
            this.imageList1.Images.SetKeyName(130, "snake3.png");
            this.imageList1.Images.SetKeyName(131, "swamp0.png");
            this.imageList1.Images.SetKeyName(132, "swamp1.png");
            this.imageList1.Images.SetKeyName(133, "swamp2.png");
            this.imageList1.Images.SetKeyName(134, "swamp3.png");
            this.imageList1.Images.SetKeyName(135, "tomb0.png");
            this.imageList1.Images.SetKeyName(136, "tomb1.png");
            this.imageList1.Images.SetKeyName(137, "tomb2.png");
            this.imageList1.Images.SetKeyName(138, "tomb3.png");
            this.imageList1.Images.SetKeyName(139, "tutorial_pad.png");
            this.imageList1.Images.SetKeyName(140, "volcanic_floor0.png");
            this.imageList1.Images.SetKeyName(141, "volcanic_floor1.png");
            this.imageList1.Images.SetKeyName(142, "volcanic_floor2.png");
            this.imageList1.Images.SetKeyName(143, "volcanic_floor3.png");
            this.imageList1.Images.SetKeyName(144, "volcanic_floor4.png");
            this.imageList1.Images.SetKeyName(145, "volcanic_floor5.png");
            this.imageList1.Images.SetKeyName(146, "volcanic_floor6.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(671, 601);
            this.Controls.Add(this.MapArea);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(640, 640);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.MapArea.ResumeLayout(false);
            this.MapArea.PerformLayout();
            this.Map_Edit_Area.ResumeLayout(false);
            this.Tile_Select_Area.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_Add;
        private System.Windows.Forms.ToolStripMenuItem Menu_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_NewNameSave;
        private System.Windows.Forms.ToolStripMenuItem 옵션ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 해상도ToolStripMenuItem;
        private System.Windows.Forms.GroupBox MapArea;
        private System.Windows.Forms.GroupBox Map_Edit_Area;
        private System.Windows.Forms.FlowLayoutPanel Map_Edit_Pannel;
        private System.Windows.Forms.ComboBox Type_Changer;
        private System.Windows.Forms.FlowLayoutPanel Tile_Select_Pannel;
        private System.Windows.Forms.Label PathPrint;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox Tile_Select_Area;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.Label Selected_Type_Print;
    }
}

