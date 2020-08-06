using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String filepath;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

//du penis
//mein Penis ist größer
//ok

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;

                button2.Text = filepath;
                //Picturebox1.Image = New Bitmap("Image Path")

                //set_Image(pictureBox1, filepath);





                /*
                 * Potentielle next steps:
                 * A) der Open File Dialog sollte nur Bilddateien anzeigen und auch nur diese öffnen können. Vllt hilfreich:
                 * https://www.c-sharpcorner.com/UploadFile/mahesh/openfiledialog-in-C-Sharp/#:~:text=C%23%20OpenFileDialog%20control%20allows%20us,folders%20and%20select%20a%20file.
                 * 
                 * B) die mit dem Open FIle dialog geöffnete bilddatei sollte in der Picture Box angezeigt werden. Dafür muss verstanden werden wie ein beliebiges Bild allgemein in
                 * die Picture Box geladen werden kann.
                 * 
                 * C) wenn B erfolgt ist kann man damit anfangen Rechtecke auf das User Interface zu malen um die Blüten zu markieren
                 * 
                 * D) als potentielle Übung: Erstelle eine Methode ~name(Input) die eine .csv Datei irgendwo lokal auf deinem Rechner speichert
                 * 
                 * E) Das Trello Board sollte mal zum laufen gebracht werden.
                 */




            }
        }

        public void set_Image(PictureBox pictureBox1, String filepath)
        {

            pictureBox1.Image = new Bitmap(filepath);
        }
    }
}
