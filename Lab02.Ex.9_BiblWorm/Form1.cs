using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02.Ex._9_BiblWorm
{
    public partial class Form1 : Form
    {
        List<MyClass.Item> its = new List<MyClass.Item>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //Book
        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Инвентарный номер
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        //Magazine
        public string MagazineTitle 
        {
            get { return textBox4.Text;}
            set { textBox4.Text = value; }
        }
        public int MagazineVolume
        {
            get { return (int)numericUpDown8.Value;  }
            set {numericUpDown8.Value = value ; }
        }
        public int MagazineNumber
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public int MagazineYear
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public int MagazineInvNumber 
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }
        public bool MagazineExistence
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass.Book b = new MyClass.Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 1;
            Year = 2021;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (MyClass.Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyClass.Magazine b = new MyClass.Magazine(MagazineVolume, MagazineNumber, MagazineTitle, MagazineYear, MagazineInvNumber, MagazineExistence);
            its.Add(b);

            MagazineTitle = "";
            MagazineVolume = MagazineNumber /*= MagazineInvNumber = 1*/;
            Year = 1900;
            Existence = ReturnTime = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
