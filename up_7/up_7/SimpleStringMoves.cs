using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace up_7
{
    static public class SimpleStringMoves
    {

        static char[] alpha = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};

        static public bool IsExist(string str, string sub)
        {
            Regex regex = new Regex(sub);
            return regex.IsMatch(str);
        }
        static public int MatchesCount(string str, string sub)
        {
            Regex regex = new Regex(sub);
            return regex.Matches(str).Count;
        }
        static public string ReplaseMatches(ref string str, string sub,string rep)
        {
            Regex regex = new Regex(sub);
            str = regex.Replace(str, rep);
            return str;
        }
        static public void AlfobetStr(string str,int n)
        {
            // Напечатать в алфавитном порядке все слова из данной строки,
            // имеющие заданную длину n.

            var words = str.Split();
            List<string> nwords = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim(new char[] { '.', ',', '/', '!' });
                if (words[i].Length == n)
                {
                    nwords.Add(words[i]);
                }
            }
            nwords.Sort();
            foreach (var word in nwords)
            {
                Console.Write(word+" ");
            }
            Console.WriteLine();
        }
        static public bool IsHave4or7(string str)
        {
            Regex r = new Regex(@"[47]");
            return r.IsMatch(str);
        }
        static public bool IsUrl(string str)
        {
            Regex reg = new Regex(@"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$");
            return reg.IsMatch(str);
        }
        private static int[] PasTri(int n)
        {
            int[] result = new int[n];
            result[0] = 1;
            for (int i = 1; i < n; i++)
            {
                int left = 0;
                for (int j = 0; j <= i; j++)
                {
                    int tmp = result[j];
                    result[j] += left;
                    left = tmp;
                }
            }
            return result;
        }
        static public string PascalEncoding(string str)
        {
            var words = str.Split('_');
            string newstring = "";
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    int index = -1;
                    for (int j = 0; j < alpha.Length; j++)
                    {
                        if (word[i] == alpha[j])
                        {
                            index = j;
                        }
                    }
                    newstring += alpha[(index + PasTri(word.Length)[i]) % alpha.Length];
                }
                newstring += '_';
            }
            return newstring;
        }
    }
}
