namespace PRLauncher_plus.Forms {
    partial class RecordingForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordingForm));
            this.mainTLP = new System.Windows.Forms.TableLayoutPanel();
            this.seperator1 = new System.Windows.Forms.Label();
            this.buttonTLP = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.discardButton = new System.Windows.Forms.Button();
            this.mainGB = new System.Windows.Forms.GroupBox();
            this.innerTLP = new System.Windows.Forms.TableLayoutPanel();
            this.seperator3 = new System.Windows.Forms.Label();
            this.pathTLP = new System.Windows.Forms.TableLayoutPanel();
            this.dirButton = new System.Windows.Forms.Button();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.seperator2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dirLabel = new System.Windows.Forms.Label();
            this.mainTLP.SuspendLayout();
            this.buttonTLP.SuspendLayout();
            this.mainGB.SuspendLayout();
            this.innerTLP.SuspendLayout();
            this.pathTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTLP
            // 
            this.mainTLP.AutoSize = true;
            this.mainTLP.ColumnCount = 1;
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.Controls.Add(this.seperator1, 0, 1);
            this.mainTLP.Controls.Add(this.buttonTLP, 0, 2);
            this.mainTLP.Controls.Add(this.mainGB, 0, 0);
            this.mainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTLP.Location = new System.Drawing.Point(0, 0);
            this.mainTLP.Margin = new System.Windows.Forms.Padding(0);
            this.mainTLP.Name = "mainTLP";
            this.mainTLP.RowCount = 3;
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.mainTLP.Size = new System.Drawing.Size(404, 411);
            this.mainTLP.TabIndex = 0;
            // 
            // seperator1
            // 
            this.seperator1.BackColor = System.Drawing.SystemColors.Control;
            this.seperator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seperator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.seperator1.Location = new System.Drawing.Point(3, 361);
            this.seperator1.Name = "seperator1";
            this.seperator1.Size = new System.Drawing.Size(398, 2);
            this.seperator1.TabIndex = 0;
            // 
            // buttonTLP
            // 
            this.buttonTLP.AutoSize = true;
            this.buttonTLP.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTLP.ColumnCount = 3;
            this.buttonTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTLP.Controls.Add(this.resetButton, 2, 0);
            this.buttonTLP.Controls.Add(this.saveButton, 1, 0);
            this.buttonTLP.Controls.Add(this.discardButton, 0, 0);
            this.buttonTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTLP.Location = new System.Drawing.Point(0, 363);
            this.buttonTLP.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTLP.Name = "buttonTLP";
            this.buttonTLP.RowCount = 1;
            this.buttonTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTLP.Size = new System.Drawing.Size(404, 48);
            this.buttonTLP.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resetButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(265, 9);
            this.resetButton.Margin = new System.Windows.Forms.Padding(9);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 30);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetPrompte);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(157, 9);
            this.saveButton.Margin = new System.Windows.Forms.Padding(9);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 30);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.Save);
            // 
            // discardButton
            // 
            this.discardButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.discardButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.discardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardButton.Location = new System.Drawing.Point(49, 9);
            this.discardButton.Margin = new System.Windows.Forms.Padding(9);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(90, 30);
            this.discardButton.TabIndex = 0;
            this.discardButton.Text = "Discard";
            this.discardButton.UseVisualStyleBackColor = false;
            this.discardButton.Click += new System.EventHandler(this.Discard);
            // 
            // mainGB
            // 
            this.mainGB.AutoSize = true;
            this.mainGB.BackColor = System.Drawing.SystemColors.Control;
            this.mainGB.Controls.Add(this.innerTLP);
            this.mainGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGB.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.mainGB.Location = new System.Drawing.Point(16, 16);
            this.mainGB.Margin = new System.Windows.Forms.Padding(16);
            this.mainGB.Name = "mainGB";
            this.mainGB.Padding = new System.Windows.Forms.Padding(2);
            this.mainGB.Size = new System.Drawing.Size(372, 329);
            this.mainGB.TabIndex = 2;
            this.mainGB.TabStop = false;
            this.mainGB.Text = "Recording Options";
            // 
            // innerTLP
            // 
            this.innerTLP.ColumnCount = 1;
            this.innerTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.innerTLP.Controls.Add(this.seperator3, 0, 4);
            this.innerTLP.Controls.Add(this.pathTLP, 0, 3);
            this.innerTLP.Controls.Add(this.enableCheckBox, 0, 0);
            this.innerTLP.Controls.Add(this.seperator2, 0, 1);
            this.innerTLP.Controls.Add(this.panel1, 0, 5);
            this.innerTLP.Controls.Add(this.dirLabel, 0, 2);
            this.innerTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerTLP.Location = new System.Drawing.Point(2, 22);
            this.innerTLP.Margin = new System.Windows.Forms.Padding(0);
            this.innerTLP.Name = "innerTLP";
            this.innerTLP.RowCount = 6;
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.innerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.innerTLP.Size = new System.Drawing.Size(368, 305);
            this.innerTLP.TabIndex = 18;
            // 
            // seperator3
            // 
            this.seperator3.BackColor = System.Drawing.SystemColors.Control;
            this.seperator3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperator3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seperator3.Location = new System.Drawing.Point(0, 127);
            this.seperator3.Margin = new System.Windows.Forms.Padding(0);
            this.seperator3.Name = "seperator3";
            this.seperator3.Size = new System.Drawing.Size(368, 2);
            this.seperator3.TabIndex = 17;
            // 
            // pathTLP
            // 
            this.pathTLP.ColumnCount = 2;
            this.pathTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pathTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.pathTLP.Controls.Add(this.dirButton, 1, 0);
            this.pathTLP.Controls.Add(this.dirTextBox, 0, 0);
            this.pathTLP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pathTLP.Location = new System.Drawing.Point(8, 75);
            this.pathTLP.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pathTLP.Name = "pathTLP";
            this.pathTLP.RowCount = 1;
            this.pathTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.pathTLP.Size = new System.Drawing.Size(360, 36);
            this.pathTLP.TabIndex = 16;
            // 
            // dirButton
            // 
            this.dirButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dirButton.BackgroundImage = global::PRLauncher_plus.Properties.Resources.folder_icon;
            this.dirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dirButton.Location = new System.Drawing.Point(324, 0);
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
            this.dirTextBox.Size = new System.Drawing.Size(316, 22);
            this.dirTextBox.TabIndex = 0;
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.enableCheckBox.Location = new System.Drawing.Point(12, 8);
            this.enableCheckBox.Margin = new System.Windows.Forms.Padding(12, 8, 12, 14);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(116, 18);
            this.enableCheckBox.TabIndex = 15;
            this.enableCheckBox.Text = "Record Demos";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            this.enableCheckBox.CheckedChanged += new System.EventHandler(this.recordStatusChanged);
            // 
            // seperator2
            // 
            this.seperator2.BackColor = System.Drawing.SystemColors.Control;
            this.seperator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperator2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seperator2.Location = new System.Drawing.Point(0, 40);
            this.seperator2.Margin = new System.Windows.Forms.Padding(0);
            this.seperator2.Name = "seperator2";
            this.seperator2.Size = new System.Drawing.Size(368, 2);
            this.seperator2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 160);
            this.panel1.TabIndex = 0;
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel);
            this.dirLabel.Location = new System.Drawing.Point(8, 50);
            this.dirLabel.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(120, 17);
            this.dirLabel.TabIndex = 17;
            this.dirLabel.Text = "Save demos to:";
            // 
            // RecordingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 411);
            this.Controls.Add(this.mainTLP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(360, 320);
            this.Name = "RecordingForm";
            this.Text = "Recording Options";
            this.mainTLP.ResumeLayout(false);
            this.mainTLP.PerformLayout();
            this.buttonTLP.ResumeLayout(false);
            this.mainGB.ResumeLayout(false);
            this.innerTLP.ResumeLayout(false);
            this.innerTLP.PerformLayout();
            this.pathTLP.ResumeLayout(false);
            this.pathTLP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTLP;
        private System.Windows.Forms.Button discardButton;
        private System.Windows.Forms.TableLayoutPanel buttonTLP;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox mainGB;
        private System.Windows.Forms.Label seperator1;
        private System.Windows.Forms.TableLayoutPanel pathTLP;
        private System.Windows.Forms.Button dirButton;
        private System.Windows.Forms.TextBox dirTextBox;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.TableLayoutPanel innerTLP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label seperator2;
        private System.Windows.Forms.Label seperator3;
    }
}