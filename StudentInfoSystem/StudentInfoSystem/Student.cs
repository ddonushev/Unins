namespace StudentInfoSystem
{
    internal class Student
    {
        public Student()
        {
        }

        public Student(string nameI, string middleNameI, string lastNameI, string facultyI, string majorI, string OKSI,
            string studentStatusI, string fakNoI, string kursI, string potokI, string grupaI)
        {
            Name = nameI;
            MiddleName = middleNameI;
            LastName = lastNameI;
            Faculty = facultyI;
            Major = majorI;
            OKS = OKSI;
            StudentStatus = studentStatusI;
            FakNo = fakNoI;
            Kurs = kursI;
            Potok = potokI;
            Grupa = grupaI;
        }

        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Faculty { get; set; }

        public string Major { get; set; }

        public string OKS { get; set; }

        public string StudentStatus { get; set; }

        public string FakNo { get; set; }

        public string Kurs { get; set; }

        public string Potok { get; set; }

        public string Grupa { get; set; }
    }
}