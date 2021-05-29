using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        override public char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException();

            if (averageGrade > 80)
                return 'A';
            if (averageGrade > 60)
                return 'B';
            if (averageGrade > 40)
                return 'C';
            if (averageGrade > 20)
                return 'D';

            return 'F';
        }
    }
}
