using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace FareKıskacı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;

            

            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            trackBar1.Value = CalcVol / (ushort.MaxValue / 10);
        }
        

        
        [DllImport("Winmm.dll")] //ses arttırma ve azaltma DLL'leri
        private static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("Winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        int score = 0;
        int saniye = 30;
        
        private void fare_Click(object sender, EventArgs e)
        {
            
            timer2.Start();
            fare.Hide();

            Point loc = new Point();

            Random rnd_x = new Random();


            int[] x = { 119, 338, 560 };
            int[] y = { 81, 250, 420 };

            int loc_x = rnd_x.Next(0, x.Length);
            int loc_y = rnd_x.Next(0, y.Length);

            loc.X = x[loc_x];
            loc.Y = y[loc_y];

            fare.Location = loc;
            score++;
            skor.Text = Convert.ToString(score);
        }

        
        
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            timer1.Interval = 1000; // 1000 interval 1 saniyedir.
            saniye = saniye - 1;
            sure.Text = Convert.ToString(saniye);
           
            if (sure.Text == "0")
            {
                timer1.Stop();
                saniye = 30;
                fare.Hide(); 

                DialogResult sonuc;
                sonuc = MessageBox.Show("Oyun bitti puanınız: " + skor.Text, "TEKRAR OYNAMAK İSTER MİSİNİZ?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                

                if (sonuc == DialogResult.Yes)
                {
                    playButton1.Show();
                }
                else
                {
                    Environment.Exit(0); //oyunu tamamen kapatan bir kod
                }
            }

           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 450; //0.35 saniye.

            Point loc = new Point(); //point ile bir nokta oluşturduk
            Random rnd = new Random(); // Locaitonları rastgele yapmak için random oluşturduk
             
            int[] x = { 119, 338, 560 }; //x lerin locationları diziye koyuldu
            int[] y = { 81, 250, 420 }; // Y lerin locationları diziye koyuldu 

            int loc_x = rnd.Next(0, x.Length); //random x noktası belirledik
            int loc_y = rnd.Next(0, y.Length); //random y noktası belirledik

            loc.X = x[loc_x]; //fareyi belirlediği noktayı bulacak
            loc.Y = y[loc_y];

            fare.Location = loc; //fareyi ışınlayacak
            fare.Show(); 
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            
            fare.Hide();
           
            playSimpleSound();
        }

        public void playSimpleSound()
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = @"C:\Users\ncskn\Desktop\Fare Oyunum\Sound\vendetta.wav";
            ses.PlayLooping();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int NewVolume = ((ushort.MaxValue / 10) * trackBar1.Value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }
        
        private void playButton1_Click(object sender, EventArgs e)
        {
            fare.Show();
            score = 0;
            skor.Text = Convert.ToString(score);
            timer1.Start(); 
            playButton1.Hide(); //fare hareket etmeye başlayacağı için bir daha play butonu çıkmaması lazım
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            DialogResult sonuc;
            sonuc = MessageBox.Show("Kapatmak istediğinize emin misiniz? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);


            if (sonuc == DialogResult.Yes) //evete bastığında oyun tamamen kapanır
            {
                Environment.Exit(0); //oyunu tamamen kapatan bir kod
            }
            else
            {
                
            }

        }
    }
}
