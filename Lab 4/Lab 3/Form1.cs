using Microsoft.VisualBasic;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Magazine p1 = new();
            Newspaper d1 = new();
            PeriodicPublication f;
            f = p1;
            f.Info();
            f = d1;
            f.Info();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double a;
            string b;
            int c;
            int d;
            double f;
            b = Convert.ToString(Interaction.InputBox("������ ����� �������", "��������", "�� �������"));
            c = Convert.ToInt16(Interaction.InputBox("������ ������� ������� �� ��", "��������", "12"));
            a = Convert.ToDouble(Interaction.InputBox("������ ������� �������", "��������", "140,0"));
            d = Convert.ToInt32(Interaction.InputBox("������ ������� �������", "��������", "15"));
            f = Convert.ToDouble(Interaction.InputBox("������ ��� (� ��������) ���������� �� ���������� �������", "��������", "60"));
            Magazine second = new(a, b, c, d, f);
            second.Info();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Magazine temp = new();
            temp.Info();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Newspaper temp = new();
            temp.Info();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            double a;
            string b;
            int c;
            int d;
            double f;
            b = Convert.ToString(Interaction.InputBox("������ ����� �������", "��������", "�� �������"));
            c = Convert.ToInt16(Interaction.InputBox("������ ������� ������� �� ��", "��������", "12"));
            a = Convert.ToDouble(Interaction.InputBox("������ ������� �������", "��������", "140,0"));
            d = Convert.ToInt32(Interaction.InputBox("������ ������� �������", "��������", "15"));
            f = Convert.ToDouble(Interaction.InputBox("������ ��� (� ��������) ���������� �� ���������� �������", "��������", "60"));
            Newspaper temp = new(a, b, c, d, f);
            temp.Info();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� ������� ��'����: " + PeriodicPublication.count);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Button a = new();
            Random rnd = new();
            a.Width = 196;
            a.Height = 60;
            a.Left = rnd.Next(500);
            a.Top = rnd.Next(400);
            a.Text = ((Button)sender).Text;
            a.Parent = this;
            a.Show();
            a.Click += new System.EventHandler(this.Button8_Click);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            foreach (Control elem in this.Controls)
                elem.Left -= 60;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Random random = new();

            foreach (Control elem in Controls)
            {
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                ((Button)elem).BackColor = randomColor;
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            PeriodicPublication pub = new Magazine(120, "����� ������", 12, 50, 5);
            pub.Info();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new();
            secondForm.Show();
        }
    }
}