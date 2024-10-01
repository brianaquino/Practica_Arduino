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

namespace Practica_Arduino
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            //crear serial port
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3"; //checar en mi equipo
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            //vincular eventos
            this.FormClosing += CerrandoForm1;
            this.btnapagar.Click += btnapagar_Click;
            this.btnencender.Click += btnencender_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnencender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void CerrandoForm1(object sender, FormClosingEventArgs e)
        {
            //cerrar puerto
            if (ArduinoPort.IsOpen) ArduinoPort.Close();

        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");

        }
    }
}
