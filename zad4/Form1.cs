using System.Data;
using System;

namespace zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadImage(string filePath)
        {
            // Sprawd�, czy plik istnieje
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik xd nie istnieje.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Odczytaj zawarto�� pliku CSV

            pictureBox1.Image = Image.FromFile(filePath);


        }
        private void wczytaj_Click(object sender, EventArgs e)
        {
            

            
        }

        public void rotateImage()
        {

        }
        public void rotateImage1()
        {

        }
        public void rotateImage2()
        {

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
            // Wy�wietlenie okna dialogowego wyboru pliku CSV
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            // Je�li u�ytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywo�anie funkcji wczytuj�cej dane z pliku CSV
                loadImage(openFileDialog1.FileName);
            }
        }
    }



}
