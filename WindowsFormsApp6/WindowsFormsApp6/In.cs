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

namespace WindowsFormsApp6
{
    public partial class In : Form
    {
        public In()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && textBox1.Text != null)
            {
                if (listBox1.SelectedItem.ToString() == "Админ")
                {
                    using (StreamReader reader = new StreamReader(@"C:\Users\Алексей\source\repos\WindowsFormsApp6\WindowsFormsApp6\bin\People\log1.ps"))
                    {
                        string buf;

                        while ((buf = reader.ReadLine()) != null)
                        {
                            if (textBox1.Text == buf)
                            {
                                MessageBox.Show("Приветствую: Администратор", "Успешно");
                                Admin frm2 = new Admin();
                                frm2.Show();
                                this.Hide();
                            }



                        }
                        
                      

                    }

                        if (listBox1.SelectedItem.ToString() == "Товаровед")
                        {
                            using (StreamReader reader2 = new StreamReader(@"C:\Users\Алексей\source\repos\WindowsFormsApp6\WindowsFormsApp6\bin\People\log3.ps"))
                            {
                                string buf3;

                                while ((buf3 = reader2.ReadLine()) != null)
                                {
                                    if (textBox1.Text == buf3)
                                    {
                                        MessageBox.Show("Приветствую: Товаровед", "Успешно");
                                        Tovaroved frm4 = new Tovaroved();
                                        frm4.Show();
                                        this.Hide();
                                    }



                                }


                            }
                        }
                    if (listBox1.SelectedItem.ToString() == "Кассир")
                    { 
                            using (StreamReader reader1 = new StreamReader(@"C:\Users\Алексей\source\repos\WindowsFormsApp6\WindowsFormsApp6\bin\People\log2.ps"))
                            {
                                string buf1;

                                while ((buf1 = reader1.ReadLine()) != null)
                                {
                                    if (textBox1.Text == buf1)
                                    {
                                        MessageBox.Show("Приветствую: Кассир", "Успешно");
                                        Kassa frm3 = new Kassa();
                                        frm3.Show();
                                        this.Hide();
                                    }



                                }


                            }
                    }

                }
    }   }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists (@"E:\12343456546456867.li"))
            {
                MessageBox.Show("Приветствую: Кассир", "Успешно");
                Kassa frm3 = new Kassa();
                frm3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Смарткарта не найдена!", "Ошибка");
            }
        }
    }
    
}
