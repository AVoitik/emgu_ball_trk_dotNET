namespace emgu_ball_trk_dotNET
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
            this.components = new System.ComponentModel.Container();
            this.start_button = new System.Windows.Forms.Button();
            this.file_box = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.next_butt = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorVid = new System.Windows.Forms.RadioButton();
            this.grayVid = new System.Windows.Forms.RadioButton();
            this.stepButton = new System.Windows.Forms.Button();
            this.diffRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.thr_radio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.play_butt = new System.Windows.Forms.Button();
            this.pause_butt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(212, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(92, 36);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Begin";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // file_box
            // 
            this.file_box.Location = new System.Drawing.Point(12, 12);
            this.file_box.Name = "file_box";
            this.file_box.Size = new System.Drawing.Size(194, 22);
            this.file_box.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // next_butt
            // 
            this.next_butt.Location = new System.Drawing.Point(509, 12);
            this.next_butt.Name = "next_butt";
            this.next_butt.Size = new System.Drawing.Size(92, 36);
            this.next_butt.TabIndex = 7;
            this.next_butt.Text = "Close";
            this.next_butt.UseVisualStyleBackColor = true;
            this.next_butt.Click += new System.EventHandler(this.next_butt_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 57);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(438, 446);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Frame 0/0";
            // 
            // colorVid
            // 
            this.colorVid.AutoSize = true;
            this.colorVid.Location = new System.Drawing.Point(9, 37);
            this.colorVid.Name = "colorVid";
            this.colorVid.Size = new System.Drawing.Size(102, 21);
            this.colorVid.TabIndex = 9;
            this.colorVid.TabStop = true;
            this.colorVid.Text = "Color Video";
            this.colorVid.UseVisualStyleBackColor = true;
            // 
            // grayVid
            // 
            this.grayVid.AutoSize = true;
            this.grayVid.Location = new System.Drawing.Point(9, 64);
            this.grayVid.Name = "grayVid";
            this.grayVid.Size = new System.Drawing.Size(93, 21);
            this.grayVid.TabIndex = 10;
            this.grayVid.TabStop = true;
            this.grayVid.Text = "Grayscale";
            this.grayVid.UseVisualStyleBackColor = true;
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(411, 12);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(92, 36);
            this.stepButton.TabIndex = 11;
            this.stepButton.Text = "Forward";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // diffRadio
            // 
            this.diffRadio.AutoSize = true;
            this.diffRadio.Location = new System.Drawing.Point(9, 91);
            this.diffRadio.Name = "diffRadio";
            this.diffRadio.Size = new System.Drawing.Size(94, 21);
            this.diffRadio.TabIndex = 12;
            this.diffRadio.TabStop = true;
            this.diffRadio.Text = "Difference";
            this.diffRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thr_radio);
            this.groupBox1.Controls.Add(this.colorVid);
            this.groupBox1.Controls.Add(this.grayVid);
            this.groupBox1.Controls.Add(this.diffRadio);
            this.groupBox1.Location = new System.Drawing.Point(456, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 167);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Types";
            // 
            // thr_radio
            // 
            this.thr_radio.AutoSize = true;
            this.thr_radio.Location = new System.Drawing.Point(9, 118);
            this.thr_radio.Name = "thr_radio";
            this.thr_radio.Size = new System.Drawing.Size(93, 21);
            this.thr_radio.TabIndex = 13;
            this.thr_radio.TabStop = true;
            this.thr_radio.Text = "Threshold";
            this.thr_radio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(456, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 67);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Bounding Box";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // play_butt
            // 
            this.play_butt.Location = new System.Drawing.Point(456, 303);
            this.play_butt.Name = "play_butt";
            this.play_butt.Size = new System.Drawing.Size(92, 36);
            this.play_butt.TabIndex = 16;
            this.play_butt.Text = "Play";
            this.play_butt.UseVisualStyleBackColor = true;
            this.play_butt.Click += new System.EventHandler(this.play_butt_Click);
            // 
            // pause_butt
            // 
            this.pause_butt.Location = new System.Drawing.Point(456, 345);
            this.pause_butt.Name = "pause_butt";
            this.pause_butt.Size = new System.Drawing.Size(92, 36);
            this.pause_butt.TabIndex = 17;
            this.pause_butt.Text = "Pause";
            this.pause_butt.UseVisualStyleBackColor = true;
            this.pause_butt.Click += new System.EventHandler(this.pause_butt_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1109, 499);
            this.ControlBox = false;
            this.Controls.Add(this.pause_butt);
            this.Controls.Add(this.play_butt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.next_butt);
            this.Controls.Add(this.file_box);
            this.Controls.Add(this.start_button);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ball Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TextBox file_box;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button next_butt;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton colorVid;
        private System.Windows.Forms.RadioButton grayVid;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.RadioButton diffRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton thr_radio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button play_butt;
        private System.Windows.Forms.Button pause_butt;
        private System.Windows.Forms.Timer timer1;
    }
}

