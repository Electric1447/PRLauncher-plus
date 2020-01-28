namespace PRLauncher_plus.Forms {
    partial class CompHintForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompHintForm));
            this.mainTLP = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTLP
            // 
            this.mainTLP.ColumnCount = 1;
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.Controls.Add(this.label1, 0, 0);
            this.mainTLP.Controls.Add(this.label2, 0, 1);
            this.mainTLP.Controls.Add(this.label3, 0, 2);
            this.mainTLP.Controls.Add(this.label4, 0, 3);
            this.mainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTLP.Location = new System.Drawing.Point(0, 0);
            this.mainTLP.Margin = new System.Windows.Forms.Padding(0);
            this.mainTLP.Name = "mainTLP";
            this.mainTLP.RowCount = 4;
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.Size = new System.Drawing.Size(304, 241);
            this.mainTLP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 16, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 16, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "- If a custom wad has \"BOOM compatible\" in its description, select \"7 - Boom\'s co" +
    "mpatibility mode\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 16, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "- If a custom wad has \"MBF compatible\" in its description, select \"11 - MBF\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 16, 12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "\"-1 - Current Prboom-plus\" option is useful when you\'re going to watch a demo and" +
    " you want PrBoom+ to auto detect the correct compatibility option for it.";
            // 
            // CompHintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 241);
            this.Controls.Add(this.mainTLP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 280);
            this.Name = "CompHintForm";
            this.Text = "Compatibility Hint";
            this.mainTLP.ResumeLayout(false);
            this.mainTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTLP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}