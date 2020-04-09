using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ArtemProject
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Kindle kindle = new Kindle("asdijasdipjaisd", "black", "Arial", 14, "Kindle Amazon", 50);
            kindle.OutputTextInfo();
            Console.WriteLine(new string('-',40));
            Graffity graffity = new Graffity("ACAB", "blue", "Sans", 103);
            graffity.OutputTextInfo();
            Console.WriteLine(new string('-', 40));
            PaperBook paperBook = new PaperBook("War and piece");
            paperBook.Pages.Add(new Page("ijf iojf ioj fiofjqwfijwqiejfwiqejf", "Black", "Times New Roman", 14));
            paperBook.Pages.Add(new Page("asdpfj askdfj  23 ij oiajf  2", "Black", "Times New Roman", 14));
            paperBook.Pages.Add(new Page("0324iojfkma qwe0fijwqpefj skladsi", "Black", "Times New Roman", 14));
            paperBook.Pages.Add(new Page("xc,vnz,xmnv aifj e8wq fj", "Black", "Times New Roman", 14));
            paperBook.OutputInfo();

            Console.ReadLine();
        }
    }
}
