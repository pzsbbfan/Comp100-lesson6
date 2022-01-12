// See https://aka.ms/new-console-template for more information

string[] faces = new string[13];
string[] suits = {"Club","Diamonds","Hearts","Spades"};
string[] cards = new string[52];
string search = "";
int counter = 0;
int location =0;
bool cardfound = false;
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
                     faces[index] = "Ace";
                     break;
                 }
             case 10:
                 {
                     faces[index] = "Jack";
                     break;
                 }


             case 11:
                 {
                     faces[index] = "Queen";
                     break;
                 }

             case 12:
                 {
                     faces[index] = "King";
                     break;
                 }

    }



    cards[counter] = faces[index].ToString() + " of " + suits[suit]; 
        counter++;
        }
}
foreach (string card in cards)
{
    Console.WriteLine(card);
}
Console.WriteLine();
Random rand = new Random();
int randomCardIndex = rand.Next(52);
Console.WriteLine("Randomly draw a card:");
Console.WriteLine(cards[randomCardIndex]);
Console.WriteLine();


Console.WriteLine("Please type the card you want to find in the deck");
search =  Console.ReadLine();
Console.WriteLine("you entered {0}",search);


foreach (string Card in cards) 
{
    if (Card == search)
    {
        Console.WriteLine("this card is located at {0}", location + 1);
        cardfound = true;
    }
    location++;
}
if (cardfound == false) 
{
    Console.WriteLine("card not found");
}



Console.ReadKey(); 