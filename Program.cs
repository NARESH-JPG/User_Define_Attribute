using System;
using System.Text;

namespace User_Define_Attribute
{
    [Author_Attribute("P.Hanselman")]
    class Program
    {
        [Author_Attribute("Dennis Ritche")]
        static void Main(string[] args)
        {
            Console.WriteLine("Demo user Define Attributes");
            Author_Attribute A1 = new Author_Attribute("Manjit singh");

            Console.WriteLine("By Default Version of the Author is : \t{0}", A1.Version_name);
        
        }


        [System.AttributeUsage(System.AttributeTargets.Class|System.AttributeTargets.Method)]
            
        public class Author_Attribute : System.Attribute
        {
            private string AuthorName;
            public Double Version_name;

            public Author_Attribute(string name )
            {
                this.AuthorName = name;
                Version_name = 5.0;
            }

        }
    }
}
