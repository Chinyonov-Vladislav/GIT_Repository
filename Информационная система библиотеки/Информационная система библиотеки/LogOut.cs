using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система_библиотеки
{
    // окно "Вход в систему"
    public partial class LogOut : Form
    {
        string login = "admin";
        string password = "12345";
        
        public LogOut()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MainFormUser mainFormUser = new MainFormUser();
            mainFormUser.ShowDialog();
            this.Hide();
            //Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string user = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (textBox1.Text==login && textBox2.Text==password && user == "Библиотекарь (Администратор)")
            {
                MainFormAdmin mainFormAdmin = new MainFormAdmin();
                mainFormAdmin.Show();
                this.Hide();
            }
            if (textBox1.Text != login && textBox2.Text != password && user == "Библиотекарь (Администратор)")
            {
                MessageBox.Show("Ошибка входа. Логин или пароль администратора были введены неверно!");
            }
            if (user == "")
            { MessageBox.Show("Ошибка входа. Тип пользователя не был выбран!"); }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.PasswordChar = '*';
            }
            else
            {
                textBox1.PasswordChar = '\0';
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.PasswordChar = '*';
            }
            else
            {
                textBox2.PasswordChar = '\0';
            }
        }
    }
}
