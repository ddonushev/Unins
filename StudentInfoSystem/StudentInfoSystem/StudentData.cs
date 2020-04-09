using System.Collections.Generic;

namespace StudentInfoSystem
{
    internal static class StudentData
    {
        private static List<Student> _testStudents;

        public static List<Student> TestStudents
        {
            get
            {
                setFirstStudent();
                return _testStudents;
            }
            private set { }
        }

        private static void setFirstStudent()
        {
            if (_testStudents == null)
            {
                _testStudents = new List<Student>();
                var s1 = new Student("Dimitar", "Ventsislavov", "Donushev", "FKST", "KSI", "bakalavar", "redoven",
                    "121216202", "3", "9", "38");
                _testStudents.Add(s1);
            }
        }
    }
}