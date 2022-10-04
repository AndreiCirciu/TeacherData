using DataTeacher;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList teachers = new ArrayList();
        int i = 0;
        string[] professors = File.ReadAllLines(@"C:\Users\andrei_circiu\OneDrive - Dell Technologies\Documents\teacherData.txt");
        foreach (var prof in professors)
        {
            string id, name, subject, section;
            string[] input = prof.Split(' ');
            id = input[0];
            name = input[1];
            subject = input[2];
            section = input[3];
            TeacherModel teach = new TeacherModel(id, name, subject, section);
            teachers.Add(teach);
            Console.WriteLine(prof);
        }
        Console.WriteLine("\n");

        foreach (TeacherModel prof in teachers)
        {
            Console.WriteLine($"ID: {prof.id}");
            Console.WriteLine($"Name: {prof.name}");
            Console.WriteLine($"Subject: {prof.subject}");
            Console.WriteLine($"Section: {prof.section} \n");
        }


        var updateTeacher = Console.ReadLine();

        if (updateTeacher == null)
            return;
        if (updateTeacher.Equals(1))
            return;

        string updateId, updateName, updateSubject, updateSection;
        var professor = updateTeacher.Split(' ');
        updateId = professor[0];
        updateName = professor[1];
        updateSubject = professor[2];
        updateSection = professor[3];
        int index = -1;
        for (i = 0; i <= updateTeacher.Length; i++)
        {
            if (((TeacherModel)teachers[i]).id == updateId)
            {
                index = i;
                break;
            }
        }

        teachers.RemoveAt(index);
        TeacherModel newTeach = new TeacherModel(updateId, updateName, updateSubject, updateSection);
        teachers.Add(newTeach);
        Console.WriteLine("\n\n\n");
        Console.WriteLine("Teacher Updated \n\n");
        foreach (TeacherModel t in teachers)
        {
            
            Console.WriteLine($"ID: {t.id}");
            Console.WriteLine($"Name: {t.name}");
            Console.WriteLine($"Subject: {t.subject}");
            Console.WriteLine($"Section: {t.section} \n");

        }
        Console.WriteLine("\n");

        using (var sw = new StreamWriter(@"C:\Users\andrei_circiu\OneDrive - Dell Technologies\Documents\teacherData.txt"))
        {
            foreach (TeacherModel e in teachers)
            {
                var write = e.id + " " + e.name + " " + e.subject + " " + e.section;
                sw.WriteLine(write);
            }
        }
    }
}