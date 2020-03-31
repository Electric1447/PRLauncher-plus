namespace PRLauncher_plus.Forms {
    partial class AboutForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
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
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.mainTLP = new System.Windows.Forms.TableLayoutPanel();
            this.banner = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.vLabel = new System.Windows.Forms.Label();
            this.mainTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTLP
            // 
            this.mainTLP.ColumnCount = 1;
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.Controls.Add(this.banner, 0, 0);
            this.mainTLP.Controls.Add(this.closeButton, 0, 2);
            this.mainTLP.Controls.Add(this.groupBox1, 0, 1);
            this.mainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTLP.Location = new System.Drawing.Point(0, 0);
            this.mainTLP.Margin = new System.Windows.Forms.Padding(0);
            this.mainTLP.Name = "mainTLP";
            this.mainTLP.RowCount = 3;
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.mainTLP.Size = new System.Drawing.Size(264, 231);
            this.mainTLP.TabIndex = 0;
            // 
            // banner
            // 
            this.banner.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.banner.Image = global::PRLauncher_plus.Properties.Resources.banner;
            this.banner.Location = new System.Drawing.Point(7, 8);
            this.banner.Margin = new System.Windows.Forms.Padding(0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(250, 45);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banner.TabIndex = 3;
            this.banner.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.closeButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.closeButton.Location = new System.Drawing.Point(92, 199);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(80, 24);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.Close);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.cLabel);
            this.groupBox1.Controls.Add(this.gLabel);
            this.groupBox1.Controls.Add(this.vLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 122);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.cLabel.Location = new System.Drawing.Point(6, 36);
            this.cLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(164, 17);
            this.cLabel.TabIndex = 2;
            this.cLabel.Text = "Created by Electric1447";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel);
            this.gLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gLabel.Location = new System.Drawing.Point(6, 69);
            this.gLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(203, 14);
            this.gLabel.TabIndex = 1;
            this.gLabel.Text = "View the sourcecode on Github";
            this.gLabel.Click += new System.EventHandler(this.Goto_Github);
            // 
            // vLabel
            // 
            this.vLabel.AutoSize = true;
            this.vLabel.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.vLabel.Location = new System.Drawing.Point(6, 8);
            this.vLabel.Margin = new System.Windows.Forms.Padding(3);
            this.vLabel.Name = "vLabel";
            this.vLabel.Size = new System.Drawing.Size(228, 17);
            this.vLabel.TabIndex = 0;
            this.vLabel.Text = "PRLauncher+ Version X.X.X";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 231);
            this.Controls.Add(this.mainTLP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 270);
            this.Name = "AboutForm";
            this.Text = "About";
            this.mainTLP.ResumeLayout(false);
            this.mainTLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTLP;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label vLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label cLabel;
    }
}