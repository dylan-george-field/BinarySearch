// See https://aka.ms/new-console-template for more information

var listToSearch = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var numberToFind = 9;

int low = 0;
int high = listToSearch.Length - 1;
int mid = 0;

int result = 0;

while (low <= high)
{
    mid = (low + high) / 2;

    if (numberToFind > listToSearch[mid])
    {
        low = mid + 1;
    }
    else if (numberToFind < listToSearch[mid])
    {
        high = mid - 1;
    }
    else
    {
        result = mid;
        break;
    }
}

Console.WriteLine(result);
Console.ReadLine();