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
using System.IO;
using System.Text.Json;

namespace Prueva_1_arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            buttonOpen.Enabled = true;
            buttonClose.Enabled = false;
            BtOn.Enabled= false;
            BtOff.Enabled = false;
            comboBoxBaudRate.Text = "9600";
            progressBarConnection.Value = 0;
            ImgLed.Image = Properties.Resources.led_variant_on_icon_136452;

            string[] puertos = SerialPort.GetPortNames();
            comboBoxComPort.Items.AddRange(puertos);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                try
                {
                    SerialPort.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort.PortName = comboBoxComPort.Text;
                SerialPort.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                SerialPort.Open();

                buttonOpen.Enabled = false;
                buttonClose.Enabled = true;
                BtOn.Enabled = true;
                BtOff.Enabled = true;
                progressBarConnection.Value = 100;
                comboBoxBaudRate.Enabled = false;
                comboBoxComPort.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            try
            {
                //envio de datos (off)
                //crea la trama de envio
                var objetoJson = new Json()
                { id = 15, titulo = "Prueba c# led", status = true, value = 0 };
                string json = JsonSerializer.Serialize(objetoJson);
                //cambio de imagen a off
                ImgLed.Image = Properties.Resources.led_variant_on_icon_136452;
                //envio de datos (off)
                SerialPort.WriteLine(json);
                SerialPort.Close();
                buttonOpen.Enabled = true;
                buttonClose.Enabled = false;
                BtOn.Enabled = false;
                BtOff.Enabled = false;
                progressBarConnection.Value = 0;
                comboBoxBaudRate.Enabled = true;
                comboBoxComPort.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtOn_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                try
                {
                    //crea la trama de envio
                    var objetoJson = new Json()
                    { id = 15, titulo = "Prueba c# led", status = true, value = 1 };
                    string json = JsonSerializer.Serialize(objetoJson);
                    //cambio de imagen a on
                    ImgLed.Image = Properties.Resources.led_on_icon_138424;
                    //envio de datos (on)
                    SerialPort.WriteLine(json);
                    /*var json = JsonSerializer.Deserialize<Json>(json);
                    TBEnvTrama.Invoke((MethodInvoker)(() =>
                    {
                        TBEnvTrama.Text = json;
                    }));
                    */
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void BtOff_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                try
                {
                    //crea la trama de envio
                    var objetoJson1 = new Json()
                    { id = 15, titulo = "Prueba c# led", status = true, value = 0 };
                    string json1 = JsonSerializer.Serialize(objetoJson1);
                    //cambio de imagen a off
                    ImgLed.Image = Properties.Resources.led_variant_on_icon_136452;
                    //envio de datos (off)
                    SerialPort.WriteLine(json1);
                    
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        //Resepcion de datos
        private async void datosRecividos(object sender, SerialDataReceivedEventArgs e)
        {
            String Data_in = SerialPort.ReadTo("\n");
            File.WriteAllText("Trama.txt", Data_in);
            Console.WriteLine(Data_in);
            TBVerTrama.Invoke((MethodInvoker)(() =>
            {
                TBVerTrama.Text = Data_in;
            }));

            //Delay
            await Task.Delay(5000);

            String Data_inJson = File.ReadAllText("Trama.txt");
            var DataJson = JsonSerializer.Deserialize<Json>(Data_inJson);

            Console.WriteLine(DataJson.value);
            TBVerTramaJson.Invoke((MethodInvoker)(() =>
            {
                TBVerTramaJson.Text = DataJson.value.ToString();
            }));

            if (DataJson.value >= circularProgressBar1.Minimum &&
                DataJson.value <= circularProgressBar1.Maximum)
            {
                circularProgressBar1.Invoke((MethodInvoker)((() =>
                {
                    circularProgressBar1.Value = DataJson.value;
                    circularProgressBar1.Text = DataJson.value.ToString();
                })));
            }

            chart1.Invoke((MethodInvoker)((() =>
            {
                chart1.Series["Analog"].Points.AddY(DataJson.value);
            })));


        }

    }
}
