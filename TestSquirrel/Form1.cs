using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;


namespace TestSquirrel
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            ls.Add("String");
           await CheckUpdate();
            DataGridView dv = new DataGridView();
            dv.DataSource = ls;
            this.Controls.Add(dv);
        
        }

        private async Task CheckUpdate()
        {

            using(var updatemanager = new UpdateManager(@"C:\Users\Munawar\source\repos\TestSquirrel\TestSquirrel\Releases"))
            {
                await updatemanager.UpdateApp();
            }
        }
    }
}
