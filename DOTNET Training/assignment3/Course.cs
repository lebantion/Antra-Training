class Course {
    public List<Student> EnrolledStudents { get; set; }

    public Course(List<Student> enrolledStudents) {
        EnrolledStudents = enrolledStudents;
    }
}