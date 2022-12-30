using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak = 0;
        string kelime = "FERRARI";
        private void button1_Click(object sender, EventArgs e)
        {                              
                if (label1.Text == "F")
                {
                    if (label2.Text == "E")
                    {
                        if (label3.Text == "R")
                        {
                            if (label4.Text == "R")
                            {
                                if (label5.Text == "A")
                                {
                                    if (label6.Text == "R")
                                    {
                                        if (label7.Text == "I")
                                        {
                                            button1.Enabled = false;
                                            textBox1.Enabled = false;
                                            MessageBox.Show("Tebrikler Oyunu Kazandınız!");
                                            Application.Exit();
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
                textBox1.Text = textBox1.Text.ToUpper();
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Lütfen Bir Harf Girin");
                }
                else
                {

                    if (textBox1.Text == kelime[0].ToString())
                    {
                        label1.Text = "F";
                    }
                    else
                    {
                        if (textBox1.Text == kelime[1].ToString())
                        {
                            label2.Text = "E";
                        }
                        else
                        {
                            if (textBox1.Text == kelime[2].ToString())
                            {
                                label3.Text = "R";
                                label4.Text = "R";
                                label6.Text = "R";
                            }
                            else
                            {
                                if (textBox1.Text == kelime[4].ToString())
                                {
                                    label5.Text = "A";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime[6].ToString())
                                    {
                                        label7.Text = "I";
                                    }
                                    else
                                    {

                                        hak++;
                                    if (hak == 1)
                                    {
                                        pictureBox1.ImageLocation = "C:\\PROJECTS\\adamAsmaca\\Resources\\1.png";
                                        MessageBox.Show("KALAN HAKKINIZ = 8");

                                    }
                                    else if (hak == 2)
                                    {
                                        pictureBox1.ImageLocation = "C:\\PROJECTS\\adamAsmaca\\Resources\\2.png";
                                        MessageBox.Show("KALAN HAKKINIZ = 7");

                                    }
                                    else if (hak == 3)
                                    {
                                        pictureBox1.ImageLocation = "C:\\PROJECTS\\adamAsmaca\\Resources\\3.png";
                                        MessageBox.Show("KALAN HAKKINIZ = 6");
                                    }
                                    else if (hak == 4)
                                    {

                                        pictureBox1.ImageLocation = "C:\\PROJECTS\\adamAsmaca\\Resources\\4.png";
                                        MessageBox.Show("KALAN HAKKINIZ = 5");
                                    }
                                    else if (hak == 5)
                                    {

                                        pictureBox1.ImageLocation = "C:\\PROJECTS\\adamAsmaca\\Resources\\5.png";
                                        MessageBox.Show("KALAN HAKKINIZ = 4");
                                    }
                                    else if (hak == 6)
                                    {

                                        pictureBox1.ImageLocation = "C:\\PROJECTS\\adamAsmaca\\Resources\\6.png";
                                        MessageBox.Show("KALAN HAKKINIZ = 3");
                                    }
                                    else if (hak == 7)
                                    {

                                        pictureBox1.ImageLocation = "C:\\PROJECTS\\adamAsmaca\\Resources\\7.png";
                                        MessageBox.Show("KALAN HAKKINIZ = 2");
                                    }
                                    else if (hak == 8)
                                    {

                                        pictureBox1.ImageLocation = "C:\\PROJECTS\\adamAsmaca\\Resources\\8.png";
                                        MessageBox.Show("KALAN HAKKINIZ = 1");
                                    }
                                    else if (hak == 9)
                                        {
                                            pictureBox1.ImageLocation = "C:\\PROJECTS\\adamAsmaca\\Resources\\9.png";
                                            button1.Enabled = false;
                                            textBox1.Enabled = false;
                                            MessageBox.Show("HAKKINIZ KALMADI");
                                            MessageBox.Show("Oyunu Kaybettiniz!");
                                            MessageBox.Show("Scuderia Ferrari", "Cevap");
                                            Application.Exit();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                textBox1.Clear();
        }                  
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Adam Asmaca'ya hoşgeldiniz.");
            pictureBox1.BackColor = Color.White;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("İtalyan Araba Markası");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
