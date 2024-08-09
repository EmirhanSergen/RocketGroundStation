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

namespace Rocket_ground_station
{
    public partial class YerIstasyonu : Form
    {

        
        public YerIstasyonu()
        {
            InitializeComponent();
            // Set default values to baudrates
            baudrateAliciComboBox.Text = baudrateAliciComboBox.Items[0].ToString();
            baudrateVericiComboBox.Text = baudrateVericiComboBox.Items[0].ToString();
        }

        private void YerIstasyonu_Load(object sender, EventArgs e)
        {
            // Take all port names and assign them to portlist
            string[] portList = SerialPort.GetPortNames();
            comPortAliciComboBox.Items.Clear();
            // Show ports in comboxes and select first ones by default 
            comPortAliciComboBox.Items.AddRange(portList);
            comPortAliciComboBox.SelectedIndex = 0;
            vericiAyarlariGonderButton.Enabled = false;

            comPortVericiComboBox.Items.Clear();
            comPortVericiComboBox.Items.AddRange(portList);
            comPortVericiComboBox.SelectedIndex = 0;

        }

        // Declaring variables
        double temperature, humidity, pressure, altitude;
        double altitude_gy, pressure_gy, temperature_gy, humidity_gy;
        double latitude_gy, longitude_gy;
        double quality;
        double latitude, longitude, date, time;
        double gyrox, gyroy, gyroz;
        double accelx, accely, accelz;

        string[] gelen_veri;
        string gelen;

        private void serialPort1_DataReceived(object sender , SerialDataReceivedEventArgs e)
        {
            try
            {
                gelen = serialPort1.ReadLine();
                if (gelen.Equals(string.Empty))
                {
                    return;
                }
                Invoke(new EventHandler(Parse_Serial_Part_Data));


            }
            catch (Exception hata) 
            {
                MessageBox.Show("Hata:" + hata.Message);
            }


        }

        public void Parse_Serial_Part_Data(object sender , EventArgs e)
        {
            try 
            {
                gelen = gelen.Replace("\r", "");
                gelen = gelen.Replace("\n", "");
                gelen_veri = gelen.Split(',');

                if (gelen_veri[0].Equals("P1"))
                {
                    irtifaAnaAviyonikTextBox.Text = gelen_veri[1];
                    gpsİrtifaAnaAviyonikTextbox.Text = gelen_veri[2];
                    enlemİrtifaAnaAviyonikTextBox.Text = gelen_veri[3];
                    boylamAnaAviyonikTextBox.Text = gelen_veri[4];
                    jiroskopXAnaAviyonikTextBox.Text = gelen_veri[5];
                    jiroskopYAnaAviyonikTextBox.Text = gelen_veri[6];
                    jiroskopZAnaAviyonikTextbox.Text = gelen_veri[7];
                    ivmeXAnaAviyonikTextBox.Text = gelen_veri[8];
                    İvmeYAnaAviyonikTextBox.Text = gelen_veri[9];
                    ivmeZAnaAviyonikTextBox.Text = gelen_veri[10];
                    aciAnaAviyonikTextBox.Text = gelen_veri[11];

                }
                else if (gelen_veri[0].Equals("P2"))
                {

                    irtifaYedekAviyonikTextBox.Text = gelen_veri[1];
                    gpsYedekİrtifaTextBox.Text = gelen_veri[2];
                    enlemYedekAviyonikTextBox.Text = gelen_veri[3];
                    boylamYedekAviyonikTextBox.Text = gelen_veri[4];
                    jiroskopXYedekAviyonikTextBox.Text = gelen_veri[5];
                    jiroskopYYedekAviyonikTextBox.Text = gelen_veri[6];
                    jiroskopZYedekAviyonikTextBox.Text = gelen_veri[7];
                    ivmeXYedekAviyonikTextBox.Text = gelen_veri[8];
                    ivmeYYedekAviyonikTextBox.Text = gelen_veri[9];
                    ivmeZYedekAviyonikTextBox.Text = gelen_veri[10];
                    aciYedekAviyonikTextBox.Text = gelen_veri[11];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }



        private void aliciAyarlariPortAyarlarıButton_MouseEnter(object sender, EventArgs e)
        {
           aliciAyarlariPortAyarlarıButton.BackColor = Color.Black;
        }

        private void aliciAyarlariPortAyarlarıButton_MouseLeave(object sender, EventArgs e)
        {
            aliciAyarlariPortAyarlarıButton.BackColor = SystemColors.Control;

        }

        private void AliciAyarlariPortAcButton_MouseEnter(object sender, EventArgs e)
        {
            AliciAyarlariPortAcButton.BackColor = Color.Black;
        }

        private void AliciAyarlariPortAcButton_MouseLeave(object sender, EventArgs e)
        {
            AliciAyarlariPortAcButton.BackColor= SystemColors.Control;
        }

        private void vericiAyarlariPortAyarlariButton_MouseEnter(object sender, EventArgs e)
        {
            vericiAyarlariPortAyarlariButton.BackColor= Color.Black;
        }

        private void vericiAyarlariPortAyarlariButton_MouseLeave(object sender, EventArgs e)
        {
            vericiAyarlariPortAyarlariButton.BackColor = SystemColors.Control;
        }

        private void vericiAyarlarıPortAcButton_MouseEnter(object sender, EventArgs e)
        {
            vericiAyarlariPortAcButton.BackColor = Color.Black;
        }

        private void vericiAyarlarıPortAcButton_MouseLeave(object sender, EventArgs e)
        {
            vericiAyarlariPortAcButton.BackColor = SystemColors.Control;
        }

        private void vericiAyarlariGonderButton_MouseEnter(object sender, EventArgs e)
        {
            vericiAyarlariGonderButton.BackColor = Color.Black;
        }

        private void vericiAyarlariGonderButton_MouseLeave(object sender, EventArgs e)
        {
            vericiAyarlariGonderButton.BackColor= SystemColors.Control;
        }

        

        private void AliciAyarlariPortAcButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Assign selected port and baudrate to serialPort1 and then open it connection
                serialPort1.PortName = comPortAliciComboBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudrateAliciComboBox.Text);
                progressBarAliciAyarlari.Value = 100;
                serialPort1.Open();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (serialPort1.IsOpen)
            {

                AliciAyarlariPortAcButton.Enabled = false;
                vericiAyarlariGonderButton.Enabled = true;
            }

        }

        private void vericiAyarlariGonderButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // Send recieved data 
                serialPort1.Write(gonderilenVeriTextBox.Text);
                //gelenVeriTextBox.Text = gonderilenVeriTextBox.Text;
                gonderilenVeriTextBox.Clear();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void takımIdGirisiButton_Click(object sender, EventArgs e)
        {
            takimIdTextbox.Text = takimIdGirisiTextBox.Text;
            takimIdGirisiTextBox.Text = "" ;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void vericiAyarlariGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void takimAdiLabel_Click(object sender, EventArgs e)
        {

        }

        private void takimIdTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sayacLabel_Click(object sender, EventArgs e)
        {

        }

        private void sayacTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vericiAyarlarıPortAcButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Assign selected port and baudrate to serialPort1 and then open it connection
                serialPort1.PortName = comPortVericiComboBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudrateVericiComboBox.Text);
                progressBarVericiAyarlari.Value = 100;
                serialPort1.Open();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (serialPort1.IsOpen)
            {
                vericiAyarlariPortAcButton.Enabled = false;
                vericiAyarlariGonderButton.Enabled = true;

            }
        }

        private void comPortVericiLabel_Click(object sender, EventArgs e)
        {

        }

        private void comPortVericiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public delegate void veriGoster(String s);

        public void textBoxYaz(String s)
        {
            gelenVeriTextBox.Text += s;
        }
       

        private void anaAviyonikgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void aliciAyarlariPortAyarlarıButton_Click(object sender, EventArgs e)
        {

        }

        private void gelenVeriTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
