using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;
using System;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace emgu_ball_trk_dotNET
{


    public partial class Form1 : Form
    {
        private bool videoPause = true;

        private VideoCapture vc = null;
        private bool cp = false;
        private Mat fr;
        private Mat backGround;
        private Mat grayBack;
        private Mat gf;
        private Mat heirarchy;
        private Mat playVideo;

        private Image<Gray, Byte> diff;
        private Image<Gray, Byte> thr;
        private Image<Gray, Byte> thrNew;
        private Image<Gray, Byte> thrCpy;
        private Image<Gray, Byte> frNew;

        private Image<Gray, Byte> img1;
        private Image<Gray, Byte> img2;

        private Image<Bgr, Byte> img3;

        private int frameCounter = 1;
        private double frameNumber;

        private int oldX = 0;
        private int oldY = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick_1;
            //don't want to use openCL
            CvInvoke.UseOpenCL = false;

            //Select video to play
            SelectVideoFile();

            this.TopMost = true;

            try
            {
                vc = new VideoCapture(file_box.Text);
                frameNumber = vc.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                

            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            fr = new Mat();
            gf = new Mat();
            grayBack = new Mat();
            backGround = new Mat();
            heirarchy = new Mat();
            playVideo = new Mat();
        }

        private void SelectVideoFile()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                file_box.Text = openFileDialog1.FileName;
                grayVid.Checked = true;
                stepButton.Enabled = false;
                button1.Enabled = false;
                pause_butt.Enabled = false;
                play_butt.Enabled = false;
                checkBox1.Enabled = true;
            }
            
        }

        private void ProcessFrame()
        {
            frameCounter = frameCounter + 1;
            if (vc != null && vc.Ptr != IntPtr.Zero)
            {
                vc.Retrieve(fr, 0);
                CvInvoke.CvtColor(fr, gf, ColorConversion.Bgr2Gray);
                
                img2 = gf.ToImage<Gray, Byte>();
                diff = img1.AbsDiff(img2);
                thr = diff.ThresholdBinary(new Gray(20), new Gray(255));
                thrNew = diff.ThresholdBinary(new Gray(20), new Gray(255));
                
                CvInvoke.BilateralFilter(thr, thrNew, 11, 17, 17);
                CvInvoke.Erode(thrNew, thrNew, null, new Point(-1, -1), 2, BorderType.Constant, CvInvoke.MorphologyDefaultBorderValue);
                CvInvoke.Dilate(thrNew, thrNew, null, new Point(-1, -1), 2, BorderType.Constant, CvInvoke.MorphologyDefaultBorderValue);
                thrCpy = thrNew;
                
                MCvMoments mom = new MCvMoments();
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                CvInvoke.FindContours(thrCpy, contours, null, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                for (int i = 0; i < contours.Size; i++)
                {
                    mom = CvInvoke.Moments(contours[i]);
                    if (mom.M00 != 0)
                    {
                        int cX = (int)((mom.M10) / (mom.M00));
                        int cY = (int)((mom.M01) / (mom.M00));

                        Rectangle pointRect = new Rectangle();

                        pointRect = CvInvoke.BoundingRectangle(contours[i]);

                        if (pointRect.Height > 6 && pointRect.Width > 6)
                        {
                            int deltaX = (pointRect.X + (pointRect.Width / 2) - oldX);
                            int deltaY = (pointRect.Y + (pointRect.Height / 2) - oldY);

                            if (((pointRect.X > 16) || (pointRect.X > 496)) && ((pointRect.Y > 16) || (pointRect.Y > 624)))
                            {

                                
                                int bd;

                                if (pointRect.Width > pointRect.Height)
                                {
                                    bd = pointRect.Width;
                                }
                                else if (pointRect.Height > pointRect.Width)
                                {
                                    bd = pointRect.Height;
                                }
                                else
                                {
                                    bd = pointRect.Width;
                                    bd = (int)((bd + 1) / 2);
                                }
                                Console.Write(bd);
                                MCvScalar color = new MCvScalar(0, 0, 255);

                                //put a brectangle around the contour
                                if(checkBox1.Checked)
                                {
                                    if (colorVid.Checked)
                                    {
                                        CvInvoke.Rectangle(fr, pointRect, color, 2);
                                    }
                                    if(diffRadio.Checked)
                                    {
                                        CvInvoke.Rectangle(diff, pointRect, color, 2);
                                    }
                                    if(grayVid.Checked)
                                    {
                                        CvInvoke.Rectangle(gf, pointRect, color, 2);
                                    }
                                    if(thr_radio.Checked)
                                    {
                                        CvInvoke.Rectangle(thrNew, pointRect, color, 2);
                                    }
                                }

                                double pixPerIn = pointRect.Height / 2.9;

                                double speedX = (((3600 * 120) * (deltaX / pixPerIn)) / (12 * 5280));
                                double speedY = (((3600 * 120) * (deltaY / pixPerIn)) / (12 * 5280));

                                double zPos = ((((4 * 73.62 * 720) / (pointRect.Height * 3.60)) / 25.4) / 2);
                            }
                        }
                    }
                }
               
                if (diffRadio.Checked)
                {
                    imageBox1.Image = diff;
                }
                else if (grayVid.Checked)
                {
                    imageBox1.Image = gf;
                }
                else if(colorVid.Checked)
                {
                    imageBox1.Image = fr;
                }
                else if(thr_radio.Checked)
                {
                    imageBox1.Image = thrNew;
                }
            }
        }
    
        private string labelText;

        private void start_button_Click(object sender, EventArgs e)
        {
            //Grab initial frame to use as background image
            if (vc != null)
            {
                if (vc.Grab())
                {
                    if (vc != null && vc.Ptr != IntPtr.Zero)
                    {
                        vc.Retrieve(backGround, 0);
                        CvInvoke.CvtColor(backGround, grayBack, ColorConversion.Bgr2Gray);
                        img1 = grayBack.ToImage<Gray, Byte>();
                        //orig. gray image is in grayBack
                        imageBox1.Image = grayBack;
                    }
                    
                }
            }
            stepButton.Enabled = true;
            button1.Enabled = true;
            start_button.Enabled = false;
            play_butt.Enabled = true;
        }

        private void next_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void stepButton_Click(object sender, EventArgs e)
        {
            labelText = "Frame: " + frameCounter + "/" + frameNumber;
            label1.Text = labelText;
            if (vc != null)
            {
                if (vc.Grab())
                {
                    ProcessFrame();
                }

                cp = !cp;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vc.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, frameCounter);
            frameCounter = frameCounter - 2;
            labelText = "Frame: " + frameCounter + "/" + frameNumber;
            label1.Text = labelText;
            if (vc != null)
            {
                if (vc.Grab())
                {
                    ProcessFrame();
                }

                cp = !cp;
            }
        }

        private void play_butt_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pause_butt.Enabled = true;
            colorVid.Checked = true;
            checkBox1.Checked = false;
        }

        private void pause_butt_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            play_butt.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if(vc.Grab())
            {
                vc.Retrieve(playVideo, 0);
                img3 = playVideo.ToImage<Bgr, Byte>();
                imageBox1.Image = img3;
                frameCounter = frameCounter + 1;
                labelText = "Frame: " + frameCounter + "/" + frameNumber;
                label1.Text = labelText;
            }
            else
            {
                pause_butt.PerformClick();
                play_butt.Enabled = false;
               
            }
            
        }
    }
}
