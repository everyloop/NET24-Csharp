Console.WriteLine("*** While loop **************");

// While loop körs noll, en, eller flera gånger.
int i = 1;

while (i <= 10)
{
    Console.WriteLine(i++);
}

Console.WriteLine();
Console.WriteLine("*** Do-while loop **************");

// Do-while körs alltid minst en gång, eftersom utvärderingen sker efter kodblock exekverat.
i = 1;
do
{
    Console.WriteLine(i++);
} while (i <= 10);

Console.WriteLine();
Console.WriteLine("*** For loop **************");

// For loop
for (int j = 1; j <= 10; j++)
{
    if (j == 3) continue;   // Avbryter pågående iteration och fortsätter på nästa iteration.
    if (j == 8) break;      // Avbryter hela loopen och fortsätter exekvering efter loopen.

    Console.WriteLine(j);
}

Console.WriteLine();
Console.WriteLine("*** Nästlad for loop **************");

// Nästlad for-loop
for (int y = 1; y <= 9; y++)
{
    for (int x = 1; x <= 9; x++)
    {
        Console.Write(y);
    }
    Console.WriteLine();
}


