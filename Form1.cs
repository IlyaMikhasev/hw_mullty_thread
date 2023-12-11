using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_mullty_thread
{
    public partial class Form1 : Form
    {
        Thread thread1;
        Thread thread2;
        int _minValue, _maxValue;
        bool pause1thread = false;
        bool pause2thread = false;
        public Form1()
        {
            InitializeComponent();
        }
        //проверка на простое число
        private bool IsPrimeNumber(int n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        //вывод простых чисел
        public void outputPrimeNumber()
        {
            for (var i = _minValue; i <= _maxValue; i++)
            {
                if (IsPrimeNumber(i))
                    tb_display_num.Text += i + " ";
                Thread.Sleep(500);
            }

        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private (int,int) validateNum() {
            int min = int.Parse(tb_bottom_number.Text);
            int max = int.Parse(tb_up_number.Text);
            if (min < 2)
                min = 2;
            if (max <= min)
                max = int.MaxValue;
            return (min,max);
        }
        private void b_gen_num_Click(object sender, EventArgs e)
        {
            int min = validateNum().Item1;
            int max = validateNum().Item2;
            
            _maxValue = max;
            _minValue = min;
            thread1 = new Thread(outputPrimeNumber);
            thread1.Start();
        }
        private void b_pause_num_Click(object sender, EventArgs e)
        {
            if (!pause1thread)
            {
                Thread.Sleep(Timeout.Infinite);
                b_pause_num.Text = "Пуск";
                pause1thread = true;
            }
            else {
                thread1.Interrupt();
                b_pause_num.Text = "Пауза";
                pause1thread = false;
            }
        }

        private void b_stop_num_Click(object sender, EventArgs e)
        {
            thread1.Abort();
        }
        //вывод чисел Фибоначи
        public void outputNumberFibonachi()
        {
            int min = 1, max = int.MaxValue;
            int j = min;
            for (int i = min; i <= max; i += j)
            {
                tb_display_numFi.Text += i + " ";
                j = i - j;
                Thread.Sleep(500);
            }
        }
        private void b_numFi_gen_Click(object sender, EventArgs e)
        {            
            thread2 = new Thread(outputNumberFibonachi);
            thread2.Start();
        }

        private void b_numFi_pause_Click(object sender, EventArgs e)
        {
            if (!pause2thread)
            {
                Thread.Sleep(Timeout.Infinite);
                b_numFi_pause.Text = "Пуск";
                pause1thread = true;
            }
            else
            {
                thread2.Interrupt();
                b_numFi_pause.Text = "Пауза";
                pause1thread = false;
            }
        }

        private void b_numFI_stop_Click(object sender, EventArgs e)
        {
            thread2.Abort();
        }
    }
}
