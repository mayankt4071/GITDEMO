using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyDemo
{
   class Course
    {
        int id; 
        string name;
        int duration;
        float fees;
        public Course()        {     }
        public Course(int id, string name, int duration, float fees)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
            this.fees = fees;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Duration { get => duration; set => duration = value; }
        public float Fees { get => fees; set => fees = value; }

        public virtual void calculateMonthlyFee() {
            Fees += Fees;
        }
       
    }

    class DegreeCourse :Course
    {
        enum level { Bachelors, Masters };
        
        bool isPlacementAvailable;

        public DegreeCourse()
        {

        }
        public DegreeCourse(bool isPlacementAvailable, int id, string name, int duration, float fees): base (id,name,duration,fees)
        {
            this.isPlacementAvailable = isPlacementAvailable;
        }
        public bool IsPlacementAvailable { get => isPlacementAvailable; set => isPlacementAvailable = value; }

        public override void calculateMonthlyFee()
        {
            if (isPlacementAvailable) {
                Fees = Fees + Fees * 10 / 100;
            }
            
        }
    }

    class DiplomaCourse : Course {
        enum type { professional, academic };
        public DiplomaCourse()
        {

        }
        public DiplomaCourse(int id, string name, int duration, float fees) : base(id, name, duration, fees)
        {

        }

        public override void calculateMonthlyFee()
        {
            Console.WriteLine("Choose the course type. professional or academic");
            string t = Console.ReadLine();
            if (t == type.professional.ToString())
            {
                Fees = Fees + Fees * 10 / 100;
            }
            else if (t == type.academic.ToString())
            {
                Fees = Fees + Fees * 5 / 100;
            }
            
        }
    } 
    class CInfo
    {
        public void display(Course course)
        {
            Console.WriteLine("Course ID= " + course.Id);
            Console.WriteLine("Name= " + course.Name);
            Console.WriteLine("Duration= " + course.Duration);
            course.calculateMonthlyFee();
            Console.WriteLine("Fees= " + course.Fees);
        }

        public void display(Student student)
        {
            Console.WriteLine("Student ID= " + student.Id);
            Console.WriteLine("Name= " + student.Name);
            Console.WriteLine("DOB= " + student.Dateofbirth.ToShortDateString());
            Console.WriteLine("College Name= " + Student.CollegeName);
            foreach (string phone in student.Phone)
            {
                Console.WriteLine("Phone Number= " + phone);
            }


        }
        public void display(Enroll enroll)
        {
            display(enroll.Student);
            display(enroll.Course);
            Console.WriteLine("Enrollment Date" + enroll.EnrollmentDate);
        
        }

    }

    class App1
    {
        static void Main()
        {
            CInfo info = new CInfo();
            //Course c = new Course(1, "java", 3, 5000);
            //// c.calculateMonthlyFee();
            //info.display(c);


           // Course c = new DegreeCourse();
            DegreeCourse dc = new DegreeCourse(true, 2, "Dotnet", 6, 6000);
           // dc.calculateMonthlyFee();
            info.display(dc);

            DiplomaCourse di = new DiplomaCourse(3, "Python", 6, 7000);
           // di.calculateMonthlyFee();
            info.display(di);
                    
        }
    
    }
}
