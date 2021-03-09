using System;

namespace Fei{
    namespace BaseLib {
        public class Reading {
            public static int GetInt(string quote) {
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
                if (int.TryParse(line, out int count)) {
                    return count;
                } else {
                    throw new FormatException("wrong format");
                }
            }

            public static char GetChar(string quote) {
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
                if (char.TryParse(line, out char count)) {
                    return count;
                } else {
                    throw new FormatException("wrong format");
                }
            }

            public static double GetDouble(string quote) {
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
                if (double.TryParse(line, out double count)) {
                    return count;
                } else {
                    throw new FormatException("wrong format");
                }
            }

            public static string GetString(string quote) {
                Console.WriteLine(quote + ": ");
                string line = Console.ReadLine();
                return line;
            }
        }

        class ExtraMath {

            public bool solveSquareEquation(double a, double b, double c) {
                double d = Math.Pow(b, 2) - 4 * a * c;

                if (d == 0) {
                    Console.Write("Both roots are equal.\n");
                    double root = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.Write("Root x = {0}\n", root);
                    return true;
                } else if (d > 0){
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.Write("First  Root x1 = {0}\n", x1);
                    Console.Write("Second Root x2 = {0}\n", x2);
                    return true;
                   
                } else {
                    Console.Write("Root are imeainary;\nNo Solution.\n");
                    return false;   
                }
            }

            public double generateRandomNumber(double minNumber, double maxNumber) {
               return new Random().NextDouble() * (maxNumber - minNumber) + minNumber;
            }

        }

        class MathConvertor {
            
            public string fromDecToBin(int number) {
                string bin = Convert.ToString(number, 2);
                Console.WriteLine(bin);
                return bin;
            }
            public int getValueOfRoman(char r) {
                if (r == 'I')
                    return 1;
                if (r == 'V')
                    return 5;
                if (r == 'X')
                    return 10;
                if (r == 'L')
                    return 50;
                if (r == 'C')
                    return 100;
                if (r == 'D')
                    return 500;
                if (r == 'M')
                    return 1000;
                return -1;
            }
          

            public int fromBinToDec(int number) {
                string bin = Convert.ToString(number, 2);
                int dec = Convert.ToInt32(bin, 2);
                return dec;
            }

            public static string DecToRoman(int decNum) {
                int number = decNum;
                if((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
                if (number < 1) return string.Empty;
                if (number >= 1000) return "M" + DecToRoman(number - 1000);
                if (number >= 900) return "CM" + DecToRoman(number - 900); 
                if (number >= 500) return "D" + DecToRoman(number - 500);
                if (number >= 400) return "CD" + DecToRoman(number - 400);
                if (number >= 100) return "C" + DecToRoman(number - 100);
                if (number >= 90) return "XC" + DecToRoman(number - 90);
                if (number >= 50) return "L" + DecToRoman(number - 50);
                if (number >= 40) return "XL" + DecToRoman(number - 40);
                if (number >= 10) return "X" + DecToRoman(number - 10);
                if (number >= 9) return "IX" + DecToRoman(number - 9);
                if (number >= 5) return "V" + DecToRoman(number - 5);
                if (number >= 4) return "IV" + DecToRoman(number - 4);
                if (number >= 1) return "I" + DecToRoman(number - 1);
                throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
            }

            public int RomanToDec(string str) {
                int res = 0;
                for (int i = 0; i < str.Length; i++) {
                    int s1 = getValueOfRoman(str[i]);
                    if (i + 1 < str.Length) {
                        int s2 = getValueOfRoman(str[i + 1]);
                        if (s1 >= s2) {
                            res = res + s1;
                        } else {
                            res = res + s2 - s1;
                            i++;
                        }
                    } else {
                        res = res + s1;
                        i++;
                    }
                }
                Console.WriteLine("This number is " + res + " in decimal");
                return res;
            }

        }
        }
    }

