using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Modemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SerialportManager serialportManager = new SerialportManager();

            //serialportManager.Connect("COM1");

            SerialPort _serialPort = new SerialPort();
            Thread reader;

            Console.WriteLine("COM1");
            if (_serialPort != null)
                if (_serialPort.IsOpen) _serialPort.Close();
            _serialPort = new SerialPort("COM1");
            if (_serialPort != null)
                _serialPort.Open();
            if (_serialPort.IsOpen)
            {
                _serialPort.DtrEnable = true;
                _serialPort.Handshake = Handshake.RequestToSend;
                Console.WriteLine(_serialPort.PortName);
                Console.WriteLine(_serialPort.BaudRate);
                Console.WriteLine(_serialPort.Parity);
                Console.WriteLine(_serialPort.DataBits);
                Console.WriteLine(_serialPort.StopBits);
                Console.WriteLine(_serialPort.Handshake);

                Console.WriteLine(_serialPort.DtrEnable);
                //reader = new Thread(Read);
                //reader.Start();

                string message = _serialPort.ReadExisting();
                textBox1.AppendText(message);

                _serialPort.Write(message);

                /*try
                {
                    port.Open();
                    Thread.Sleep(1000);
                    port.Write("some command" + Environment.NewLine);

                }
                catch (Exception ex)
                {

                }*/



            }
        }
    }
}
