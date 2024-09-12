
Console.WriteLine("*** Path ******************");
Console.WriteLine();

string path = @"c:\windows\users\fredrik";

path = Path.Combine("c:", "users", "fredrik", "documents", "NET24", "fredrik.txt");

Console.WriteLine($"path = {Path.GetFullPath(path)}");
Console.WriteLine();
Console.WriteLine($"Path.GetFullPath(path) => {Path.GetFullPath(path)}");
Console.WriteLine($"Path.GetFileName(path) => {Path.GetFileName(path)}");
Console.WriteLine($"Path.GetFileNameWithoutExtension(path) => {Path.GetFileNameWithoutExtension(path)}");
Console.WriteLine($"Path.GetExtension(path) => {Path.GetExtension(path)}");
Console.WriteLine($"Path.GetDirectoryName(path) => {Path.GetDirectoryName(path)}");
Console.WriteLine($"Path.GetPathRoot(path) => {Path.GetPathRoot(path)}");
Console.WriteLine();
Console.WriteLine($"Path.Exists(path) => {Path.Exists(path)}");


Console.WriteLine("*** Directory ******************");
Console.WriteLine();

Console.WriteLine($"Directory.GetCurrentDirectory() => {Directory.GetCurrentDirectory()}");
Console.WriteLine();

string folderPath = Path.GetDirectoryName(path);
Console.WriteLine($"List files in {folderPath}:");

string[] files = Directory.GetFiles(folderPath);

foreach (var file in files)
{
    Console.WriteLine(Path.GetFileName(file));
}

Console.WriteLine();
string[] directories = Directory.GetDirectories(folderPath);
Console.WriteLine($"List folders in {folderPath}:");

foreach (var directory in directories)
{
    Console.WriteLine(Path.GetFileName(directory));
}

Console.WriteLine();

string newFolder = Path.Combine(folderPath, "NewFolder", "Test1", "Test2");
Console.WriteLine($"newFolder = {newFolder}");

Directory.CreateDirectory(newFolder);

Directory.Delete(newFolder);

