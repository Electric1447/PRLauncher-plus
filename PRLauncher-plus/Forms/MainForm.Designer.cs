using System.Windows.Forms;

namespace PRLauncher_plus.Forms {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTLP = new System.Windows.Forms.TableLayoutPanel();
            this.runButton = new System.Windows.Forms.Button();
            this.banner = new System.Windows.Forms.PictureBox();
            this.innerTLP = new System.Windows.Forms.TableLayoutPanel();
            this.dirGroup = new System.Windows.Forms.GroupBox();
            this.pathTLP = new System.Windows.Forms.TableLayoutPanel();
            this.dirButton = new System.Windows.Forms.Button();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.execCheckBox = new System.Windows.Forms.CheckBox();
            this.launchGroup = new System.Windows.Forms.GroupBox();
            this.launchTPL = new System.Windows.Forms.TableLayoutPanel();
            this.launchTLP2 = new System.Windows.Forms.TableLayoutPanel();
            this.argTextBox = new System.Windows.Forms.TextBox();
            this.diffComboBox = new System.Windows.Forms.ComboBox();
            this.argLabel = new System.Windows.Forms.Label();
            this.compComboBox = new System.Windows.Forms.ComboBox();
            this.iwadComboBox = new System.Windows.Forms.ComboBox();
            this.compLabel = new System.Windows.Forms.Label();
            this.diffLabel = new System.Windows.Forms.Label();
            this.iwadLabel = new System.Windows.Forms.Label();
            this.launchTPL3 = new System.Windows.Forms.TableLayoutPanel();
            this.warpLabel = new System.Windows.Forms.Label();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveConfigToINIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigFromINIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordingOptionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.demosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playDemoFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recordingOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compatibilityHintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.innerTLP.SuspendLayout();
            this.dirGroup.SuspendLayout();
            this.pathTLP.SuspendLayout();
            this.launchGroup.SuspendLayout();
            this.launchTPL.SuspendLayout();
            this.launchTLP2.SuspendLayout();
            this.launchTPL3.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTLP
            // 
            this.mainTLP.BackColor = System.Drawing.SystemColors.Control;
            this.mainTLP.ColumnCount = 1;
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.Controls.Add(this.runButton, 0, 3);
            this.mainTLP.Controls.Add(this.banner, 0, 1);
            this.mainTLP.Controls.Add(this.innerTLP, 0, 2);
            this.mainTLP.Controls.Add(this.mainMenuStrip, 0, 0);
            this.mainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTLP.Location = new System.Drawing.Point(0, 0);
            this.mainTLP.Margin = new System.Windows.Forms.Padding(0);
            this.mainTLP.Name = "mainTLP";
            this.mainTLP.RowCount = 4;
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.mainTLP.Size = new System.Drawing.Size(464, 601);
            this.mainTLP.TabIndex = 0;
            // 
            // runButton
            // 
            this.runButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Row;
            this.runButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.runButton.Font = new System.Drawing.Font("Verdana", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(112, 533);
            this.runButton.Margin = new System.Windows.Forms.Padding(96, 0, 96, 0);
            this.runButton.MaximumSize = new System.Drawing.Size(240, 48);
            this.runButton.MinimumSize = new System.Drawing.Size(240, 48);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(240, 48);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "Launch";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButton);
            // 
            // banner
            // 
            this.banner.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.banner.Image = global::PRLauncher_plus.Properties.Resources.banner;
            this.banner.Location = new System.Drawing.Point(57, 34);
            this.banner.Margin = new System.Windows.Forms.Padding(0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(350, 63);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banner.TabIndex = 2;
            this.banner.TabStop = false;
            // 
            // innerTLP
            // 
            this.innerTLP.ColumnCount = 1;
            this.innerTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.innerTLP.Controls.Add(this.dirGroup, 0, 0);
            this.innerTLP.Controls.Add(this.launchGroup, 0, 1);
            this.innerTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerTLP.Location = new System.Drawing.Point(0, 97);
            this.innerTLP.Margin = new System.Windows.Forms.Padding(0);
            this.innerTLP.Name = "innerTLP";
            this.innerTLP.Padding = new System.Windows.Forms.Padding(16, 16, 16, 0);
            this.innerTLP.RowCount = 2;
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.innerTLP.Size = new System.Drawing.Size(464, 436);
            this.innerTLP.TabIndex = 5;
            // 
            // dirGroup
            // 
            this.dirGroup.Controls.Add(this.pathTLP);
            this.dirGroup.Controls.Add(this.execCheckBox);
            this.dirGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.dirGroup.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dirGroup.Location = new System.Drawing.Point(16, 16);
            this.dirGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.dirGroup.Name = "dirGroup";
            this.dirGroup.Padding = new System.Windows.Forms.Padding(8);
            this.dirGroup.Size = new System.Drawing.Size(432, 92);
            this.dirGroup.TabIndex = 13;
            this.dirGroup.TabStop = false;
            this.dirGroup.Text = "PRBoom+ Directory Settings:";
            // 
            // pathTLP
            // 
            this.pathTLP.ColumnCount = 2;
            this.pathTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pathTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.pathTLP.Controls.Add(this.dirButton, 1, 0);
            this.pathTLP.Controls.Add(this.dirTextBox, 0, 0);
            this.pathTLP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pathTLP.Location = new System.Drawing.Point(8, 28);
            this.pathTLP.Margin = new System.Windows.Forms.Padding(0);
            this.pathTLP.Name = "pathTLP";
            this.pathTLP.RowCount = 1;
            this.pathTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.pathTLP.Size = new System.Drawing.Size(416, 36);
            this.pathTLP.TabIndex = 14;
            // 
            // dirButton
            // 
            this.dirButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dirButton.BackgroundImage = global::PRLauncher_plus.Properties.Resources.folder_icon;
            this.dirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dirButton.Location = new System.Drawing.Point(380, 0);
            this.dirButton.Margin = new System.Windows.Forms.Padding(0);
            this.dirButton.Name = "dirButton";
            this.dirButton.Size = new System.Drawing.Size(28, 28);
            this.dirButton.TabIndex = 13;
            this.dirButton.UseVisualStyleBackColor = true;
            this.dirButton.Click += new System.EventHandler(this.ChooseDirectoryButton);
            // 
            // dirTextBox
            // 
            this.dirTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dirTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dirTextBox.Location = new System.Drawing.Point(0, 3);
            this.dirTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.Size = new System.Drawing.Size(372, 22);
            this.dirTextBox.TabIndex = 0;
            this.dirTextBox.TextChanged += new System.EventHandler(this.RefreshDirectory);
            // 
            // execCheckBox
            // 
            this.execCheckBox.AutoSize = true;
            this.execCheckBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.execCheckBox.Location = new System.Drawing.Point(16, 64);
            this.execCheckBox.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.execCheckBox.Name = "execCheckBox";
            this.execCheckBox.Size = new System.Drawing.Size(295, 18);
            this.execCheckBox.TabIndex = 13;
            this.execCheckBox.Text = "Use OpenGL executable (glboom-plus.exe)";
            this.execCheckBox.UseVisualStyleBackColor = true;
            this.execCheckBox.CheckedChanged += new System.EventHandler(this.ExecutableChanged);
            // 
            // launchGroup
            // 
            this.launchGroup.AutoSize = true;
            this.launchGroup.Controls.Add(this.launchTPL);
            this.launchGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.launchGroup.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.launchGroup.Location = new System.Drawing.Point(16, 124);
            this.launchGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.launchGroup.Name = "launchGroup";
            this.launchGroup.Padding = new System.Windows.Forms.Padding(8);
            this.launchGroup.Size = new System.Drawing.Size(432, 246);
            this.launchGroup.TabIndex = 14;
            this.launchGroup.TabStop = false;
            this.launchGroup.Text = "Launch Arguments:";
            // 
            // launchTPL
            // 
            this.launchTPL.AutoSize = true;
            this.launchTPL.ColumnCount = 1;
            this.launchTPL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.launchTPL.Controls.Add(this.launchTLP2, 0, 0);
            this.launchTPL.Controls.Add(this.launchTPL3, 0, 1);
            this.launchTPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launchTPL.Location = new System.Drawing.Point(8, 28);
            this.launchTPL.Margin = new System.Windows.Forms.Padding(0);
            this.launchTPL.Name = "launchTPL";
            this.launchTPL.RowCount = 2;
            this.launchTPL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.launchTPL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.launchTPL.Size = new System.Drawing.Size(416, 210);
            this.launchTPL.TabIndex = 3;
            // 
            // launchTLP2
            // 
            this.launchTLP2.AutoSize = true;
            this.launchTLP2.ColumnCount = 2;
            this.launchTLP2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.launchTLP2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.launchTLP2.Controls.Add(this.argTextBox, 1, 3);
            this.launchTLP2.Controls.Add(this.diffComboBox, 1, 2);
            this.launchTLP2.Controls.Add(this.argLabel, 0, 3);
            this.launchTLP2.Controls.Add(this.compComboBox, 1, 1);
            this.launchTLP2.Controls.Add(this.iwadComboBox, 1, 0);
            this.launchTLP2.Controls.Add(this.compLabel, 0, 1);
            this.launchTLP2.Controls.Add(this.diffLabel, 0, 2);
            this.launchTLP2.Controls.Add(this.iwadLabel, 0, 0);
            this.launchTLP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launchTLP2.Location = new System.Drawing.Point(0, 0);
            this.launchTLP2.Margin = new System.Windows.Forms.Padding(0);
            this.launchTLP2.Name = "launchTLP2";
            this.launchTLP2.RowCount = 4;
            this.launchTLP2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.launchTLP2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.launchTLP2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.launchTLP2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.launchTLP2.Size = new System.Drawing.Size(416, 168);
            this.launchTLP2.TabIndex = 8;
            // 
            // argTextBox
            // 
            this.argTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.argTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.argTextBox.Location = new System.Drawing.Point(200, 126);
            this.argTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.argTextBox.Name = "argTextBox";
            this.argTextBox.Size = new System.Drawing.Size(216, 22);
            this.argTextBox.TabIndex = 0;
            // 
            // diffComboBox
            // 
            this.diffComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.diffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diffComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.diffComboBox.FormattingEnabled = true;
            this.diffComboBox.Location = new System.Drawing.Point(200, 84);
            this.diffComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.diffComboBox.Name = "diffComboBox";
            this.diffComboBox.Size = new System.Drawing.Size(216, 22);
            this.diffComboBox.TabIndex = 2;
            this.diffComboBox.SelectedIndexChanged += new System.EventHandler(this.diffCB_IndexChanged);
            // 
            // argLabel
            // 
            this.argLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.argLabel.AutoSize = true;
            this.argLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.argLabel.Location = new System.Drawing.Point(0, 128);
            this.argLabel.Margin = new System.Windows.Forms.Padding(0, 2, 16, 23);
            this.argLabel.Name = "argLabel";
            this.argLabel.Size = new System.Drawing.Size(166, 17);
            this.argLabel.TabIndex = 5;
            this.argLabel.Text = "Additional Arguments:";
            // 
            // compComboBox
            // 
            this.compComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.compComboBox.FormattingEnabled = true;
            this.compComboBox.Location = new System.Drawing.Point(200, 42);
            this.compComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.compComboBox.Name = "compComboBox";
            this.compComboBox.Size = new System.Drawing.Size(216, 22);
            this.compComboBox.TabIndex = 2;
            this.compComboBox.SelectedIndexChanged += new System.EventHandler(this.compCB_IndexChanged);
            // 
            // iwadComboBox
            // 
            this.iwadComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.iwadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iwadComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.iwadComboBox.FormattingEnabled = true;
            this.iwadComboBox.Location = new System.Drawing.Point(200, 0);
            this.iwadComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.iwadComboBox.Name = "iwadComboBox";
            this.iwadComboBox.Size = new System.Drawing.Size(216, 22);
            this.iwadComboBox.TabIndex = 2;
            this.iwadComboBox.SelectedIndexChanged += new System.EventHandler(this.iwadCB_IndexChanged);
            // 
            // compLabel
            // 
            this.compLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.compLabel.AutoSize = true;
            this.compLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.compLabel.Location = new System.Drawing.Point(0, 44);
            this.compLabel.Margin = new System.Windows.Forms.Padding(0, 2, 16, 23);
            this.compLabel.Name = "compLabel";
            this.compLabel.Size = new System.Drawing.Size(144, 17);
            this.compLabel.TabIndex = 1;
            this.compLabel.Text = "Compatibility Level:";
            // 
            // diffLabel
            // 
            this.diffLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.diffLabel.AutoSize = true;
            this.diffLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.diffLabel.Location = new System.Drawing.Point(0, 86);
            this.diffLabel.Margin = new System.Windows.Forms.Padding(0, 2, 16, 23);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(74, 17);
            this.diffLabel.TabIndex = 3;
            this.diffLabel.Text = "Difficulty:";
            // 
            // iwadLabel
            // 
            this.iwadLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iwadLabel.AutoSize = true;
            this.iwadLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.iwadLabel.Location = new System.Drawing.Point(0, 2);
            this.iwadLabel.Margin = new System.Windows.Forms.Padding(0, 2, 16, 23);
            this.iwadLabel.Name = "iwadLabel";
            this.iwadLabel.Size = new System.Drawing.Size(55, 17);
            this.iwadLabel.TabIndex = 7;
            this.iwadLabel.Text = "IWAD:";
            // 
            // launchTPL3
            // 
            this.launchTPL3.AutoSize = true;
            this.launchTPL3.ColumnCount = 3;
            this.launchTPL3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.launchTPL3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.launchTPL3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.launchTPL3.Controls.Add(this.warpLabel, 0, 0);
            this.launchTPL3.Controls.Add(this.levelTextBox, 2, 0);
            this.launchTPL3.Controls.Add(this.levelComboBox, 1, 0);
            this.launchTPL3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launchTPL3.Location = new System.Drawing.Point(0, 168);
            this.launchTPL3.Margin = new System.Windows.Forms.Padding(0);
            this.launchTPL3.Name = "launchTPL3";
            this.launchTPL3.RowCount = 1;
            this.launchTPL3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.launchTPL3.Size = new System.Drawing.Size(416, 42);
            this.launchTPL3.TabIndex = 9;
            // 
            // warpLabel
            // 
            this.warpLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.warpLabel.AutoSize = true;
            this.warpLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.warpLabel.Location = new System.Drawing.Point(0, 2);
            this.warpLabel.Margin = new System.Windows.Forms.Padding(0, 2, 16, 23);
            this.warpLabel.Name = "warpLabel";
            this.warpLabel.Size = new System.Drawing.Size(49, 17);
            this.warpLabel.TabIndex = 6;
            this.warpLabel.Text = "Level:";
            // 
            // levelTextBox
            // 
            this.levelTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.levelTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.levelTextBox.Location = new System.Drawing.Point(280, 0);
            this.levelTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(136, 22);
            this.levelTextBox.TabIndex = 1;
            // 
            // levelComboBox
            // 
            this.levelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.levelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Location = new System.Drawing.Point(160, 0);
            this.levelComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(100, 22);
            this.levelComboBox.TabIndex = 2;
            this.levelComboBox.SelectedIndexChanged += new System.EventHandler(this.levelCB_IndexChanged);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.demosToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(464, 24);
            this.mainMenuStrip.TabIndex = 6;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCurrentConfigToolStripMenuItem,
            this.defaultConfigToolStripMenuItem,
            this.toolStripSeparator4,
            this.saveConfigToINIToolStripMenuItem,
            this.loadConfigFromINIToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveCurrentConfigToolStripMenuItem
            // 
            this.saveCurrentConfigToolStripMenuItem.Name = "saveCurrentConfigToolStripMenuItem";
            this.saveCurrentConfigToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveCurrentConfigToolStripMenuItem.Text = "Save Current Config";
            this.saveCurrentConfigToolStripMenuItem.Click += new System.EventHandler(this.SaveCurrentConfig);
            // 
            // defaultConfigToolStripMenuItem
            // 
            this.defaultConfigToolStripMenuItem.Name = "defaultConfigToolStripMenuItem";
            this.defaultConfigToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.defaultConfigToolStripMenuItem.Text = "Default Config";
            this.defaultConfigToolStripMenuItem.Click += new System.EventHandler(this.ResetConfigPrompte);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(183, 6);
            // 
            // saveConfigToINIToolStripMenuItem
            // 
            this.saveConfigToINIToolStripMenuItem.Name = "saveConfigToINIToolStripMenuItem";
            this.saveConfigToINIToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveConfigToINIToolStripMenuItem.Text = "Save Config to INI";
            this.saveConfigToINIToolStripMenuItem.Click += new System.EventHandler(this.SaveToINI);
            // 
            // loadConfigFromINIToolStripMenuItem
            // 
            this.loadConfigFromINIToolStripMenuItem.Name = "loadConfigFromINIToolStripMenuItem";
            this.loadConfigFromINIToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.loadConfigFromINIToolStripMenuItem.Text = "Load Config from INI";
            this.loadConfigFromINIToolStripMenuItem.Click += new System.EventHandler(this.LoadFromINI);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitTSMI);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.recordingOptionsToolStripMenuItem2});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // recordingOptionsToolStripMenuItem2
            // 
            this.recordingOptionsToolStripMenuItem2.Name = "recordingOptionsToolStripMenuItem2";
            this.recordingOptionsToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.recordingOptionsToolStripMenuItem2.Text = "Recording Options";
            // 
            // demosToolStripMenuItem
            // 
            this.demosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playDemoFileToolStripMenuItem,
            this.recordDemoToolStripMenuItem,
            this.toolStripSeparator2,
            this.recordingOptionsToolStripMenuItem});
            this.demosToolStripMenuItem.Name = "demosToolStripMenuItem";
            this.demosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.demosToolStripMenuItem.Text = "Demos";
            // 
            // playDemoFileToolStripMenuItem
            // 
            this.playDemoFileToolStripMenuItem.Name = "playDemoFileToolStripMenuItem";
            this.playDemoFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playDemoFileToolStripMenuItem.Text = "Play Demo File";
            this.playDemoFileToolStripMenuItem.Click += new System.EventHandler(this.PlayDemo);
            // 
            // recordDemoToolStripMenuItem
            // 
            this.recordDemoToolStripMenuItem.CheckOnClick = true;
            this.recordDemoToolStripMenuItem.Name = "recordDemoToolStripMenuItem";
            this.recordDemoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recordDemoToolStripMenuItem.Text = "Record Demo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // recordingOptionsToolStripMenuItem
            // 
            this.recordingOptionsToolStripMenuItem.Name = "recordingOptionsToolStripMenuItem";
            this.recordingOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recordingOptionsToolStripMenuItem.Text = "Recording Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compatibilityHintToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // compatibilityHintToolStripMenuItem
            // 
            this.compatibilityHintToolStripMenuItem.Name = "compatibilityHintToolStripMenuItem";
            this.compatibilityHintToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.compatibilityHintToolStripMenuItem.Text = "Compatibility Hint";
            this.compatibilityHintToolStripMenuItem.Click += new System.EventHandler(this.Goto_CompHint);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.Goto_About);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.mainTLP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 960);
            this.MinimumSize = new System.Drawing.Size(480, 620);
            this.Name = "MainForm";
            this.Text = "PRLauncher+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.mainTLP.ResumeLayout(false);
            this.mainTLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.innerTLP.ResumeLayout(false);
            this.innerTLP.PerformLayout();
            this.dirGroup.ResumeLayout(false);
            this.dirGroup.PerformLayout();
            this.pathTLP.ResumeLayout(false);
            this.pathTLP.PerformLayout();
            this.launchGroup.ResumeLayout(false);
            this.launchGroup.PerformLayout();
            this.launchTPL.ResumeLayout(false);
            this.launchTPL.PerformLayout();
            this.launchTLP2.ResumeLayout(false);
            this.launchTLP2.PerformLayout();
            this.launchTPL3.ResumeLayout(false);
            this.launchTPL3.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel mainTLP;
        private TableLayoutPanel innerTLP;
        private TableLayoutPanel pathTLP;
        private TableLayoutPanel launchTPL;
        private TableLayoutPanel launchTLP2;
        private TableLayoutPanel launchTPL3;
        private PictureBox banner;
        private GroupBox dirGroup;
        private GroupBox launchGroup;
        private TextBox dirTextBox;
        private TextBox argTextBox;
        private TextBox levelTextBox;
        private ComboBox iwadComboBox;
        private ComboBox compComboBox;
        private ComboBox diffComboBox;
        private ComboBox levelComboBox;
        private CheckBox execCheckBox;
        private Label iwadLabel;
        private Label argLabel;
        private Label diffLabel;
        private Label compLabel;
        private Label warpLabel;
        private Button dirButton;
        private Button runButton;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem saveCurrentConfigToolStripMenuItem;
        private ToolStripMenuItem defaultConfigToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem videoToolStripMenuItem;
        private ToolStripMenuItem displayToolStripMenuItem;
        private ToolStripMenuItem recordingOptionsToolStripMenuItem2;
        private ToolStripMenuItem demosToolStripMenuItem;
        private ToolStripMenuItem playDemoFileToolStripMenuItem;
        private ToolStripMenuItem recordDemoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem recordingOptionsToolStripMenuItem;
        private ToolStripMenuItem compatibilityHintToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem saveConfigToINIToolStripMenuItem;
        private ToolStripMenuItem loadConfigFromINIToolStripMenuItem;
    }
}

