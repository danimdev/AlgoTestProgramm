using System.Linq;

List<string> wordList = new List<string>();

GetWordList();
DotNetSort();
BubbleSort();


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
            if (wordList[i].Length > wordList[i + 1].Length)
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

    foreach (string s in wordList)
    {
        Console.WriteLine(s);
    }

}