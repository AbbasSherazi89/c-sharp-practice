//Console.WriteLine("Enter your name:");
//string name = Console.ReadLine();

//Console.WriteLine("Your name is: " + name);

//string name2 = "Abbas";
//int age = 27;
//string result = $"My name is {name2} and I am {age} years old.";
//Console.WriteLine(result);

int[] arr = new int[4] { 1, 5, 3, 2 };
Array.Sort(arr);
foreach(int i in arr)
{
    Console.WriteLine(i);
}
Console.WriteLine(arr.Max());

int[,] numbers = { { 1, 4, 2 }, { 5, 4, 0 } };

foreach(int i in numbers)
{
    Console.WriteLine("\n");
    Console.WriteLine(i);
}