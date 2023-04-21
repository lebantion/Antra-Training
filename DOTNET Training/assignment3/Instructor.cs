class Instructor : Person, IInstructorService {
    public Department Department { get; set; }
    public bool IsDepartmentHead { get; set; }
    private DateTime JoinDate;

    public Instructor(string firstName, string lastName, DateTime birthDate, List<String> addresses, Department department, bool isDepartmentHead, DateTime joinDate)
        : base(firstName, lastName, birthDate, addresses) {
        Department = department;
        IsDepartmentHead = isDepartmentHead;
        JoinDate = joinDate;
    }

    public float CalculateBonusSalary() {
        // implementation needed
        return 1;
    }

    public int CalculateYearsOfExperience() {
        // implementation needed
        return 1;
    }

    float IPersonService.CalculateSalary()
    {
        throw new NotImplementedException();
    }
}
