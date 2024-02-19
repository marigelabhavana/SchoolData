using NUnit.Framework;
using Moq;
using SchoolDataLibrary;
namespace SchoolData
{
    [TestFixture]
    public class SchoolDataTests
    {
        [Test]
        public void Teacher_GetTeacherInfo_ShouldReturnCorrectInfo()
        {
            var teacher = new Teacher("Jaanu Shetty", "Math");
            var result = teacher.GetTeacherInfo();
            Assert.That(result, Is.EqualTo("Jaanu Shetty teaches Math"));
        }

        [Test]
        public void Student_GetStudentInfo_ShouldReturnCorrectInfo()
        {
            var student = new Student("Jaanvi", 10);
            var result = student.GetStudentInfo();
            Assert.That(result, Is.EqualTo("Jaanvi is in grade 10"));
        }

        [Test]
        public void Subject_GetSubjectInfo_ShouldReturnCorrectInfo()
        {
            var subject = new Subject("History", 3);
            var result = subject.GetSubjectInfo();
            Assert.That(result, Is.EqualTo("History has 3 credits"));
        }

        [Test]
        public void MockingExample()
        {
            var mockTeacher = new Teacher("MockedTeacher", "MockedSubject");
            var result = mockTeacher.GetTeacherInfo();
            Assert.That(result, Is.EqualTo("MockedTeacher teaches MockedSubject"));
        }

        [Test]
        [TestCase("Jaanu", 8)]
        [TestCase("Jaanvi", 9)]
        public void Student_GetStudentInfoWithData(string studentName, int gradeLevel)
        {
            var student = new Student(studentName, gradeLevel);
            var result = student.GetStudentInfo();
            Assert.That(result, Is.EqualTo($"{studentName} is in grade {gradeLevel}"));
        }
    }
}