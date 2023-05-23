using BarcodeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Los_Dos_Chinos
{
    public partial class Codigo_Barras : Form
    {
        public Codigo_Barras()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string contenido = txtContenido.Text;
            int longitud_codigo = contenido.Length; 

            try
            {

                
                Barcode codigo = new Barcode();
                codigo.IncludeLabel = true;
                codigo.Alignment = AlignmentPositions.CENTER;
                codigo.LabelFont = new Font(FontFamily.GenericMonospace, 14, FontStyle.Regular);
                Image img = codigo.Encode(TYPE.UPCA, contenido, Color.Black, Color.White, 254, 148); // UPCA para cargar de  11 o 12 numeros
                pictureBox.Image = img;
                codigo.SaveImage(@"C:\Usuarios\Usuario\source\repos\Los Dos Chinos\Los Dos Chinos\Barcode\codigo.jpg", SaveTypes.JPG); // carpeta donde guardo la imagen automaticamente , en cada codigo generado la iamgen se reemplaza por la nueva(no se acumulan las iamgenes ,ahorro espacio) Cierro y vuelvo abrir  "La ventana para generar ", y vuelvoa  generar.
               

            }
            catch {

                    MessageBox.Show("Introducir una cantidad de números  de 11 a 12 ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);// para controlar el formato UPCA que pide  11 o 12 nuemros para generar el código.

            }
         
        }
    }
}
