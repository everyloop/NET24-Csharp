

//try
//{

//    Int32.Parse("Hej");

//    int x = 0;
//    int y = 1 / x;

//    MyFunction();

//    Console.WriteLine("Allt gick bra!");
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine($"Någon angav ett felaktigt index.");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"Strängen gick inte att tolka som ett tal.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Något oväntat fel inträffade: {ex.StackTrace}");
//}

//static void MyFunction()
//{
//    try
//    {
//        int[] myArray = new int[] { 4, 5, 1, 4 };
//        myArray[10] = 0;
//    }
//    catch
//    {
//        Console.WriteLine("Nåt gick fel i MyFunction()!");
//        throw;
//    }
//}

//try
//{
//    try
//    {
//        MyFunction();
//        Int32.Parse("Hej");
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine($"Något oväntat fel inträffade: {ex.Message}");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Oj, nåt gick fel! {ex.Message}");
//}


//static void OpenFile(string filename)
//{
//    if (FileExist(filename))
//    {
//        // Gör något med filen.
//    }
//    else
//    {
//        throw new FileNotFoundException();
//    }
//}
//Console.WriteLine("Stop");

// Miniuppgift: Skriv klart funktionen CalculateDiffFromNow, så den returnerar hur mångar år i framtiden det givna året är,
// men kastar en exception om året redan har varit.

static int CalculateDiffFromNow(int futureYear)
{
    int currentYear = DateTime.Now.Year;
    int result = 0;
    
    if (futureYear <= currentYear)
    {
        throw new ArgumentOutOfRangeException();
    }
    else
    {
        result = futureYear - currentYear;
    }

    return result;
}

try
{
    int futureYear = 2029;
    int years = CalculateDiffFromNow(futureYear);
    Console.WriteLine($"The year {futureYear} is {years} in the future.");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("The year is not in the future!");
 }
