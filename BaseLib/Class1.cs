using System;

namespace Fei{
    namespace BaseLib{
        public class Reading{
            public static int GetInt(string quote) {
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
                int.TryParse(line, out int count);
                return count;
            }

            public static char GetChar(string quote){
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
                char.TryParse(line, out char count);
                return count;
            }

            public static double GetDouble(string quote){
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
                double.TryParse(line, out double count);
                return count;
            }

            public static string GetString(string quote){
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
                return line;
            }
        }
    }
}
