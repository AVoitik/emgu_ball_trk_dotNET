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
            this.ballDetect = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.play_butt = new System.Windows.Forms.Button();
            this.pause_butt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.obj_count = new System.Windows.Forms.Label();
            this.spX = new System.Windows.Forms.Label();
            this.spY = new System.Windows.Forms.Label();
            this.spT = new System.Windows.Forms.Label();
            this.dX = new System.Windows.Forms.Label();
            this.dY = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bbh = new System.Windows.Forms.Label();
            this.bbw = new System.Windows.Forms.Label();
            this.bdnum = new System.Windows.Forms.Label();
            this.speedList = new System.Windows.Forms.RichTextBox();
            this.dump_velo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(9, 37);
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
            this.groupBox2.Controls.Add(this.ballDetect);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(456, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 67);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // ballDetect
            // 
            this.ballDetect.AutoSize = true;
            this.ballDetect.Location = new System.Drawing.Point(6, 39);
            this.ballDetect.Name = "ballDetect";
            this.ballDetect.Size = new System.Drawing.Size(114, 21);
            this.ballDetect.TabIndex = 1;
            this.ballDetect.Text = "Ball Detected";
            this.ballDetect.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 12);
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
            // obj_count
            // 
            this.obj_count.AutoSize = true;
            this.obj_count.Location = new System.Drawing.Point(97, 37);
            this.obj_count.Name = "obj_count";
            this.obj_count.Size = new System.Drawing.Size(106, 17);
            this.obj_count.TabIndex = 18;
            this.obj_count.Text = "Object Count: 0";
            // 
            // spX
            // 
            this.spX.AutoSize = true;
            this.spX.Location = new System.Drawing.Point(457, 388);
            this.spX.Name = "spX";
            this.spX.Size = new System.Drawing.Size(70, 17);
            this.spX.TabIndex = 19;
            this.spX.Text = "SpeedX : ";
            // 
            // spY
            // 
            this.spY.AutoSize = true;
            this.spY.Location = new System.Drawing.Point(460, 409);
            this.spY.Name = "spY";
            this.spY.Size = new System.Drawing.Size(66, 17);
            this.spY.TabIndex = 20;
            this.spY.Text = "SpeedY: ";
            // 
            // spT
            // 
            this.spT.AutoSize = true;
            this.spT.Location = new System.Drawing.Point(462, 443);
            this.spT.Name = "spT";
            this.spT.Size = new System.Drawing.Size(91, 17);
            this.spT.TabIndex = 21;
            this.spT.Text = "Final Speed: ";
            // 
            // dX
            // 
            this.dX.AutoSize = true;
            this.dX.Location = new System.Drawing.Point(555, 303);
            this.dX.Name = "dX";
            this.dX.Size = new System.Drawing.Size(48, 17);
            this.dX.TabIndex = 22;
            this.dX.Text = "deltaX";
            // 
            // dY
            // 
            this.dY.AutoSize = true;
            this.dY.Location = new System.Drawing.Point(555, 345);
            this.dY.Name = "dY";
            this.dY.Size = new System.Drawing.Size(50, 17);
            this.dY.TabIndex = 23;
            this.dY.Text = "DeltaY";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bdnum);
            this.groupBox3.Controls.Add(this.bbw);
            this.groupBox3.Controls.Add(this.bbh);
            this.groupBox3.Location = new System.Drawing.Point(631, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 233);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BBH & W";
            // 
            // bbh
            // 
            this.bbh.AutoSize = true;
            this.bbh.Location = new System.Drawing.Point(7, 37);
            this.bbh.Name = "bbh";
            this.bbh.Size = new System.Drawing.Size(57, 17);
            this.bbh.TabIndex = 0;
            this.bbh.Text = "Height: ";
            // 
            // bbw
            // 
            this.bbw.AutoSize = true;
            this.bbw.Location = new System.Drawing.Point(6, 64);
            this.bbw.Name = "bbw";
            this.bbw.Size = new System.Drawing.Size(52, 17);
            this.bbw.TabIndex = 1;
            this.bbw.Text = "Width: ";
            // 
            // bdnum
            // 
            this.bdnum.AutoSize = true;
            this.bdnum.Location = new System.Drawing.Point(6, 93);
            this.bdnum.Name = "bdnum";
            this.bdnum.Size = new System.Drawing.Size(64, 17);
            this.bdnum.TabIndex = 2;
            this.bdnum.Text = "BDNum: ";
            // 
            // speedList
            // 
            this.speedList.Location = new System.Drawing.Point(631, 297);
            this.speedList.Name = "speedList";
            this.speedList.Size = new System.Drawing.Size(157, 190);
            this.speedList.TabIndex = 25;
            this.speedList.Text = "";
            // 
            // dump_velo
            // 
            this.dump_velo.Location = new System.Drawing.Point(608, 12);
            this.dump_velo.Name = "dump_velo";
            this.dump_velo.Size = new System.Drawing.Size(93, 36);
            this.dump_velo.TabIndex = 26;
            this.dump_velo.Text = "Dump";
            this.dump_velo.UseVisualStyleBackColor = true;
            this.dump_velo.Click += new System.EventHandler(this.dump_velo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1109, 499);
            this.ControlBox = false;
            this.Controls.Add(this.dump_velo);
            this.Controls.Add(this.speedList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dY);
            this.Controls.Add(this.dX);
            this.Controls.Add(this.spT);
            this.Controls.Add(this.spY);
            this.Controls.Add(this.spX);
            this.Controls.Add(this.obj_count);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label obj_count;
        private System.Windows.Forms.Label spX;
        private System.Windows.Forms.Label spY;
        private System.Windows.Forms.Label spT;
        private System.Windows.Forms.CheckBox ballDetect;
        private System.Windows.Forms.Label dX;
        private System.Windows.Forms.Label dY;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label bbw;
        private System.Windows.Forms.Label bbh;
        private System.Windows.Forms.Label bdnum;
        private System.Windows.Forms.RichTextBox speedList;
        private System.Windows.Forms.Button dump_velo;
    }
}

