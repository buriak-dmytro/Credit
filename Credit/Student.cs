using System;

namespace Credit
{
    abstract class Student
    {
        protected static Random randGen = new Random();
        protected static int lessons = 20;

        protected string fullName;
        protected int visitedLessons;

        public Student(string fullName, int visitedLessons)
        {
            this.fullName = fullName;
            this.visitedLessons = visitedLessons;
        }

        public abstract bool PassCredit();

        public override string ToString()
        {
            return $"{fullName}, visited {visitedLessons}: {(PassCredit() ? "pass" : "fail")}";
        }
    }
}
