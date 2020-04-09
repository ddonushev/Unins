using UserLogin;

namespace StudentInfoSystem

{
    internal class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            if (user.FacNumber != null)
                foreach (var student in StudentData.TestStudents)
                    //Users have a FacNumber
                    //Students have a FakNo
                    if (student.FakNo == user.FacNumber)
                        return student;
            return null;
        }
    }
}