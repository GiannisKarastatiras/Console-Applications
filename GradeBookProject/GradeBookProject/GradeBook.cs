using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookProject
{
    public class GradeBook             
    {
        private List<float> grades;              //encaptulation

        public GradeBook()                      
        {
            grades = new List<float>();         
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeBookStatistics ComputeStatistics()
        {
            GradeBookStatistics stats = new GradeBookStatistics();
            

            float sum = 0;
            foreach (var grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);


                
                //if (grade > stats.HighestGrade)
                //    stats.HighestGrade = grade;

                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }   
    }
}
