using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MysqlBDM.controllers;
using MysqlBDM.models;

namespace MysqlBDM.views
{
    public partial class UICategory : Form
    {
        public UICategory()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nameCategory = textBox2.Text;
            ControllerCategory objcontrolC = new ControllerCategory();
            Category objc = new Category(nameCategory);

            bool result = objcontrolC.InsertCategory(objc);

            if (result == true)
            {
                MessageBox.Show("Se inserto con exito la categoria");
            }
            else
            {
                MessageBox.Show("No se inserto la categoria");
            }

        }
    }
}
