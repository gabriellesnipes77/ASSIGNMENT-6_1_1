namespace ASSIGNMENT_6_1_1
{

    class HouseNode
    {
        public int HouseNumber;
        public string Address;
        public string HouseType;
        public HouseNode Next;


        // Constructor to create a new house node
        public HouseNode(int houseNumber, string address, string houseType)
        {
            HouseNumber = houseNumber;
            Address = address;
            HouseType = houseType;
            Next = null;
        }
    }

    class HouseLinkedList
    {
        private HouseNode head;

        public HouseLinkedList()
        {
            head = null;
        }

        public void AddHouse(int houseNumber, string address, string houseType)

        {
            HouseNode newHouse = new HouseNode(houseNumber, address, houseType);

            if (head == null)
            {
                head = newHouse;
            }
            else
            {
                HouseNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newHouse;
            }
        }


        public HouseNode SearchHouse(int houseNumber)
        {
            HouseNode current = head;
            while (current != null)
            {
                if (current.HouseNumber == houseNumber)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }



        public void DisplayHouseDetails(HouseNode house)
        {
            if (house != null)
            {
                Console.WriteLine($"House Number: {house.HouseNumber}");
                Console.WriteLine($"Address: {house.Address}");
                Console.WriteLine($"House Type: {house.HouseType}");
            }
            else
            {
                Console.WriteLine("House not found.");
            }
        }


        public void DisplayAllHouses()
        {
            HouseNode current = head;
            if (current == null)
            {
                Console.WriteLine("No houses available.");
                return;
            }
            while (current != null)
            {
                DisplayHouseDetails(current);
                Console.WriteLine("------");
                current = current.Next;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            HouseLinkedList houseList = new HouseLinkedList();

            houseList.AddHouse(101, "1260 Parkway Place, Clarksville", "TownHouse");
            houseList.AddHouse(102, "170 Ashford Drive, Norfolk", "House");
            houseList.AddHouse(103, "546 Beckett Road, Raleigh", "Apartment");

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Search house by number");
                Console.WriteLine("2. Display all houses");
                Console.WriteLine("3. Exit");

                Console.WriteLine("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter house number to search: ");
                    int houseNumber = int.Parse(Console.ReadLine());
                    HouseNode house = houseList.SearchHouse(houseNumber);
                    houseList.DisplayHouseDetails(house);
                }
                else if (choice == "2")
                {
                    houseList.DisplayAllHouses();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

            }
        }
    }
}
