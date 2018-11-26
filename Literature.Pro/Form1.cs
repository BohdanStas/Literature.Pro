using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Literature.Pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarydbDataSet.Readers' table. You can move, or remove it, as needed.
            this.readersTableAdapter.Fill(this.librarydbDataSet.Readers);
            // TODO: This line of code loads data into the 'librarydbDataSet.Editions' table. You can move, or remove it, as needed.
            this.editionsTableAdapter.Fill(this.librarydbDataSet.Editions);
            // TODO: This line of code loads data into the 'librarydbDataSet.PBHouse' table. You can move, or remove it, as needed.
            this.pBHouseTableAdapter.Fill(this.librarydbDataSet.PBHouse);
            // TODO: This line of code loads data into the 'librarydbDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.librarydbDataSet.books);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            booksTableAdapter.Update(librarydbDataSet);
            pBHouseTableAdapter.Update(librarydbDataSet);
            editionsTableAdapter.Update(librarydbDataSet);
            readersTableAdapter.Update(librarydbDataSet);

            
        }

        private void bookAuthorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = booksBindingSource;
            label1.Text = "Книги";
        }

        private void видавництваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pBHouseBindingSource;
            label1.Text = "Видавництва";
        }

        private void видачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EditionsbindingSource;
            label1.Text = "Видачі";
        }

        private void читачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReadersbindingSource;
            label1.Text = "Читачі";
        }
    }
}
