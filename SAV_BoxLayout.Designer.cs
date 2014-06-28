﻿namespace PKHeX
{
    partial class SAV_BoxLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAV_BoxLayout));
            this.LB_BoxSelect = new System.Windows.Forms.ListBox();
            this.TB_BoxName = new System.Windows.Forms.TextBox();
            this.L_BoxName = new System.Windows.Forms.Label();
            this.MT_BG = new System.Windows.Forms.MaskedTextBox();
            this.L_BG = new System.Windows.Forms.Label();
            this.L_Flags = new System.Windows.Forms.Label();
            this.MT_BG1 = new System.Windows.Forms.MaskedTextBox();
            this.MT_BG2 = new System.Windows.Forms.MaskedTextBox();
            this.MT_BG3 = new System.Windows.Forms.MaskedTextBox();
            this.B_Save = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_BoxSelect
            // 
            this.LB_BoxSelect.FormattingEnabled = true;
            this.LB_BoxSelect.Items.AddRange(new object[] {
            "Box 1",
            "Box 2",
            "Box 3",
            "Box 4",
            "Box 5",
            "Box 6",
            "Box 7",
            "Box 8",
            "Box 9",
            "Box 10",
            "Box 11",
            "Box 12",
            "Box 13",
            "Box 14",
            "Box 15",
            "Box 16",
            "Box 17",
            "Box 18",
            "Box 19",
            "Box 20",
            "Box 21",
            "Box 22",
            "Box 23",
            "Box 24",
            "Box 25",
            "Box 26",
            "Box 27",
            "Box 28",
            "Box 29",
            "Box 30",
            "Box 31"});
            this.LB_BoxSelect.Location = new System.Drawing.Point(12, 14);
            this.LB_BoxSelect.Name = "LB_BoxSelect";
            this.LB_BoxSelect.Size = new System.Drawing.Size(78, 134);
            this.LB_BoxSelect.TabIndex = 0;
            this.LB_BoxSelect.SelectedIndexChanged += new System.EventHandler(this.changeBox);
            // 
            // TB_BoxName
            // 
            this.TB_BoxName.Location = new System.Drawing.Point(106, 35);
            this.TB_BoxName.MaxLength = 15;
            this.TB_BoxName.Name = "TB_BoxName";
            this.TB_BoxName.Size = new System.Drawing.Size(100, 20);
            this.TB_BoxName.TabIndex = 1;
            this.TB_BoxName.WordWrap = false;
            this.TB_BoxName.TextChanged += new System.EventHandler(this.changeBoxDetails);
            // 
            // L_BoxName
            // 
            this.L_BoxName.AutoSize = true;
            this.L_BoxName.Location = new System.Drawing.Point(104, 19);
            this.L_BoxName.Name = "L_BoxName";
            this.L_BoxName.Size = new System.Drawing.Size(59, 13);
            this.L_BoxName.TabIndex = 2;
            this.L_BoxName.Text = "Box Name:";
            // 
            // MT_BG
            // 
            this.MT_BG.Location = new System.Drawing.Point(177, 61);
            this.MT_BG.Mask = "00";
            this.MT_BG.Name = "MT_BG";
            this.MT_BG.Size = new System.Drawing.Size(29, 20);
            this.MT_BG.TabIndex = 3;
            this.MT_BG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MT_BG.TextChanged += new System.EventHandler(this.changeBoxDetails);
            // 
            // L_BG
            // 
            this.L_BG.AutoSize = true;
            this.L_BG.Location = new System.Drawing.Point(104, 64);
            this.L_BG.Name = "L_BG";
            this.L_BG.Size = new System.Drawing.Size(68, 13);
            this.L_BG.TabIndex = 4;
            this.L_BG.Text = "Background:";
            // 
            // L_Flags
            // 
            this.L_Flags.AutoSize = true;
            this.L_Flags.Location = new System.Drawing.Point(104, 82);
            this.L_Flags.Name = "L_Flags";
            this.L_Flags.Size = new System.Drawing.Size(102, 13);
            this.L_Flags.TabIndex = 5;
            this.L_Flags.Text = "Unlocked BG Flags:";
            // 
            // MT_BG1
            // 
            this.MT_BG1.Location = new System.Drawing.Point(106, 98);
            this.MT_BG1.Mask = "00";
            this.MT_BG1.Name = "MT_BG1";
            this.MT_BG1.Size = new System.Drawing.Size(29, 20);
            this.MT_BG1.TabIndex = 6;
            this.MT_BG1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MT_BG1.TextChanged += new System.EventHandler(this.changeBoxDetails);
            // 
            // MT_BG2
            // 
            this.MT_BG2.Location = new System.Drawing.Point(142, 98);
            this.MT_BG2.Mask = "00";
            this.MT_BG2.Name = "MT_BG2";
            this.MT_BG2.Size = new System.Drawing.Size(29, 20);
            this.MT_BG2.TabIndex = 7;
            this.MT_BG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MT_BG2.TextChanged += new System.EventHandler(this.changeBoxDetails);
            // 
            // MT_BG3
            // 
            this.MT_BG3.Location = new System.Drawing.Point(177, 98);
            this.MT_BG3.Mask = "00";
            this.MT_BG3.Name = "MT_BG3";
            this.MT_BG3.Size = new System.Drawing.Size(29, 20);
            this.MT_BG3.TabIndex = 8;
            this.MT_BG3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MT_BG3.TextChanged += new System.EventHandler(this.changeBoxDetails);
            // 
            // B_Save
            // 
            this.B_Save.Location = new System.Drawing.Point(157, 127);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(50, 23);
            this.B_Save.TabIndex = 9;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Location = new System.Drawing.Point(101, 127);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(50, 23);
            this.B_Cancel.TabIndex = 10;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // SAV_BoxLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 162);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.MT_BG3);
            this.Controls.Add(this.MT_BG2);
            this.Controls.Add(this.MT_BG1);
            this.Controls.Add(this.L_Flags);
            this.Controls.Add(this.L_BG);
            this.Controls.Add(this.MT_BG);
            this.Controls.Add(this.L_BoxName);
            this.Controls.Add(this.TB_BoxName);
            this.Controls.Add(this.LB_BoxSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SAV_BoxLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Box Layout Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_BoxSelect;
        private System.Windows.Forms.TextBox TB_BoxName;
        private System.Windows.Forms.Label L_BoxName;
        private System.Windows.Forms.MaskedTextBox MT_BG;
        private System.Windows.Forms.Label L_BG;
        private System.Windows.Forms.Label L_Flags;
        private System.Windows.Forms.MaskedTextBox MT_BG1;
        private System.Windows.Forms.MaskedTextBox MT_BG2;
        private System.Windows.Forms.MaskedTextBox MT_BG3;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Cancel;
    }
}