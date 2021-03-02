using System;

namespace Fei{
    namespace BaseLib{
        public class Reading{
            public static int GetInt(string quote) {
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
                if(int.TryParse(line, out int count)){
                    return count;
                }
                else {
                    throw new FormatException("wrong format");
                }
            }

            public static char GetChar(string quote){
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
               if(char.TryParse(line, out char count)){
                    return count;
                }
                else
                {
                    throw new FormatException("wrong format");
                }
            }

            public static double GetDouble(string quote){
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
                if(double.TryParse(line, out double count)){
                    return count;
                }
                else
                {
                    throw new FormatException("wrong format");
                }
            }

            public static string GetString(string quote){
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
                return line;
            }
        }
    }
}
