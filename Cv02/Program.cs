using System;
using System.Linq;

namespace Cv02{
    class Program{
        static void Main(string[] args){
            int arraySize = 10;
            int[] array = new int[arraySize];

            while (true){
                Console.WriteLine(
            "             MENU           \n"                    +
            "1. Zadání prvku z klávesnice\n"                    +
            "2. Výpis pole na obrazovku\n"                      +
            "3. Utřídění pole vzestupně\n"                      +
            "4. Utřídění pole sestupně\n"                       +
            "5. Hledání minimálního prvku\n"                    +
            "6. Hledání prvního výskytu zadaného čísla\n"       +
            "7. Hledání posledního výskytu zadaného čísla\n"    + 
            "8. konec programu\n");
            int choice = Fei.BaseLib.Reading.GetInt("Zadej číslo pro volbu v menu");

                if (choice >= 1 && choice <= 7){
                    switch (choice)
                    {
                        case 1:
                            InsertElement(array);
                            break;
                        case 2:
                            PrintArray(array);
                            break;
                        case 3:
                            SortArrayIncreasing(array);
                            break;
                        case 4:
                            SortArrayDescending(array);
                            break;
                        case 5:
                            FindMinimumElemnt(array);
                            break;
                        case 6:
                            FindFirstOccurrence(array);
                            break;
                        case 7:
                            FindLastOccurrence(array);
                            break;
                        default:
                            break;
                    }
                }
                else if (choice == 8){
                    break;
                }else{
                    Console.WriteLine("Zadejte číslo mezi 1 a 8");
                }
            }
        }

        private static void FindLastOccurrence(int[] array){
            int num = Fei.BaseLib.Reading.GetInt("Jaké číslo hledáš?");
            int index = -1;
            for (int i = 0; i < array.Length; i++){
                if (array[i] == num){
                    num = array[i];
                    index = i;
                }
            }
            Console.WriteLine("Poslední výskyt cisla " + num + "je na indexu " + index);
        }

        private static void FindFirstOccurrence(int[] array){
            int num = Fei.BaseLib.Reading.GetInt("Jaké číslo hledáš?");
            for (int i = 0; i < array.Length; i++){
                if(array[i] == num) {
                    Console.WriteLine("Prvni výskyt cisla " + array[i] + "je na indexu " + i);
                    return;
                }
            }
        }

        private static void FindMinimumElemnt(int[] array){
            Console.WriteLine(array.Min());
        }

        private static void SortArrayIncreasing(int[] array){
            Array.Sort(array);
        }

        private static void SortArrayDescending(int[] array){
            Array.Sort(array);
            Array.Reverse(array);
        }

        private static void PrintArray(int[] array){
            for (int i = 0; i < array.Length; i++){
                Console.WriteLine(array[i]);
            }
        }

        private static void InsertElement(int[] array){
            for (int i = 0; i < array.Length; i++){
                array[i] = Fei.BaseLib.Reading.GetInt("Zadej prvek který chceš přidat");
            }
        }
    }
}

