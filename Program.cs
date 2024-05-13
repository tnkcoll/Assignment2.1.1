namespace Assignment2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            //student1.StudentId = 1;
            //student1.StudentFName = "Ted";
            //student1.StudentLName = "Collins";
            //student1.StudentGrade = 'A';
            
            Console.WriteLine("Please enter the new student's ID number.");
            student1.StudentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the new student's first name.");
            student1.StudentFName = Console.ReadLine();

            Console.WriteLine("Please enter the new student's last name.");
            student1.StudentLName = Console.ReadLine();

            Console.WriteLine("Please enter the new student's grade.");
            student1.StudentGrade = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("Student's ID number is " + student1.StudentId);
            Console.WriteLine("Student's first name is " + student1.StudentFName);
            Console.WriteLine("Student's last name is " + student1.StudentLName);
            Console.WriteLine("Student's grade is " + student1.StudentGrade);
        }

    }

    public class Student()
    {
        private int _studentId;
        private string _studentFName;
        private string _studentLName;
        private char _studentGrade;

        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public string StudentFName
        {
            get { return _studentFName; }
            set { _studentFName = value; }
        }

        public string StudentLName
        {
            get { return _studentLName; }
            set { _studentLName = value; }
        }

        public char StudentGrade
        {
            get { return _studentGrade; }
            set { _studentGrade = value; }
        }

    }
}
