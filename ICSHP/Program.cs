using System;
using System.IO;
using System.Net;
using System.Xml;

namespace ICSHP
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            task5();
        }
        static void task1()
        {
            Console.WriteLine("Josef Novák \nJindrišská 16 \n111 50, Praha 1 ");
        }
        static void task2()
        {
            int i = 97;
            while (i != 123)
            {
                char temp = (char)i;
                Console.WriteLine(temp);
                i++;
            }
        }

        static void task3()
        {
            Console.WriteLine("Write personal id:");

            string persIdNum;
            char five = '5';
            char six = '6';
            persIdNum = Console.ReadLine();
            Console.WriteLine(persIdNum[2]);
            if (persIdNum[2] == five || persIdNum[2] == six)
            {
                Console.WriteLine("Female");
            }
            else
            {
                Console.WriteLine("Male");
            }
        }

        static void task4()
        {
            string answear;
            while (true)
            {
                string guess;
                int countOfGuess = 0;
                Random r = new Random();
                int rInt = r.Next(0, 100);
                Console.WriteLine("Guess number from 0 - 100:");
                while (true)
                {
                    guess = Console.ReadLine();
                    if (int.Parse(guess) == rInt)
                    {
                        Console.WriteLine("Congratulation! You won!");
                    }
                    else if (int.Parse(guess) > rInt)
                    {
                        Console.WriteLine("Number is lower than your guess");
                    }
                    else if (int.Parse(guess) < rInt)
                    {
                        Console.WriteLine("Number is higher than your guess");
                    }


                    if (countOfGuess == 10)
                    {
                        Console.WriteLine("You tried to guess 10 times already, you lost :(");
                    }

                    countOfGuess++;
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                answear = Console.ReadLine();

                if (answear == "n") break; else continue;
            }
        }

        static void task5(){
            Console.WriteLine("Add lat:");
            string lat = Console.ReadLine();
            Console.WriteLine("Add lon:");
            string lon = Console.ReadLine();

            WebClient client = new WebClient();
            string request = "https://api.met.no/weatherapi/locationforecast/1.9/?lat=" + lat + "&lon=" + lon;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(client.DownloadString(request));


            string pres = GetStr("pressure", "value=", doc);
            string temp = GetStr("temperature", "value=", doc);
            string wind = GetStr("windSpeed", "mps=", doc);
            Console.WriteLine("Pressure: "+pres + "\nTemperature: " + temp + "\nWindSpeed: " + wind + "\n");

        }
        static string GetStr(string measurement, string value,  XmlDocument doc){
            XmlNodeList list = doc.SelectNodes("weatherdata/product/time/location/" + measurement);
            XmlNode xml = list.Item(0);
            string temp = xml.OuterXml;
            int startIndex = temp.IndexOf(value);
            temp = temp.Substring(startIndex + value.Length );
            int counter = 0;
            string result = null;
            while (true) { 
                if(temp[counter] == '"'){
                    break;
                }
                else{
                    result += temp[counter];
                }
                counter++;
            }
            return result;
        }
    }

}
