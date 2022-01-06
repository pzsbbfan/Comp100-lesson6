// See https://aka.ms/new-console-template for more information

int[] faces = new int[13];
string[] suits = {"Club","Diamonds","Hearts","Spades"};
string[] cards = new string[52];
int counter = 0;


for (int face  = 0; face < faces.Length; face ++) 
{
    faces[face] = face + 1;
}

for (int suit = 0; suit < suits.Length; suit++) 
{
    for (int index = 0; index < faces.Length; index++)
    {
        cards[counter] = faces[index].ToString() + "of" + suits[suit]; 
        Console.WriteLine(cards[counter]);
        counter++;
    }
} 


Console.ReadKey(); 