// See https://aka.ms/new-console-template for more information

int[] dice;
dice = new int[6];

Random rand = new Random();
for (int i = 0; i < 6; i++)
{
    dice[i] = rand.Next();
    Console.WriteLine(rand.Next(i));
}

Console.ReadKey();