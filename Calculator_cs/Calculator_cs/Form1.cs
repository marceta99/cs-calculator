using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_cs
{
    public partial class Form1 : Form
    {

        bool zapamceno = false;
        double memorisanBroj;
        char operacija;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";     //ovo znaci da stavim 0 po defaultu na ekran kada se prvi put ucita program

            //ali posto 0 na pocetku na vecini digitrona stoji sa desne a kod nas sa leve treba to da 
            //promenimo da stoji na desnoj strani tako sto idemo u propertis od textBoxa u formi i u 
            //textAlign stavimo right


        }



        private void button1_Click(object sender, EventArgs e)
        {
            //ovo je dugme 7
            if (zapamceno == true) //kada smo pritisli neko dugme za operaciju(+,=,/*) tada je zapamceno = true i onda posle te operacije
            {                      //ako pritisnemo broj 7 samo on treba da se pojavi na ekranu i onda kada se pritisne jednako prikazace se zbir npr
                textBox1.Text = "7";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "7"; //pocetni slucaj kada se ucitala aplikacija kada je i dalje zapamecno = false ali je 0 na ekranu po defaultu
            }
            else
            {
                textBox1.Text = textBox1.Text + "7"; //i treci slucaj kada hocemo da dodamo 7 na kraj npr imamo broj 117
            }
            zapamceno = false;   //ako je zapamceno bilo true onda treba kada kliknemo na broj 7 da vratimo na false

            //i sad sve ovo gore kopiramo kod svih brojeva 



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dugme 8

            if (zapamceno == true)
            {
                textBox1.Text = "8";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }

            zapamceno = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dugme 9

            if (zapamceno == true)
            {
                textBox1.Text = "9";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
            zapamceno = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //cetri

            if (zapamceno == true)
            {
                textBox1.Text = "4";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
            zapamceno = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //pet

            if (zapamceno == true)
            {
                textBox1.Text = "5";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
            zapamceno = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //sest

            if (zapamceno == true)
            {
                textBox1.Text = "6";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
            zapamceno = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //jedan

            if (zapamceno == true)
            {
                textBox1.Text = "1";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
            zapamceno = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //2

            if (zapamceno == true)
            {
                textBox1.Text = "2";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
            zapamceno = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //tri

            if (zapamceno == true)
            {
                textBox1.Text = "3";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
            zapamceno = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //nula


            if (zapamceno == true)
            {
                textBox1.Text = "0";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
            zapamceno = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //tacka 

            textBox1.Text = textBox1.Text + ".";   //kada se pristne tacka samo se doda tacka na kraj 
            zapamceno = false;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //ono C sto inace znaci Clear i to dugme brise sve i stavlja 0 

            textBox1.Text = "0";
            zapamceno = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //plus 
            //znaci kada neko klikne dugme  plus treba da se zapamti prethonda vrednost sa ekrana

            operacija = '+';
            zapamceno = true;  //i postavlja se zapamceno na true zato sto hocemo posle kada prisnemo broj da zna da li je bilo prisnuta neka operacija da onda samo ispise taj broj na ekranu 
            memorisanBroj = double.Parse(textBox1.Text); //pamtimo taj broj koji je bio na ekranu kada se pristnuo plus da bi posle mogli da odradimo zbir kada se pritisne drugi broj pa jednako 
        }
        private void button14_Click(object sender, EventArgs e)
        {
            //minus
            operacija = '-';
            zapamceno = true;
            memorisanBroj = double.Parse(textBox1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //mnozenje
            operacija = 'X';
            zapamceno = true;
            memorisanBroj = double.Parse(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //deljenje
            operacija = ':';
            zapamceno = true;
            memorisanBroj = double.Parse(textBox1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //jednako 

            double trenutniBroj = double.Parse(textBox1.Text);   //ovo je broj koji je trenutno zapisan na ekranu 

            if(operacija == '+')                                //znaci kada se prisnuo plus operacija ce da dobije vrednost "+"
            {                                                   //i onda ce da znamo da je kliknuto plus
                double zbir = memorisanBroj + trenutniBroj;     //zbir je  zbir onog memorisanog broja koji smo sacuvali kada je prisnuto plus i onog drugog broja koji je bio na ekranu kada  je pritisnuto jednako 
                textBox1.Text = zbir.ToString();                //na ekranu ispisi zbir 
            }
            else if (operacija == '-')
            {
                double razlika = memorisanBroj - trenutniBroj;
                textBox1.Text = razlika.ToString();  
            }
            else if (operacija == ':')
            {
                if (trenutniBroj != 0)
                {
                    double kolicnik = memorisanBroj / trenutniBroj;
                    textBox1.Text = kolicnik.ToString();

                }
                else
                {
                    textBox1.Text = "you can not devide with zero ";  
                }
            }
            else if (operacija == 'X')
            {
                double proizvod = memorisanBroj * trenutniBroj;
                textBox1.Text = proizvod.ToString();
            }
        }
    }
}