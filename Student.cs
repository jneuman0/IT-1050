namespace IT_1050_Lab_3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string name, int grade, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Grade = 0;

        }
        public void SetGrade(int grade)
        {
            this.Grade = grade;
        }

        public void Print()
        {
            System.Console.WriteLine("My name is " + this.Name);
            System.Console.WriteLine("My grade was " + this.Grade + ".");
            this.Teacher.Print();
        }
    
  

    }
}
