namespace Tamrin.T3 
{
    public class PersonInfoBuilder : PersonBuilder
    {

    public PersonInfoBuilder(Person person) { this.person = person;}  



        public PersonInfoBuilder Name(string Name) {


            person.Name = Name;
            return this;
        }
    }
}