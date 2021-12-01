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
//Rinse repeat for part 2 
int part2 = 0;

for (int i = 0; i < inputInts.Length-3; i++)
{
    int sumOne = inputInts[i] + inputInts[i+1] + inputInts[i+2];
    int sumTwo = inputInts[i+1] + inputInts[i+2] + inputInts[i+3];

    if (sumTwo > sumOne)
    {
        part2++;
    }
}

Console.WriteLine(part2);
