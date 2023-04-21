class Department : IDepartmentService {
    public Instructor HeadInstructor { get; set; }
    public float Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Course> Courses { get; set; }
}