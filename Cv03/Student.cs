using System;
using System.Collections.Generic;
using System.Text;

namespace Cv03{
    public enum Faculty { FES, FF, FEI, FCHT }
    public class Student{
        private Faculty faculty;
        public Faculty Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        private string name;
        public string Name  { 
            get { return name; } 
            set { name = value; } 
        }
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        
        public void SetDifficulty(Faculty value)
        {
            faculty = value;
        }
        public Student(string name, int number, Faculty faculty){
            this.name = name;
            this.number = number;
            this.faculty = faculty;
        }

       
        public override string ToString(){
            return $"Jméno studenta: {name}\nČíslo studenta: {number} \nFakulta: {faculty.ToString()}";
        }
    }
}
