//LA 3.2

using System;

class ArrayNames
{
    static void Main()
    {
        string[] classmates = new string[14];

        classmates[0] = "1. Maahin. Age: 23";
        classmates[1] = "2. Emre. Age: 20";
        classmates[2] = "3. Ethan. Age: 27";
        classmates[3] = "4. Mason. Age: 29";
        classmates[4] = "5. Keegan. Age: 25 ";
        classmates[5] = "6. Cat. Age: 24";
        classmates[6] = "7. Bruno. Age: 24";
        classmates[7] = "8. Julianna. Age: 22";
        classmates[8] = "9. Camilo. Age: 28";
        classmates[9] = "10. Jose. Age: 21";
        classmates[10] = "11. Canyon. Age: 20";
        classmates[11] = "12. Shea. Age: 30";
        classmates[12] = "13. Lukas. Age: 27";
        classmates[13] = "14. Lucas. Age: 25";

        Console.WriteLine("Students: \n");

        foreach (string name in classmates)
        {
            Console.WriteLine(name);
        }

        {
            string[] Wonders = new string[7];
            Wonders[0] = "\n1. The Colosseum, ITALY";
            Wonders[1] = "2. The Great Wall of China, CHINA ";
            Wonders[2] = "3. The Taj Mahal, INDIA";
            Wonders[3] = "4. Christ the Redeemer, BRAZIL";
            Wonders[4] = "5. Machu Picchu, PERU";
            Wonders[5] = "6. Chichen Itza, MEXICO";
            Wonders[6] = "7. Petra, JORDAN";

            Console.WriteLine("\n7 Wonders of the World: ");

            foreach (string name in Wonders)
            {
                Console.WriteLine(name);
            }
        }
    }

}