// See https://aka.ms/new-console-template for more information

// Declare the arrays
string[] faces = new string [13];
string[] suits = {"Club","Diamond","Heart","Spades"};

// initialized the deck of card array
string[] deckOfCards = new string[52];

//initialized counter to track each element in deckOfCards[]
int counter = 0;

//initialized a string for finding a card
string findCard = "";

//initialized the position of card want to find 
int position = 0;

//initialized a boolean for find card loop to go
bool foundCard = false;

// fixing the index and values of faces[] 
for (int face = 0; face < faces.Length; face++)
{
    faces[face] = (face + 1).ToString();
}

// combine faces[] with suits[] using nested loops 
for (int suit = 0; suit < suits.Length; suit++)
{
    for (int card = 0; card < faces.Length; card++)
    {
        // pass the vaulue to deckOfCards[] 
        deckOfCards[counter] = faces[card].ToString() + " of " + suits[suit];
        Console.WriteLine(deckOfCards[counter]);
        counter++;
    }
}
Console.WriteLine();
// Generates Random in order to draw a random card 
Random random = new Random();

// Generates random index for drawing a card
int randomIndex = random.Next(52);
Console.WriteLine("The random card you draw from the deck is {0}",deckOfCards[randomIndex]);
Console.WriteLine();

// Finding the place of a card that user inputs
// prompt a card that user want to find

while (foundCard == false) 
{
    Console.WriteLine("Enter the card you want to find");
    findCard = Console.ReadLine();
    // using foreach loop to go through everysinge element in deckOfCard[]
    foreach (string card in deckOfCards)
    {
        // using if statement to check
        if (findCard == deckOfCards[position])
        {
            Console.WriteLine("{0} is located at {1}th position of the deck", card, position + 1);
            foundCard = true;
            break;
        }
        position++;
    }

    if (foundCard == false)
    {
        Console.WriteLine("card not found");
        position = 0;
    }
}


Console.ReadKey(); 