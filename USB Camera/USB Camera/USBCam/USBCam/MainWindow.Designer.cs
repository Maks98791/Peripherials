namespace USBCam
{
    partial class MainWindow
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
            this.button_searchDev = new System.Windows.Forms.Button();
            this.cmbDevList1 = new System.Windows.Forms.ComboBox();
            this.cmbDevList2 = new System.Windows.Forms.ComboBox();
            this.pbCam1 = new System.Windows.Forms.PictureBox();
            this.labelCamera1 = new System.Windows.Forms.Label();
            this.labelCamera2 = new System.Windows.Forms.Label();
            this.pbCam2 = new System.Windows.Forms.PictureBox();
            this.buttonSsCam1 = new System.Windows.Forms.Button();
            this.buttonCamOneStop = new System.Windows.Forms.Button();
            this.buttonCamTwoStop = new System.Windows.Forms.Button();
            this.buttonSsCam2 = new System.Windows.Forms.Button();
            this.buttonPictureCamOne = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonPictureCamTwo = new System.Windows.Forms.Button();
            this.buttonRecordingCamOne = new System.Windows.Forms.Button();
            this.buttonStopRecordingCamOne = new System.Windows.Forms.Button();
            this.brightness1label = new System.Windows.Forms.Label();
            this.saturation1label = new System.Windows.Forms.Label();
            this.contrast1label = new System.Windows.Forms.Label();
            this.jasnosc1TrackBar = new System.Windows.Forms.TrackBar();
            this.nasycenie1TrackBar = new System.Windows.Forms.TrackBar();
            this.kontrast1TrackBar = new System.Windows.Forms.TrackBar();
            this.kontrast2TrackBar = new System.Windows.Forms.TrackBar();
            this.nasycenie2TrackBar = new System.Windows.Forms.TrackBar();
            this.jasnosc2TrackBar = new System.Windows.Forms.TrackBar();
            this.contrast2label = new System.Windows.Forms.Label();
            this.saturation2label = new System.Windows.Forms.Label();
            this.brightness2label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasnosc1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasycenie1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrast1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrast2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasycenie2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasnosc2TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button_searchDev
            // 
            this.button_searchDev.Location = new System.Drawing.Point(12, 8);
            this.button_searchDev.Name = "button_searchDev";
            this.button_searchDev.Size = new System.Drawing.Size(136, 23);
            this.button_searchDev.TabIndex = 0;
            this.button_searchDev.Text = "Search devices";
            this.button_searchDev.UseVisualStyleBackColor = true;
            this.button_searchDev.Click += new System.EventHandler(this.button_searchDev_Click);
            // 
            // cmbDevList1
            // 
            this.cmbDevList1.FormattingEnabled = true;
            this.cmbDevList1.Location = new System.Drawing.Point(12, 54);
            this.cmbDevList1.Name = "cmbDevList1";
            this.cmbDevList1.Size = new System.Drawing.Size(357, 21);
            this.cmbDevList1.TabIndex = 1;
            // 
            // cmbDevList2
            // 
            this.cmbDevList2.FormattingEnabled = true;
            this.cmbDevList2.Location = new System.Drawing.Point(375, 54);
            this.cmbDevList2.Name = "cmbDevList2";
            this.cmbDevList2.Size = new System.Drawing.Size(357, 21);
            this.cmbDevList2.TabIndex = 2;
            // 
            // pbCam1
            // 
            this.pbCam1.Location = new System.Drawing.Point(12, 81);
            this.pbCam1.Name = "pbCam1";
            this.pbCam1.Size = new System.Drawing.Size(357, 271);
            this.pbCam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCam1.TabIndex = 3;
            this.pbCam1.TabStop = false;
            // 
            // labelCamera1
            // 
            this.labelCamera1.AutoSize = true;
            this.labelCamera1.Location = new System.Drawing.Point(12, 35);
            this.labelCamera1.Name = "labelCamera1";
            this.labelCamera1.Size = new System.Drawing.Size(55, 13);
            this.labelCamera1.TabIndex = 4;
            this.labelCamera1.Text = "Camera 1:";
            // 
            // labelCamera2
            // 
            this.labelCamera2.AutoSize = true;
            this.labelCamera2.Location = new System.Drawing.Point(372, 35);
            this.labelCamera2.Name = "labelCamera2";
            this.labelCamera2.Size = new System.Drawing.Size(55, 13);
            this.labelCamera2.TabIndex = 5;
            this.labelCamera2.Text = "Camera 2:";
            // 
            // pbCam2
            // 
            this.pbCam2.Location = new System.Drawing.Point(375, 81);
            this.pbCam2.Name = "pbCam2";
            this.pbCam2.Size = new System.Drawing.Size(357, 271);
            this.pbCam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCam2.TabIndex = 6;
            this.pbCam2.TabStop = false;
            // 
            // buttonSsCam1
            // 
            this.buttonSsCam1.Location = new System.Drawing.Point(12, 358);
            this.buttonSsCam1.Name = "buttonSsCam1";
            this.buttonSsCam1.Size = new System.Drawing.Size(65, 23);
            this.buttonSsCam1.TabIndex = 7;
            this.buttonSsCam1.Text = "Start";
            this.buttonSsCam1.UseVisualStyleBackColor = true;
            this.buttonSsCam1.Click += new System.EventHandler(this.buttonSsCam1_Click);
            // 
            // buttonCamOneStop
            // 
            this.buttonCamOneStop.Location = new System.Drawing.Point(83, 358);
            this.buttonCamOneStop.Name = "buttonCamOneStop";
            this.buttonCamOneStop.Size = new System.Drawing.Size(65, 23);
            this.buttonCamOneStop.TabIndex = 8;
            this.buttonCamOneStop.Text = "Stop";
            this.buttonCamOneStop.UseVisualStyleBackColor = true;
            this.buttonCamOneStop.Click += new System.EventHandler(this.buttonCamOneStop_Click);
            // 
            // buttonCamTwoStop
            // 
            this.buttonCamTwoStop.Location = new System.Drawing.Point(446, 358);
            this.buttonCamTwoStop.Name = "buttonCamTwoStop";
            this.buttonCamTwoStop.Size = new System.Drawing.Size(65, 23);
            this.buttonCamTwoStop.TabIndex = 10;
            this.buttonCamTwoStop.Text = "Stop";
            this.buttonCamTwoStop.UseVisualStyleBackColor = true;
            this.buttonCamTwoStop.Click += new System.EventHandler(this.buttonCamTwoStop_Click);
            // 
            // buttonSsCam2
            // 
            this.buttonSsCam2.Location = new System.Drawing.Point(375, 358);
            this.buttonSsCam2.Name = "buttonSsCam2";
            this.buttonSsCam2.Size = new System.Drawing.Size(65, 23);
            this.buttonSsCam2.TabIndex = 9;
            this.buttonSsCam2.Text = "Start";
            this.buttonSsCam2.UseVisualStyleBackColor = true;
            this.buttonSsCam2.Click += new System.EventHandler(this.buttonSsCam2_Click);
            // 
            // buttonPictureCamOne
            // 
            this.buttonPictureCamOne.Location = new System.Drawing.Point(154, 358);
            this.buttonPictureCamOne.Name = "buttonPictureCamOne";
            this.buttonPictureCamOne.Size = new System.Drawing.Size(65, 23);
            this.buttonPictureCamOne.TabIndex = 11;
            this.buttonPictureCamOne.Text = "Picture";
            this.buttonPictureCamOne.UseVisualStyleBackColor = true;
            this.buttonPictureCamOne.Click += new System.EventHandler(this.buttonPictureCamOne_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "picture";
            // 
            // buttonPictureCamTwo
            // 
            this.buttonPictureCamTwo.Location = new System.Drawing.Point(517, 358);
            this.buttonPictureCamTwo.Name = "buttonPictureCamTwo";
            this.buttonPictureCamTwo.Size = new System.Drawing.Size(65, 23);
            this.buttonPictureCamTwo.TabIndex = 12;
            this.buttonPictureCamTwo.Text = "Picture";
            this.buttonPictureCamTwo.UseVisualStyleBackColor = true;
            this.buttonPictureCamTwo.Click += new System.EventHandler(this.buttonPictureCamTwo_Click);
            // 
            // buttonRecordingCamOne
            // 
            this.buttonRecordingCamOne.Location = new System.Drawing.Point(225, 358);
            this.buttonRecordingCamOne.Name = "buttonRecordingCamOne";
            this.buttonRecordingCamOne.Size = new System.Drawing.Size(65, 23);
            this.buttonRecordingCamOne.TabIndex = 13;
            this.buttonRecordingCamOne.Text = "Record";
            this.buttonRecordingCamOne.UseVisualStyleBackColor = true;
            this.buttonRecordingCamOne.Click += new System.EventHandler(this.buttonRecordingCamOne_Click);
            // 
            // buttonStopRecordingCamOne
            // 
            this.buttonStopRecordingCamOne.Location = new System.Drawing.Point(0, 0);
            this.buttonStopRecordingCamOne.Name = "buttonStopRecordingCamOne";
            this.buttonStopRecordingCamOne.Size = new System.Drawing.Size(75, 23);
            this.buttonStopRecordingCamOne.TabIndex = 0;
            // 
            // brightness1label
            // 
            this.brightness1label.AutoSize = true;
            this.brightness1label.Location = new System.Drawing.Point(80, 402);
            this.brightness1label.Name = "brightness1label";
            this.brightness1label.Size = new System.Drawing.Size(62, 13);
            this.brightness1label.TabIndex = 15;
            this.brightness1label.Text = "Brightness1";
            // 
            // saturation1label
            // 
            this.saturation1label.AutoSize = true;
            this.saturation1label.Location = new System.Drawing.Point(82, 466);
            this.saturation1label.Name = "saturation1label";
            this.saturation1label.Size = new System.Drawing.Size(61, 13);
            this.saturation1label.TabIndex = 16;
            this.saturation1label.Text = "Saturation1";
            // 
            // contrast1label
            // 
            this.contrast1label.AutoSize = true;
            this.contrast1label.Location = new System.Drawing.Point(82, 530);
            this.contrast1label.Name = "contrast1label";
            this.contrast1label.Size = new System.Drawing.Size(52, 13);
            this.contrast1label.TabIndex = 17;
            this.contrast1label.Text = "Contrast1";
            // 
            // jasnosc1TrackBar
            // 
            this.jasnosc1TrackBar.Location = new System.Drawing.Point(85, 418);
            this.jasnosc1TrackBar.Maximum = 100;
            this.jasnosc1TrackBar.Minimum = -100;
            this.jasnosc1TrackBar.Name = "jasnosc1TrackBar";
            this.jasnosc1TrackBar.Size = new System.Drawing.Size(131, 45);
            this.jasnosc1TrackBar.TabIndex = 18;
            this.jasnosc1TrackBar.Scroll += new System.EventHandler(this.jasnosc1TrackBar_Scroll);
            // 
            // nasycenie1TrackBar
            // 
            this.nasycenie1TrackBar.Location = new System.Drawing.Point(83, 482);
            this.nasycenie1TrackBar.Maximum = 100;
            this.nasycenie1TrackBar.Minimum = -100;
            this.nasycenie1TrackBar.Name = "nasycenie1TrackBar";
            this.nasycenie1TrackBar.Size = new System.Drawing.Size(131, 45);
            this.nasycenie1TrackBar.TabIndex = 19;
            this.nasycenie1TrackBar.Scroll += new System.EventHandler(this.nasycenie1TrackBar_Scroll);
            // 
            // kontrast1TrackBar
            // 
            this.kontrast1TrackBar.Location = new System.Drawing.Point(83, 546);
            this.kontrast1TrackBar.Maximum = 100;
            this.kontrast1TrackBar.Minimum = -100;
            this.kontrast1TrackBar.Name = "kontrast1TrackBar";
            this.kontrast1TrackBar.Size = new System.Drawing.Size(131, 45);
            this.kontrast1TrackBar.TabIndex = 20;
            this.kontrast1TrackBar.Scroll += new System.EventHandler(this.kontrast1TrackBar_Scroll);
            // 
            // kontrast2TrackBar
            // 
            this.kontrast2TrackBar.Location = new System.Drawing.Point(375, 546);
            this.kontrast2TrackBar.Maximum = 100;
            this.kontrast2TrackBar.Minimum = -100;
            this.kontrast2TrackBar.Name = "kontrast2TrackBar";
            this.kontrast2TrackBar.Size = new System.Drawing.Size(131, 45);
            this.kontrast2TrackBar.TabIndex = 26;
            this.kontrast2TrackBar.Scroll += new System.EventHandler(this.kontrast2TrackBar_Scroll);
            // 
            // nasycenie2TrackBar
            // 
            this.nasycenie2TrackBar.Location = new System.Drawing.Point(375, 482);
            this.nasycenie2TrackBar.Maximum = 100;
            this.nasycenie2TrackBar.Minimum = -100;
            this.nasycenie2TrackBar.Name = "nasycenie2TrackBar";
            this.nasycenie2TrackBar.Size = new System.Drawing.Size(131, 45);
            this.nasycenie2TrackBar.TabIndex = 25;
            this.nasycenie2TrackBar.Scroll += new System.EventHandler(this.nasycenie2TrackBar_Scroll);
            // 
            // jasnosc2TrackBar
            // 
            this.jasnosc2TrackBar.Location = new System.Drawing.Point(377, 418);
            this.jasnosc2TrackBar.Maximum = 100;
            this.jasnosc2TrackBar.Minimum = -100;
            this.jasnosc2TrackBar.Name = "jasnosc2TrackBar";
            this.jasnosc2TrackBar.Size = new System.Drawing.Size(131, 45);
            this.jasnosc2TrackBar.TabIndex = 24;
            this.jasnosc2TrackBar.Scroll += new System.EventHandler(this.jasnosc2TrackBar_Scroll);
            // 
            // contrast2label
            // 
            this.contrast2label.AutoSize = true;
            this.contrast2label.Location = new System.Drawing.Point(374, 530);
            this.contrast2label.Name = "contrast2label";
            this.contrast2label.Size = new System.Drawing.Size(52, 13);
            this.contrast2label.TabIndex = 23;
            this.contrast2label.Text = "Contrast2";
            // 
            // saturation2label
            // 
            this.saturation2label.AutoSize = true;
            this.saturation2label.Location = new System.Drawing.Point(374, 466);
            this.saturation2label.Name = "saturation2label";
            this.saturation2label.Size = new System.Drawing.Size(61, 13);
            this.saturation2label.TabIndex = 22;
            this.saturation2label.Text = "Saturation2";
            // 
            // brightness2label
            // 
            this.brightness2label.AutoSize = true;
            this.brightness2label.Location = new System.Drawing.Point(372, 402);
            this.brightness2label.Name = "brightness2label";
            this.brightness2label.Size = new System.Drawing.Size(62, 13);
            this.brightness2label.TabIndex = 21;
            this.brightness2label.Text = "Brightness2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kontrast2TrackBar);
            this.Controls.Add(this.nasycenie2TrackBar);
            this.Controls.Add(this.jasnosc2TrackBar);
            this.Controls.Add(this.contrast2label);
            this.Controls.Add(this.saturation2label);
            this.Controls.Add(this.brightness2label);
            this.Controls.Add(this.kontrast1TrackBar);
            this.Controls.Add(this.nasycenie1TrackBar);
            this.Controls.Add(this.jasnosc1TrackBar);
            this.Controls.Add(this.contrast1label);
            this.Controls.Add(this.saturation1label);
            this.Controls.Add(this.brightness1label);
            this.Controls.Add(this.buttonRecordingCamOne);
            this.Controls.Add(this.buttonPictureCamTwo);
            this.Controls.Add(this.buttonPictureCamOne);
            this.Controls.Add(this.buttonCamTwoStop);
            this.Controls.Add(this.buttonSsCam2);
            this.Controls.Add(this.buttonCamOneStop);
            this.Controls.Add(this.buttonSsCam1);
            this.Controls.Add(this.pbCam2);
            this.Controls.Add(this.labelCamera2);
            this.Controls.Add(this.labelCamera1);
            this.Controls.Add(this.pbCam1);
            this.Controls.Add(this.cmbDevList2);
            this.Controls.Add(this.cmbDevList1);
            this.Controls.Add(this.button_searchDev);
            this.Name = "MainWindow";
            this.Text = "USBCam";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasnosc1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasycenie1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrast1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrast2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasycenie2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasnosc2TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_searchDev;
        private System.Windows.Forms.ComboBox cmbDevList1;
        private System.Windows.Forms.ComboBox cmbDevList2;
        private System.Windows.Forms.PictureBox pbCam1;
        private System.Windows.Forms.Label labelCamera1;
        private System.Windows.Forms.Label labelCamera2;
        private System.Windows.Forms.PictureBox pbCam2;
        private System.Windows.Forms.Button buttonSsCam1;
        private System.Windows.Forms.Button buttonCamOneStop;
        private System.Windows.Forms.Button buttonCamTwoStop;
        private System.Windows.Forms.Button buttonSsCam2;
        private System.Windows.Forms.Button buttonPictureCamOne;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonPictureCamTwo;
        private System.Windows.Forms.Button buttonRecordingCamOne;
        private System.Windows.Forms.Button buttonStopRecordingCamOne;
        private System.Windows.Forms.Label brightness1label;
        private System.Windows.Forms.Label saturation1label;
        private System.Windows.Forms.Label contrast1label;
        private System.Windows.Forms.TrackBar jasnosc1TrackBar;
        private System.Windows.Forms.TrackBar nasycenie1TrackBar;
        private System.Windows.Forms.TrackBar kontrast1TrackBar;
        private System.Windows.Forms.TrackBar kontrast2TrackBar;
        private System.Windows.Forms.TrackBar nasycenie2TrackBar;
        private System.Windows.Forms.TrackBar jasnosc2TrackBar;
        private System.Windows.Forms.Label contrast2label;
        private System.Windows.Forms.Label saturation2label;
        private System.Windows.Forms.Label brightness2label;
        private System.Windows.Forms.Button button1;
    }
}

