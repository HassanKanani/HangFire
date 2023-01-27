
using System;
using System.Reflection;
using System.Linq;
namespace taturial
{


    public abstract class father
    {



        public virtual void SayYourRoule()
        {


            System.Console.WriteLine("i am a father");
        }


    }
    public class child : father
    {

        public override void SayYourRoule()
        {
            //  base.SayYourRoule();
            System.Console.WriteLine("I Am FirstChild");
        }

    }


    public interface ICar { }
    public class pride : ICar
    {



    }
    public class BMW : ICar
    {


    }

//     public class test
//     {
//         Assembly a=typeof(ICar).Assembly;

//  IEnumerable<ICar> types = a.SelectMany(a => a.GetExportedTypes())
//                 .Where(c => c.IsClass && !c.IsAbstract && c.IsPublic && typeof(BaseType).IsAssignableFrom(c));


//     }







}