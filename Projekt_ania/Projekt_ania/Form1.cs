using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Zadanie1
{

    public partial class Form1 : Form
    {
        double t = 0;
        double tz = 0;
        string krok, odp1, odp2, odp3, odp4, odp5, odp6, odp7, odp8, odp9, uczelnia, wykształcenie, zamieszkanie;
        char plec;
        int wiek;
        double t1, t2, t3, t4, t5, t6, t7, t8, t9;

        public Form1()
        {
            InitializeComponent();
            //pictureBox1.Image = Image.FromFile("pliki/zad_1_c/all.jpg");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                krok = label1.Text;

                switch (krok)
                {
                    case "1/9":
                        pictureBox1.Visible = true;
                        timer1.Start();
                        timer2.Start();
                        pictureBox1.Image = Image.FromFile("pliki/zad_2_a/all1.jpg");// po 3 sekundach znian obrazka 

                        groupBox1.Text = "";
                        button1.Text = "Dalej";
                        label2.Text = "Twoim zadaniem jest ustalenie kolejności prezentowanych wcześniej kształtów. Wykonaj zadanie możliwie dokładnie i szybko. Odpowiedź zaznacz klikając w wybrany obraz.";
                        break;
                    case "2/9":
                        textBox1.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;

                        timer2.Stop();
                        timer1.Stop();
                        odp1 = textBox1.Text + textBox4.Text + textBox5.Text;
                        t1 = t - 3;
                        t = 0;
                        tz = 0;
                        pictureBox1.Image = Image.FromFile("pliki/zad_1_b/all.jpg");
                        //label1.Text = "3/9";
                        timer1.Start();
                        timer2.Start();
                        break;

                    case "3/9":

                        textBox1.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;
                        textBox7.Visible = false;
                        textBox8.Visible = false;
                        textBox9.Visible = false;

                        timer1.Stop();
                        odp2 = textBox1.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text + textBox7.Text + textBox9.Text;
                        t2 = t - 3;
                        t = 0;
                        pictureBox1.Image = Image.FromFile("pliki/zad_1_c/all.jpg");
                        //label1.Text = "4/9";
                        timer1.Start();
                        timer2.Start();

                        break;
                    case "4/9":// przyciski 1/3 
                        textBox1.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;
                        textBox7.Visible = false;
                        textBox8.Visible = false;
                        textBox9.Visible = false;
                        label2.Text = "Twoim zadaniem jest wskazanie obrazu identycznego jak wzór na górze. Wykonaj zadanie możliwie dokładnie i szybko. Odpowiedź zaznacz klikając w wybrany obraz.";
                        timer1.Stop();
                        timer2.Stop();
                        odp3 = textBox1.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text + textBox7.Text + textBox9.Text;
                        t3 = t - 3;
                        tz = 0;
                        t = 0;
                        button2.Image = Image.FromFile("pliki/zad_2_a/1.jpg");
                        button3.Image = Image.FromFile("pliki/zad_2_a/2.jpg");
                        button4.Image = Image.FromFile("pliki/zad_2_a/3.jpg");
                        button5.Image = Image.FromFile("pliki/zad_2_a/4.jpg");
                        button6.Image = Image.FromFile("pliki/zad_2_a/5.jpg");
                        button1.Visible = false;
                        pictureBox1.Image = Image.FromFile("pliki/zad_2_a/all.jpg");
                        timer1.Start();
                        timer2.Start();
                        //label1.Text = "5/6";
                        groupBox1.Text = "";
                        break;

                    case "8/9":
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile("pliki/zad_2_b/all.jpg");

                        timer1.Stop();
                        timer2.Stop();
                        odp7 = textBox1.Text;
                        t7 = t - 3;
                        tz = 0;
                        t = 0;
                        timer2.Start();
                        timer1.Start();
                        break;
                    case "9/9":
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile("pliki/zad_3_c/all.jpg");

                        timer1.Stop();
                        timer2.Stop();
                        odp8 = textBox1.Text;
                        t8 = t - 3;
                        tz = 0;
                        t = 0;
                        label1.Text = "10/10";
                        timer2.Start();
                        timer1.Start();
                        break;

                    case "10/10":
                        timer1.Stop();
                        odp9 = textBox1.Text;
                        t9 = t - 3;
                        t = 0;
                        button1.Text = "zakończ";
                        button1.Visible = true;
                        groupBox1.Text = "Metryczka:";
                        panel1.Visible = true;
                        label1.Text = "";
                        label2.Text = "Proszę o wypełnienie metryczki i dziękuję za udział w badaniu.";
                        pictureBox1.Visible = false;
                        break;

                }
            }
            else
            {
                if (radioButton1.Checked == false & radioButton2.Checked == false)
                {
                    MessageBox.Show("Zaznacz swoją płeć", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (radioButton3.Checked == false & radioButton4.Checked == false)
                    {
                        MessageBox.Show("Zaznacz miejsce zamieszkania", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        if (textBox2.Text == "")
                        {
                            MessageBox.Show("Wpisz wiek", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            if (comboBox1.Text == "")
                            {
                                MessageBox.Show("Wybierz wykształcenie z listy", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {

                                if (radioButton1.Checked == true)
                                {
                                    plec = 'K';
                                }
                                else
                                {
                                    plec = 'M';
                                }


                                if (radioButton3.Checked == true)
                                {
                                    zamieszkanie = "miasto";
                                }
                                else
                                {
                                    zamieszkanie = "wieś";
                                }
                                wiek = Convert.ToInt16(textBox2.Text);
                                uczelnia = textBox3.Text;
                                wykształcenie = comboBox1.Text;

                                File.AppendAllText(@"Badanie2.txt", "\r\n" + plec + "\t" + wiek + "\t" + zamieszkanie + "\t" + uczelnia + "\t" + odp1 + "\t" + t1 + "\t" + odp2 + "\t" + t2 + "\t" + odp3 + "\t" + t3 + "\t" + odp4 + "\t" + t4 + "\t" + odp5 + "\t" + t5 + "\t" + odp6 + "\t" + t6 + "\t" + odp7 + "\t" + t7 + "\t" + odp8 + "\t" + t8 + "\t" + odp9 + "\t" + t9);
                                this.Close();
                            }
                        }
                    }

                }

            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = Math.Round(t + 0.1, 1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                int isNumber = 0;
                e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                int isNumber = 0;
                e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button5.Focus();
            // pictureBox1.Image = Image.FromFile("pliki/zad_2_a/all1.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            krok = label1.Text;

            switch (krok)
            {
                case "0/6":


                    break;
                case "5/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;

                    timer1.Stop();
                    timer2.Stop();
                    odp4 = "A";
                    t4 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_2_b/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_b/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_b/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_b/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_b/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_b/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_b/6.jpg");


                    timer1.Start();
                    timer2.Start();
                    break;

                case "6/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;

                    timer1.Stop();
                    odp5 = "A";
                    t5 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_2_c/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_c/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_c/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_c/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_c/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_c/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_c/6.jpg");
                    button8.Image = Image.FromFile("pliki/zad_2_c/7.jpg");
                    button9.Image = Image.FromFile("pliki/zad_2_c/8.jpg");
                    button10.Image = Image.FromFile("pliki/zad_2_c/9.jpg");
                    button11.Image = Image.FromFile("pliki/zad_2_c/10.jpg");


                    timer1.Start();
                    timer2.Start();

                    break;
                case "7/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button1.Visible = true;
                    label2.Text = "Twoim zadaniem jest wypisae wszystkich prezentowanych wcześniej liczb. Wykonaj zadanie możliwie dokładnie i szybko.";
                    timer1.Stop();
                    odp6 = "A";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_3_a/all.jpg");

                    timer1.Start();
                    timer2.Start();

                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            krok = label1.Text;

            switch (krok)
            {
                case "5/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;

                    timer1.Stop();
                    timer2.Stop();
                    odp5 = "B";
                    t5 = t - 3;
                    t = 0;

                    pictureBox1.Image = Image.FromFile("pliki/zad_2_b/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_b/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_b/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_b/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_b/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_b/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_b/6.jpg");


                    timer1.Start();
                    timer2.Start();
                    break;


                case "6/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;

                    timer1.Stop();
                    odp6 = "B";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_2_c/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_c/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_c/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_c/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_c/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_c/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_c/6.jpg");
                    button8.Image = Image.FromFile("pliki/zad_2_c/7.jpg");
                    button9.Image = Image.FromFile("pliki/zad_2_c/8.jpg");
                    button10.Image = Image.FromFile("pliki/zad_2_c/9.jpg");
                    button11.Image = Image.FromFile("pliki/zad_2_c/10.jpg");


                    timer1.Start();
                    timer2.Start();
                    break;

                case "7/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button1.Visible = true;
                    label2.Text = "Twoim zadaniem jest wypisae wszystkich prezentowanych wcześniej liczb. Wykonaj zadanie możliwie dokładnie i szybko.";
                    timer1.Stop();
                    odp6 = "B";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_3_a/all.jpg");

                    timer1.Start();
                    timer2.Start();

                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            krok = label1.Text;

            switch (krok)
            {
                case "5/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;

                    timer1.Stop();
                    timer2.Stop();
                    odp5 = "C";
                    t5 = t - 3;
                    t = 0;

                    pictureBox1.Image = Image.FromFile("pliki/zad_2_b/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_b/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_b/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_b/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_b/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_b/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_b/6.jpg");


                    timer1.Start();
                    timer2.Start();
                    break;


                case "6/9":

                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;

                    timer1.Stop();
                    odp6 = "C";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_2_c/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_c/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_c/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_c/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_c/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_c/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_c/6.jpg");
                    button8.Image = Image.FromFile("pliki/zad_2_c/7.jpg");
                    button9.Image = Image.FromFile("pliki/zad_2_c/8.jpg");
                    button10.Image = Image.FromFile("pliki/zad_2_c/9.jpg");
                    button11.Image = Image.FromFile("pliki/zad_2_c/10.jpg");


                    timer1.Start();
                    timer2.Start();
                    break;

                case "7/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button1.Visible = true;
                    label2.Text = "Twoim zadaniem jest wypisae wszystkich prezentowanych wcześniej liczb. Wykonaj zadanie możliwie dokładnie i szybko.";
                    timer1.Stop();
                    odp6 = "C";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_3_a/all.jpg");

                    timer1.Start();
                    timer2.Start();

                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            krok = label1.Text;

            switch (krok)
            {
                case "5/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;

                    timer1.Stop();
                    timer2.Stop();
                    odp5 = "D";
                    t5 = t - 3;
                    t = 0;

                    pictureBox1.Image = Image.FromFile("pliki/zad_2_b/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_b/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_b/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_b/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_b/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_b/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_b/6.jpg");


                    timer1.Start();
                    timer2.Start();
                    break;


                case "6/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;

                    timer1.Stop();
                    odp6 = "D";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_2_c/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_c/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_c/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_c/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_c/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_c/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_c/6.jpg");
                    button8.Image = Image.FromFile("pliki/zad_2_c/7.jpg");
                    button9.Image = Image.FromFile("pliki/zad_2_c/8.jpg");
                    button10.Image = Image.FromFile("pliki/zad_2_c/9.jpg");
                    button11.Image = Image.FromFile("pliki/zad_2_c/10.jpg");


                    timer1.Start();
                    timer2.Start();
                    break;

                case "7/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button1.Visible = true;
                    label2.Text = "Twoim zadaniem jest wypisae wszystkich prezentowanych wcześniej liczb. Wykonaj zadanie możliwie dokładnie i szybko.";
                    timer1.Stop();
                    odp6 = "D";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_3_a/all.jpg");

                    timer1.Start();
                    timer2.Start();

                    break;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            krok = label1.Text;

            switch (krok)
            {
                case "5/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;

                    timer1.Stop();
                    timer2.Stop();
                    odp5 = "E";
                    t5 = t - 3;
                    t = 0;

                    pictureBox1.Image = Image.FromFile("pliki/zad_2_b/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_b/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_b/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_b/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_b/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_b/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_b/6.jpg");


                    timer1.Start();
                    timer2.Start();
                    break;


                case "6/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;

                    timer1.Stop();
                    odp6 = "E";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_2_c/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_c/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_c/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_c/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_c/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_c/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_c/6.jpg");
                    button8.Image = Image.FromFile("pliki/zad_2_c/7.jpg");
                    button9.Image = Image.FromFile("pliki/zad_2_c/8.jpg");
                    button10.Image = Image.FromFile("pliki/zad_2_c/9.jpg");
                    button11.Image = Image.FromFile("pliki/zad_2_c/10.jpg");


                    timer1.Start();
                    timer2.Start();
                    break;

                case "7/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button1.Visible = true;
                    label2.Text = "Twoim zadaniem jest wypisae wszystkich prezentowanych wcześniej liczb. Wykonaj zadanie możliwie dokładnie i szybko.";
                    timer1.Stop();
                    odp6 = "E";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_3_a/all.jpg");

                    timer1.Start();
                    timer2.Start();

                    break;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            krok = label1.Text;

            switch (krok)
            {
                case "6/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;

                    timer1.Stop();
                    odp6 = "F";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_2_c/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_c/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_c/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_c/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_c/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_c/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_c/6.jpg");
                    button8.Image = Image.FromFile("pliki/zad_2_c/7.jpg");
                    button9.Image = Image.FromFile("pliki/zad_2_c/8.jpg");
                    button10.Image = Image.FromFile("pliki/zad_2_c/9.jpg");
                    button11.Image = Image.FromFile("pliki/zad_2_c/10.jpg");


                    timer1.Start();
                    timer2.Start();
                    break;

                case "7/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button1.Visible = true;
                    label2.Text = "Twoim zadaniem jest wypisae wszystkich prezentowanych wcześniej liczb. Wykonaj zadanie możliwie dokładnie i szybko.";
                    timer1.Stop();
                    odp6 = "F";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_3_a/all.jpg");

                    timer1.Start();
                    timer2.Start();

                    break;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            krok = label1.Text;

            switch (krok)
            {
                case "6/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;

                    timer1.Stop();
                    odp6 = "G";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_2_c/all.jpg");
                    button2.Image = Image.FromFile("pliki/zad_2_c/1.jpg");
                    button3.Image = Image.FromFile("pliki/zad_2_c/2.jpg");
                    button4.Image = Image.FromFile("pliki/zad_2_c/3.jpg");
                    button5.Image = Image.FromFile("pliki/zad_2_c/4.jpg");
                    button6.Image = Image.FromFile("pliki/zad_2_c/5.jpg");
                    button7.Image = Image.FromFile("pliki/zad_2_c/6.jpg");
                    button8.Image = Image.FromFile("pliki/zad_2_c/7.jpg");
                    button9.Image = Image.FromFile("pliki/zad_2_c/8.jpg");
                    button10.Image = Image.FromFile("pliki/zad_2_c/9.jpg");
                    button11.Image = Image.FromFile("pliki/zad_2_c/10.jpg");


                    timer1.Start();
                    timer2.Start();
                    break;

                case "7/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button1.Visible = true;
                    label2.Text = "Twoim zadaniem jest wypisae wszystkich prezentowanych wcześniej liczb. Wykonaj zadanie możliwie dokładnie i szybko.";
                    timer1.Stop();
                    odp6 = "G";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_3_a/all.jpg");

                    timer1.Start();
                    timer2.Start();

                    break;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            krok = label1.Text;

            switch (krok)
            {
                case "7/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button1.Visible = true;
                    label2.Text = "Twoim zadaniem jest wypisae wszystkich prezentowanych wcześniej liczb. Wykonaj zadanie możliwie dokładnie i szybko.";
                    timer1.Stop();
                    odp6 = "H";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_3_a/all.jpg");

                    timer1.Start();
                    timer2.Start();

                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            krok = label1.Text;

            switch (krok)
            {
                case "7/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button1.Visible = false;
                    button1.Visible = true;
                    label2.Text = "Twoim zadaniem jest wypisae wszystkich prezentowanych wcześniej liczb. Wykonaj zadanie możliwie dokładnie i szybko.";
                    timer1.Stop();
                    odp6 = "I";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_3_a/all.jpg");

                    timer1.Start();
                    timer2.Start();

                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            krok = label1.Text;

            switch (krok)
            {
                case "7/9":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button1.Visible = true;
                    label2.Text = "Twoim zadaniem jest wypisae wszystkich prezentowanych wcześniej liczb. Wykonaj zadanie możliwie dokładnie i szybko.";
                    timer1.Stop();
                    odp6 = "J";
                    t6 = t - 3;
                    t = 0;
                    tz = 0;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("pliki/zad_3_a/all.jpg");

                    timer1.Start();
                    timer2.Start();

                    break;

            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            tz = Math.Round(t + 0.1, 1);
            if (tz == 3.0)
            {
                switch (krok)
                {
                    case "1/9":
                        pictureBox1.Image = Image.FromFile("pliki/zad _1_A/all_odp.jpg");
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox1.Visible = true;
                        textBox4.Visible = true;
                        textBox5.Visible = true;
                        label1.Text = "2/9";
                        break;
                    case "2/9":
                        pictureBox1.Image = Image.FromFile("pliki/zad_1_B/all_odp.jpg");
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        textBox1.Visible = true;
                        textBox4.Visible = true;
                        textBox5.Visible = true;
                        textBox6.Visible = true;
                        textBox7.Visible = true;
                        textBox8.Visible = true;
                        textBox9.Visible = true;
                        label1.Text = "3/9";
                        break;
                    case "3/9":
                        pictureBox1.Image = Image.FromFile("pliki/zad_1_C/all_odp.jpg");
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        textBox1.Visible = true;
                        textBox4.Visible = true;
                        textBox5.Visible = true;
                        textBox6.Visible = true;
                        textBox7.Visible = true;
                        textBox8.Visible = true;
                        textBox9.Visible = true;
                        label1.Text = "4/9";
                        break;
                    case "4/9":
                        pictureBox1.Visible = false;
                        button2.Visible = true;
                        button3.Visible = true;
                        button4.Visible = true;
                        button5.Visible = true;
                        button6.Visible = true;
                        label1.Text = "5/9";
                        break;

                    case "5/9":
                        pictureBox1.Visible = false;
                        button2.Visible = true;
                        button3.Visible = true;
                        button4.Visible = true;
                        button5.Visible = true;
                        button6.Visible = true;
                        button7.Visible = true;

                        label1.Text = "6/9";
                        break;

                    case "6/9":
                        pictureBox1.Visible = false;
                        button2.Visible = true;
                        button3.Visible = true;
                        button4.Visible = true;
                        button5.Visible = true;
                        button6.Visible = true;
                        button7.Visible = true;
                        button8.Visible = true;
                        button9.Visible = true;
                        button10.Visible = true;
                        button11.Visible = true;
                        label1.Text = "7/9";
                        break;

                    case "7/9":
                        pictureBox1.Visible = false;
                        textBox1.Text = "";
                        textBox1.Visible = true;
                        label1.Text = "8/9";
                        break;

                    case "8/9":
                        pictureBox1.Visible = false;
                        textBox1.Text = "";
                        textBox1.Visible = true;
                        label1.Text = "9/9";
                        break;
                    case "9/9":
                        pictureBox1.Visible = false;
                        textBox1.Text = "";
                        textBox1.Visible = true;
                        label1.Text = "10/10";
                        break;
                }
            }
        }
    }
}
