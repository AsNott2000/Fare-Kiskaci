using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareKıskacı
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //this.IsMdiContainer= true; bunu sonra halledicem form1 in içindekilerin png şekilde görünmemesine yol açıyor
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }



        Form2 form2;
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (form2 == null)
            {
                form2 = new Form2();
                //form2.MdiParent = this; //form1 in içinde açılmasını sağlar
                Size = new Size(950, 950); //form 2 açıldığında çözünürlük onunkine ayarlanır

                form2.Show();
                this.Hide();
                playButton2.Hide(); //yeni form2 açıldığında buton kaybolur
            }
        }

        private void playButton2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {


            }
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.discord.gg/zEmtM2nYht");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com/borekli_poca");
        }
    }
}
