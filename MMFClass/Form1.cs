using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMFClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.propertyGrid1.SelectedObject = this.Patent;

            patents.Add(new Patent());
            patents.Add(new Patent());
            patents.Add(new Patent());


            this.dataGridView1.DataSource = patents;
        }

        public Patent Patent { get; set; } = new Patent();
        public List<Patent> patents { get; set; } = new List<Patent>();

        private void button1_Click(object sender, EventArgs e)
        {
            patents.Add(new Patent());
            this.dataGridView1.DataSource = patents;
        }
    }
}
