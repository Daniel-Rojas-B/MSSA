using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod7DBFirstDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PCAD16BooksEntities pCAD16BooksEntities = new PCAD16BooksEntities();
            dataGridView1.DataSource = pCAD16BooksEntities.Books.ToList();
        }
    }
}
