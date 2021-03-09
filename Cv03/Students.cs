using System;
using System.Collections.Generic;
using System.Text;

namespace Cv03{
    public class Students{
        public delegate bool CompareNumDelegate(int first, int second);
        public delegate bool CompareNameDelegate(string fisrt, string second);
        public delegate bool CompareFacultyDelegate(Faculty first, Faculty second);
        Student[] array;
        int arraySize = 3;
        public void menu(){
           array = new Student[arraySize];
            while (true){
                Console.WriteLine(
                                 "  1) Načtení studentů z klávesnice\n" +
                                 "  2) Výpis studentů na obrazovku\n" +
                                 "  3) Seřazení studentů podle čísla\n" +
                                 "  4) Seřazení studentů podle jména\n" +
                                 "  5) Seřazení studentů podle fakulty\n" +
                                 "  0) Konec programu\n" +
                                 "Zadej číslo pro volbu v menu\n");

                string temp = Console.ReadLine();
                int.TryParse(temp, out int choice);

                if (choice >= 1 && choice <= 5)
                {
                    switch (choice)
                    {
                        case 1:
                            InsertElement(array);
                            break;
                        case 2:
                            PrintArray(array);
                            break;
                        case 3:
                            SortArrayByNumber(WhichNumbIsHigher);
                            break;
                        case 4:
                            SortArrayByName(WhichStringIsFirst);
                            break;
                        case 5:
                            SortArrayByFac(WhichFacultyIsFirst);
                            break;
                        default:
                            Console.WriteLine("Konec programu");
                            return;
                    }
                }
            }
        }

        private void SortArrayByFac(CompareFacultyDelegate compareFacultyDelegate){
            Student temp;
            for (int write = 0; write < array.Length; write++){
                for (int sort = 0; sort < array.Length - 1; sort++){
                    if (compareFacultyDelegate(array[sort].Faculty, array[sort + 1].Faculty)){
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
        }

        private void SortArrayByName(CompareNameDelegate compareNameDelegate){
            Student temp;
            for (int write = 0; write < array.Length; write++){
                for (int sort = 0; sort < array.Length - 1; sort++){
                    if (compareNameDelegate(array[sort].Name.ToString(),
                        array[sort + 1].Name.ToString())){
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
        }
        public bool WhichNumbIsHigher(int first, int second) {
            if (first > second) { return true; }
            else { return false; }
        }

        public bool WhichStringIsFirst(string first, string second){
           int temp = string.Compare(first, second);
            if (temp < 0) {
                return false;
            }
            else { return true; }
        }

        public bool WhichFacultyIsFirst(Faculty fisrt, Faculty second) {
            if (fisrt < second){
                return false;
            }
            return true;
        }
        private void SortArrayByNumber(CompareNumDelegate compareNumDelegate){
            Student temp;
            for (int write = 0; write < array.Length; write++){
                for (int sort = 0; sort < array.Length - 1; sort++){
                    if (compareNumDelegate(int.Parse(array[sort].Number.ToString()), 
                        int.Parse(array[sort + 1].Number.ToString()))){
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
        }

        private void PrintArray(Student[] array){
            for (int i = 0; i < array.Length; i++){
              Console.WriteLine(array[i].ToString());
            }
        }
        
        private void InsertElement(Student[] array){
            string name;
            string temp;
            for (int i = 0; i < array.Length; i++){
                Console.WriteLine("Zadejte jmeno");
                name = Console.ReadLine();
                Console.WriteLine("Zadejte čislo");
                temp = Console.ReadLine();
                int.TryParse(temp, out int num);
                Console.WriteLine("Zadejte fakultu");
                Faculty.TryParse(Console.ReadLine(), out Faculty fac);
                array[i] = new Student(name, num, fac);
            }
        }
    }
}
