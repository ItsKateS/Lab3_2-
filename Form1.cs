using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Lab3_2
{
    public partial class Form1 : Form
    {
        Emgu.CV.VideoCapture capture;
        CascadeClassifier face;
        Mat image = new Mat();
        Image<Bgr, byte> input;
        Mat frame;

        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            face = new CascadeClassifier("D:\\FD\\haarcascade_frontalface_default.xml");
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.ShowDialog();

            frame = CvInvoke.Imread(ofd.FileName, ImreadModes.Unchanged);

            Label.Text = frame.Split().Length.ToString();
            Box.Image = frame.Split()[3];
        }

        private void Start_Click(object sender, EventArgs e)
        {
            capture = new VideoCapture();
            capture.ImageGrabbed += ProcessFrame;
            capture.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if(capture != null && capture.Ptr != IntPtr.Zero)
            {
                capture.Retrieve(image);
                input = image.ToImage<Bgr, byte>();

                List<Rectangle> faces = new List<Rectangle>();

                Mat ugray = new Mat();
                CvInvoke.CvtColor(image, ugray, ColorConversion.Bgr2Gray);
                Rectangle[] facesDetected = face.DetectMultiScale(ugray, 1.2, 10, new Size(20, 20));
                faces.AddRange(facesDetected);

                Image<Bgra, byte> res = input.Convert<Bgra, byte>();

                if(faces.Count > 0)
                {
                    foreach(Rectangle rect in faces)
                    {
                        res.ROI = rect;
                        Image<Bgra, byte> small = frame.ToImage<Bgra, byte>().Resize(rect.Width, rect.Height, Inter.Linear);

                        CvInvoke.cvCopy(small, res, small.Split()[3]);
                        res.ROI = Rectangle.Empty;
                    }

                    faces.Clear();
                }

                Box.Image = res;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            capture.Stop();
            capture.ImageGrabbed -= ProcessFrame;
        }
    }
}
