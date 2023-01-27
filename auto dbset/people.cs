using System.Reflection;
namespace palce
{
    public class man : Human, I
    {
        public man(string name, int age) : base(name, age)
        {
        }

        public void g()
        {
            var a = typeof(I).FindMembers;
            var inter = typeof(I);
            System.Console.WriteLine("i am a man");
        }
    }

    public class woman : Human, I
    {
        public woman(string name, int age) : base(name, age)
        {
            name=name;
            age=age;
        }

        public void wash()
        {
            System.Console.WriteLine("i am a woman");
        }
       
   }

public class Human : I
{
    public Human(string name ,int age)
    {
        name=name;
       age=age;
    }
    public int NationalId { get; set; }
    public string name { get; set; }
}
public interface I
{

}
}