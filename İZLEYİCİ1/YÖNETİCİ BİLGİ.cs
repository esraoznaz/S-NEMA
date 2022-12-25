using genel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İZLEYİCİ1
{
    public partial class YÖNETİCİ_BİLGİ : Form
    {
        public YÖNETİCİ_BİLGİ()
        {
            InitializeComponent();
        }

        private void YÖNETİCİ_BİLGİ_Load(object sender, EventArgs e)
        {
            //label1.Text = Form1.gonderilecekBilgi;
            listBox1.Items.Add(Form1.gonderilecekBilgi1);
            listBox1.Items.Add(Form1.gonderilecekBilgi2);
            listBox1.Items.Add(Form1.gonderilecekBilgi3);
            listBox1.Items.Add(Form1.gonderilecekBilgi4);
        }
        İzleyici bilgi = new İzleyici();

        private void button_goruntule_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label_bakiye.Text = bilgi.BakiyeOgren().ToString();
            //label_bakiye.Text = Form1.gonderilecekBilgi5;
        }
    }
}
