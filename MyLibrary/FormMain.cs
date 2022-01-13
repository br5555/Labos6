using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            var login = new Login();
            login.UserLoggedIn += this.DisplayList;
            login.Show(this); //ShowDialog onemogucava drugim da dode fokus na njega (kao kad trazimo file)
        }

        private void DisplayList(object sender, EventArgs e)
        {
            using (DataSet ds = new DataSet())
            {
                var filename = "popisKnjiga.xml";
                var currentDirectory = Directory.GetCurrentDirectory();
                var usernameAndPasswordsFilepath = Path.Combine(currentDirectory, filename);
                ds.ReadXml(usernameAndPasswordsFilepath);
                this.dataGridViewPopisKnjiga.DataSource = ds.Tables[0];
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
