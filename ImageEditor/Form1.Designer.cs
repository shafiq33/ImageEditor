namespace ImageEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            label2 = new Label();
            trackBar3 = new TrackBar();
            label3 = new Label();
            button8 = new Button();
            button9 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1071, 544);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1077, 28);
            button1.Name = "button1";
            button1.Size = new Size(152, 48);
            button1.TabIndex = 1;
            button1.Text = "Reload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1077, 82);
            button2.Name = "button2";
            button2.Size = new Size(152, 49);
            button2.TabIndex = 2;
            button2.Text = "Filter1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1077, 137);
            button3.Name = "button3";
            button3.Size = new Size(152, 49);
            button3.TabIndex = 3;
            button3.Text = "Filter2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1077, 192);
            button4.Name = "button4";
            button4.Size = new Size(152, 49);
            button4.TabIndex = 4;
            button4.Text = "Filter3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1077, 247);
            button5.Name = "button5";
            button5.Size = new Size(152, 49);
            button5.TabIndex = 5;
            button5.Text = "Filter4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1077, 302);
            button6.Name = "button6";
            button6.Size = new Size(152, 49);
            button6.TabIndex = 6;
            button6.Text = "Filter5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1077, 357);
            button7.Name = "button7";
            button7.Size = new Size(152, 49);
            button7.TabIndex = 7;
            button7.Text = "Filter6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 564);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 8;
            label1.Text = "RED";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(71, 564);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(1000, 45);
            trackBar1.TabIndex = 9;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(71, 591);
            trackBar2.Maximum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(1000, 45);
            trackBar2.TabIndex = 11;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 589);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 10;
            label2.Text = "GREEN";
            label2.Click += label2_Click;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(71, 619);
            trackBar3.Maximum = 100;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(1000, 45);
            trackBar3.TabIndex = 13;
            trackBar3.Scroll += trackBar3_Scroll;
            trackBar3.ValueChanged += trackBar3_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 615);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 12;
            label3.Text = "BLUE";
            label3.Click += label3_Click;
            // 
            // button8
            // 
            button8.Location = new Point(1077, 541);
            button8.Name = "button8";
            button8.Size = new Size(152, 60);
            button8.TabIndex = 14;
            button8.Text = "Save Image";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(1077, 607);
            button9.Name = "button9";
            button9.Size = new Size(152, 61);
            button9.TabIndex = 15;
            button9.Text = "Open Image";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 678);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(trackBar3);
            Controls.Add(label3);
            Controls.Add(trackBar2);
            Controls.Add(label2);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label2;
        private TrackBar trackBar3;
        private Label label3;
        private Button button8;
        private Button button9;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
