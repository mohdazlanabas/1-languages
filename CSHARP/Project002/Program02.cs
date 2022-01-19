using System.Text;
using System;
using System.Threading.Tasks;

namespace Project002
{
    class Song
    { 
        static void Main(string[] args)
    {
        classSong holiday = new classSong("Holiday", "Green Day", 200);
        Console.WriteLine(classSong.songCount);
        classSong kashmir = new classSong("Kashmir", "led Zepplin", 15);
        Console.WriteLine(classSong.songCount);

        }
    }
}
