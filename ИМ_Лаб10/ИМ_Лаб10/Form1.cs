using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИМ_Лаб10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] name = new string[]
            {
                "1 Боевые кабаны",
                "2 Рыжие псы",
                "3 Птицы гордые",
                "4 Звери дикие"
            };
            Grid.RowCount++;
            for (int i = 0; i < 4; i++)
            {
                Grid.RowCount++;
                Grid.ColumnCount++;
                Grid.Columns[i].Width = 100;
            }
            Grid.Columns[4].Width = 100;
            for (int i = 1; i < 5; i++) {
                Grid.Rows[i].Cells[0].Value = name[i - 1];
                Grid.Rows[0].Cells[i].Value = i;
                Grid.Rows[i].Cells[i].Style.BackColor = Color.DarkSalmon;
            }
        }

        int i = 1, j = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            double y1, y2;
            Random rand = new Random();

            y1 = (double)numericUpDown1.Value;
            y2 = (double)numericUpDown2.Value;

            double variable1, avariable2;
            double S1 = 0, S2 = 0;
            int point1 = 0, point2 = 0;

            while (S1 >= -y1 || S2 >= -y2)
            {
                variable1 = rand.NextDouble();
                avariable2 = rand.NextDouble();

                if (S1 >= -y1)
                {
                    S1 += Math.Log(variable1);
                    point1++;
                }

                if (S2 >= -y2)
                {
                    S2 += Math.Log(avariable2);
                    point2++;
                }
            }

            if (point1 > point2)
            {
                i++;
            }
            if (point1 < point2)
            {
                j++;
            }
            if (i >= 5 || j >= 5) { return ; }
            Grid.Rows[i].Cells[j].Value = point2 + ":" + point1;
            Grid.Rows[j].Cells[i].Value = point1 + ":" + point2;
        }
    }
}
