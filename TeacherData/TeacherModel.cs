using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherData
{
    internal class TeacherModel
    {
        public string id = default(string);
        public string name = default(string);
        public string teaches = default(string);
        public string section = default(string);

        public TeacherModel(string _id, string _name, string _teaches, string _section)
        {
            id = _id;
            name = _name;
            teaches = _teaches;
            section = _section;
        }

        public void Replace(string _name, string _teaches, string _section)
        {
            name = _name;
            teaches = _teaches;
            section = _section;
        }

        public void Show()
        {
            Console.WriteLine(this.id + " - " + this.name + " " + this.teaches + " " + this.section);
        }
    }
}