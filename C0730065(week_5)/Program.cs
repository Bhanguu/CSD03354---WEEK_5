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
            public Node linkA;
            public Node elevatorUp;
            public string FloorNumber;
        }
        class Department
        {
            public Department a department;
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
    }
}
        
        
        
        
    


