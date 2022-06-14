using System.Linq;

List<string> wordList = new List<string>();

GetWordList();

void BubbleSort()
{
    int[] arr = { 120, 29, 31, 78, 990, 1201 };

    int temp;

    for (int i = 0; i <= arr.Length - 2; i++)
    {
        for (int j = 0; j <= arr.Length - 2; j++)
        {
            if (arr[i] > arr[i + 1])
            {
                temp = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = temp;
            }
        }
    }

    Console.WriteLine("Sorted:");
    foreach (int p in arr)
        Console.Write(p + " ");
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