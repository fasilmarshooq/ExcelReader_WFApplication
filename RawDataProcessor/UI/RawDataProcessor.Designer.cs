namespace RawDataProcessor
{
    partial class RawDataProcessorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawDataProcessorForm));
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Location = new System.Windows.Forms.Label();
            this.rawData = new System.Windows.Forms.Label();
            this.loationtextBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.processedData = new System.Windows.Forms.TextBox();
            this.processBtn = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelFooter.Controls.Add(this.label1);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 426);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(383, 24);
            this.panelFooter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "© Buddy Solutions All Rights Reserved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Location);
            this.groupBox1.Controls.Add(this.rawData);
            this.groupBox1.Controls.Add(this.loationtextBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(45, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.Location = new System.Drawing.Point(21, 22);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(59, 16);
            this.Location.TabIndex = 3;
            this.Location.Text = "Location";
            // 
            // rawData
            // 
            this.rawData.AutoSize = true;
            this.rawData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawData.Location = new System.Drawing.Point(21, 59);
            this.rawData.Name = "rawData";
            this.rawData.Size = new System.Drawing.Size(67, 16);
            this.rawData.TabIndex = 2;
            this.rawData.Text = "Raw Data";
            // 
            // loationtextBox
            // 
            this.loationtextBox.FormattingEnabled = true;
            this.loationtextBox.Items.AddRange(new object[] {
            "CAN",
            "US"});
            this.loationtextBox.Location = new System.Drawing.Point(117, 21);
            this.loationtextBox.Name = "loationtextBox";
            this.loationtextBox.Size = new System.Drawing.Size(153, 21);
            this.loationtextBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // processedData
            // 
            this.processedData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.processedData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processedData.ForeColor = System.Drawing.Color.Lime;
            this.processedData.Location = new System.Drawing.Point(99, 243);
            this.processedData.Multiline = true;
            this.processedData.Name = "processedData";
            this.processedData.ReadOnly = true;
            this.processedData.Size = new System.Drawing.Size(187, 20);
            this.processedData.TabIndex = 3;
            // 
            // processBtn
            // 
            this.processBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.processBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.processBtn.Location = new System.Drawing.Point(150, 214);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(75, 23);
            this.processBtn.TabIndex = 4;
            this.processBtn.Text = "Process";
            this.processBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.processBtn.UseVisualStyleBackColor = false;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.messageBox.Location = new System.Drawing.Point(99, 400);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(187, 20);
            this.messageBox.TabIndex = 5;
            // 
            // RawDataProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.processedData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RawDataProcessorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RawDataProcessor";
            this.Load += new System.EventHandler(this.RawDataProcessor_Load);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label rawData;
        private System.Windows.Forms.ComboBox loationtextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox processedData;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.TextBox messageBox;
    }
}