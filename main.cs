using System;// this imports something re \read powerpoint



namespace PersonNameSpace
{// open personNameSpace

    public class Person
    {// open class person
// initialize attributes and create getter and setter methods for proper encapulation
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }

// created a method GetPersonalInfo to access attributes
        public string GetPersonalInfo()
        {
//$" notates string interpolation 
            return
            $"{Name}\n{DateOfBirth.ToString("M/d/yyyy")}\nwork {WorkPhone}\ncell {CellPhone}"; ;

        }// close GetOutput ()
    } // close class person
      // close personNameSpace

    class PersonalInfo
    {// open class PersonalInfo
        public static void Main(string[] args)
        {

// declare an array of type person  called people and initialize it to set values.
            Person[] people = new Person[]{
      new Person{ // person 1
        Name = "Lucinda Potter",
        DateOfBirth = new DateTime(1992,6,24),
        WorkPhone = "000-000-0101",
        CellPhone = "000-000-0189"
      },// close person 1
      new Person{ // person 2
        Name = "John Smith",
        DateOfBirth = new DateTime(1978,8,15),
        WorkPhone = "000-000-0101",
        CellPhone = "000-000-0189"
      },
      new Person {// person 3
        Name = "Chris Johnson",
        DateOfBirth = new DateTime(1987,12,1),
        WorkPhone = "000-222-0101",
        CellPhone = "000-222-0189"

      },//close person 3
      new Person{// person 4
        Name = "Robert Hall",
        DateOfBirth = new DateTime(1949,2,27),
        WorkPhone = "000-444-0101",
        CellPhone = "000-444-0189"
      }
    };//close array
          
// create a forEach loop to cycle through each person element in the person[]
            foreach (var person in people)
            {// open foreach loop
              // call the GetOutput() to preint out the information for each person
                Console.WriteLine(person.GetPersonalInfo());
                Console.WriteLine();// print a blank line after each itteration of the foreach loop
            }// close foreach loop
        }// close main
    }// close class PersonalInfo
}// close PersonNameSpace