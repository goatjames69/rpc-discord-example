using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpc_example
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            discordrpc.Initialize();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
//by goatjames