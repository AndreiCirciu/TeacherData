namespace DataTeacher
{
    internal class TeacherModel
    {
        public string id = string.Empty;
        public string name = string.Empty;
        public string subject = string.Empty;
        public string section = string.Empty;

        public TeacherModel(string _id, string _name, string _subject, string _section)
        {
            id = _id;
            name = _name;
            subject = _subject;
            section = _section;
        }       
    }
}