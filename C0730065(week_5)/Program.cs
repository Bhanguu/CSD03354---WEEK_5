using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730065_week_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator e = new Elevator();
            e.setup();
            e.traverseList();

        }
        class Node
        {
            public Node() { }
          
            public Node elevatorUp;
            public string FloorNumber;
        }

        class Department
        {
            public Department(string dept_name)
            {
                DepartmentDescription = dept_name;
            }
            public Department nextDepartment;
            public Department previousDepartment;
            public string DepartmentDescription;
        }

        class DepartmentStore
        {
            public void InitializeDepartments()
            {
                Department Books = new Department("Books");
                Department Kitchenware = new Department("Kitchenware");


                Kitchenware.nextDepartment = Books;
                Kitchenware.previousDepartment = FirstFloor;
                Department Books = new Department("Books");

            }

        }
        class Elevator
        {
            Node Head;
            Node FirstFloor;
            Node SecondFloor;
            Node ThirdFloor;
            Node FourthFloor;

            public void setup()
            {
                FirstFloor = new Node();
                SecondFloor = new Node();
                ThirdFloor = new Node();
                FourthFloor = new Node();
                Head = new Node();

                FirstFloor.FloorNumber = "First Floor";
                FirstFloor.elevatorUp = SecondFloor;
                SecondFloor.FloorNumber = " Second Floor";
                SecondFloor.elevatorUp = ThirdFloor;
                ThirdFloor.FloorNumber = " Third Floor";
                ThirdFloor.elevatorUp = FourthFloor;
                FourthFloor.FloorNumber = "FourthFloor";
                FourthFloor.elevatorUp = null;
            }

            public void traverseList()
            {
                Node temp;
                temp = Head;
                //Where am i going to start?
                Console.WriteLine("The first floor is" + Head.FloorNumber);

                while (temp != null)
                {
                    Console.WriteLine(temp.FloorNumber);
                    temp = temp.elevatorUp;
                   

                }
            }
        }

        class BubbleSort

        {
            public void run()
            {
                int[] array = new int[5] { 9, 11, 3, 5, 17 };
                int temp;

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        temp = 0;
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[i] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
                // Console.WriteLine("the i-th value is {0} ", array[i]);
            }

            // Console.WriteLine("C'est Fini");

        }
    
}
    

        
        
        
        
    


