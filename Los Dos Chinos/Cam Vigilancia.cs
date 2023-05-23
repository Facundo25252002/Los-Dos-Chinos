using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow; // nugets para la camara, isntalar previamente
using AForge.Video;

namespace Los_Dos_Chinos
{
   

    public partial class Cam_Vigilancia : Form
    {
        private bool HayDispositivos = false;  // por defecto es false 
        private FilterInfoCollection Dispositivos;
        private VideoCaptureDevice miCam; 

        public Cam_Vigilancia()
        {
            InitializeComponent();
        }

        private void Cam_Vigilancia_Load(object sender, EventArgs e)
        {
            CargarDispositivo();  // metodo para cargas dispositivos que tengo
        }

        public void CargarDispositivo() {

            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice); // el metodo filter category me da audio o video
            if (Dispositivos.Count > 0) {
                HayDispositivos = true;
                for (int i = 0; i < Dispositivos.Count; i++) {

                    comboBox1.Items.Add(Dispositivos[i].Name.ToString());

                    comboBox1.Text = Dispositivos[0].ToString();
                }
            }
            else
            {

                HayDispositivos = false ;

            }
        
        }

        public void cerrarCam (){
            if (miCam != null && miCam.IsRunning)
            {
                miCam.SignalToStop();
                miCam = null;

             }
            
          
        
        }

        private void button1_Click(object sender, EventArgs e)
        {   try
            {
                cerrarCam();
                int i = comboBox1.SelectedIndex;
                string nombreVideo = Dispositivos[i].MonikerString;
                miCam = new VideoCaptureDevice(nombreVideo);
                miCam.NewFrame += new NewFrameEventHandler(Capturando);
                miCam.Start();


            }
            catch {

                MessageBox.Show("Seleccionar  dispositivo de camara correcto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // cuando seleccionaba la priemera opcion (que es lo que detecta los dispositivos) daba error, este try es para controlar ese error
            }
          
        }

        private void Capturando(object sender,NewFrameEventArgs eventArgs)
        {

            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = Imagen;


        }

        private void Cam_Vigilancia_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrarCam();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
