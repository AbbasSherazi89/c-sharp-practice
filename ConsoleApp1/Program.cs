//Console.WriteLine("Enter your name:");
//string name = Console.ReadLine();

//Console.WriteLine("Your name is: " + name);

//string name2 = "Abbas";
//int age = 27;
//string result = $"My name is {name2} and I am {age} years old.";
//Console.WriteLine(result);

//int[] arr = new int[4] { 1, 5, 3, 2 };
//Array.Sort(arr);
//foreach(int i in arr)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine(arr.Max());

//int[,] numbers = { { 1, 4, 2 }, { 5, 4, 0 } };

//foreach(int i in numbers)
//{
//    Console.WriteLine("\n");
//    Console.WriteLine(i);
//}

//Exercise 1:Print all even numbers from 1 to 50 using a loop.
//Console.WriteLine("Even numbers from 1 to 50: \n");
//for (int i=0; i<=50; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

////Exercise 2: Take user input and reverse it without using a arra.reverse method.

// Console.WriteLine("Enter a string to reverse:");
// string userInput = Console.ReadLine();

//for (int i=userInput.Length - 1; i >= 0; i-- )
//{
//            Console.Write(userInput[i]);
//}

//Exercise 3: Create an array of 5 numbers and calculate their sum and average.

//int[] sum_averaged_arr = new int[5]{ 45, 22, 44, 55, 22 };
//int sum = 0;
//for (int i=0; i<sum_averaged_arr.Length; i++)
//{
//    sum+= sum_averaged_arr[i];
//    if (i == sum_averaged_arr.Length - 1)
//    {
//        Console.WriteLine("Sum of the array is:" + sum);
//        Console.WriteLine("Average of the array is:" + (sum / sum_averaged_arr.Length));
//    }
//}

//Exercise 4:Ask user for a number and print its multiplication table (1-10).
//Console.WriteLine("Enter a number to print its multiplication table:");
//int num_mult = int.Parse(Console.ReadLine());
//for (int i=1; i<=10; i++)
//    {
//    Console.WriteLine($"Table of {num_mult}: {num_mult} x {i} = {num_mult * i}");
//    }

//Exercise 5: Count vowels(a, e, i, o, u) in a given string.

//string str_vowels = "Hello world";
//int count_vowels = 0;
//for (int i = 0; i < str_vowels.Length; i++)
//{
//    if (str_vowels[i] == 'a' || str_vowels[i] == 'e' || str_vowels[i] == 'i' || str_vowels[i] == 'o' || str_vowels[i] == 'u' 
//        || str_vowels[i] == 'A' || str_vowels[i] == 'E' || str_vowels[i] == 'I' || str_vowels[i] == 'O' || str_vowels[i] == 'U')
//    {
//        count_vowels++;
//    }
//}
//Console.WriteLine($"Number of vowels in the string \"{str_vowels}\" is: {count_vowels}");

////Exercise 6: Find the largest and smallest number in an array.

//int[] max_min_arr = { 45, 22, 44, 55, 22 };
//int max = max_min_arr[0];
//int min = max_min_arr[0];

//for (int i=0; i<max_min_arr.Length; i++)
//{
//    if(max_min_arr[i] > max)
//    {
//        max = max_min_arr[i];
//    }
//    if(max_min_arr[i] < min)
//    {
//        min = max_min_arr[i];
//    }
//}
//Console.WriteLine($"Original array: [{string.Join(", ", max_min_arr)}]");
//Console.WriteLine($"Largest number in the array is: {max}");
//Console.WriteLine($"Smallest number in the array is: {min}");

// Exercise 7. (Palindrome Check) Check if a word reads the same backward (e.g., "radar", "level").
//Console.WriteLine("Enter a word to check if it's a palindrome:");
//string palindrome = Console.ReadLine();

//int left_text = 0;
//int right_text = palindrome.Length - 1;
//while (left_text < right_text)
//{
//    if (palindrome[left_text] != palindrome[right_text])
//    {
//        Console.WriteLine($"The word \"{palindrome}\" is not a palindrome.");
//        break;
//    }
//    left_text++;
//    right_text--;
//}
//if (left_text >= right_text)
//{
//    Console.WriteLine($"The word \"{palindrome}\" is a palindrome.");
//}
//Console.WriteLine("\nPress any key to exit...");
//Console.ReadKey();

// Exercise 8: Remove duplicates characters from a string

void RemoveDuplicates(string input)
{
    string result = "";
    for (int i = 0; i < input.Length; i++)
    {
        //Console.WriteLine(!input.Contains("ab"));
        if (!result.Contains(input[i]))
        {
            result += input[i];
        }
    }

    Console.WriteLine($"String after removing duplication is: ${result}");

}

Console.WriteLine("Enter a string to remove the duplicates from it:");
string input = Console.ReadLine();

RemoveDuplicates(input);
