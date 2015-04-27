using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BookInfoApp
{
    public partial class BookInfoUI : Form
    {
        public BookInfoUI()
        {
            InitializeComponent();
        }

        Hashtable bookInfo = new Hashtable();

        private void addBookInfoButton_Click(object sender, EventArgs e)
        {
            if (isbnNumTextBox.Text != string.Empty && bookInfoTextBox.Text != string.Empty)
            {
                bookInfo.Add(isbnNumTextBox.Text, bookInfoTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please enter ISBN number and Book Details");
            }

            isbnNumTextBox.Clear();
            bookInfoTextBox.Clear();
        }

        private void searchBookInfoButton_Click(object sender, EventArgs e)
        {
            isbnSearchTextBox.Clear();
            bookInfoSearchTextBox.Clear();
            if(isbnSearchTextBox.Text !=string.Empty  &&
                bookInfo.ContainsKey(isbnSearchTextBox.Text))
            {
                bookInfoSearchTextBox.Text =(string) bookInfo[isbnSearchTextBox.Text];
            }
            else
            {
                MessageBox.Show("Book is  not found");
            }


        }
    }
}
