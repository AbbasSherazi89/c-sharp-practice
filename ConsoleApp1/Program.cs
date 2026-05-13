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

//Exercise 1:Print all even numbers from 1 to 50 using a loop.
Console.WriteLine("Even numbers from 1 to 50: \n");
for (int i=0; i<=50; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

//Exercise 2: Take user input and reverse it without using a arra.reverse method.

 Console.WriteLine("Enter a string to reverse:");
 string userInput = Console.ReadLine();

for (int i=userInput.Length - 1; i >= 0; i-- )
{
            Console.Write(userInput[i]);
}
