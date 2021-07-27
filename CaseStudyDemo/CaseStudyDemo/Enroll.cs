using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyDemo
{
    class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        public Enroll()
        {

        }
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.Student = student;
            this.Course = course;
            this.EnrollmentDate = enrollmentDate;
        }

        public DateTime EnrollmentDate { get => enrollmentDate; set => enrollmentDate = value; }
        internal Student Student { get => student; set => student = value; }
        internal Course Course { get => course; set => course = value; }
    }

    
    interface AppEngine
    {
     public void introduce(Course course); 
	 public void register(Student student);
	 public List<Student> listOfStudents();
	 public void enroll(Student student, Course course);
	 public List<Enroll> listOfEnrollments();
    }

    class InMemoryAppEngine : AppEngine
    {
        static int x=20;
        private List<Student> students;
        private List<Course> courses;
        private List<Enroll> enrolls;

        public InMemoryAppEngine()
        {
            Students = new List<Student>();
            courses = new List<Course>();
            enrolls = new List<Enroll>();

        }
        public InMemoryAppEngine(List<Student> students, List<Course> courses, List<Enroll> enrolls)
        {
            this.students = students;
            this.courses = courses;
            this.enrolls = enrolls;
        }

        internal List<Student> Students { get => students; set => students = value; }
        internal List<Course> Courses { get => courses; set => courses = value; }
        internal List<Enroll> Enrolls { get => enrolls; set => enrolls = value; }

        public void enroll(Student student, Course course)
        {
           
            Enroll enroll = new Enroll(student, course, DateTime.Now);
            Enrolls.Add(enroll);
        }

        public void introduce(Course course)
        {
            Courses.Add(course);
        }

        public List<Enroll> listOfEnrollments()
        {
            return Enrolls;
        }

        public List<Student> listOfStudents()
        {
            return Students;
        }

        public void register(Student student)
        {
           
            Students.Add(student);
        }
    }

    class App3
    {
        static void Main()
        {
            
            InMemoryAppEngine AppEngine = new InMemoryAppEngine();
            CInfo info = new CInfo();

            Course c=new Course(1, "java", 3, 5000);
            Student s = new Student(1, "John",DateTime.Parse("2000-03-04"), new string[] { "1111", "2222" });
            
            AppEngine.introduce(c);
            AppEngine.register(s);
            AppEngine.enroll(s, c);


            foreach (Enroll e in AppEngine.Enrolls)
            {
                info.display(e);
            }    





        }
    
    }

}
