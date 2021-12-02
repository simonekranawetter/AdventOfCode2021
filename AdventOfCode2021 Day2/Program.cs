//Get the input
string[] input = File.ReadAllLines(@"C:\Users\Simone\Documents\WIN21\C-Sharp\AdventOfCode2021 Day1\AdventOfCode2021 Day2\input.txt");


int forward = 0;
int depth = 0;

//Split the input into the movement command and the number, and calculate the result
foreach (string line in input)
{
    string[] tokens = line.Split(' ');
    string movement = tokens[0];
    string numberString = tokens[1];

    if (movement == "forward")
    {
        forward += int.Parse(numberString);
    }
    else if (movement == "down")
    {
        depth += int.Parse(numberString);
    }
    else if (movement == "up")
    {
        depth -= int.Parse(numberString); 
    }
    else
    { //You never know if there's something you didn't expect and I don't know how to properly adress errors yet
        Console.WriteLine("yo, you messed up!");
    }
}
//Result for part 1
Console.WriteLine(forward * depth);
