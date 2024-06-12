using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31._2_List_WF
{
    internal class Ev
    {
        private string name;
        private string description;
        private int date;

        public Ev(int date,string name,string description)
        {
            this.date = date;
            this.name = name;
            this.description = description;
        }
        public string getName() => name;
        public string getDescription() => description;
        public int getDate() => date;
        
    }
}
