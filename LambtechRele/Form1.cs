using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambtechRele
{
    public partial class Form1 : MetroForm
    {
        static SerialPort _port;
        byte _direccion = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var serial = SerialPort.GetPortNames();
            //if (serial.Length==0)
            //{
            //    MessageBox.Show("Sin puerto abiertos.");
            //}

            cmbPorts.DataSource = serial;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (_port == null)
            {
                //configure serial port
                _port.BaudRate = 9600;
                _port.DataBits = 8;
                _port.Parity = Parity.None;
                _port.StopBits = StopBits.One;
                _port.ReadTimeout = 500;
                _port.WriteTimeout = 500;
                //_port.DataReceived += new
                // SerialDataReceivedEventHandler(port_DataReceived);
                _port.Open();

            }

            //btnConectar.Enabled = false;
            btnConectar.Style = MetroColorStyle.Green;
            btnDesconectar.Style = MetroColorStyle.Black;
            btnDesconectar.Enabled = true;

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (_port != null)
            {
                _port.Close();
                _port = null;
            }
           // btnConectar.Enabled = true;
            //btnDesconectar.Enabled = false;
            btnDesconectar.Style = MetroColorStyle.Red;
            btnConectar.Style = MetroColorStyle.Black;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_port != null)
                _port.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (_port!= null)
            {
                MetroButton button = (MetroButton)sender;
                byte[] data = new byte[2];
                switch (button.Text)
                {
                    case "1":
                        data[0] = _direccion;
                        data[1] = 1;
                        _port.Write(data, 0, data.Length);
                        break;
                    case "2":
                        data[0] = _direccion;
                        data[1] = 2;
                        _port.Write(data, 0, data.Length);
                        break;
                    case "3":
                        data[0] = _direccion;
                        data[1] = 3;
                        _port.Write(data, 0, data.Length);
                        break;
                    case "4":
                        data[0] = _direccion;
                        data[1] = 4;
                        _port.Write(data, 0, data.Length);
                        break;

                    default:
                        break;

                }

            }
            else
            {
                MessageBox.Show("Problemas con el puerto");
            }

        }

    }
}
