using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ruletka
{
    public partial class Form1 : Form
    {
        private static int currentAccount; 

        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newGame();
        }

        private void newGame()
        {
            currentAccount = 300;
            labelCurrentAccount.Text = "Текущий счет: " + currentAccount;
            textBoxInput.Text = "";
            labelResult.Text = "Выпало:";
            labelWin.Text = "Выиграш:";
            pictureBoxResult.Image = null;
        }

        private void go()
        {
            int input = 0;
            if (textBoxInput.Text.Equals("")) {
                MessageBox.Show("Введите количество кредитов, которые вы хотите поставить","Ошибка");
                return;
            } else if (!radioButtonBlack.Checked && !radioButtonRed.Checked && !radioButtonGreen.Checked) {
                MessageBox.Show("Выберите, на что вы хотите поставить", "Ошибка");
                return;
            }
            else if ((input = Int32.Parse(textBoxInput.Text)) > currentAccount) {
                MessageBox.Show("Сумма, которую вы хотите поставить - больше чем вы имеете", "Ошибка");
                return;
            } else {
                currentAccount -= input;
                labelWin.Text = "Выиграш: 0";
                Random rnd = new Random();
                int output = rnd.Next(37);
                Thread.Sleep(1000);
                Win(input,output);
                labelResult.Text = "Выпало: " + output;
                labelCurrentAccount.Text = "Текущий счет: " + currentAccount;
            }
        }

        private void Win(int input, int output)
        {
            if (output == 0) {
                pictureBoxResult.Image = imageList.Images[2];
                if (radioButtonGreen.Checked)
                {
                    currentAccount += input * 35;
                    labelWin.Text = "Выиграш: " + input * 35;
                    MessageBox.Show("УРА!!! Вы выиграли: " + input * 35,"Зеленое");
                }
            } else 
            if ((output % 2) == 1)
            {
                pictureBoxResult.Image = imageList.Images[1];
                if (radioButtonRed.Checked)
                {
                    labelWin.Text = "Выиграш: " + input * 2;
                    currentAccount += input * 2;
                }
            }
            else
            {
                pictureBoxResult.Image = imageList.Images[0];
                if (radioButtonBlack.Checked)
                {
                    labelWin.Text = "Выиграш: " + input * 2;
                    currentAccount += input * 2;
                }
            }
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            go();
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
