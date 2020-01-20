namespace PRLauncher_plus {
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
            this.dirButton = new System.Windows.Forms.Button();
            this.banner = new System.Windows.Forms.PictureBox();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.iwadComboBox = new System.Windows.Forms.ComboBox();
            this.compComboBox = new System.Windows.Forms.ComboBox();
            this.diffComboBox = new System.Windows.Forms.ComboBox();
            this.argTextBox = new System.Windows.Forms.TextBox();
            this.levelGroup = new System.Windows.Forms.GroupBox();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.dirGroup = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.execRadio2 = new System.Windows.Forms.RadioButton();
            this.execRadio1 = new System.Windows.Forms.RadioButton();
            this.launchGroup = new System.Windows.Forms.GroupBox();
            this.iwadLabel = new System.Windows.Forms.Label();
            this.argLabel = new System.Windows.Forms.Label();
            this.diffLabel = new System.Windows.Forms.Label();
            this.compLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.levelGroup.SuspendLayout();
            this.dirGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.launchGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dirButton
            // 
            this.dirButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.dirButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dirButton.Location = new System.Drawing.Point(0, 0);
            this.dirButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.dirButton.Name = "dirButton";
            this.dirButton.Size = new System.Drawing.Size(200, 28);
            this.dirButton.TabIndex = 0;
            this.dirButton.Text = "Select PRBoom+ Directory";
            this.dirButton.UseVisualStyleBackColor = true;
            this.dirButton.Click += new System.EventHandler(this.ChooseDirectoryButton);
            // 
            // banner
            // 
            this.banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner.Image = global::PRLauncher_plus.Properties.Resources.banner;
            this.banner.Location = new System.Drawing.Point(20, 20);
            this.banner.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(424, 72);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.banner.TabIndex = 1;
            this.banner.TabStop = false;
            // 
            // dirTextBox
            // 
            this.dirTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dirTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dirTextBox.Location = new System.Drawing.Point(8, 28);
            this.dirTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.Size = new System.Drawing.Size(408, 22);
            this.dirTextBox.TabIndex = 0;
            this.dirTextBox.TextChanged += new System.EventHandler(this.RefreshDirectory);
            // 
            // runButton
            // 
            this.runButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.runButton.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.runButton.Location = new System.Drawing.Point(20, 533);
            this.runButton.Margin = new System.Windows.Forms.Padding(0);
            this.runButton.MaximumSize = new System.Drawing.Size(600, 48);
            this.runButton.MinimumSize = new System.Drawing.Size(414, 48);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(424, 48);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Launch";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.run);
            // 
            // iwadComboBox
            // 
            this.iwadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iwadComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.iwadComboBox.FormattingEnabled = true;
            this.iwadComboBox.Location = new System.Drawing.Point(190, 28);
            this.iwadComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.iwadComboBox.Name = "iwadComboBox";
            this.iwadComboBox.Size = new System.Drawing.Size(226, 22);
            this.iwadComboBox.TabIndex = 2;
            this.iwadComboBox.SelectedIndexChanged += new System.EventHandler(this.iwadCB_IndexChanged);
            // 
            // compComboBox
            // 
            this.compComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.compComboBox.FormattingEnabled = true;
            this.compComboBox.Location = new System.Drawing.Point(190, 70);
            this.compComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.compComboBox.Name = "compComboBox";
            this.compComboBox.Size = new System.Drawing.Size(226, 22);
            this.compComboBox.TabIndex = 2;
            this.compComboBox.SelectedIndexChanged += new System.EventHandler(this.compCB_IndexChanged);
            // 
            // diffComboBox
            // 
            this.diffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diffComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.diffComboBox.FormattingEnabled = true;
            this.diffComboBox.Location = new System.Drawing.Point(190, 112);
            this.diffComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.diffComboBox.Name = "diffComboBox";
            this.diffComboBox.Size = new System.Drawing.Size(226, 22);
            this.diffComboBox.TabIndex = 2;
            this.diffComboBox.SelectedIndexChanged += new System.EventHandler(this.diffCB_IndexChanged);
            // 
            // argTextBox
            // 
            this.argTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.argTextBox.Location = new System.Drawing.Point(190, 154);
            this.argTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.argTextBox.Name = "argTextBox";
            this.argTextBox.Size = new System.Drawing.Size(226, 22);
            this.argTextBox.TabIndex = 0;
            // 
            // levelGroup
            // 
            this.levelGroup.Controls.Add(this.levelComboBox);
            this.levelGroup.Controls.Add(this.levelTextBox);
            this.levelGroup.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.levelGroup.Location = new System.Drawing.Point(20, 444);
            this.levelGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.levelGroup.Name = "levelGroup";
            this.levelGroup.Padding = new System.Windows.Forms.Padding(8);
            this.levelGroup.Size = new System.Drawing.Size(424, 64);
            this.levelGroup.TabIndex = 10;
            this.levelGroup.TabStop = false;
            this.levelGroup.Text = "Enter Level:";
            // 
            // levelComboBox
            // 
            this.levelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Location = new System.Drawing.Point(222, 28);
            this.levelComboBox.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(194, 22);
            this.levelComboBox.TabIndex = 2;
            // 
            // levelTextBox
            // 
            this.levelTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.levelTextBox.Location = new System.Drawing.Point(8, 28);
            this.levelTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(194, 22);
            this.levelTextBox.TabIndex = 1;
            // 
            // dirGroup
            // 
            this.dirGroup.AutoSize = true;
            this.dirGroup.Controls.Add(this.panel1);
            this.dirGroup.Controls.Add(this.dirTextBox);
            this.dirGroup.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dirGroup.Location = new System.Drawing.Point(20, 112);
            this.dirGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.dirGroup.MaximumSize = new System.Drawing.Size(0, 96);
            this.dirGroup.MinimumSize = new System.Drawing.Size(424, 96);
            this.dirGroup.Name = "dirGroup";
            this.dirGroup.Padding = new System.Windows.Forms.Padding(8);
            this.dirGroup.Size = new System.Drawing.Size(424, 96);
            this.dirGroup.TabIndex = 12;
            this.dirGroup.TabStop = false;
            this.dirGroup.Text = "PRBoom+ Directory Settings:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dirButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(8, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 28);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.execRadio2);
            this.panel2.Controls.Add(this.execRadio1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 28);
            this.panel2.TabIndex = 13;
            // 
            // execRadio2
            // 
            this.execRadio2.BackColor = System.Drawing.SystemColors.Control;
            this.execRadio2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.execRadio2.Location = new System.Drawing.Point(97, 5);
            this.execRadio2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.execRadio2.Name = "execRadio2";
            this.execRadio2.Size = new System.Drawing.Size(85, 18);
            this.execRadio2.TabIndex = 14;
            this.execRadio2.TabStop = true;
            this.execRadio2.Text = "GLBoom+";
            this.execRadio2.UseVisualStyleBackColor = false;
            this.execRadio2.CheckedChanged += new System.EventHandler(this.ExecutableChanged);
            // 
            // execRadio1
            // 
            this.execRadio1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.execRadio1.Location = new System.Drawing.Point(0, 5);
            this.execRadio1.Margin = new System.Windows.Forms.Padding(20, 5, 0, 5);
            this.execRadio1.Name = "execRadio1";
            this.execRadio1.Size = new System.Drawing.Size(85, 18);
            this.execRadio1.TabIndex = 13;
            this.execRadio1.TabStop = true;
            this.execRadio1.Text = "PRBoom+";
            this.execRadio1.UseVisualStyleBackColor = true;
            this.execRadio1.CheckedChanged += new System.EventHandler(this.ExecutableChanged);
            // 
            // launchGroup
            // 
            this.launchGroup.Controls.Add(this.iwadComboBox);
            this.launchGroup.Controls.Add(this.compComboBox);
            this.launchGroup.Controls.Add(this.diffComboBox);
            this.launchGroup.Controls.Add(this.argTextBox);
            this.launchGroup.Controls.Add(this.iwadLabel);
            this.launchGroup.Controls.Add(this.argLabel);
            this.launchGroup.Controls.Add(this.diffLabel);
            this.launchGroup.Controls.Add(this.compLabel);
            this.launchGroup.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.launchGroup.Location = new System.Drawing.Point(20, 232);
            this.launchGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.launchGroup.Name = "launchGroup";
            this.launchGroup.Padding = new System.Windows.Forms.Padding(8);
            this.launchGroup.Size = new System.Drawing.Size(424, 192);
            this.launchGroup.TabIndex = 12;
            this.launchGroup.TabStop = false;
            this.launchGroup.Text = "Launch Arguments:";
            // 
            // iwadLabel
            // 
            this.iwadLabel.AutoSize = true;
            this.iwadLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.iwadLabel.Location = new System.Drawing.Point(8, 30);
            this.iwadLabel.Margin = new System.Windows.Forms.Padding(0, 2, 16, 23);
            this.iwadLabel.Name = "iwadLabel";
            this.iwadLabel.Size = new System.Drawing.Size(55, 17);
            this.iwadLabel.TabIndex = 7;
            this.iwadLabel.Text = "IWAD:";
            // 
            // argLabel
            // 
            this.argLabel.AutoSize = true;
            this.argLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.argLabel.Location = new System.Drawing.Point(8, 156);
            this.argLabel.Margin = new System.Windows.Forms.Padding(0, 2, 16, 23);
            this.argLabel.Name = "argLabel";
            this.argLabel.Size = new System.Drawing.Size(166, 17);
            this.argLabel.TabIndex = 5;
            this.argLabel.Text = "Additional Arguments:";
            // 
            // diffLabel
            // 
            this.diffLabel.AutoSize = true;
            this.diffLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.diffLabel.Location = new System.Drawing.Point(8, 114);
            this.diffLabel.Margin = new System.Windows.Forms.Padding(0, 2, 16, 23);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(74, 17);
            this.diffLabel.TabIndex = 3;
            this.diffLabel.Text = "Difficulty:";
            // 
            // compLabel
            // 
            this.compLabel.AutoSize = true;
            this.compLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.compLabel.Location = new System.Drawing.Point(8, 72);
            this.compLabel.Margin = new System.Windows.Forms.Padding(0, 2, 16, 23);
            this.compLabel.Name = "compLabel";
            this.compLabel.Size = new System.Drawing.Size(144, 17);
            this.compLabel.TabIndex = 1;
            this.compLabel.Text = "Compatibility Level:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.launchGroup);
            this.Controls.Add(this.dirGroup);
            this.Controls.Add(this.levelGroup);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.banner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(480, 720);
            this.MinimumSize = new System.Drawing.Size(480, 640);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "PRLauncher+ 0.5.0";
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.levelGroup.ResumeLayout(false);
            this.levelGroup.PerformLayout();
            this.dirGroup.ResumeLayout(false);
            this.dirGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.launchGroup.ResumeLayout(false);
            this.launchGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dirButton;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.TextBox dirTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.ComboBox iwadComboBox;
        private System.Windows.Forms.ComboBox compComboBox;
        private System.Windows.Forms.ComboBox diffComboBox;
        private System.Windows.Forms.TextBox argTextBox;
        private System.Windows.Forms.GroupBox levelGroup;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.GroupBox dirGroup;
        private System.Windows.Forms.RadioButton execRadio1;
        private System.Windows.Forms.RadioButton execRadio2;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox launchGroup;
        private System.Windows.Forms.Label iwadLabel;
        private System.Windows.Forms.Label argLabel;
        private System.Windows.Forms.Label diffLabel;
        private System.Windows.Forms.Label compLabel;
        private System.Windows.Forms.Panel panel2;
    }
}

