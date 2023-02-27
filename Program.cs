string[] mainArray = { "hello", "2", "world", ":-)" };
int sizeMainArray = mainArray.Length;
string[] resultArray = new string[sizeMainArray];
int sizeResultArray = 0;

for (int i = 0; i < sizeMainArray; i++)
{
    if (mainArray[i].Length <= 3)
    {
        resultArray[sizeResultArray] = mainArray[i];
        sizeResultArray += 1;
    }
}

Console.Write("[");
Console.Write(string.Join(", ", resultArray, 0, sizeResultArray));
Console.Write("]");