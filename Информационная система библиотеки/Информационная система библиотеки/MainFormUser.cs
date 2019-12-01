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
    // окно "Главное окно пользователя"
    public partial class MainFormUser : Form
    {
        public MainFormUser()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            searchBook.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BooksOfReader booksOfReader = new BooksOfReader();
            booksOfReader.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void MainFormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
