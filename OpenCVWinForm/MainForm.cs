using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AForge.Imaging;

using OpenCvSharp;

namespace OpenCVWinForm
{
    public partial class MainForm : Form
    {
        private Thread _cameraThread;
        private static int x, y;

        public MainForm()
        {
            InitializeComponent();
            x = 0;
            y = 0;
        }

        #region Camera Thread
        private void CaptureCamera()
        {
            _cameraThread = new Thread(new ThreadStart(CaptureCameraCallback));
            _cameraThread.Start();
        }

        private void CaptureCameraCallback()
        {
            const double ScaleFactor = 3.5;
            const int MinNeighbors = 5;
            CvSize MinSize = new CvSize(25, 25);

            CvCapture cap = CvCapture.FromCamera(5);
            CvHaarClassifierCascade cascade = CvHaarClassifierCascade.FromFile("haarcascade_eye.xml");
            while (true)
            {
                IplImage img = cap.QueryFrame();
                CvSeq<CvAvgComp> eyes = Cv.HaarDetectObjects(img, cascade, Cv.CreateMemStorage(), ScaleFactor, MinNeighbors, HaarDetectionType.DoCannyPruning, MinSize);

                foreach (CvAvgComp eye in eyes.AsParallel())
                {

                    img.DrawRect(eye.Rect, CvColor.Blue);
                    if (Math.Abs(x - eye.Rect.Location.X) >= 4 && Math.Abs(y - eye.Rect.Location.Y) >= 4)
                    {
                        Point newPoint = new Point(eye.Rect.Location.X, eye.Rect.Location.Y);
                        x = eye.Rect.Location.X;
                        y = eye.Rect.Location.Y;
                        try
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                movable.Location = newPoint;
                                if (checkBox1.Checked == true)
                                { Cursor.Position = newPoint; }
                            });
                        }
                        catch
                        {

                        }
                    }
                    if (eye.Rect.Left > VedioCapWindow.Width / 2)
                    {
                        try
                        {
                            IplImage rightEyeImg1 = img.Clone();
                            Cv.SetImageROI(rightEyeImg1, eye.Rect);
                            IplImage rightEyeImg2 = Cv.CreateImage(eye.Rect.Size, rightEyeImg1.Depth, rightEyeImg1.NChannels);
                            Cv.Copy(rightEyeImg1, rightEyeImg2, null);
                            Cv.ResetImageROI(rightEyeImg1);

                            
                            Bitmap rightEyeBm = BitmapConverter.ToBitmap(rightEyeImg2);
                            rightEyeBm = pupil(rightEyeBm);
                            pctRightEye.Image = rightEyeBm;
                           
                        }
                        catch { }
                    }
                    else
                    {
                        try
                        {
                            IplImage leftEyeImg1 = img.Clone();
                            Cv.SetImageROI(leftEyeImg1, eye.Rect);
                            IplImage leftEyeImg2 = Cv.CreateImage(eye.Rect.Size, leftEyeImg1.Depth, leftEyeImg1.NChannels);
                            Cv.Copy(leftEyeImg1, leftEyeImg2, null);
                            Cv.ResetImageROI(leftEyeImg1);

                            Bitmap leftEyeBm = BitmapConverter.ToBitmap(leftEyeImg2);
                            leftEyeBm = pupil(leftEyeBm);
                            pctLeftEye.Image = leftEyeBm;
                        }catch{}
                    }
                }

                Bitmap bm = BitmapConverter.ToBitmap(img);
                bm.SetResolution(VedioCapWindow.Width, VedioCapWindow.Height);
                VedioCapWindow.Image = bm;

                img = null;
                bm = null;
            }
        }
        #endregion
        private Bitmap pupil(Bitmap aq)
        {
           
            Invert a = new Invert();
            aq = a.Apply(aq);
            AForge.Imaging.Image.FormatImage(ref aq);

            
            IFilter filter = Grayscale.CommonAlgorithms.BT709;
            aq = filter.Apply(aq);

            Threshold th = new Threshold(220);
            aq = th.Apply(aq);

           
            BlobCounter bl = new BlobCounter(aq);
            int i = bl.ObjectsCount;
            ExtractBiggestBlob fil2 = new ExtractBiggestBlob();

         
            int x = 0;
            int y = 0;
            int h = 0;
            if (i > 0)
            {
                fil2.Apply(aq);
                x = fil2.BlobPosition.X;
                y = fil2.BlobPosition.Y;

                h = fil2.Apply(aq).Height;
            }

            Rectangle section = new Rectangle(new Point(x - h, y - h), new Size(3 * h, 3 * h));

            return aq;
        }

        #region Button Handlers
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text.Equals("Start"))
            {
                CaptureCamera();
                btnStart.Text = "Stop";
            }
            else
            {
                _cameraThread.Abort();
                btnStart.Text = "Start";
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "opencv-image.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String imageFileName = saveFileDialog1.FileName;
                VedioCapWindow.Image.Save(imageFileName);
            }
        }
        #endregion

        private void pctCvWindow_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
