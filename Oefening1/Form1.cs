using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening1
{
    public partial class Form1 : Form
    {

        private int boxWidth = 80;
        private int boxHeight = 26;
        private int margin = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] dataArray = new string[24, 7];

            txtmaandag.Location = new Point(boxWidth + 20, 20);
            txtdinsdag.Location = new Point(boxWidth*2 + 20, 20);
            txtwoensdag.Location = new Point(boxWidth*3 + 20, 20);
            txtdonderdag.Location = new Point(boxWidth*4 + 20, 20);
            txtvrijdag.Location = new Point(boxWidth*5 + 20, 20);
            txtzaterdag.Location = new Point(boxWidth*6 + 20, 20);
            txtzondag.Location = new Point(boxWidth*7 + 20, 20);

            // lijst met textboxen om de uren voor te stellen
            for (int i = 0; i < dataArray.GetLength(0); i++)
            {
                TextBox newTxtBox = new TextBox
                {
                    Width = boxWidth,
                    Height = boxHeight
                };
                newTxtBox.Location = new Point( 10, (newTxtBox.Height * (i + 1)) +margin);
                Controls.Add(newTxtBox);
                newTxtBox.TextAlign = HorizontalAlignment.Center;
                newTxtBox.Text = (i + ":00");
                newTxtBox.Enabled = false;

            }

            // vullen van 2d-Array met 'rust'
            for (int day = 0; day < dataArray.GetLength(1); day++)
            {
                for (int hour = 0; hour < dataArray.GetLength(0); hour++)
                {
                    dataArray[hour, day] = "--";
                }
            }

            // textboxen printen met de waardes
            for (int day = 0; day < dataArray.GetLength(1); day++)
            {
                for (int hour = 0; hour < dataArray.GetLength(0); hour++)
                {
                    TextBox newTxtBox = new TextBox();
                    newTxtBox.Width = boxWidth;
                    newTxtBox.Height = boxHeight;
                    newTxtBox.Text = dataArray[hour, day];
                    newTxtBox.Location = new Point((newTxtBox.Width*(day+1))+20, (newTxtBox.Height * (hour + 1)) + margin);
                    Controls.Add(newTxtBox);
                    newTxtBox.TextAlign = HorizontalAlignment.Center;
                }
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdonderdag_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
