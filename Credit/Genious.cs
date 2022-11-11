using System;

namespace Credit
{
    class Genious : Student
    {
        public Genious(string fullName, int visitedLessons) : base(fullName, visitedLessons) { }

        public override bool PassCredit()
        {
            if (visitedLessons >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
