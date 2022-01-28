
namespace MaterialCreator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MakeBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BrightNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.HeightNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.WidthNum = new System.Windows.Forms.NumericUpDown();
            this.PrevImg = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NormalImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AlbedoImg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbedoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MakeBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BrightNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.HeightNum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.WidthNum);
            this.panel1.Controls.Add(this.PrevImg);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NormalImg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AlbedoImg);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 378);
            this.panel1.TabIndex = 0;
            // 
            // MakeBtn
            // 
            this.MakeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MakeBtn.Location = new System.Drawing.Point(141, 105);
            this.MakeBtn.Name = "MakeBtn";
            this.MakeBtn.Size = new System.Drawing.Size(75, 23);
            this.MakeBtn.TabIndex = 13;
            this.MakeBtn.Text = "Save";
            this.MakeBtn.UseVisualStyleBackColor = true;
            this.MakeBtn.Click += new System.EventHandler(this.MakeBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bright";
            // 
            // BrightNum
            // 
            this.BrightNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BrightNum.Location = new System.Drawing.Point(180, 78);
            this.BrightNum.Name = "BrightNum";
            this.BrightNum.Size = new System.Drawing.Size(38, 20);
            this.BrightNum.TabIndex = 11;
            this.BrightNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BrightNum.ValueChanged += new System.EventHandler(this.BrightNum_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Height";
            // 
            // HeightNum
            // 
            this.HeightNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HeightNum.Location = new System.Drawing.Point(180, 55);
            this.HeightNum.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.HeightNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNum.Name = "HeightNum";
            this.HeightNum.Size = new System.Drawing.Size(44, 20);
            this.HeightNum.TabIndex = 9;
            this.HeightNum.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.HeightNum.ValueChanged += new System.EventHandler(this.HeightNum_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Width";
            // 
            // WidthNum
            // 
            this.WidthNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WidthNum.Location = new System.Drawing.Point(180, 32);
            this.WidthNum.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.WidthNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNum.Name = "WidthNum";
            this.WidthNum.Size = new System.Drawing.Size(44, 20);
            this.WidthNum.TabIndex = 7;
            this.WidthNum.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.WidthNum.ValueChanged += new System.EventHandler(this.WidthNum_ValueChanged);
            // 
            // PrevImg
            // 
            this.PrevImg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PrevImg.Location = new System.Drawing.Point(2, 131);
            this.PrevImg.Name = "PrevImg";
            this.PrevImg.Size = new System.Drawing.Size(354, 244);
            this.PrevImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrevImg.TabIndex = 6;
            this.PrevImg.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Normal";
            // 
            // NormalImg
            // 
            this.NormalImg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NormalImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NormalImg.Location = new System.Drawing.Point(253, 41);
            this.NormalImg.Name = "NormalImg";
            this.NormalImg.Size = new System.Drawing.Size(103, 84);
            this.NormalImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NormalImg.TabIndex = 4;
            this.NormalImg.TabStop = false;
            this.NormalImg.Click += new System.EventHandler(this.NormalImg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Albedo";
            // 
            // AlbedoImg
            // 
            this.AlbedoImg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AlbedoImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlbedoImg.Location = new System.Drawing.Point(2, 41);
            this.AlbedoImg.Name = "AlbedoImg";
            this.AlbedoImg.Size = new System.Drawing.Size(103, 84);
            this.AlbedoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlbedoImg.TabIndex = 0;
            this.AlbedoImg.TabStop = false;
            this.AlbedoImg.Click += new System.EventHandler(this.AlbedoImg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(141, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Material Maker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 377);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Maker 1.0";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbedoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox AlbedoImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox NormalImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PrevImg;
        private System.Windows.Forms.Button MakeBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown BrightNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown HeightNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown WidthNum;
        private System.Windows.Forms.Label label2;
    }
}

