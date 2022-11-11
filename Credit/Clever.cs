using System;

namespace Credit
{
    class Clever : Student
    {
        public Clever(string fullName, int visitedLessons) : base(fullName, visitedLessons) { }

        public override bool PassCredit()
        {
            if (visitedLessons == lessons)
            {
                return true;
            }
            else if (visitedLessons > lessons / 2)
            {
                if (randGen.NextDouble() >= 0.3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
