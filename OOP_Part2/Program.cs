namespace OOP_Part2
{
    internal class Program
    {
        public class Room
        {
            public int roomNumber;
            public string roomType;
            public double pricePerNight;
            public bool isAvailable;

            public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
            {
                this.roomNumber = roomNumber;
                this.roomType = roomType;
                this.pricePerNight = pricePerNight;
                this.isAvailable = isAvailable;
            }

            public void displayRoom()
            {
                Console.WriteLine("Room Number: " + roomNumber);
                Console.WriteLine("Room Type: " + roomType);
                Console.WriteLine("Price Per Night: " + pricePerNight);
                Console.WriteLine("Available: " + isAvailable);
            }
        }

    }
}

