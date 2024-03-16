using static System.Console;
using static System.Convert;
using static System.Math;

int n;
string str = "it";
n = ToInt32(ReadLine());
for(int i = 0; i < n; i++)
{
    if (i == n - 1)
    {
        str = "it";
    }
    else
    {
        str = "that ";
    }
    if (i % 2 == 0)
    {
        Write($"I hate {str}");
    }
    else
    {
        Write($"I love {str}");
    }
}
WriteLine();