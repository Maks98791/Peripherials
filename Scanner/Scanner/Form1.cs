using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using System.IO;

namespace Scanner
{
    public partial class Form1 : Form
    {
        Device device;
        DeviceManager deviceManager = new DeviceManager();
        DeviceInfo firstDevice = null;
        Item scannerItem;
        ImageFile imageFile;

        int resolution = 150;
        int width_pixel = 1250;
        int height_pixel = 1700;
        int color_mode = 1;
        int brightness = 0;
        int contrast = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    continue;
                else
                {
                    comboBox1.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());
                    firstDevice = deviceManager.DeviceInfos[i];

                    break;
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            trackBarsInit();

            device = firstDevice.Connect();
            scannerItem = device.Items[1];

            AdjustScannerSettings(scannerItem, resolution, 0, 0, width_pixel, height_pixel, brightness, contrast, color_mode);

            var path = "temp.jpeg";
            imageFile = (ImageFile)scannerItem.Transfer(FormatID.wiaFormatJPEG);

            if (File.Exists(path))
                File.Delete(path);

            imageFile.SaveFile(path);

            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = new Bitmap(path);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imageFile = (ImageFile)scannerItem.Transfer(FormatID.wiaFormatJPEG);

            var path = @"C:\Users\lab\Desktop\scan.jpeg";

            if (File.Exists(path))
                File.Delete(path);

            imageFile.SaveFile(path);
        }

        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel, int scanWidthPixels, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);
        }

        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBarsInit()
        {
            trackBar1.Minimum = -100;
            trackBar1.Maximum = 100;
            trackBar1.Value = 0;
            trackBar2.Minimum = -100;
            trackBar2.Maximum = 100;
            trackBar2.Value = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.GetItemText(this.comboBox2.SelectedItem) == "Czarno-biały")
                color_mode = 2;
            else
                color_mode = 1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> reso = new List<int>();
            foreach (int item in comboBox1.Items)
                reso.Add(item);

            resolution = reso[comboBox1.SelectedIndex];
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            brightness = trackBar1.Value;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            contrast = trackBar2.Value;
        }
    }
}
