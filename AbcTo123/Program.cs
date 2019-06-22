using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcTo123
{
    class Program
    {
       
        static void Main(string[] args)
        {

            // input CAD output 314

            convert("CAD");
            

        }

        public static void convert(string input)
        {
            
            string stringVaslue = "";
            char[] myarray = input.ToCharArray();
            foreach(char c in input.ToCharArray())
            {
                stringVaslue = stringVaslue + Alphabets.GetDictionary().Where(x => x.Key == c).Select(x => x.Value).FirstOrDefault().ToString();

            }
            Console.WriteLine("new value is " + stringVaslue);
            Console.ReadLine();
           
            
        }
     
    }
    static class Alphabets
    {

       public static Dictionary<char, int> GetDictionary()
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            dic.Add('A', 1);
            dic.Add('D', 4);
            dic.Add('C', 3);
            return dic;
        }
    }
    static class NewClass
    {
        static readonly string[] Columns = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH" };
        public static string IndexToColumn(int index)
        {
            if (index <= 0)
                throw new IndexOutOfRangeException("index must be a positive number");

            return Columns[index - 1];
        }
    }
}
