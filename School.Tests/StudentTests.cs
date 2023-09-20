﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Sam";

            // Act
            string studentName = student.Name;

            // Assert
            Assert.AreEqual("Sam", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "123 Main St";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("123 Main St", studentAddress);
        }
    }
}
