
using System.Diagnostics;

Stopwatch sw = new();

List<string> wordList = new List<string>();

bool firstRun = false;

GetWordList();

while (true)
{
    for (int i = 0; i < 5; i++)
    {

        //DotNetSort();
        BubbleSort();

        var rnd = new Random();
        var randomized = wordList.OrderBy(item => rnd.Next());

    }
    Thread.Sleep(1000);
    Console.Clear();
}

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
    sw.Start();
    Console.WriteLine("");

    string temp;

    for (int i = 0; i < wordList.Count - 1; i++)
    {
        for (int j = i + 1; j < wordList.Count; j++)
        {
            if (wordList[j].CompareTo(wordList[i]) > 0)
            {
                temp = wordList[i];
                wordList[i] = wordList[j];
                wordList[j] = temp;
            }
        }
    }


    sw.Stop();
    TimeSpan ts = sw.Elapsed;

    Console.WriteLine("Sort Time BubbleSort: " + ts.TotalMilliseconds);

    sw.Restart();
    //Console.Read();
}

void GetWordList()
{
    string filename = "wordlist.txt";
    FileStream stream = new FileStream(filename, FileMode.Open);

    using (StreamReader sr = new StreamReader(stream))
    {
        string line;

        while ((line = sr.ReadLine()) != null)
        {
            wordList.Add(line.ToLower());
        }
    }

    //foreach (string s in wordList)
    //{
    //    Console.WriteLine(s);
    //}

}
