namespace OOP_Part2
{
    internal class Program
    {

        // Room Class
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

            // Guest Class 
            public class Guest
            {
                public string guestId;
                public string guestName;
                public string roomNumber;
                public string checkInDate;
                public int totalNights;

                public Guest(string guestId, string guestName, string roomNumber,
                             string checkInDate, int totalNights)
                {
                    this.guestId = guestId;
                    this.guestName = guestName;
                    this.roomNumber = roomNumber;
                    this.checkInDate = checkInDate;
                    this.totalNights = totalNights;
                }

            public void displayGuest()
            {
                Console.WriteLine("Guest ID: " + guestId);
                Console.WriteLine("Guest Name: " + guestName);
                Console.WriteLine("Room Number: " + roomNumber);
                Console.WriteLine("Check-In Date: " + checkInDate);
                Console.WriteLine("Total Nights: " + totalNights);
            }
                    public double calculateTotalCost(double pricePerNight)
                {
                    return totalNights * pricePerNight;
                }

            }

        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            // Pre-load Rooms
            rooms.Add(new Room(101, "Single", 25, true));
            rooms.Add(new Room(102, "Single", 25, true));
            rooms.Add(new Room(201, "Double", 40, true));
            rooms.Add(new Room(202, "Double", 40, true));
            rooms.Add(new Room(301, "Suite", 80, true));
            rooms.Add(new Room(302, "Suite", 80, true));

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("GRAND VISTA HOTE");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");

                Console.Write("Choose an option: ");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                switch (choice)
                {

                    // Case 01 Add New Room 

                    case 1:
                        {
                            Console.Write("Enter Room Number: ");

                            int roomNumber;

                            if (!int.TryParse(Console.ReadLine(), out roomNumber) || roomNumber <= 0)
                            {
                                Console.WriteLine("Invalid room number.");
                                break;
                            }

                            if (rooms.Any(r => r.roomNumber == roomNumber))
                            {
                                Console.WriteLine("Room number already exists.");
                                break;
                            }

                            Console.Write("Enter Room Type (Single/Double/Suite): ");
                            string roomType = Console.ReadLine();

                            Console.Write("Enter Price Per Night: ");

                            double price;

                            if (!double.TryParse(Console.ReadLine(), out price) || price <= 0)
                            {
                                Console.WriteLine("Invalid price.");
                                break;
                            }

                            Room newRoom = new Room(roomNumber, roomType, price, true);

                            rooms.Add(newRoom);

                            Console.WriteLine("Room Added Successfully!");
                            Console.WriteLine("Room Number: " + newRoom.roomNumber);
                            Console.WriteLine("Room Type: " + newRoom.roomType);
                            Console.WriteLine("Price: " + newRoom.pricePerNight);
                            Console.WriteLine("Available: " + newRoom.isAvailable);
                            Console.WriteLine("Total Rooms: " + rooms.Count());

                            break;
                        }

                    // Case 02 Register New Guest

                    case 2:
                        {
                            Console.Write("Enter Guest Name: ");
                            string guestName = Console.ReadLine();

                            Console.Write("Enter Check-In Date: ");
                            string checkInDate = Console.ReadLine();

                            Console.Write("Enter Number of Nights: ");

                            int totalNights;

                            if (!int.TryParse(Console.ReadLine(), out totalNights) || totalNights <= 0)
                            {
                                Console.WriteLine("Invalid number of nights.");
                                break;
                            }


                            // Auto generate Guest ID using Count()
                            string guestId = "G" + (guests.Count() + 1).ToString("D3");


                            Guest newGuest = new Guest
                            (
                                guestId,
                                guestName,
                                "Not Assigned",
                                checkInDate,
                                totalNights
                            );


                            guests.Add(newGuest);


                            Console.WriteLine("Guest Registered Successfully!");
                            Console.WriteLine("Guest ID: " + newGuest.guestId);
                            Console.WriteLine("Guest Name: " + newGuest.guestName);
                            Console.WriteLine("Check-In Date: " + newGuest.checkInDate);
                            Console.WriteLine("Total Nights: " + newGuest.totalNights);

                            break;
                        }

                }
            }
        }
    }
}

  

