using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMasterCreateAssignment
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.CreateEditButton.Click += new EventHandler(CreateEditButton__Click);
        }

        private void CreateEditButton__Click(object sender, EventArgs e) {
            CreateAssignment create = new CreateAssignment();
            create.Show();


        }

        private void daysGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
