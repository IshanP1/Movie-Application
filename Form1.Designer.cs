namespace reward_pointsssssss
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
            this.textBoxMovie = new System.Windows.Forms.TextBox();
            this.checkBox3D = new System.Windows.Forms.CheckBox();
            this.checkBoxDelux = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.listBoxViewing = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxSummary = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMovie
            // 
            this.textBoxMovie.Location = new System.Drawing.Point(71, 96);
            this.textBoxMovie.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxMovie.Name = "textBoxMovie";
            this.textBoxMovie.Size = new System.Drawing.Size(210, 20);
            this.textBoxMovie.TabIndex = 0;
            // 
            // checkBox3D
            // 
            this.checkBox3D.AutoSize = true;
            this.checkBox3D.Location = new System.Drawing.Point(71, 122);
            this.checkBox3D.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.checkBox3D.Name = "checkBox3D";
            this.checkBox3D.Size = new System.Drawing.Size(40, 17);
            this.checkBox3D.TabIndex = 1;
            this.checkBox3D.Text = "3D";
            this.checkBox3D.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelux
            // 
            this.checkBoxDelux.AutoSize = true;
            this.checkBoxDelux.Location = new System.Drawing.Point(71, 150);
            this.checkBoxDelux.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.checkBoxDelux.Name = "checkBoxDelux";
            this.checkBoxDelux.Size = new System.Drawing.Size(53, 17);
            this.checkBoxDelux.TabIndex = 2;
            this.checkBoxDelux.Text = "Delux";
            this.checkBoxDelux.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 177);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(102, 289);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 47);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate Points";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // listBoxViewing
            // 
            this.listBoxViewing.Font = new System.Drawing.Font("Consolas", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxViewing.FormattingEnabled = true;
            this.listBoxViewing.Location = new System.Drawing.Point(303, 33);
            this.listBoxViewing.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.listBoxViewing.Name = "listBoxViewing";
            this.listBoxViewing.Size = new System.Drawing.Size(747, 212);
            this.listBoxViewing.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1337, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 22);
            this.fileToolStripMenuItem.Text = "file";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // listBoxSummary
            // 
            this.listBoxSummary.Font = new System.Drawing.Font("Consolas", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSummary.FormattingEnabled = true;
            this.listBoxSummary.Location = new System.Drawing.Point(303, 267);
            this.listBoxSummary.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxSummary.Name = "listBoxSummary";
            this.listBoxSummary.Size = new System.Drawing.Size(532, 212);
            this.listBoxSummary.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 569);
            this.Controls.Add(this.listBoxSummary);
            this.Controls.Add(this.listBoxViewing);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxDelux);
            this.Controls.Add(this.checkBox3D);
            this.Controls.Add(this.textBoxMovie);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMovie;
        private System.Windows.Forms.CheckBox checkBox3D;
        private System.Windows.Forms.CheckBox checkBoxDelux;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ListBox listBoxViewing;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxSummary;
    }
}

