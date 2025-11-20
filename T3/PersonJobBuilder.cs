namespace Tamrin.T3
{
    public class PersonJobBuilder :PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
        this.person = person;
         person.Job = new Job();
        }
        public PersonJobBuilder Company (string company)
        {
            person.Job.Company = company;
            return this;
        }
        public PersonJobBuilder At(string Position)
        {
            person.Job.At = Position;
            return this;
        }
    }
}
