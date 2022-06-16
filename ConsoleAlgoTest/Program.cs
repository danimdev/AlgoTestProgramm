using System.Linq;

char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

List<string> wordList = new List<string>();

GetWordList();
//DotNetSort();
BubbleSort();

//the standard dotnet algo
void DotNetSort()
{
    Console.WriteLine("");

    wordList.Sort();

    foreach (string word in wordList)
    {
        Console.WriteLine("dotnet: " + word);
    }
}

void BubbleSort()
{
    Console.WriteLine("");

    string temp;

    for (int i = 0; i <= wordList.Count - 2; i++)
    {
        for (int j = 0; j <= wordList.Count - 2; j++)
        {
            if (wordList[i].First() == alphabet[i + 1])
            {
                temp = wordList[i + 1];
                wordList[i + 1] = wordList[i];
                wordList[i] = temp;
            }
        }
    }

    Console.WriteLine("Sorted:");
    foreach (var p in wordList)
    {
        Console.WriteLine(p + " ");
    }
    Console.Read();
}

void GetWordList()
{
    string filename = "wordlist.txt";
    FileStream stream = new FileStream(filename,FileMode.Open);

    using(StreamReader sr = new StreamReader(stream))
    {
        string line;
        
        while((line = sr.ReadLine()) != null)
        {
            wordList.Add(line);
        }
    }

    //foreach (string s in wordList)
    //{
    //    Console.WriteLine(s);
    //}

}
