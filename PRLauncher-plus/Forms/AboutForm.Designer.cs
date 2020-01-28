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
            this.innerTLP = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.iTLP3 = new System.Windows.Forms.TableLayoutPanel();
            this.aboutLabel3 = new System.Windows.Forms.Label();
            this.aboutLabel6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iTLP2 = new System.Windows.Forms.TableLayoutPanel();
            this.aboutLabel2 = new System.Windows.Forms.Label();
            this.aboutLabel5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iTLP1 = new System.Windows.Forms.TableLayoutPanel();
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.aboutLabel4 = new System.Windows.Forms.Label();
            this.mainTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.innerTLP.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.iTLP3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.iTLP2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.iTLP1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTLP
            // 
            this.mainTLP.ColumnCount = 1;
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.Controls.Add(this.banner, 0, 0);
            this.mainTLP.Controls.Add(this.closeButton, 0, 2);
            this.mainTLP.Controls.Add(this.innerTLP, 0, 1);
            this.mainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTLP.Location = new System.Drawing.Point(0, 0);
            this.mainTLP.Margin = new System.Windows.Forms.Padding(0);
            this.mainTLP.Name = "mainTLP";
            this.mainTLP.RowCount = 3;
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.mainTLP.Size = new System.Drawing.Size(264, 241);
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
            this.closeButton.Location = new System.Drawing.Point(92, 209);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(80, 24);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.Close);
            // 
            // innerTLP
            // 
            this.innerTLP.ColumnCount = 1;
            this.innerTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.innerTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.innerTLP.Controls.Add(this.groupBox3, 0, 2);
            this.innerTLP.Controls.Add(this.groupBox2, 0, 1);
            this.innerTLP.Controls.Add(this.groupBox1, 0, 0);
            this.innerTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerTLP.Location = new System.Drawing.Point(12, 61);
            this.innerTLP.Margin = new System.Windows.Forms.Padding(12, 8, 12, 9);
            this.innerTLP.Name = "innerTLP";
            this.innerTLP.RowCount = 3;
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.innerTLP.Size = new System.Drawing.Size(240, 139);
            this.innerTLP.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.iTLP3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 92);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1, 0, 1, 2);
            this.groupBox3.Size = new System.Drawing.Size(240, 47);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // iTLP3
            // 
            this.iTLP3.ColumnCount = 2;
            this.iTLP3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iTLP3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iTLP3.Controls.Add(this.aboutLabel3, 0, 0);
            this.iTLP3.Controls.Add(this.aboutLabel6, 1, 0);
            this.iTLP3.Location = new System.Drawing.Point(1, 14);
            this.iTLP3.Margin = new System.Windows.Forms.Padding(0);
            this.iTLP3.Name = "iTLP3";
            this.iTLP3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.iTLP3.RowCount = 1;
            this.iTLP3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iTLP3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iTLP3.Size = new System.Drawing.Size(238, 31);
            this.iTLP3.TabIndex = 6;
            // 
            // aboutLabel3
            // 
            this.aboutLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aboutLabel3.AutoSize = true;
            this.aboutLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.aboutLabel3.Location = new System.Drawing.Point(4, 2);
            this.aboutLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.aboutLabel3.Name = "aboutLabel3";
            this.aboutLabel3.Size = new System.Drawing.Size(110, 18);
            this.aboutLabel3.TabIndex = 3;
            this.aboutLabel3.Text = "Source Page:";
            // 
            // aboutLabel6
            // 
            this.aboutLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutLabel6.AutoSize = true;
            this.aboutLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutLabel6.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.aboutLabel6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.aboutLabel6.Location = new System.Drawing.Point(152, 2);
            this.aboutLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.aboutLabel6.Name = "aboutLabel6";
            this.aboutLabel6.Size = new System.Drawing.Size(53, 18);
            this.aboutLabel6.TabIndex = 5;
            this.aboutLabel6.Text = "github";
            this.aboutLabel6.Click += new System.EventHandler(this.Goto_Github);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iTLP2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 0, 1, 2);
            this.groupBox2.Size = new System.Drawing.Size(240, 46);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // iTLP2
            // 
            this.iTLP2.ColumnCount = 2;
            this.iTLP2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iTLP2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iTLP2.Controls.Add(this.aboutLabel2, 0, 0);
            this.iTLP2.Controls.Add(this.aboutLabel5, 1, 0);
            this.iTLP2.Location = new System.Drawing.Point(1, 15);
            this.iTLP2.Margin = new System.Windows.Forms.Padding(0);
            this.iTLP2.Name = "iTLP2";
            this.iTLP2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.iTLP2.RowCount = 1;
            this.iTLP2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iTLP2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iTLP2.Size = new System.Drawing.Size(238, 29);
            this.iTLP2.TabIndex = 5;
            // 
            // aboutLabel2
            // 
            this.aboutLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aboutLabel2.AutoSize = true;
            this.aboutLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.aboutLabel2.Location = new System.Drawing.Point(4, 1);
            this.aboutLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.aboutLabel2.Name = "aboutLabel2";
            this.aboutLabel2.Size = new System.Drawing.Size(70, 18);
            this.aboutLabel2.TabIndex = 1;
            this.aboutLabel2.Text = "Version:";
            // 
            // aboutLabel5
            // 
            this.aboutLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutLabel5.AutoSize = true;
            this.aboutLabel5.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.aboutLabel5.Location = new System.Drawing.Point(154, 1);
            this.aboutLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.aboutLabel5.Name = "aboutLabel5";
            this.aboutLabel5.Size = new System.Drawing.Size(48, 18);
            this.aboutLabel5.TabIndex = 4;
            this.aboutLabel5.Text = "X.X.X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iTLP1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 2);
            this.groupBox1.Size = new System.Drawing.Size(240, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // iTLP1
            // 
            this.iTLP1.ColumnCount = 2;
            this.iTLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.iTLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.iTLP1.Controls.Add(this.aboutLabel1, 0, 0);
            this.iTLP1.Controls.Add(this.aboutLabel4, 1, 0);
            this.iTLP1.Location = new System.Drawing.Point(1, 15);
            this.iTLP1.Margin = new System.Windows.Forms.Padding(0);
            this.iTLP1.Name = "iTLP1";
            this.iTLP1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.iTLP1.RowCount = 1;
            this.iTLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iTLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iTLP1.Size = new System.Drawing.Size(238, 29);
            this.iTLP1.TabIndex = 4;
            // 
            // aboutLabel1
            // 
            this.aboutLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aboutLabel1.AutoSize = true;
            this.aboutLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.aboutLabel1.Location = new System.Drawing.Point(4, 1);
            this.aboutLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(94, 18);
            this.aboutLabel1.TabIndex = 0;
            this.aboutLabel1.Text = "Created by:";
            // 
            // aboutLabel4
            // 
            this.aboutLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutLabel4.AutoSize = true;
            this.aboutLabel4.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.aboutLabel4.Location = new System.Drawing.Point(129, 1);
            this.aboutLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.aboutLabel4.Name = "aboutLabel4";
            this.aboutLabel4.Size = new System.Drawing.Size(100, 18);
            this.aboutLabel4.TabIndex = 3;
            this.aboutLabel4.Text = "Electric1447";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 241);
            this.Controls.Add(this.mainTLP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 280);
            this.Name = "AboutForm";
            this.Text = "About";
            this.mainTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.innerTLP.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.iTLP3.ResumeLayout(false);
            this.iTLP3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.iTLP2.ResumeLayout(false);
            this.iTLP2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.iTLP1.ResumeLayout(false);
            this.iTLP1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTLP;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TableLayoutPanel innerTLP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label aboutLabel6;
        private System.Windows.Forms.Label aboutLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label aboutLabel2;
        private System.Windows.Forms.Label aboutLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label aboutLabel1;
        private System.Windows.Forms.Label aboutLabel4;
        private System.Windows.Forms.TableLayoutPanel iTLP3;
        private System.Windows.Forms.TableLayoutPanel iTLP2;
        private System.Windows.Forms.TableLayoutPanel iTLP1;
    }
}