interface IDepartmentService {
    Instructor HeadInstructor { get; set; }
    float Budget { get; set; }
    DateTime StartDate { get; set; }
    DateTime EndDate { get; set; }
    List<Course> Courses { get; set; }
}