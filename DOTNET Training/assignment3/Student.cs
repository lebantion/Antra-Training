class Student : Person, IStudentService {
    private List<Course> Courses;

    public Student(string firstName, string lastName, DateTime birthDate, List<String> addresses, List<Course> courses)
        : base(firstName, lastName, birthDate, addresses) {
        Courses = courses;
    }

    public List<Course> GetCourses() {
        return Courses;
    }

    public double CalculateGPA() {
        return 1;
    }
}
