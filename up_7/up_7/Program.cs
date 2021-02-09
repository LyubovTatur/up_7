using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( SimpleStringMoves.IsExist("qwerty asdfgh zxcvb", "as"));
            string s = "qwertyye";
            Console.WriteLine(s);
            SimpleStringMoves.ReplaseMatches(ref s, "yy", "!!");
            Console.WriteLine(s);
            SimpleStringMoves.AlfobetStr("wer. ewrtehry, fds/ ge. aaa. ccc bbb", 3);
            Console.WriteLine(SimpleStringMoves.IsHave4or7("qer7erw"));
            Console.WriteLine(SimpleStringMoves.IsUrl("http://www.foufos.gr"));
            Console.WriteLine(SimpleStringMoves.IsUrl("https://stackoverflow.com/questions/5717312/regular-expression-for-url"));
            Console.WriteLine();
            Console.WriteLine(SimpleStringMoves.PascalEncoding("я_милая_девочка_"));
            Console.ReadLine();
        }
        
    }
}
