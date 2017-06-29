namespace AchaeaSnooper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.playersVisibleLabel = new System.Windows.Forms.Label();
            this.playerDataLabel = new System.Windows.Forms.Label();
            this.lookupTextBox = new System.Windows.Forms.TextBox();
            this.lookupButton = new System.Windows.Forms.Button();
            this.characterDataLabel1 = new System.Windows.Forms.Label();
            this.characterDataLabel2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameListBox
            // 
            this.nameListBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nameListBox.CausesValidation = false;
            this.nameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 16;
            this.nameListBox.Location = new System.Drawing.Point(8, 37);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(103, 260);
            this.nameListBox.TabIndex = 0;
            this.nameListBox.SelectedValueChanged += new System.EventHandler(this.nameListBox_SelectedValueChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Black;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(117, 40);
            this.nameLabel.MinimumSize = new System.Drawing.Size(10, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(451, 30);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshButton.Location = new System.Drawing.Point(8, 305);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(103, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // playersVisibleLabel
            // 
            this.playersVisibleLabel.AutoSize = true;
            this.playersVisibleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersVisibleLabel.ForeColor = System.Drawing.Color.White;
            this.playersVisibleLabel.Location = new System.Drawing.Point(21, 14);
            this.playersVisibleLabel.Name = "playersVisibleLabel";
            this.playersVisibleLabel.Size = new System.Drawing.Size(101, 20);
            this.playersVisibleLabel.TabIndex = 4;
            this.playersVisibleLabel.Text = "Chars online:";
            this.playersVisibleLabel.Click += new System.EventHandler(this.playersVisibleLabel_Click);
            // 
            // playerDataLabel
            // 
            this.playerDataLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerDataLabel.AutoSize = true;
            this.playerDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDataLabel.ForeColor = System.Drawing.Color.White;
            this.playerDataLabel.Location = new System.Drawing.Point(252, 14);
            this.playerDataLabel.Name = "playerDataLabel";
            this.playerDataLabel.Size = new System.Drawing.Size(162, 20);
            this.playerDataLabel.TabIndex = 5;
            this.playerDataLabel.Text = "Character information";
            this.playerDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lookupTextBox
            // 
            this.lookupTextBox.Location = new System.Drawing.Point(8, 336);
            this.lookupTextBox.Name = "lookupTextBox";
            this.lookupTextBox.Size = new System.Drawing.Size(103, 20);
            this.lookupTextBox.TabIndex = 6;
            // 
            // lookupButton
            // 
            this.lookupButton.Location = new System.Drawing.Point(117, 336);
            this.lookupButton.Name = "lookupButton";
            this.lookupButton.Size = new System.Drawing.Size(75, 20);
            this.lookupButton.TabIndex = 7;
            this.lookupButton.Text = "Lookup";
            this.lookupButton.UseVisualStyleBackColor = true;
            this.lookupButton.Click += new System.EventHandler(this.lookupButton_Click);
            // 
            // characterDataLabel1
            // 
            this.characterDataLabel1.Font = new System.Drawing.Font("Inconsolata", 14F);
            this.characterDataLabel1.ForeColor = System.Drawing.Color.White;
            this.characterDataLabel1.Location = new System.Drawing.Point(130, 87);
            this.characterDataLabel1.Name = "characterDataLabel1";
            this.characterDataLabel1.Size = new System.Drawing.Size(225, 224);
            this.characterDataLabel1.TabIndex = 8;
            this.characterDataLabel1.Text = "Class: Error\r\nCity:  Error\r\nHouse: Error";
            // 
            // characterDataLabel2
            // 
            this.characterDataLabel2.Font = new System.Drawing.Font("Inconsolata", 14F);
            this.characterDataLabel2.ForeColor = System.Drawing.Color.White;
            this.characterDataLabel2.Location = new System.Drawing.Point(361, 87);
            this.characterDataLabel2.Name = "characterDataLabel2";
            this.characterDataLabel2.Size = new System.Drawing.Size(217, 224);
            this.characterDataLabel2.TabIndex = 9;
            this.characterDataLabel2.Text = "XP rank:    Error\r\nExpl. rank: Error\r\nMob kills:  Error\r\nAdv. kills: Error";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(579, 388);
            this.tabControl.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.characterDataLabel2);
            this.tabPage1.Controls.Add(this.playerDataLabel);
            this.tabPage1.Controls.Add(this.lookupButton);
            this.tabPage1.Controls.Add(this.nameLabel);
            this.tabPage1.Controls.Add(this.playersVisibleLabel);
            this.tabPage1.Controls.Add(this.lookupTextBox);
            this.tabPage1.Controls.Add(this.nameListBox);
            this.tabPage1.Controls.Add(this.refreshButton);
            this.tabPage1.Controls.Add(this.characterDataLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(603, 412);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jayden\'s Achaea Snooper (alpha)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label playersVisibleLabel;
        private System.Windows.Forms.Label playerDataLabel;
        private System.Windows.Forms.TextBox lookupTextBox;
        private System.Windows.Forms.Button lookupButton;
        private System.Windows.Forms.Label characterDataLabel1;
        private System.Windows.Forms.Label characterDataLabel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

