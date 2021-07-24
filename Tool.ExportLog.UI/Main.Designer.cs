
namespace Tool.ExportLog.UI
{
    partial class form_main
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
            this.pn_main = new System.Windows.Forms.Panel();
            this.chooseFolderOutput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextOutput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richtextActivityTime = new System.Windows.Forms.RichTextBox();
            this.pn_toolbar = new System.Windows.Forms.Panel();
            this.chooseFolderInput = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAppPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_folder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.pn_top = new System.Windows.Forms.Panel();
            this.lb_copyright = new System.Windows.Forms.Label();
            this.folderBrowserDialogInput = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.lbGuide = new System.Windows.Forms.Label();
            this.pn_main.SuspendLayout();
            this.pn_toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.Beige;
            this.pn_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pn_main.Controls.Add(this.chooseFolderOutput);
            this.pn_main.Controls.Add(this.txtOutput);
            this.pn_main.Controls.Add(this.label4);
            this.pn_main.Controls.Add(this.richTextOutput);
            this.pn_main.Controls.Add(this.label3);
            this.pn_main.Controls.Add(this.richtextActivityTime);
            this.pn_main.Controls.Add(this.pn_toolbar);
            this.pn_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 0);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(800, 623);
            this.pn_main.TabIndex = 1;
            // 
            // chooseFolderOutput
            // 
            this.chooseFolderOutput.Location = new System.Drawing.Point(569, 388);
            this.chooseFolderOutput.Name = "chooseFolderOutput";
            this.chooseFolderOutput.Size = new System.Drawing.Size(95, 25);
            this.chooseFolderOutput.TabIndex = 13;
            this.chooseFolderOutput.Text = "Choose Folder";
            this.chooseFolderOutput.UseVisualStyleBackColor = true;
            this.chooseFolderOutput.Click += new System.EventHandler(this.chooseFolderOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutput.Location = new System.Drawing.Point(31, 388);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(532, 25);
            this.txtOutput.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro Cond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(28, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Outputs";
            // 
            // richTextOutput
            // 
            this.richTextOutput.BackColor = System.Drawing.SystemColors.Info;
            this.richTextOutput.Location = new System.Drawing.Point(31, 419);
            this.richTextOutput.Name = "richTextOutput";
            this.richTextOutput.Size = new System.Drawing.Size(738, 134);
            this.richTextOutput.TabIndex = 10;
            this.richTextOutput.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Cond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Activity time:";
            // 
            // richtextActivityTime
            // 
            this.richtextActivityTime.BackColor = System.Drawing.Color.White;
            this.richtextActivityTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtextActivityTime.Location = new System.Drawing.Point(31, 138);
            this.richtextActivityTime.Name = "richtextActivityTime";
            this.richtextActivityTime.Size = new System.Drawing.Size(738, 189);
            this.richtextActivityTime.TabIndex = 8;
            this.richtextActivityTime.Text = "";
            // 
            // pn_toolbar
            // 
            this.pn_toolbar.BackColor = System.Drawing.Color.Beige;
            this.pn_toolbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pn_toolbar.Controls.Add(this.chooseFolderInput);
            this.pn_toolbar.Controls.Add(this.pictureBox1);
            this.pn_toolbar.Controls.Add(this.txtAppPath);
            this.pn_toolbar.Controls.Add(this.label2);
            this.pn_toolbar.Controls.Add(this.lb_folder);
            this.pn_toolbar.Controls.Add(this.label1);
            this.pn_toolbar.Controls.Add(this.btnExportToExcel);
            this.pn_toolbar.Controls.Add(this.toDate);
            this.pn_toolbar.Controls.Add(this.fromDate);
            this.pn_toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_toolbar.Location = new System.Drawing.Point(0, 0);
            this.pn_toolbar.Name = "pn_toolbar";
            this.pn_toolbar.Size = new System.Drawing.Size(800, 100);
            this.pn_toolbar.TabIndex = 7;
            // 
            // chooseFolderInput
            // 
            this.chooseFolderInput.Location = new System.Drawing.Point(560, 22);
            this.chooseFolderInput.Name = "chooseFolderInput";
            this.chooseFolderInput.Size = new System.Drawing.Size(95, 25);
            this.chooseFolderInput.TabIndex = 7;
            this.chooseFolderInput.Text = "Choose Folder";
            this.chooseFolderInput.UseVisualStyleBackColor = true;
            this.chooseFolderInput.Click += new System.EventHandler(this.chooseFolderInput_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tool.ExportLog.UI.Properties.Resources.logo_927730ab;
            this.pictureBox1.Location = new System.Drawing.Point(707, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtAppPath
            // 
            this.txtAppPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAppPath.Location = new System.Drawing.Point(71, 22);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.Size = new System.Drawing.Size(483, 25);
            this.txtAppPath.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(314, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // lb_folder
            // 
            this.lb_folder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_folder.AutoSize = true;
            this.lb_folder.Font = new System.Drawing.Font("Myriad Pro Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_folder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_folder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_folder.Location = new System.Drawing.Point(28, 22);
            this.lb_folder.Name = "lb_folder";
            this.lb_folder.Size = new System.Drawing.Size(37, 18);
            this.lb_folder.TabIndex = 1;
            this.lb_folder.Text = "Folder";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportToExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExportToExcel.Font = new System.Drawing.Font("Myriad Pro Cond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExportToExcel.Location = new System.Drawing.Point(560, 54);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(209, 43);
            this.btnExportToExcel.TabIndex = 2;
            this.btnExportToExcel.Text = "Start Export";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // toDate
            // 
            this.toDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toDate.Location = new System.Drawing.Point(354, 54);
            this.toDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(200, 25);
            this.toDate.TabIndex = 4;
            // 
            // fromDate
            // 
            this.fromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromDate.Location = new System.Drawing.Point(71, 54);
            this.fromDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(200, 25);
            this.fromDate.TabIndex = 3;
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.SystemColors.Control;
            this.pn_top.Controls.Add(this.lbGuide);
            this.pn_top.Controls.Add(this.lb_copyright);
            this.pn_top.Cursor = System.Windows.Forms.Cursors.Default;
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_top.ForeColor = System.Drawing.Color.Transparent;
            this.pn_top.Location = new System.Drawing.Point(0, 585);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(800, 38);
            this.pn_top.TabIndex = 2;
            // 
            // lb_copyright
            // 
            this.lb_copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_copyright.AutoSize = true;
            this.lb_copyright.ForeColor = System.Drawing.Color.Gray;
            this.lb_copyright.Location = new System.Drawing.Point(462, 11);
            this.lb_copyright.Name = "lb_copyright";
            this.lb_copyright.Size = new System.Drawing.Size(307, 18);
            this.lb_copyright.TabIndex = 0;
            this.lb_copyright.Text = "Copyright ©  2021 Project - All Rights Reserved - writed by namnv";
            this.lb_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGuide
            // 
            this.lbGuide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGuide.AutoSize = true;
            this.lbGuide.BackColor = System.Drawing.Color.Transparent;
            this.lbGuide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGuide.Font = new System.Drawing.Font("Myriad Pro Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGuide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbGuide.Location = new System.Drawing.Point(28, 11);
            this.lbGuide.Name = "lbGuide";
            this.lbGuide.Size = new System.Drawing.Size(97, 20);
            this.lbGuide.TabIndex = 2;
            this.lbGuide.Text = "Guide how use tool";
            this.lbGuide.Click += new System.EventHandler(this.lbGuide_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.pn_top);
            this.Controls.Add(this.pn_main);
            this.Font = new System.Drawing.Font("Myriad Pro Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A Small Tool for Support Export Log DCS-Mobile";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.pn_main.ResumeLayout(false);
            this.pn_main.PerformLayout();
            this.pn_toolbar.ResumeLayout(false);
            this.pn_toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_top.ResumeLayout(false);
            this.pn_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.Label lb_copyright;
        private System.Windows.Forms.Label lb_folder;
        private System.Windows.Forms.TextBox txtAppPath;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richtextActivityTime;
        private System.Windows.Forms.Panel pn_toolbar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogInput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
        private System.Windows.Forms.Button chooseFolderInput;
        private System.Windows.Forms.Button chooseFolderOutput;
        private System.Windows.Forms.Label lbGuide;
    }
}

