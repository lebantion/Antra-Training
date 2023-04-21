interface IInstructorService : IPersonService {
    Department Department { get; set; }
    bool IsDepartmentHead { get; set; }
    float CalculateBonusSalary();
    int CalculateYearsOfExperience();
}