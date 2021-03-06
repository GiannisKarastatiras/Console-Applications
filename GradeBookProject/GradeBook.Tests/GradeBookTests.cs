﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBookProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);

            GradeBookStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);           
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);

            GradeBookStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);          
        }
    }
}
