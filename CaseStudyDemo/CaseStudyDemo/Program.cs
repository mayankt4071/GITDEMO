using System;
using System.Collections.Generic;

namespace CaseStudyDemo
{
    class Student
    {
        int id;
        string name;
        DateTime dateofbirth;
        string[] phone;
        static string collegeName;

        static Student()
        {
            collegeName = "IIT";
        }

        public Student()
        {

        }

        public Student(int id, string name, DateTime dateofbirth,string[] phone)
        {
            this.id = id;
            this.name = name;
            this.dateofbirth = dateofbirth;
            this.phone = phone;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        public static string CollegeName { get => collegeName; set => collegeName = value; }
        public string[] Phone { get => phone; set => phone = value; }
    }
    class Info
    {
        public void display(Student student)
        {
            Console.WriteLine("Student ID= "+ student.Id);
            Console.WriteLine("Name= " + student.Name);
            Console.WriteLine("DOB= " + student.Dateofbirth.ToShortDateString());
            Console.WriteLine("College Name= " + Student.CollegeName);
            foreach(string phone in student.Phone)
            {
                Console.WriteLine("Phone Number= " + phone);
            }


        }
    }
    class App
    {
       
        static void Main(string[] args)
        {
            //scenario1();
            //scenario2();
            //scenario3();
            scenario4();
        }
        static void scenario1()
        {
            Student s1 = new Student(1, "John", DateTime.Parse("2000-03-04"),new string[] { "12344","45666"});
            Student s2 = new Student(2, "Mark", DateTime.Parse("2001-05-12"),new string[] { "12324","12334", "45666" });
            Student s3 = new Student(3, "Mary", DateTime.Parse("1999-08-04"),new string[] { "12344"});

            Info info = new Info();
            info.display(s1);
            info.display(s2);
            info.display(s3);

        }
        static void scenario2()
        {
            Student[] students = new Student[] {
                new Student(1, "John", DateTime.Parse("2000-03-04"),new string[] { "12344","45666"}),
                new Student(2, "Mark", DateTime.Parse("2001-05-12"), new string[] { "12324", "12334", "45666" }),
                new Student(3, "Mary", DateTime.Parse("1999-08-04"), new string[] { "12344" })
                    };

          //  int[] i = new int[] { 1, 2, 3 };

            Student[] stud = new Student[2];
            Student s1 = new Student(1, "John", DateTime.Parse("2000-03-04"), new string[] { "12344", "45666" });
            stud[0] = s1;
            stud[1] = new Student(2, "Mark", DateTime.Parse("2001-05-12"), new string[] { "12324", "12334", "45666" });

            Info info = new Info();
            foreach (Student student in students)
            {
                info.display(student);            
            }
        }
        static void scenario3()
        {
            Console.WriteLine("Enter the Number of students");
            int count = int.Parse(Console.ReadLine());
            //int id;string name; DateTime dob;string[] phone;
            Student[] students = new Student[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter student id,name,DOB");
                //string h = Console.ReadLine();
                // students[i].Id =int.Parse(h.Split()[0]);
                students[i] = new Student();
                students[i].Id = int.Parse(Console.ReadLine());
                students[i].Name = Console.ReadLine();
                students[i].Dateofbirth = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of phone numbers");
                int count1 = int.Parse(Console.ReadLine());
                students[i].Phone = new string[count1];
                for (int j = 0; j < count1; j++)
                {
                   students[i].Phone[j] = Console.ReadLine();

                }
                //students[i] = new Student(id,name,dob,phone);
            }
            Info info = new Info();
            foreach (Student stud in students)
            {
                info.display(stud);
            }
        }
        static void scenario4()
        {
            Console.WriteLine("Enter the Number of students");
            int count = int.Parse(Console.ReadLine());
            int id;string name; DateTime dob;string[] phone;
            List<Student> students = new List<Student>() ;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter student id,name,DOB");
                //string h = Console.ReadLine();
                // students[i].Id =int.Parse(h.Split()[0]);
                // students[i] = new Student();
                
                id = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                dob = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of phone numbers");
                int count1 = int.Parse(Console.ReadLine());
                phone = new string[count1];
               

                for (int j = 0; j < count1; j++)
                {
                   phone[j] = Console.ReadLine();

                }
                students.Add(new Student(id,name,dob,phone));
            }
            
            Info info = new Info();
            foreach (Student stud in students)
            {
                info.display(stud);
            }
        }

    }
}
