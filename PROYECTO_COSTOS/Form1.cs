using System;

namespace PROYECTO_COSTOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TRY AND CATCH PARA EXEPCION
            double A1 = (double.Parse(a1.Text));
            double A4 = (double.Parse(a4.Text));
            double A7 = (double.Parse(a7.Text));
            double mul = A4 * A7;
            a10.Text = mul.ToString();

            double A2 = (double.Parse(a2.Text));
            double A5 = (double.Parse(a5.Text));
            double A8 = (double.Parse(a8.Text));
            double mul1 = A5 * A8;
            a11.Text = mul1.ToString();

            double A3 = (double.Parse(a3.Text));
            double A6 = (double.Parse(a6.Text));
            double A9 = (double.Parse(a9.Text));
            double mul2 = A6 * A9;
            a12.Text = mul2.ToString();


            double A13 = (double.Parse(a13.Text));
            double A16 = (double.Parse(a16.Text));
            double mul3 = A13 * A16;
            a19.Text = mul3.ToString();

            double A14 = (double.Parse(a14.Text));
            double A17 = (double.Parse(a17.Text));
            double mul4 = A14 * A17;
            a20.Text = mul4.ToString();

            double A15 = (double.Parse(a15.Text));
            double A18 = (double.Parse(a18.Text));
            double mul5 = A15 * A18;
            a21.Text = mul5.ToString();

            double suma1 = (A1 + mul) - mul3;
            a22.Text = suma1.ToString();
            double suma2 = (A2 + mul1) - mul4;
            a23.Text = suma2.ToString();
            double suma3 = (A3 + mul2) - mul5;
            a24.Text = suma3.ToString();

            double B1 = (double.Parse(b1.Text));
            double B5 = (double.Parse(b5.Text));
            double mul6 = B1 + B5;
            b9.Text = mul6.ToString();

            double B2 = (double.Parse(b2.Text));
            double B6 = (double.Parse(b6.Text));
            double mul7 = B2 + B6;
            b10.Text = mul7.ToString();

            double B3 = (double.Parse(b3.Text));
            double B7 = (double.Parse(b7.Text));
            double mul8 = B3 + B7;
            b11.Text = mul8.ToString();

            double suma = (mul6) + (mul7) + (mul8);
            b12.Text = suma.ToString();

            b13.Text = mul3.ToString();
            b14.Text = mul4.ToString();
            b15.Text = mul5.ToString();

            b17.Text = suma1.ToString();
            b18.Text = suma2.ToString();
            b19.Text = suma3.ToString();

            double suma4 = (mul3) + (suma1);
            b21.Text = suma4.ToString();
            double suma5 = (mul4) + (suma2);
            b22.Text = suma5.ToString();
            double suma6 = (mul5) + (suma3);
            b23.Text = suma6.ToString();

            double divi = (mul6) / suma4;
            b25.Text = divi.ToString();
            double divi1 = (mul7) / suma5;
            b26.Text = divi1.ToString();
            double divi2 = (mul8) / suma6;
            b27.Text = divi2.ToString();

            c1.Text = mul.ToString();
            c2.Text = mul1.ToString();
            c3.Text = mul2.ToString();

            c4.Text = divi.ToString();
            c5.Text = divi1.ToString();
            c6.Text = divi2.ToString();

            double mul9 = (double.Parse(c1.Text)) * (double.Parse(c4.Text));
            c7.Text = mul9.ToString();
            double mul10 = (double.Parse(c2.Text)) *(double.Parse(c5.Text));
            c8.Text = mul10.ToString();
            double mul11 = (double.Parse(c3.Text)) *(double.Parse(c6.Text));
            c9.Text = mul11.ToString();

            double suma7 = (mul9) + (mul10) + (mul11);
            c10.Text = suma7.ToString();

            d1.Text = a1.Text;
            d2.Text = a2.Text;
            d3.Text = a3.Text;

            d4.Text = divi.ToString();
            d5.Text = divi1.ToString();
            d6.Text = divi2.ToString();

            double mul12 = (double.Parse(d1.Text)) * (double.Parse(d4.Text));
            d7.Text = mul12.ToString();
            double mul13 = (double.Parse(d2.Text)) * (double.Parse(d5.Text));
            d8.Text = mul13.ToString();
            double mul14 = (double.Parse(d3.Text)) * (double.Parse(d6.Text));
            d9.Text = mul14.ToString();

            double suma8 = (mul12) + (mul13) + (mul14);
            d10.Text = suma8.ToString();

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LOS DATOS TIENE QUE GUARDARSE
            //e1.Text = " ";
            //e2.Text = " ";
            //e3.Text = " ";
            //e4.Text = " ";
            e5.Text = d3.Text;
            //e6.Text = " ";
            //e7.Text = " ";
            //e8.Text = " ";
            //e9.Text = " ";
            //e10.Text = " ";
            //e11.Text = " ";

            f1.Text = d7.Text;
            f2.Text = d8.Text;
            double summa = (double.Parse(d7.Text)) + (double.Parse(d8.Text));
            f3.Text = summa.ToString();
            f4.Text = d9.Text;
            double summa1 = summa + (double.Parse(f4.Text));
            f5.Text = summa1.ToString();

            f6.Text = d4.Text;
            f7.Text = d5.Text;
            double summa2 = (double.Parse(d4.Text)) + (double.Parse(d5.Text));
            f8.Text = summa2.ToString();
            f9.Text = d6.Text;
            double summa3 = summa2 + (double.Parse(d9.Text));
            f10.Text = summa3.ToString();
        }
    }
}