namespace OpenCVWinForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Right = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.Label();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cameratxt = new System.Windows.Forms.Label();
            this.VedioCapWindow = new System.Windows.Forms.PictureBox();
            this.pctRightEye = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pctLeftEye = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblobjectmovement = new System.Windows.Forms.Label();
            this.box = new System.Windows.Forms.Panel();
            this.movable = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VedioCapWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRightEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeftEye)).BeginInit();
            this.box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Right);
            this.panel1.Controls.Add(this.Left);
            this.panel1.Controls.Add(this.btnSaveImage);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 615);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 40);
            this.panel1.TabIndex = 0;
            // 
            // Right
            // 
            this.Right.AutoSize = true;
            this.Right.Location = new System.Drawing.Point(381, 12);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(0, 13);
            this.Right.TabIndex = 3;
            // 
            // Left
            // 
            this.Left.AutoSize = true;
            this.Left.Location = new System.Drawing.Point(325, 12);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(0, 13);
            this.Left.TabIndex = 2;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(84, 7);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(95, 23);
            this.btnSaveImage.TabIndex = 1;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.Filter = "JPEG|*.jpg";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 615);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(924, 615);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(84, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 86);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 67);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 92);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cameratxt);
            this.splitContainer1.Panel1.Controls.Add(this.VedioCapWindow);
            this.splitContainer1.Panel1.Controls.Add(this.pctRightEye);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.pctLeftEye);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel2.Controls.Add(this.lblobjectmovement);
            this.splitContainer1.Panel2.Controls.Add(this.box);
            this.splitContainer1.Size = new System.Drawing.Size(924, 520);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.TabIndex = 6;
            // 
            // cameratxt
            // 
            this.cameratxt.AutoSize = true;
            this.cameratxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameratxt.Location = new System.Drawing.Point(112, 4);
            this.cameratxt.Name = "cameratxt";
            this.cameratxt.Size = new System.Drawing.Size(187, 31);
            this.cameratxt.TabIndex = 5;
            this.cameratxt.Text = "Camera View";
            // 
            // VedioCapWindow
            // 
            this.VedioCapWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VedioCapWindow.Location = new System.Drawing.Point(3, 51);
            this.VedioCapWindow.Name = "VedioCapWindow";
            this.VedioCapWindow.Size = new System.Drawing.Size(450, 318);
            this.VedioCapWindow.TabIndex = 0;
            this.VedioCapWindow.TabStop = false;
            this.VedioCapWindow.Click += new System.EventHandler(this.pctCvWindow_Click);
            // 
            // pctRightEye
            // 
            this.pctRightEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctRightEye.Location = new System.Drawing.Point(232, 430);
            this.pctRightEye.Name = "pctRightEye";
            this.pctRightEye.Size = new System.Drawing.Size(219, 81);
            this.pctRightEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRightEye.TabIndex = 2;
            this.pctRightEye.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "LeftEye";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pctLeftEye
            // 
            this.pctLeftEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctLeftEye.Location = new System.Drawing.Point(12, 430);
            this.pctLeftEye.Name = "pctLeftEye";
            this.pctLeftEye.Size = new System.Drawing.Size(212, 81);
            this.pctLeftEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLeftEye.TabIndex = 1;
            this.pctLeftEye.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "RightEye";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(3, 482);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Select cursor movement";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblobjectmovement
            // 
            this.lblobjectmovement.AutoSize = true;
            this.lblobjectmovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobjectmovement.Location = new System.Drawing.Point(79, 4);
            this.lblobjectmovement.Name = "lblobjectmovement";
            this.lblobjectmovement.Size = new System.Drawing.Size(312, 31);
            this.lblobjectmovement.TabIndex = 6;
            this.lblobjectmovement.Text = "Object Movement View";
            // 
            // box
            // 
            this.box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box.BackColor = System.Drawing.Color.Gainsboro;
            this.box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box.Controls.Add(this.movable);
            this.box.Location = new System.Drawing.Point(3, 51);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(452, 402);
            this.box.TabIndex = 5;
            // 
            // movable
            // 
            this.movable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movable.Image = ((System.Drawing.Image)(resources.GetObject("movable.Image")));
            this.movable.Location = new System.Drawing.Point(167, 127);
            this.movable.Name = "movable";
            this.movable.Size = new System.Drawing.Size(42, 38);
            this.movable.TabIndex = 0;
            this.movable.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Eye Tracking System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VedioCapWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRightEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeftEye)).EndInit();
            this.box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movable)).EndInit();
            this.ResumeLayout(false);

        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox VedioCapWindow;
        private System.Windows.Forms.Label Right;
        private System.Windows.Forms.Label Left;
        private System.Windows.Forms.PictureBox pctRightEye;
        private System.Windows.Forms.PictureBox pctLeftEye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel box;
        private System.Windows.Forms.PictureBox movable;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label cameratxt;
        private System.Windows.Forms.Label lblobjectmovement;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

