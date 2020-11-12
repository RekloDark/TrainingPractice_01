using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int times = 0; //Счет времени
        Random rand = new Random((int)DateTime.Now.Ticks);//Рандом
        int[] number = new int[51];//Для цикла
        int[] mas = new int[52]; //Массив с случайным порядком чисел от 1 до 51
        public Form1()
        {
            //Изначальная позиция всех элементов
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            pictureBox1.Image = Image.FromFile("../../Resources/1.png");
            pictureBox2.Image = Image.FromFile("../../Resources/2.png");
            pictureBox3.Image = Image.FromFile("../../Resources/3.png");
            pictureBox4.Image = Image.FromFile("../../Resources/4.png");
            pictureBox5.Image = Image.FromFile("../../Resources/5.png");
            pictureBox6.Image = Image.FromFile("../../Resources/6.png");
            pictureBox7.Image = Image.FromFile("../../Resources/7.png");
            pictureBox8.Image = Image.FromFile("../../Resources/8.png");
            pictureBox9.Image = Image.FromFile("../../Resources/9.png");
            pictureBox10.Image = Image.FromFile("../../Resources/10.png");
            pictureBox11.Image = Image.FromFile("../../Resources/11.png");
            pictureBox12.Image = Image.FromFile("../../Resources/12.png");
            pictureBox13.Image = Image.FromFile("../../Resources/13.png");
            pictureBox14.Image = Image.FromFile("../../Resources/14.png");
            pictureBox15.Image = Image.FromFile("../../Resources/15.png");
            pictureBox16.Image = Image.FromFile("../../Resources/16.png");
            pictureBox17.Image = Image.FromFile("../../Resources/17.png");
            pictureBox18.Image = Image.FromFile("../../Resources/18.png");
            pictureBox19.Image = Image.FromFile("../../Resources/19.png");
            pictureBox20.Image = Image.FromFile("../../Resources/20.png");
            pictureBox21.Image = Image.FromFile("../../Resources/21.png");
            pictureBox22.Image = Image.FromFile("../../Resources/22.png");
            pictureBox23.Image = Image.FromFile("../../Resources/23.png");
            pictureBox24.Image = Image.FromFile("../../Resources/24.png");
            pictureBox25.Image = Image.FromFile("../../Resources/25.png");
            pictureBox26.Image = Image.FromFile("../../Resources/26.png");
            pictureBox27.Image = Image.FromFile("../../Resources/27.png");
            pictureBox28.Image = Image.FromFile("../../Resources/28.png");
            pictureBox29.Image = Image.FromFile("../../Resources/29.png");
            pictureBox30.Image = Image.FromFile("../../Resources/30.png");
            pictureBox31.Image = Image.FromFile("../../Resources/31.png");
            pictureBox32.Image = Image.FromFile("../../Resources/32.png");
            pictureBox33.Image = Image.FromFile("../../Resources/33.png");
            pictureBox34.Image = Image.FromFile("../../Resources/34.png");
            pictureBox35.Image = Image.FromFile("../../Resources/35.png");
            pictureBox36.Image = Image.FromFile("../../Resources/36.png");
            pictureBox37.Image = Image.FromFile("../../Resources/37.png");
            pictureBox38.Image = Image.FromFile("../../Resources/38.png");
            pictureBox39.Image = Image.FromFile("../../Resources/39.png");
            pictureBox40.Image = Image.FromFile("../../Resources/40.png");
            pictureBox41.Image = Image.FromFile("../../Resources/41.png");
            pictureBox42.Image = Image.FromFile("../../Resources/42.png");
            pictureBox43.Image = Image.FromFile("../../Resources/43.png");
            pictureBox44.Image = Image.FromFile("../../Resources/44.png");
            pictureBox45.Image = Image.FromFile("../../Resources/45.png");
            pictureBox46.Image = Image.FromFile("../../Resources/46.png");
            pictureBox47.Image = Image.FromFile("../../Resources/47.png");
            pictureBox48.Image = Image.FromFile("../../Resources/48.png");
            pictureBox49.Image = Image.FromFile("../../Resources/49.png");
            pictureBox50.Image = Image.FromFile("../../Resources/50.png");
            pictureBox51.Image = Image.FromFile("../../Resources/51.png");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Времени прошло:" + times;
            times++;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }
        //Начало игры, включение таймера, разблакировка кнопки
        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
            pictureBox1.Image = Image.FromFile("../../Resources/" + Convert.ToString(rand.Next(1, 51)) + ".png");

            for (int i = 1; i < number.Length; i++)
            {

                // l[i] = rand.Next(1, 51);

                int a = rand.Next(1, 51);
                if (!mas.Contains(a))
                {
                    mas[i] = a;
                }
                else
                    i--;

                switch (i)
                {
                    case 1:
                        pictureBox1.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 2:
                        pictureBox2.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 3:
                        pictureBox3.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 4:
                        pictureBox4.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 5:
                        pictureBox5.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 6:
                        pictureBox6.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 7:
                        pictureBox7.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 8:
                        pictureBox8.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 9:
                        pictureBox9.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 10:
                        pictureBox10.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 11:
                        pictureBox11.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 12:
                        pictureBox12.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 13:
                        pictureBox13.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 14:
                        pictureBox14.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 15:
                        pictureBox15.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 16:
                        pictureBox16.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 17:
                        pictureBox17.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 18:
                        pictureBox18.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 19:
                        pictureBox19.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 20:
                        pictureBox20.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 21:
                        pictureBox21.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 22:
                        pictureBox22.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 23:
                        pictureBox23.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 24:
                        pictureBox24.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 25:
                        pictureBox25.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 26:
                        pictureBox26.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 27:
                        pictureBox27.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 28:
                        pictureBox28.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 29:
                        pictureBox29.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 30:
                        pictureBox30.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 31:
                        pictureBox31.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 32:
                        pictureBox32.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 33:
                        pictureBox33.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 34:
                        pictureBox34.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 35:
                        pictureBox35.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 36:
                        pictureBox36.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 37:
                        pictureBox37.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 38:
                        pictureBox38.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 39:
                        pictureBox39.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 40:
                        pictureBox40.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 41:
                        pictureBox41.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 42:
                        pictureBox42.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 43:
                        pictureBox43.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 44:
                        pictureBox44.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 45:
                        pictureBox45.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 46:
                        pictureBox46.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 47:
                        pictureBox47.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 48:
                        pictureBox48.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 49:
                        pictureBox49.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 50:
                        pictureBox50.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                    case 51:
                        pictureBox51.Image = Image.FromFile("../../Resources/" + Convert.ToString(mas[i]) + ".png");
                        break;
                }
            }
            for (int k = 1; k < number.Length; k++)
            {
                mas[k] = 0;
            }
        }
        //Конец игры
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = ("Ваш результат " + times + " сек.");
            times = 0;
            button2.Enabled = false;
            button3.Enabled = true;
        }
        //Возвращение значений к первоначальным
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled = true;
            pictureBox1.Image = Image.FromFile("../../Resources/1.png");
            pictureBox2.Image = Image.FromFile("../../Resources/2.png");
            pictureBox3.Image = Image.FromFile("../../Resources/3.png");
            pictureBox4.Image = Image.FromFile("../../Resources/4.png");
            pictureBox5.Image = Image.FromFile("../../Resources/5.png");
            pictureBox6.Image = Image.FromFile("../../Resources/6.png");
            pictureBox7.Image = Image.FromFile("../../Resources/7.png");
            pictureBox8.Image = Image.FromFile("../../Resources/8.png");
            pictureBox9.Image = Image.FromFile("../../Resources/9.png");
            pictureBox10.Image = Image.FromFile("../../Resources/10.png");
            pictureBox11.Image = Image.FromFile("../../Resources/11.png");
            pictureBox12.Image = Image.FromFile("../../Resources/12.png");
            pictureBox13.Image = Image.FromFile("../../Resources/13.png");
            pictureBox14.Image = Image.FromFile("../../Resources/14.png");
            pictureBox15.Image = Image.FromFile("../../Resources/15.png");
            pictureBox16.Image = Image.FromFile("../../Resources/16.png");
            pictureBox17.Image = Image.FromFile("../../Resources/17.png");
            pictureBox18.Image = Image.FromFile("../../Resources/18.png");
            pictureBox19.Image = Image.FromFile("../../Resources/19.png");
            pictureBox20.Image = Image.FromFile("../../Resources/20.png");
            pictureBox21.Image = Image.FromFile("../../Resources/21.png");
            pictureBox22.Image = Image.FromFile("../../Resources/22.png");
            pictureBox23.Image = Image.FromFile("../../Resources/23.png");
            pictureBox24.Image = Image.FromFile("../../Resources/24.png");
            pictureBox25.Image = Image.FromFile("../../Resources/25.png");
            pictureBox26.Image = Image.FromFile("../../Resources/26.png");
            pictureBox27.Image = Image.FromFile("../../Resources/27.png");
            pictureBox28.Image = Image.FromFile("../../Resources/28.png");
            pictureBox29.Image = Image.FromFile("../../Resources/29.png");
            pictureBox30.Image = Image.FromFile("../../Resources/30.png");
            pictureBox31.Image = Image.FromFile("../../Resources/31.png");
            pictureBox32.Image = Image.FromFile("../../Resources/32.png");
            pictureBox33.Image = Image.FromFile("../../Resources/33.png");
            pictureBox34.Image = Image.FromFile("../../Resources/34.png");
            pictureBox35.Image = Image.FromFile("../../Resources/35.png");
            pictureBox36.Image = Image.FromFile("../../Resources/36.png");
            pictureBox37.Image = Image.FromFile("../../Resources/37.png");
            pictureBox38.Image = Image.FromFile("../../Resources/38.png");
            pictureBox39.Image = Image.FromFile("../../Resources/39.png");
            pictureBox40.Image = Image.FromFile("../../Resources/40.png");
            pictureBox41.Image = Image.FromFile("../../Resources/41.png");
            pictureBox42.Image = Image.FromFile("../../Resources/42.png");
            pictureBox43.Image = Image.FromFile("../../Resources/43.png");
            pictureBox44.Image = Image.FromFile("../../Resources/44.png");
            pictureBox45.Image = Image.FromFile("../../Resources/45.png");
            pictureBox46.Image = Image.FromFile("../../Resources/46.png");
            pictureBox47.Image = Image.FromFile("../../Resources/47.png");
            pictureBox48.Image = Image.FromFile("../../Resources/48.png");
            pictureBox49.Image = Image.FromFile("../../Resources/49.png");
            pictureBox50.Image = Image.FromFile("../../Resources/50.png");
            pictureBox51.Image = Image.FromFile("../../Resources/51.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = ("Здравствуйте! \nИгра очень простая, вам \nВсего напросто нужно найти все числа\n от 1 до 51,После чего нажать кнопку\nЗакончить игру\nУдачи!");
            button4.Enabled = false;
        }
    }
}