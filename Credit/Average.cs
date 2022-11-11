using System;

namespace Credit
{
    class Average : Student
    {
        public Average(string fullName, int visitedLessons) : base(fullName, visitedLessons) { }

        public override bool PassCredit()
        {
            if (visitedLessons == lessons)
            {
                return true;
            }
            else if (visitedLessons > lessons / 2)
            {
                if (randGen.NextDouble() >= 0.5)
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
