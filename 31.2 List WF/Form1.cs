using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31._2_List_WF
{
    public partial class Form1 : Form
    {
        
        private description description;
        private List<Ev> evet;
        public Form1()
        {
            InitializeComponent();
            description = new description();
            evet = description.getEvet();
            UpdateForm();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbDate.Items.Add(tb1.Text);
            lbName.Items.Add(tb2.Text);
            lbDis.Items.Add(tb3.Text);
            UpdateForm();

        }
        private void UpdateForm()
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tbSearch.Clear();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            string name = tbSearch.Text;
            int index = lbName.Items.IndexOf(name);
            if(index != -1)
            {
                lbName.Items.RemoveAt(index);
                lbDis.Items.RemoveAt(index);
                lbDate.Items.RemoveAt(index);
            }

            UpdateForm();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
          string search = tbSearch.Text;

            int index = -1;
            for(int i =0; i <lbName.Items.Count; i++)
            {
                if (lbName.Items[i].ToString() == search)
                {
                    index = i; break;
                }
            }
            if (index != -1)
            {
                lbDate.Items.Clear();
                lbName.Items.Clear();
                lbDis.Items.Clear();
                lbDate.Items.Add(search);
                lbName.Items.Add(search);
                lbDis.Items.Add(search);

            }





        }
    }
}
