

//var myPerson = new Person()


class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }


    public Person(string firstName, string lastName, string title) : this(firstName, lastName)
    {
        Title = title;
    }
    public Person(string firstName, string lastName) : this(firstName)
    {
        LastName = lastName;
    }
    public Person(string firstName)
    {
        FirstName = firstName;
    }

    public Person()
    {

    }

}

class Student : Person
{
    public double Grade { get; set; }

    public Student(string firstName, string lastName, string title, double grade) : 
        base(firstName, lastName, title)
    {
        Grade = grade;
    }
}