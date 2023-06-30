

int redaka=5, stupaca=5;
Console.Write("unesi broj redova: ");
redaka = int.Parse(Console.ReadLine());

Console.Write("unesi broj stupaca: ");
stupaca = int.Parse(Console.ReadLine());

int[,] matrica = new int[redaka, stupaca];


for(int i =1; i<=stupaca; i++)
{
    matrica[redaka-1,stupaca -i] = i++;
}




for(int i = 0; i < redaka; i++)
    {
    for (int j = 0; j < stupaca; j++) 
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("**************");
//treba mi brojac

int b= 1;

matrica[redaka = -1, stupaca - 1] = b++;
matrica[redaka = -1, stupaca - 2] = b++;
matrica[redaka = -1, stupaca - 3] = b++;
matrica[redaka = -1, stupaca - 4] = b++;
matrica[redaka = -1, stupaca - 6] = b++;




for(int i=redaka-2; i>=0; i--)
{
    matrica[i, 0] = b++;
}

for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}