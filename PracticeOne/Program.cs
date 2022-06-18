// See https://aka.ms/new-console-template for more information

//string name = "Corey Gossett";

//Console.WriteLine($"Hello, {name}!");

//           ----------------------
//int numOne = 5;
//int numTwo = 11;

//Console.WriteLine($"{numOne + numTwo}");

//        -----------------------

//int numOne = 100;
//int numTwo = 2;

//Console.WriteLine($"{numOne / numTwo}");


//        ----------------------------


//Console.WriteLine(-1 + 4 * 6);

//Console.WriteLine((35 + 5) % 7);

//Console.WriteLine(14 + -4 * 6 / 11);

//Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

//    ------------------------------------------




//int numOne, numTwo, numThree;

//Console.WriteLine("Enter the first number to multiply.");

//numOne = Convert.ToInt32(Console.ReadLine());

//Console.Clear();

//Console.WriteLine("Enter the second number to multiply.");

//numTwo = Convert.ToInt32(Console.ReadLine());

//Console.Clear();

//Console.WriteLine("Enter the third number to multiply.");

//numThree = Convert.ToInt32(Console.ReadLine());

//Console.Clear();

//int result = numOne * numTwo * numThree;

//Console.WriteLine($"{numOne} x {numTwo} x {numThree} = {result}");

//int numOne, numTwo;

//Console.WriteLine("Enter the first number to calculate.");
//numOne = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter the second number to calculate.");
//numTwo = Convert.ToInt32(Console.ReadLine());

//int additionResult = numOne + numTwo;
//int subtractionResult = numOne - numTwo;
//int multiplyResult = numOne * numTwo;
//int divisionResult = numOne / numTwo;

//Console.WriteLine($"{numOne} + {numTwo} = {additionResult}");
//Console.WriteLine($"{numOne} - {numTwo} = {subtractionResult}");
//Console.WriteLine($"{numOne} * {numTwo} = {multiplyResult}");
//Console.WriteLine($"{numOne} / {numTwo} = {divisionResult}");

//Console.WriteLine("Enter the number to get multiplication table.");
//int number = Convert.ToInt32(Console.ReadLine());

//int resultOne = number * 1;
//int resultTwo = number * 2;
//int resultThree = number * 3;
//int resultFour = number * 4;
//int resultFive = number * 5;
//int resultSix = number * 6;
//int resultSeven = number * 7;
//int resultEight = number * 8;
//int resultNine = number * 9;
//int resultTen = number * 10;

//Console.WriteLine($"{number} x 1 = {resultOne}");
//Console.WriteLine($"{number} x 2 = {resultTwo}");
//Console.WriteLine($"{number} x 3 = {resultThree}");
//Console.WriteLine($"{number} x 4 = {resultFour}");
//Console.WriteLine($"{number} x 5 = {resultFive}");
//Console.WriteLine($"{number} x 6 = {resultSix}");
//Console.WriteLine($"{number} x 7 = {resultSeven}");
//Console.WriteLine($"{number} x 8 = {resultEight}");
//Console.WriteLine($"{number} x 9 = {resultNine}");
//Console.WriteLine($"{number} x 10 = {resultTen}");


//Console.WriteLine(RemoveChar("w3resource", 1));
//Console.WriteLine(RemoveChar("w3resource", 9));
//Console.WriteLine(RemoveChar("w3resource", 0));

//static string RemoveChar(string str, int n)
//{
//    return str.Remove(n, 1);
//}


//Console.WriteLine(FirstToLastTwo("w3resource"));
//Console.WriteLine(FirstToLastTwo("Python"));
//Console.WriteLine(FirstToLastTwo("how the fuck?"));


//static string FirstToLast(string ustr)
//{
//    return ustr.Length > 1
//        ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
//}

//static string FirstToLastTwo(string str)
//{
//    if (str.Length > 1)
//    {
//        return str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
//    }
//    return str;
//}

//Console.WriteLine("The quick brown fox jumps over the lazy dog.");
//string str = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(GetLetter(str));


//static string GetLetter(string str)
//{
//    if (str.Length >= 1)
//    {
//        return str.Substring(0, 1) + str + str.Substring(0, 1);
//    }
//    return str;
//}




//string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
//string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
//string word = "";
//int ctr = 0;
//foreach (String s in words)
//{
//    if (s.Length > ctr)
//    {
//        word = s;
//        ctr = s.Length;
//    }
//}

//Console.WriteLine(word);

//Console.WriteLine("Write a sentence and I'll tell you the biggest word in it.");
//string line = Console.ReadLine();

//Console.Clear();

//string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
//string word = "";
//int ctr = 0;
//foreach (var str in words)
//{
//    if (str != null)
//    {
//        Console.WriteLine(str);
//    }
//}

//foreach (var str in words)
//{
//    if (str.Length > ctr)
//    {
//        word = str;
//        ctr = str.Length;
//    }
//}

//Console.WriteLine("Here is the biggest word in the sentence:");
//Console.WriteLine(word);


//string line = "Display the pattern like pyramid using the alphabet.";

//Console.WriteLine("Original String: " + line);

//string result = "";

//List<string> wordsList = new List<string>();

//string[] words = line.Split(new[] {
//   " "
//  }, StringSplitOptions.None);

//for (int i = words.Length - 1; i >= 0; i--)
//{
//    result = result + words[i] + " ";
//}

//wordsList.Add(result);

//foreach (String s in wordsList)
//{

//    Console.WriteLine("Reverse String: " + s);
//}

string line = "We are going to display this sentence backwards.";

Console.WriteLine("Original Sentence:" + line);

string result = "";

//List<string> wordsList = new List<string>();

string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

for (int i = words.Length - 1; i >= 0; i--)
{
    result = result + words[i] + " ";
}

Console.WriteLine("Reverse String: " + result);

//wordsList.Add(result);

//foreach (var s in wordsList)
//{
//    Console.WriteLine("Reverse String: " + s);
//}

//ASK ASH WHY YOU MIGHT USE A LIST HERE INSTEAD OF JUST DOING THE RESULT!