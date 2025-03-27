using System.Data;
using System;
using System.Linq.Expressions;

namespace zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int rorataeval = 0;
        public void loadImage(string filePath)
        {
            // SprawdŸ, czy plik istnieje
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik xd nie istnieje.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Odczytaj zawartoœæ pliku CSV

            pictureBox1.Image = Image.FromFile(filePath);
           

        }
        private void wczytaj_Click(object sender, EventArgs e)
        {



        }

        public void rotateImage()
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }
        public void rotateImage1()
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }
        public void rotateImage2()
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
        }
        public void invert()
        {

        }
        public void greeeen()
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Wyœwietlenie okna dialogowego wyboru pliku CSV
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywo³anie funkcji wczytuj¹cej dane z pliku CSV
                loadImage(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (rorataeval)
            {
                case 90:
                    label1.Text = rorataeval.ToString();
                    rotateImage();
                    break;
                case 180:
                    label1.Text = rorataeval.ToString();
                    rotateImage1();
                    break;
                case 270:
                    label1.Text = rorataeval.ToString();
                    rotateImage2();
                    break;
                default:
                    // code block
                    break;
            }
            pictureBox1.Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rorataeval = 90;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rorataeval = 180;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rorataeval = 270;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = rorataeval.ToString();
        }
    }



}
