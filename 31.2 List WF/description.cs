using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._2_List_WF
{
    internal class description
    {
        private List<Ev> list;
        public description()
        {
            list = new List<Ev>();
        }
        public void add(Ev evet)
        {
            list.Add(evet);
        }
        public void remove(string description)
        {
            Ev evet = list.FirstOrDefault(p=>p.getName()==description);
            list.Remove(evet);
        }
        public int getCount() => list.Count;
        public List<Ev> getEvet() => list;
        public List <Ev> getEvByCriteria(string name)

        {
            List <Ev> Eves = list.Where(p=>p.getName()==name).ToList();
            if(Eves.Count ==0)
            {
                int date;
                int.TryParse(name, out date);
                Eves = list.Where(p => p.getDate()==date).ToList();
            }
            return Eves;
        }
        public List<Ev> getEvByCriteria1(string description)

        {
            List<Ev> Eves = list.Where(p => p.getDescription() == description).ToList();
            if (Eves.Count == 0)
            {
                int date;
                int.TryParse(description, out date);
                Eves = list.Where(p => p.getDate() == date).ToList();
            }
            return Eves;
        }

        internal static void remove(System.Windows.Forms.ListBox lbName)
        {
            throw new NotImplementedException();
        }
    }
}
