using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using Accord.Video.VFW;
using Accord.Video.FFMPEG;
using AForge.Imaging.Filters;


namespace USBCam
{
    public partial class MainWindow : Form
    {
        FilterInfoCollection videoDevicesList;
        VideoCaptureDevice cameraOne;
        VideoCaptureDevice cameraTwo;
        int brightess1 = 0;
        int contrast1 = 0;
        int saturation1 = 0;
        int brightess2 = 0;
        int contrast2 = 0;
        int saturation2 = 0;
        bool isRecording1 = false;
        bool isRecording2 = false;
       // bool startButtonClicked1 = false;
        //bool startButtonClicked2 = false;
        //VideoCaptureDevice videoSource;
        VideoFileWriter writer;
       // private DateTime? firstFrameTime;
        private Bitmap oldBitmap;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (videoSource.IsRunning)
           // {
            //    videoSource.Stop();
            //}
        }
        private void button_searchDev_Click(object sender, EventArgs e)
        {
            videoDevicesList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videoDevice in videoDevicesList)
            {
                cmbDevList1.Items.Add(videoDevice.Name);
                cmbDevList2.Items.Add(videoDevice.Name);
            }
        }

        public static bool CompareBitmapsFast(Bitmap bmp1, Bitmap bmp2)
        {
            if (bmp1 == null || bmp2 == null)
                return false;
            if (object.Equals(bmp1, bmp2))
                return true;
            if (!bmp1.Size.Equals(bmp2.Size) || !bmp1.PixelFormat.Equals(bmp2.PixelFormat))
                return false;

            int bytes = bmp1.Width * bmp1.Height * (Image.GetPixelFormatSize(bmp1.PixelFormat) / 8);

            bool result = true;
            byte[] b1bytes = new byte[bytes];
            byte[] b2bytes = new byte[bytes];

            BitmapData bitmapData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadOnly, bmp1.PixelFormat);
            BitmapData bitmapData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadOnly, bmp2.PixelFormat);

            Marshal.Copy(bitmapData1.Scan0, b1bytes, 0, bytes);
            Marshal.Copy(bitmapData2.Scan0, b2bytes, 0, bytes);

            for (int n = 0; n <= bytes - 1; n++)
            {
                if (b1bytes[n] != b2bytes[n])
                {
                    result = false;
                    break;
                }
            }

            bmp1.UnlockBits(bitmapData1);
            bmp2.UnlockBits(bitmapData2);

            return result;
        }

        private void CameraOne_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap1 = (Bitmap) eventArgs.Frame.Clone();
            BrightnessCorrection br = new BrightnessCorrection(brightess1);
            ContrastCorrection cr = new ContrastCorrection(contrast1);
            SaturationCorrection sr = new SaturationCorrection(saturation1);
            bitmap1 = br.Apply((Bitmap)bitmap1.Clone());
            bitmap1 = cr.Apply((Bitmap)bitmap1.Clone());
            bitmap1 = sr.Apply((Bitmap)bitmap1.Clone());

      
            

            if (isRecording1)
            {
                writer.WriteVideoFrame(bitmap1);
            }
            else
            {
                if (oldBitmap!=null)
                {
                    if (CompareBitmapsFast(bitmap1, oldBitmap))
                    {
                        pbCam2.Image = oldBitmap;
                    }
                    else
                    {
                        pbCam2.Image = null;
                    }
                }

                oldBitmap = bitmap1;

                pbCam1.Image = bitmap1;
            }
        }

        private void CameraTwo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap2 = (Bitmap)eventArgs.Frame.Clone();
            BrightnessCorrection br = new BrightnessCorrection(brightess1);
            ContrastCorrection cr = new ContrastCorrection(contrast1);
            SaturationCorrection sr = new SaturationCorrection(saturation1);
            bitmap2 = br.Apply((Bitmap)bitmap2.Clone());
            bitmap2 = cr.Apply((Bitmap)bitmap2.Clone());
            bitmap2 = sr.Apply((Bitmap)bitmap2.Clone());

            pbCam2.Image = bitmap2;

            if (isRecording2)
            {
                writer.WriteVideoFrame(bitmap2);
            }
        }

        private void buttonSsCam1_Click(object sender, EventArgs e)
        {
            cameraOne = new VideoCaptureDevice(videoDevicesList[cmbDevList1.SelectedIndex].MonikerString);
            cameraOne.NewFrame += new NewFrameEventHandler(CameraOne_NewFrame);
            cameraOne.Stop();
            cameraOne.Start();
        }

        private void buttonCamOneStop_Click(object sender, EventArgs e)
        {
            cameraOne.Stop();
        }

        private void buttonSsCam2_Click(object sender, EventArgs e)
        {
            cameraTwo = new VideoCaptureDevice(videoDevicesList[cmbDevList2.SelectedIndex].MonikerString);
            cameraTwo.NewFrame += new NewFrameEventHandler(CameraTwo_NewFrame);
            cameraTwo.Stop();
            cameraTwo.Start();
        }

        private void buttonCamTwoStop_Click(object sender, EventArgs e)
        {
            cameraTwo.Stop();
        }

        private void buttonPictureCamOne_Click(object sender, EventArgs e)
        {
            buttonCamOneStop_Click(sender, e);
            Bitmap picture = (Bitmap) pbCam1.Image;
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
            System.IO.FileStream fs = (System.IO.FileStream) saveFileDialog.OpenFile();
            picture.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
            fs.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void buttonPictureCamTwo_Click(object sender, EventArgs e)
        {
            buttonCamTwoStop_Click(sender, e);
            Bitmap picture = (Bitmap)pbCam2.Image;
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
            System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
            picture.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
            fs.Close();
        }

        private void buttonRecordingCamOne_Click(object sender, EventArgs e)
        {
            if (cameraOne.IsRunning)
            {
//                buttonRecordingCamOne.Enabled = false;
//                buttonStopRecordingCamOne.Enabled = true;
                
                try
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Avi Files (*.avi)|*.avi";
                    saveFileDialog.Title = "Save a Video File";
                    saveFileDialog.ShowDialog();
                    writer = new VideoFileWriter();
                    writer.Open(saveFileDialog.FileName, pbCam1.Image.Width, pbCam1.Image.Height, 30, VideoCodec.MPEG4);
                    isRecording1 = true;
                }
                catch
                {

                }
            }
        }
//        private void buttonStopRecordingCamOne_Click(object sender, EventArgs e)
//        {
//            if (cameraOne.IsRunning)
//            {
//                isRecording1 = false;
//                writer.Close();
//
//                buttonRecordingCamOne.Enabled = true;
//                buttonStopRecordingCamOne.Enabled = false;
//                saveFileDialog.Filter = "Avi Files (*.avi)|*.avi";
//                saveFileDialog.Title = "Save a Video File";
//                saveFileDialog.ShowDialog();
//                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
//            }
//        }
        private void jasnosc1TrackBar_Scroll(object sender, EventArgs e)
        {
                if(cameraOne.IsRunning)
                brightess1 = jasnosc1TrackBar.Value;

        }
        private void jasnosc2TrackBar_Scroll(object sender, EventArgs e)
        {
                if(cameraTwo.IsRunning)
                brightess2 = jasnosc2TrackBar.Value;
        }
        private void kontrast1TrackBar_Scroll(object sender, EventArgs e)
        {
                if(cameraOne.IsRunning)
                contrast1 = kontrast1TrackBar.Value;
        }

        private void nasycenie1TrackBar_Scroll(object sender, EventArgs e)
        {
                if (cameraOne.IsRunning)
                saturation1 = nasycenie1TrackBar.Value;
        }
        private void kontrast2TrackBar_Scroll(object sender, EventArgs e)
        {
                if (cameraTwo.IsRunning)
                contrast2 = kontrast2TrackBar.Value;
        }

        private void nasycenie2TrackBar_Scroll(object sender, EventArgs e)
        {
                if (cameraTwo.IsRunning)
                saturation2 = nasycenie2TrackBar.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cameraOne.IsRunning && isRecording1)
            {
                isRecording1 = false;
                writer.Close();

                buttonRecordingCamOne.Enabled = true;
//                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
             
            }
        }
        /*private void trackBar1_Scroll(object sender, EventArgs e)
{

} */
    }
}

// https://www.mesta-automation.com/getting-started-with-computer-vision-in-c-sharp/