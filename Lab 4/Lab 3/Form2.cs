using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab_3.Form1;

namespace Lab_3
{
    public partial class Form2 : Form
    {
        private readonly Random random = new();

        private PeriodicPublication publication1;
        private PeriodicPublication publication2;
        private PeriodicPublication selectedPublication;

        public Form2()
        {
            InitializeComponent();
            publication1 = new Magazine();
            publication2 = new Newspaper();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            publication1 = new Magazine();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            publication2 = new Newspaper();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int randomNumber = random.Next(2);

            if (randomNumber == 0)
            {
                selectedPublication = publication1;
            }
            else
            {
                selectedPublication = publication2;
            }

            if (selectedPublication != null)
            {
                selectedPublication.Info();
            }
            else
            {
                MessageBox.Show("Оберіть об'єкт для відображення інформації.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
