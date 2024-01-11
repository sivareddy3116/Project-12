using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using RainbowSchoolLibrary;
using SchoolLib;
using System;
using Assert = NUnit.Framework.Assert;


namespace RainbowSchoolTests
{

    [TestFixture]
    public class SchoolUnitTest
    {
        [Test]
        public void AddStudent()
        {
            var Management = new Management();
            var student = new Student { StudentId = 1, StudentName = "Siva Reddy", Class = "Class 10" };

            // Act
            Management.AddStudent(student);

            // Assert
            Assert.Contains(student, Management.Students);
        }
        [Test]
        public void AddSubject()
        {
            var Management = new Management();
            var subject = new subject { subjectId = 1, subjectName = "Math" };

            // Act
            Management.AddSubject(subject);

            // Assert
            Assert.Contains(subject, Management.Subjects);
        }
        [Test]
        public void AddTeacher()
        {
            var Management = new Management();
            var teacher = new Teacher { TeacherId = 1, TeacherName = "Mr. LIKI" };

            // Act
            Management.AddTeacher(teacher);

            // Assert
            Assert.Contains(teacher, Management.Teachers);
        }
        [Test]
        public void StudentMockTest()
        {
            var Management = new Management();
            var studentMock = new Mock<Student>();
            studentMock.SetupGet(s => s.StudentId).Returns(1);
            studentMock.SetupGet(s => s.StudentName).Returns("Siva Reddy");
            studentMock.SetupGet(s => s.Class).Returns("Class 10");

            // Act
            Management.AddStudent(studentMock.Object);

            // Assert
            Assert.Contains(studentMock.Object, Management.Students);
        }
        [Test]
        public void TeacherMockTest()
        {
            var Management = new Management();
            var teacherMock = new Mock<Teacher>();
            teacherMock.SetupGet(s => s.TeacherId).Returns(1);
            teacherMock.SetupGet(s => s.TeacherName).Returns("Mr.LIKI");


            // Act
            Management.AddTeacher(teacherMock.Object);

            // Assert
            Assert.Contains(teacherMock.Object, Management.Teachers);
        }
        [Test]
        public void subjectMockTest()
        {
            var Management = new Management();
            var subjectMock = new Mock<subject>();
            subjectMock.SetupGet(s => s.subjectId).Returns(1);
            subjectMock.SetupGet(s => s.subjectName).Returns("Math");


            // Act
            Management.AddSubject(subjectMock.Object);

            // Assert
            Assert.Contains(subjectMock.Object, Management.Subjects);
        }
    }
}