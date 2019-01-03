using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookProject
{
    public class GradeBookStatistics
    {
        public float AverageGrade;          
        public float HighestGrade;
        public float LowestGrade;

        public GradeBookStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;          
        }
    }
}
