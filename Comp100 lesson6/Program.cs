// See https://aka.ms/new-console-template for more information

string[] faces = new string[13];
string[] suits = {"Club","Diamonds","Hearts","Spades"};
string[] cards = new string[52];
int counter = 0;


for (int face  = 0; face < faces.Length; face ++) 
{
    faces[face] = (face + 1).ToString();
}

for (int suit = 0; suit < suits.Length; suit++) 
{
    for (int index = 0; index < faces.Length; index++)
    {
         switch (counter) 
         {
             case 0: 
                 {
                     faces[index] = "Ace ";
                     break;
                 }
             case 10:
                 {
                     faces[index] = "Jack ";
                     break;
                 }


             case 11:
                 {
                     faces[index] = "Queen";
                     break;
                 }

             case 12:
                 {
                     faces[index] = "King ";
                     break;
                 }

    }



    cards[counter] = faces[index].ToString() + "of " + suits[suit]; 
        Console.WriteLine(cards[counter]);
        counter++;
        }
}
Console.WriteLine();
Random rand = new Random();

for (int i = 0; i < 6; i++)
{
    int randomIndex = rand.Next(cards.Length);
    Console.WriteLine(cards[randomIndex]);
}




Console.ReadKey(); 