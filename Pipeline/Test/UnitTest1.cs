using Logic;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Person person = new Person("Boutet", "Cl�ment", 20);
            person.Age = 19;
            Assert.Equal(person.Age, 29);
        
        }
    }
}