interface IStudentService : IPersonService {
    List<Course> GetCourses();
    double CalculateGPA();
}