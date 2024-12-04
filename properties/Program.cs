using System;

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student C1 = new student();
            C1.id = 101;
            C1.Name = "Mark";

            Console.WriteLine("Student Id = {0}", C1.id);
            Console.WriteLine("student name = {0}", C1.Name);
            Console.WriteLine("Pass mark = {0}", C1.PassMark);
        }
    }
    public class student
    {
        private int _id;
        private string _name;
        private int _passMarks = 35;
        private string _city;
        private string _email;

        public string Email
        {
            get;
            set;
        }
        public string city
        {
            get;
            set;
        }
        public int getPassMark()
        {
            return this._passMarks;
        }
        public string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
            }
        }
        public int id
        {
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Student id cannot be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

    }
}
