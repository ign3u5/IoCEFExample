using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly CollabSoftContext _database;

        public Form1(CollabSoftContext database)
        {
            InitializeComponent();
            _database = database;
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            nameLbl.Text = _database.Users.First(b => b.ID == 1).Name;
        }
    }
}
