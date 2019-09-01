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

        private  void Form1_Load(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            ls.Add("String");
         
            DataGridView dv = new DataGridView();
            dv.DataSource = ls;
            this.Controls.Add(dv);
           

        }

        private async Task CheckUpdate()
        {
            try
            {

                using (var mgr =await UpdateManager.GitHubUpdateManager(@"https://github.com/MarkBQE/TestSquirrel"))
                {
                   
                        var UpdateNeeded = await mgr.UpdateApp();


                  
                }
            }
            catch (Exception e)
            {

            }

        }

        private async  void UltraButton1_Click(object sender, EventArgs e)
        {
            await CheckUpdate();
        }
    }
}
