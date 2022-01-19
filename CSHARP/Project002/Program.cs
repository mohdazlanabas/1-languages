using System.Text;
using System;
using System.Threading.Tasks;

namespace Project002
{
    class Book
    {
        static void Main(string[] args)
        {
            // THIS IS ABOUT CLASSES OBJECTS AND METHODS

            classBook book1 = new classBook("Harry Potter", "JK ROwling", 400);
            classBook book2 = new classBook("Lord Of The Rings", "Tolkien",700);

            /*book1.title = "Harry Potter";
            book1.author = "JK ROwling";
            book1.pages = 400;

            ClassBook book2 = new ClassBook();
            book2.title = "Lord Of The RIngs";
            book2.author = "Tolkien";
            book2.pages = 700;*/

            Console.WriteLine(book1.title);
        }
    }
}
