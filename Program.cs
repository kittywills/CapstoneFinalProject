using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinchAPI;


//************************************
//Title: Finchi the Ghost Hunter - Capstone Final 
//Application Type: C# .NET framework and FinchAPI
//Description: Text based adventure game with the finch robot.
//Author: Katelyn Williams
//Date Created: 11.13.17
//Last Modified: 12.10.17
//************************************


namespace CapstoneFinal
{
    class Program
    {
        //*****************
        //APPLICATION FLOW
        //*****************

        static void Main(string[] args)
        {

            Finch finchi = new Finch();

            DisplayWelcomeScreen(finchi);
            DisplayClosingScreen(finchi);
            
        }


        //******************
        // MENU CODE BLOCKS
        //******************

        static void DisplayFirstFloor(Finch finchi)
        {

            string menuChoice;
            string message = "";
          


            {
                DisplayHeader("First Floor");

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("The mansion is old and dusty. A perfect place for ghosts. What room should Finchi check out first?");
                Console.WriteLine();

                Console.WriteLine("\t1) Front Door");
                Console.WriteLine("\t2) Dining Room");
                Console.WriteLine("\t3) Kitchen");
                Console.WriteLine("\t4) Sitting Room");
                Console.WriteLine("\t5) Hall Bathroom");
                Console.WriteLine("\t6) Go Upstairs");

                Console.WriteLine();
                Console.Write("Enter Choice");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        message = "Why are you leaving?! Finchi doesn't want to hust ghosts alone.";
                        break;

                    case "2":
                        DisplayDiningRoom(finchi);
                        break;

                    case "3":
                        DisplayKitchen(finchi);
                        break;

                    case "4":
                        DisplaySittingRoom(finchi);
                        break;

                    case "5":
                        DisplayHallBathroom(finchi);
                        break;

                    case "6":
                        DisplaySecondFloor(finchi);
                        break;


                    default:
                        DisplayFirstFloor(finchi);
                        break;
                }

                if (message != "")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(message);
                    DisplayContinuePrompt();
                    DisplayFirstFloor(finchi);
                }
            }

        }


        static void DisplaySecondFloor(Finch finchi)
        {

            string menuChoice;

            string message = "";


            {
                DisplayHeader("Second Floor");

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Those stairs are really creaky, but we made it all the way up.");
                Console.WriteLine("Let's look around!");
                Console.WriteLine();

                Console.WriteLine("\t1) Green Bedroom");
                Console.WriteLine("\t2) Red Bedroom");
                Console.WriteLine("\t3) Study");
                Console.WriteLine("\t4) Master Bedroom");
                Console.WriteLine("\t5) Master Bathroom");
                Console.WriteLine("\t6) Go Downstairs");
                Console.WriteLine("\t7) Time to leave");

                Console.WriteLine();
                Console.Write("Enter Choice");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        DisplayGreenBedroom(finchi);
                        break;

                    case "2":
                        DisplayRedBedroom(finchi);
                        break;

                    case "3":
                        DisplayStudy(finchi);
                        break;

                    case "4":
                        DisplayMasterBedroom(finchi);
                        break;

                    case "5":
                        DisplayMasterBathroom(finchi);
                        break;

                    case "6":
                        DisplayFirstFloor(finchi);
                        break;

                    case "7":
                        DisplayGoOutside(finchi);
                        break;

                    default:
                        DisplaySecondFloor(finchi);
                        break;
                }

                if (message != "")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(message);
                    DisplayContinuePrompt();
                    DisplaySecondFloor(finchi);
                }
            }

        }


        //*************************
        // APPLICATION CODE BLOCKS
        //*************************

        //display opening screen
        static void DisplayWelcomeScreen(Finch finchi)
        {

            Console.WriteLine("\tFinchi the Ghost Hunter");
            Console.WriteLine("\tBy Katelyn 'kat' Wililams");

            Console.WriteLine("\t\t .-.");
            Console.WriteLine("\t\t(o o) boo!");
            Console.WriteLine("\t\t( O )");
            Console.WriteLine("\t\t(   ~");
            Console.WriteLine("\t\t`~   ~");
            Console.WriteLine("\t\t  ~~  ~");
            Console.WriteLine("\t\t     ~");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Finchi has been playing too much of Luigi's Mansion and wants to go hunt down some ghosts.");
            Console.WriteLine("She has found a creepy mansion on the outskirts of town that is totes for reelz haunted.");
            Console.WriteLine("Help her out to go bust some ghosts.");
            Console.WriteLine();
            Console.WriteLine("Enter numerical values (1,2,3...) to explore the mansion.");


            Console.WriteLine("Press any key to start exploring.");
            Console.ReadKey();

            InitializeFinch(finchi);

        }

        // initialize finch
        static void InitializeFinch(Finch finchi)
        {

            string userResponse;

            Console.Clear();


            Console.WriteLine("                  ,'.");
            Console.WriteLine("  ,',           ,':::`.");
            Console.WriteLine(",':::`.   ,'.    u---u");
            Console.WriteLine(" |,'.|  ,':::`.  |,'.|");
            Console.WriteLine(",':::`.  ||=||  ,':::`.");
            Console.WriteLine(" u|-|u   |,'.|   u|-|u");
            Console.WriteLine(" ||,||  ,'mmm`.  ||,||");
            Console.WriteLine(" ;;u;;u;;|'|'|;;u;;u;;");
            Console.WriteLine(" ||:;:;:;|=|=|:;:;:;|| ,");
            Console.WriteLine("_||;:;:;:|=|=|;:;:;:||_n_");

            Console.WriteLine();
            Console.WriteLine("The mansion is pretty creepy, give Finchi a word of encouragement!");
            userResponse = Console.ReadLine();
            Console.WriteLine();

            if (finchi.connect())
            {
                Console.WriteLine("Finchi is pumped, lets go find some ghosts!");
                finchi.setLED(255, 255, 255);
                finchi.noteOn(266);
                finchi.wait(500);
                finchi.setLED(0, 0, 0);
                finchi.noteOff();
            }

            else
            {
                Console.WriteLine("Finchi is too scared to go inside!");
                Console.WriteLine("(Please check if the finch robot is connected to computer and restart application. Thank you.)");
                Console.ReadKey();

            }

            Console.WriteLine("Press Enter to go inside.");
            DisplayFirstFloor(finchi);
        }

        // end of game screen
        static void DisplayGoOutside(Finch finchi)
        {
            DisplayHeader("Back Yard");

            Console.WriteLine("The house was explored throughly... but no ghosts could be found.");
            Console.WriteLine("Finchi is bummed...");
            Console.WriteLine();

            Console.ReadKey();
            Console.Clear();


            DisplayHeader("Back Yard");
            Console.WriteLine("We will have to check out some other creepy mansions!");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(" .-.");
            Console.WriteLine("(o o)");
            Console.WriteLine("( O )");
            Console.WriteLine("(    ~");
            Console.WriteLine("~    ~'");
            Console.WriteLine("~  ~~");
            Console.WriteLine(" ~");

            Console.ReadKey();
            Console.Clear();


            DisplayHeader("Back Yard");
            Console.WriteLine("Finchi is pretty sure there abandoned hospital down the road.");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t .-.");
            Console.WriteLine("\t(o o)");
            Console.WriteLine("\t( O )");
            Console.WriteLine("\t(    ~");
            Console.WriteLine("\t~    ~");
            Console.WriteLine("\t~  ~~");
            Console.WriteLine("\t ~");

            Console.ReadKey();
            Console.Clear();


            DisplayHeader("Back Yard");
            Console.WriteLine("... Finchi wants to know what you are looking at...?");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t\t .-.");
            Console.WriteLine("\t\t(o o)");
            Console.WriteLine("\t\t( O )");
            Console.WriteLine("\t\t(    ~");
            Console.WriteLine("\t\t~    ~");
            Console.WriteLine("\t\t~  ~~");
            Console.WriteLine("\t\t ~");

            Console.ReadKey();
            Console.Clear();


            DisplayHeader("Back Yard");
            Console.WriteLine("ITS A GHOST!");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t\t .-.");
            Console.WriteLine("\t\t(o o) boo!");
            Console.WriteLine("\t\t( O )");
            Console.WriteLine("\t\t(    ~");
            Console.WriteLine("\t\t~    ~");
            Console.WriteLine("\t\t~  ~~");
            Console.WriteLine("\t\t ~");


            finchi.setMotors(-200, 200);
            finchi.wait(500);
            finchi.setMotors(0, 0);
            finchi.setLED(255, 0, 0);
            finchi.noteOn(555);
            finchi.wait(300);
            finchi.noteOff();

            finchi.setMotors(-200, 200);

            Console.ReadKey();
            Console.Clear();
            string userResponse;

            DisplayHeader("Back Yard");
            Console.WriteLine("Quick! Punch the ghost!");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t\t\t .-.");
            Console.WriteLine("\t\t\t(o o)");
            Console.WriteLine("\t\t\t( O )");
            Console.WriteLine("\t\t\t(    ~");
            Console.WriteLine("\t\t\t~    ~");
            Console.WriteLine("\t\t\t~  ~~");
            Console.WriteLine("\t\t\t ~");

            userResponse = Console.ReadLine();
            Console.WriteLine();

            Console.ReadKey();
            Console.Clear();


            DisplayHeader("Back Yard");
            Console.WriteLine("Nothing happened!");
            Console.WriteLine("Why would you punch of ghost that's a terrible idea!");
            Console.WriteLine("Try telling the ghost to go away!");

            Console.WriteLine("\t\t .-.");
            Console.WriteLine("\t\t(o o)");
            Console.WriteLine("\t\t( O )");
            Console.WriteLine("\t\t(   ~");
            Console.WriteLine("\t\t`~   ~");
            Console.WriteLine("\t\t  ~~  ~");
            Console.WriteLine("\t\t     ~");

            userResponse = Console.ReadLine();
            Console.WriteLine();

            Console.ReadKey();
            Console.Clear();


            DisplayHeader("Back Yard");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t\t .-.");
            Console.WriteLine("\t\t(o o) . . .");
            Console.WriteLine("\t\t( - )");
            Console.WriteLine("\t\t(   ~");
            Console.WriteLine("\t\t`~   ~");
            Console.WriteLine("\t\t  ~~  ~");
            Console.WriteLine("\t\t     ~");

            Console.ReadKey();
            Console.Clear();


            finchi.setMotors(0, 0);

            DisplayHeader("Back Yard");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t\t .-.");
            Console.WriteLine("\t\t(o o) ok.");
            Console.WriteLine("\t\t( - )");
            Console.WriteLine("\t\t(   ~");
            Console.WriteLine("\t\t`~   ~");
            Console.WriteLine("\t\t  ~~  ~");
            Console.WriteLine("\t\t     ~");

            Console.ReadKey();
            Console.Clear();


            DisplayHeader("Back Yard");

            Console.WriteLine("Oh... the ghost is leaving...");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t .-.");
            Console.WriteLine("\t(o o)");
            Console.WriteLine("\t( - )");
            Console.WriteLine("\t(   ~");
            Console.WriteLine("\t`~   ~");
            Console.WriteLine("\t  ~~  ~");
            Console.WriteLine("\t     ~");

            Console.ReadKey();
            Console.Clear();


            DisplayHeader("Back Yard");

            Console.WriteLine("There it goes...");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(" .-.");
            Console.WriteLine("(o o)");
            Console.WriteLine("( - )");
            Console.WriteLine("(   ~");
            Console.WriteLine("`~   ~");
            Console.WriteLine("  ~~  ~");
            Console.WriteLine("     ~");

            Console.ReadKey();
            Console.Clear();


            DisplayHeader("Back Yard");

            Console.WriteLine("That was kinda anticlimatic...");
            Console.WriteLine("But we found a ghost! Finchi is thrilled!");

            Console.ReadKey();

            DisplayClosingScreen(finchi);

        }

        //******************
        // ROOM CODE BLOCKS
        //******************

        static void DisplayDiningRoom(Finch finchi)
        {

            DisplayHeader("Dining Room");

            string menuChoice;
            string messageDiningRoom = "";

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t1) Check inside the china cabinet.");
            Console.WriteLine("\t2) Look under the table.");
            Console.WriteLine("\t3) Avoid the shadowy corner.");

            Console.WriteLine("\t4) Back");

            Console.WriteLine();
            Console.Write("Enter Choice");
            menuChoice = Console.ReadLine();


            switch (menuChoice)
            {

                case "1":
                    messageDiningRoom = "There is a mouse in there! Scary!";
                    break;

                case "2":
                    messageDiningRoom = "Just a bunch of dust bunnies.";
                    break;

                case "3":
                    messageDiningRoom = "It's really dark over there. Finchi will light the way.";
                    finchi.setLED(255, 255, 255);
                    finchi.wait(200);
                    finchi.setLED(0, 0, 0);
                    break;

                case "4":
                    DisplayFirstFloor(finchi);
                    break;

                default:
                    DisplayDiningRoom(finchi);
                    break;
            }

            if (messageDiningRoom != "")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(messageDiningRoom);
                DisplayContinuePrompt();
                DisplayDiningRoom(finchi);
            }

        }


        static void DisplayKitchen(Finch finchi)
        {

            DisplayHeader("Kitchen");

            string menuChoice;
            string messageKitchen = "";

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t1) Check inside the icebox.");
            Console.WriteLine("\t2) Look in the cupboards.");
            Console.WriteLine("\t3) Eat the fruit on the table.");

            Console.WriteLine("\t4) Back");

            Console.WriteLine();
            Console.Write("Enter Choice");
            menuChoice = Console.ReadLine();


            switch (menuChoice)
            {

                case "1":
                    messageKitchen = "Doesn't look like there has been any ice in here in a long time...";
                    break;

                case "2":
                    messageKitchen = "Just a bunch of broken plates and cups.";
                    break;

                case "3":
                    messageKitchen = "It's not real! Its plastic apples. Ew!";
                    finchi.setMotors(-200, -200);
                    finchi.setLED(255, 0, 0);
                    finchi.wait(500);
                    finchi.setMotors(0, 0);
                    finchi.setLED(0, 0, 0);
                    break;

                case "4":
                    DisplayFirstFloor(finchi);
                    break;

                default:
                    DisplayKitchen(finchi);
                    break;
            }

            if (messageKitchen != "")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(messageKitchen);
                DisplayContinuePrompt();
                DisplayKitchen(finchi);
            }

        }


        static void DisplaySittingRoom(Finch finchi)
        {

            DisplayHeader("Sitting Room");

            string menuChoice;
            string messageSittingRoom = "";

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t1) Sit on the couch.");
            Console.WriteLine("\t2) Turn on the lamp.");
            Console.WriteLine("\t3) Check out the bookshelf.");

            Console.WriteLine("\t4) Back");

            Console.WriteLine();
            Console.Write("Enter Choice");
            menuChoice = Console.ReadLine();


            switch (menuChoice)
            {

                case "1":
                    messageSittingRoom = "The couch doesn't seem very comfortable. It looks like there are small rodents living in it.";
                    break;

                case "2":
                    messageSittingRoom = "There isn't any power in the place. Finchi will light the way.";
                    finchi.setLED(255, 255, 255);
                    finchi.wait(200);
                    finchi.setLED(0, 0, 0);
                    break;

                case "3":
                    messageSittingRoom = "Aww... There isn't a hidden passage behind it. Just the complete collection of the 1954 edtion of the Encyclopedia Britannica.";
                    break;

                case "4":
                    DisplayFirstFloor(finchi);
                    break;

                default:
                    DisplaySittingRoom(finchi);
                    break;
            }

            if (messageSittingRoom != "")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(messageSittingRoom);
                DisplayContinuePrompt();
                DisplaySittingRoom(finchi);
            }

        }

        static void DisplayHallBathroom(Finch finchi)
        {

            DisplayHeader("Hall Bathroom");

            string menuChoice;
            string messageHallBathroom = "";

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t1) Check behind the shower curtain.");
            Console.WriteLine("\t2) Turn on the sink.");
            Console.WriteLine("\t3) Look in the linens closet.");

            Console.WriteLine("\t4) Back");

            Console.WriteLine();
            Console.Write("Enter Choice");
            menuChoice = Console.ReadLine();


            switch (menuChoice)
            {

                case "1":
                    messageHallBathroom = "Eww... the show is covered in mildew. This was not the type of slime Finchi was looking for.";

                    break;

                case "2":
                    messageHallBathroom = "The spout makes some sputtering noise but then nothing happens.";
                    break;

                case "3":
                    messageHallBathroom = "As the door is opened all the linens fall out! Finchi thinks that you look like a ghost now.";
                    finchi.noteOn(659);
                    finchi.wait(100);
                    finchi.noteOn(659);
                    finchi.wait(100);
                    finchi.noteOn(659);
                    finchi.wait(100);
                    finchi.noteOn(880);
                    finchi.wait(100);
                    finchi.noteOff();
                    break;

                case "4":
                    DisplayFirstFloor(finchi);
                    break;

                default:
                    DisplayHallBathroom(finchi);
                    break;
            }

            if (messageHallBathroom != "")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(messageHallBathroom);
                DisplayContinuePrompt();
                DisplayHallBathroom(finchi);
            }

        }

        static void DisplayGreenBedroom(Finch finchi)
        {

            DisplayHeader("Green Bedroom");

            string menuChoice;
            string messageGreenBedroom = "";

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t1) Jump on bed.");
            Console.WriteLine("\t2) Check inside bureau.");
            Console.WriteLine("\t3) Look out the window.");

            Console.WriteLine("\t4) Back");

            Console.WriteLine();
            Console.Write("Enter Choice");
            menuChoice = Console.ReadLine();


            switch (menuChoice)
            {

                case "1":
                    messageGreenBedroom = "If you fall and break yoru leg Finchi is going to leave you here.";
                    break;

                case "2":
                    messageGreenBedroom = "Ahh! It's a ghost! Oh wait... it's just a fuzzy white coat.";
                    finchi.setLED(255, 0, 0);
                    finchi.noteOn(1047);
                    finchi.wait(1000);
                    finchi.noteOff();
                    finchi.setLED(0, 255, 0);
                    finchi.wait(500);
                    finchi.setLED(0, 0, 0);
                    break;

                case "3":
                    messageGreenBedroom = "There is only dark woods back there. Maybe you can go hunt for Mothman after this!";

                    break;

                case "4":
                    DisplaySecondFloor(finchi);
                    break;

                default:
                    DisplayGreenBedroom(finchi);
                    break;
            }

            if (messageGreenBedroom != "")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(messageGreenBedroom);
                DisplayContinuePrompt();
                DisplayGreenBedroom(finchi);
            }

        }

        static void DisplayRedBedroom(Finch finchi)
        {

            DisplayHeader("Red Bedroom");

            string menuChoice;
            string messageRedBedroom = "";

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t1) Look inside the pillow case.");
            Console.WriteLine("\t2) Check out the top of the vanity.");
            Console.WriteLine("\t3) Open the drawers on the nightstand.");

            Console.WriteLine("\t4) Back");

            Console.WriteLine();
            Console.Write("Enter Choice");
            menuChoice = Console.ReadLine();


            switch (menuChoice)
            {

                case "1":
                    messageRedBedroom = "Nothing but feathers and dust. You're going to make Finchi sneeze!";
                    finchi.noteOn(988);
                    finchi.noteOn(587);
                    finchi.noteOff();
                    break;

                case "2":
                    messageRedBedroom = "There is a picture of a fancy lady laying there. Finchi wonders if that is who used to own the mansion.";
                    //DisplayFindKey(finchi);
                    break;

                case "3":
                    messageRedBedroom = "So many socks! But only the left pair...";

                    break;

                case "4":
                    DisplaySecondFloor(finchi);
                    break;

                default:
                    DisplayRedBedroom(finchi);
                    break;
            }

            if (messageRedBedroom != "")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(messageRedBedroom);
                DisplayContinuePrompt();
                DisplayRedBedroom(finchi);
            }

        }

        static void DisplayStudy(Finch finchi)
        {

            DisplayHeader("Study");

            string menuChoice;
            string messageStudy = "";

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t1) Poke around the fireplace.");
            Console.WriteLine("\t2) Go read the books on the shelf.");
            Console.WriteLine("\t3) Sit down at the writing desk.");

            Console.WriteLine("\t4) Back");

            Console.WriteLine();
            Console.Write("Enter Choice");
            menuChoice = Console.ReadLine();


            switch (menuChoice)
            {

                case "1":
                    messageStudy = "It's full of old ashes and burnt paper. Finchi wonder what was burnt here.";
                    break;

                case "2":
                    messageStudy = "Only the full edition of the 1973 Encyclopedia Britannica... Whoever owned this place really liked encyclopedias.";

                    break;

                case "3":
                    messageStudy = "Finchi wonders... why is a raven like a writing desk...?";

                    break;

                case "4":
                    DisplaySecondFloor(finchi);
                    break;

                default:
                    DisplayStudy(finchi);
                    break;
            }

            if (messageStudy != "")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(messageStudy);
                DisplayContinuePrompt();
                DisplayStudy(finchi);
            }

        }

        static void DisplayMasterBedroom(Finch finchi)
        {

            DisplayHeader("Master Bathroom");

            string menuChoice;
            string messageMasterBedroom = "";

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t1) Look under the bed.");
            Console.WriteLine("\t2) Open up the closet.");
            Console.WriteLine("\t3) Quick! Turn around!");

            Console.WriteLine("\t4) Back");

            Console.WriteLine();
            Console.Write("Enter Choice");
            menuChoice = Console.ReadLine();


            switch (menuChoice)
            {

                case "1":
                    messageMasterBedroom = "Finchi will check under the bed for monsters. ... Finchi doesn't see anything... ";
                    finchi.setLED(255, 255, 255);
                    finchi.setMotors(200, 200);
                    finchi.wait(1000);
                    finchi.setMotors(-200, -200);
                    finchi.wait(1000);
                    finchi.setLED(0, 0, 0);
                    finchi.setMotors(0, 0);
                    break;

                case "2":
                    messageMasterBedroom = "Doesn't look like there are an skeletons in this closet.";

                    break;

                case "3":
                    messageMasterBedroom = "Nope, nothing behind us. Finchi just wanted to make sure a ghost wasn't stalking you.";
                    finchi.setMotors(-250, 0);
                    break;

                case "4":
                    DisplaySecondFloor(finchi);
                    break;

                default:
                    DisplayMasterBedroom(finchi);
                    break;
            }

            if (messageMasterBedroom != "")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(messageMasterBedroom);
                DisplayContinuePrompt();
                DisplayMasterBedroom(finchi);
            }

        }

        static void DisplayMasterBathroom(Finch finchi)
        {

            DisplayHeader("Master Bathroom");

            string menuChoice;
            string messageMasterBathroom = "";

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t1) Take a bath.");
            Console.WriteLine("\t2) Look in the mirror");
            Console.WriteLine("\t3) Steal the towels.");

            Console.WriteLine("\t4) Back");

            Console.WriteLine();
            Console.Write("Enter Choice");
            menuChoice = Console.ReadLine();


            switch (menuChoice)
            {

                case "1":
                    messageMasterBathroom = "Finchi does not think that this is the right time for this.";
                    finchi.setLED(0, 255, 0);
                    finchi.wait(300);
                    finchi.setLED(0, 0, 255);
                    finchi.wait(300);
                    finchi.setLED(0, 0, 0);
                    break;

                case "2":
                    messageMasterBathroom = "Say Bloody Mary three times and see what happens! Aw... nothing happened... ";

                    break;

                case "3":
                    messageMasterBathroom = "Finchi can't take  you anywhere...";

                    break;

                case "4":
                    DisplaySecondFloor(finchi);
                    break;

                default:
                    DisplayMasterBathroom(finchi);
                    break;
            }

            if (messageMasterBathroom != "")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(messageMasterBathroom);
                DisplayContinuePrompt();
                DisplayMasterBathroom(finchi);
            }

        }


        //****************
        // UI CODE BLOCKS
        //****************


        // display header
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }



        // display continue prompt     
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to keep exploring.");
            Console.ReadKey();
        }


        // display closing screen 
        static void DisplayClosingScreen(Finch finchi)
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("You have defeated the ghost!");
            Console.WriteLine("Finchi now dubs you offical ghost puncher.");
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine();
            
            finchi.disConnect();

            Console.WriteLine();
            Console.WriteLine("ASKII art used under the creative commons license from Chris.com");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }




    }
}

//****************
// UNFINISHED CODE
// I tried to make a bool to open and close a door depending if you had picked a up a key. Could not get it to work properly.
//****************

//static bool DisplayFindKey()
//{
//    DisplayHeader("Find Key");
//    bool hasKey = false;          
//    hasKey = true;
//    return hasKey;
//    DisplayContinuePrompt();
//}
//static void DisplayOpenDoor(bool hasKey)
//{
//    DisplayHeader("Find Key");
//    if (hasKey)
//    {
//        hasKey = true;
//        Console.WriteLine("The door is locked");
//    }
//    else if (!hasKey)
//    {
//        hasKey = true;
//        Console.WriteLine("The door is open");
//    }
// DisplayContinuePrompt();
//}



