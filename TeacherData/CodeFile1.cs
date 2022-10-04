using TeacherData;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;

class ReadFromFile
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\andrei_circiu\OneDrive - Dell Technologies\Documents\teacherData.txt");
        ArrayList teachers = new ArrayList();
        int i = 0;
        foreach (string line in lines)
        {
            string id;
            string name;
            string teaches;
            string section;
            string[] input = line.Split(',');
            id = input[0];
            name = input[1];
            teaches = input[2];
            section = input[3];
            Teacher teach = new Teacher(id, name, teaches, section);
            teachers.Add(teach);
            Console.WriteLine(line);
        }
        Console.WriteLine("\n");

        foreach (Teacher teach in teachers)
        {
            teach.Show();
        }

        while (true)
        {
            Console.Write("Write a teacher, or type exit to exit.\n");
            var input = Console.ReadLine();

            if (input == null)
                break;
            if (input.Equals("exit"))
                break;

            string id;
            string name;
            string teaches;
            string section;
            var line = input.Split(',');
            id = line[0];
            name = line[1];
            teaches = line[2];
            section = line[3];
            int index = -1;
            for (i = 0; i < teaches.Length; i++)
            {
                if (((Teacher)teachers[i]).id.Equals(id))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                break;
            }
            teachers.RemoveAt(index);
            Teacher teach = new Teacher(id, name, teaches, section);
            teachers.Add(teach);

            //Process input
            Console.WriteLine("\n");
            foreach (Teacher t in teachers)
            {
                t.Show();
            }
            Console.WriteLine("\n");

            using (var sw = new StreamWriter(@"C:\Users\andrei_circiu\OneDrive - Dell Technologies\Documents\teacherData.txt"))
            {
                foreach (Teacher t in teachers)
                {
                    var write = t.id + ", " + t.name + ", " + t.teaches + ", " + t.section;
                    sw.WriteLine(write);
                }
            }
        }
    }
}