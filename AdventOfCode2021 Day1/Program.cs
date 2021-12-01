//Get the input from input.txt
string[] input = File.ReadAllLines(@"C:\Users\Simone\Documents\WIN21\C-Sharp\AdventOfCode2021 Day1\AdventOfCode2021 Day1\input.txt");

//Convert the string array to an int array
int[] inputInts = new int [input.Length];
for (int i = 0; i < input.Length; i++)
{
    inputInts[i] = int.Parse(input[i]);
}
//Going through inputs to find the answer for part 1
int part1 = 0;
for (int i = 1; i < inputInts.Length; i++)
{
    if (inputInts[i] > inputInts[i - 1])
    {
        part1++;
    }
}
Console.WriteLine(part1);
