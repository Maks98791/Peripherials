using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modemy
{
    class SerialPortManager
    {
        SerialPort _serialPort;
        Thread reader;
        public SerialPortManager()
        {
        }
        public void Connect(string COM)
        {
            Console.WriteLine(COM);
            if (_serialPort != null)
                if (_serialPort.IsOpen) _serialPort.Close();
            _serialPort = new SerialPort(COM);
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
                reader = new Thread(Read);
                reader.Start();
            }
        }

        public void SendMessage(string message)
        {
            if (_serialPort != null)
                _serialPort.Write(message);
            else
                Console.WriteLine("ERROR !! CONNECT TO SERIAL PORT");
        }
        private void Read()
        {
            while (_serialPort.IsOpen)
            {
                try
                {
                    string message = _serialPort.ReadExisting();
                    Console.Write(message);
                }
                catch (TimeoutException) { }
            }
        }
    }
}