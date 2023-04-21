class Person {
    private string FirstName;
    private string LastName;
    private DateTime BirthDate;
    private List<String> Addresses;

    public Person(string firstName, string lastName, DateTime birthDate, List<String> addresses) {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Addresses = addresses;
    }

    public int CalculateAge() {
        return 1;
    }

    public float CalculateSalary() {
        return 1;
    }

    public List<String> GetAddresses() {
        return new List<string> {"ADDRESS"};
    }
}