using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickMorty
{
    public enum Item { plumbus, meeseeks, portalgun };

    public class ProgramUI
    {
        private int _sleepTime = 5000;
        public List<Item> inventory = new List<Item>();
        //Connecting the room to the room name
        Dictionary<string, Room> Rooms = new Dictionary<string, Room>
        {
            {"garage",garage},{"house",house},{"driveway",driveway},{"laboratory",lab},{"lab",lab}
        };

        // Garage Splash
        public static Room garage = new Room(
            "\n\nYou're in the garage with all your junk and crap.\n\n" +
            "Obvious exits are DRIVEWAY and HOUSE\n", new List<string> { "driveway", "house" }, new List<Item> { Item.plumbus }, new List<Event>{
            new Event("Control Panel",EventType.Use,new Result("laboratory","You've opened the hatch to your LABORATORY."))
            });

        // lab Room
        public static Room lab = new Room("\n\n\n You've entered your secret lab under the garage.\n" +
            "It's way nicer than the rest of the house\n\n" +
            "Ovious exits are GARAGE\n", new List<string> { "garage" }, new List<Item> { },new List<Event> { });

        //driveway splash
        public static Room driveway = new Room("\n\nYou're in the driveway. The car is goine but \n" +
            "the oil stain is still there. \n\n" +
            "Obvious exits are GARAGE and YARD\n", new List<string> { "garage" }, new List<Item> {},new List<Event> { });

        //House splash
        public static Room house = new Room("\n\nYou're in the house now. It's drab and smells like \n" +
            "lemon pine-sol with a hint of stale fart. \n\n" +
            "Obvious exits are GARAGE and KITCHEN\n", new List<string> { "garage" }, new List<Item> { },new List<Event> { });

        public void Run()
        {
            Room currentRoom = garage;

            Console.Clear();
            Console.WriteLine("You accidentally killed Morty. \n" +
                "In order to construct a passable facsimile, you must collect\n" +
                "enough Mortys from other dimensions to assemble from them \n" +
                "Morty's genetic structure and connectome.");

            Console.WriteLine(" \n\nPress any key to continue");
            Console.ReadKey();

            bool alive = true;

            while (alive)
            {
                Console.Clear();

                Console.WriteLine(currentRoom.Splash);

                string command = Console.ReadLine().ToLower();

                if (command.StartsWith("go ") || command.StartsWith("exit"))
                {
                    bool foundExit = false;

                    foreach (string exit in currentRoom.Exits)
                        if (command.Contains(exit) && Rooms.ContainsKey(exit))
                        {
                            currentRoom = Rooms[exit];
                            foundExit = true;
                            break;
                        }
                    if(!foundExit)
                        Console.WriteLine("Uh.. Go where?");

                    if (command.Contains("garage"))
                        currentRoom = garage;
                    else if (command.Contains("driveway"))
                        currentRoom = driveway;
                    else if (command.Contains("house"))
                        currentRoom = house;
                    else
                        Console.WriteLine("Uh... Go where?");
                }
                else if (command.StartsWith("get ") || command.StartsWith("take ") || command.StartsWith("grab "))
                {
                    bool foundItem = false;
                    foreach(Item item in currentRoom.Items)
                    {
                        if(!foundItem && command.Contains(item.ToString()))
                        {
                            Random rand = new Random();
                            int flavorTextChoice = rand.Next(0, 3); // This will use 0 1 and 2 and pick a random value there 
                            string flavorText;
                            switch (flavorTextChoice)
                            {
                                case 0:
                                    flavorText = "Don't Break it.";
                                    break;
                                case 1:
                                    flavorText = "Good for you.";
                                    break;
                                case 2:
                                default:
                                    flavorText = "Fantastic.";
                                        break;
                            }
                            Console.WriteLine($"Congratulations, You found a(n) {item}. {flavorText}\n" +
                            $"Press any key to continue...");
                            currentRoom.RemoveItem(item);
                            inventory.Add(item);
                            foundItem = true;
                            Console.ReadKey();
                            break;
                        }
                    }
                    if (!foundItem)
                    {
                        Console.WriteLine("I don't know what you're talking about.");
                        Thread.Sleep(_sleepTime);
                    }
                }
                else if (command.StartsWith("use ") || command.StartsWith("activate "))
                {
                    string eventMessage = "I doubt you know how";
                    foreach(Event roomEvent in currentRoom.Events)
                    {
                        if(!command.Contains(roomEvent.TriggerPhrase) || roomEvent.Type != EventType.Use)
                        {
                            continue;
                        }
                        if(roomEvent.EventResult.Type == ResultType.NewExit)
                        {
                            currentRoom.Exits.Add(roomEvent.EventResult.ResultDestination);
                            eventMessage = roomEvent.EventResult.ResultMessage;
                        }
                        else if(roomEvent.EventResult.Type == ResultType.GetItem)
                        {
                            inventory.Add(roomEvent.EventResult.ResultItem);
                            eventMessage = roomEvent.EventResult.ResultMessage;
                        }
                        else if(roomEvent.EventResult.Type == ResultType.MessageOnly)
                        {
                            eventMessage = roomEvent.EventResult.ResultMessage;
                        }
                    }
                    Console.WriteLine(eventMessage);
                    Thread.Sleep(_sleepTime);
                }
                else
                {
                    Console.WriteLine("*BUUUURP* What?");
                    Thread.Sleep(_sleepTime);
                }
            }
        }
    }

    
    public class Room
    {
        public List<Item> Items { get; }
        public string Splash { get; }
        public List<string> Exits { get; }
        public List<Event> Events { get; }

        public void RemoveItem(Item item)
        {
            if (Items.Contains(item))
                Items.Remove(item);
        }

        public Room() { }
        public Room(string splash, List<string> exits,List<Item> items,List<Event> events)
        {
            this.Splash = splash;
            this.Exits = exits;
            this.Items = items;
            this.Events = events;
        }

        public void ResolveEvent(Event resolvedEvent)
        {
            if (Events.Contains(resolvedEvent))
                Events.Remove(resolvedEvent);
        }
    }
}
