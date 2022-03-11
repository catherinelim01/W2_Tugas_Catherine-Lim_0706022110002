using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W2_Tugas_Catherine__Lim_0706022110002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string isi = "ISI", shown = "SHOWN", hide = "HIDE", pilihWarna = "WARNA", warnaDefault = "DEFAULT", warnaMerah = "MERAH", warnaHijau = "HIJAU", warnaBiru = "BIRU", restart = "RESTART", fontDiperbesar = "DIPERBESAR", fontDiperkecil = "DIPERKECIL";
        int a = 8;

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            string perintah = textBoxInputData.Text;
            string[] hasil = perintah.Split(':');

            if (hasil[0].ToUpper() == isi)
                labelOutput.Text = hasil[1];
            else if (perintah.ToUpper() == shown)
                labelOutput.Visible = true;
            else if (perintah.ToUpper() == hide)
                labelOutput.Visible = false;
            else if (hasil[0].ToUpper() == pilihWarna)
            {
                if (hasil[1].ToUpper() == warnaDefault)
                    labelOutput.ForeColor = Color.Black;
                else if (hasil[1].ToUpper() == warnaMerah)
                    labelOutput.ForeColor = Color.Red;
                else if (hasil[1].ToUpper() == warnaHijau)
                    labelOutput.ForeColor = Color.Green;
                else if (hasil[1].ToUpper() == warnaBiru)
                    labelOutput.ForeColor = Color.Blue;
                else
                    MessageBox.Show("Warna Tidak Tersedia");
            }
            else if (perintah.ToUpper() == restart)
            {
                labelOutput.Text = "[EMPTY]";
                labelOutput.Font = new Font ("Microsoft Sans Serif", 8);
                labelOutput.ForeColor = Color.Black;
            }
            else if (perintah.ToUpper() == fontDiperbesar)
            {  
                a ++;
                labelOutput.Font = new Font("Microsoft Sans Serif", a);
            }
            else if (perintah.ToUpper() == fontDiperkecil)
            {
                a--;
                labelOutput.Font = new Font("Microsoft Sans Serif", a);
            }
            else
            {
                MessageBox.Show("Syntax tidak terdaftar");
                labelOutput.Text = "Syntax tidak terdaftar!";
            }
        }
    }
}
