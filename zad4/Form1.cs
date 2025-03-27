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
            Bitmap bmpDest = null;

            using (Bitmap bmpSource = new Bitmap(pictureBox1.Image))
            {
                bmpDest = new Bitmap(bmpSource.Width, bmpSource.Height);

                for (int x = 0; x < bmpSource.Width; x++)
                {
                    for (int y = 0; y < bmpSource.Height; y++)
                    {

                        Color clrPixel = bmpSource.GetPixel(x, y);

                        if (clrPixel.G < clrPixel.R + clrPixel.B)
                        {
                            clrPixel = Color.FromArgb(0, 0, 0);
                        }



                        bmpDest.SetPixel(x, y, clrPixel);
                    }
                }
            }

            pictureBox1.Image = (Image)bmpDest;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            greeeen();
        }
    }



}
