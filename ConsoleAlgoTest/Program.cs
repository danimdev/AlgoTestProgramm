
using System.Diagnostics;

Stopwatch sw = new();

List<string> wordList = new List<string>();

GetWordList();

while (true)
{
    //for (int i = 0; i < 5; i++)
    //{

    //DotNetSort();
    //BubbleSort();


    sw.Start();
    quicksort(wordList, 0, wordList.Count - 1);

    sw.Stop();
    TimeSpan ts = sw.Elapsed;
    Console.WriteLine(ts.TotalMilliseconds);

    //var rnd = new Random();
    //var randomized = wordList.OrderBy(item => rnd.Next());
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

    sw.Reset();
    //Console.Read();
}

void quicksort(List<string> wordlist, int start, int end)
{
    if (start < end)
    {
        int pivotIndex = partition(wordlist, start, end);
        quicksort(wordlist, start, pivotIndex - 1);
        quicksort(wordlist, pivotIndex + 1, end);
    }
}

int partition(List<string> arr, int start, int end)
{
    int pivot = end;
    int i = start, j = end;
    string temp;
    while (i < j)
    {
        while (i < end && string.Compare(arr[i], arr[pivot]) < 0)
            i++;
        while (j > start && string.Compare(arr[j], arr[pivot]) > 0)
            j--;

        if (i < j)
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    temp = arr[pivot];
    arr[pivot] = arr[j];
    arr[j] = temp;
    return j;
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
