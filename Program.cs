int[][] ExtendedBottomUpCutRod(int[] p, int n)
{
    var r = new int[n + 1];
    var s = new int[n + 1];
    r[0] = 0;

    for (var j = 1; j <= n; j++)
    {
        var q = int.MinValue;
        for (var i = 1; i <= j; i++)
        {
            var x = p[i - 1] + r[j - i];
            if (q < x)
            {
                q = Math.Max(q, x);
                s[j] = i;
            }
        }

        r[j] = q;
    }

    return new[] {r, s};
}

void PrintCutRodSolution(int[] p, int n)
{
    var y = ExtendedBottomUpCutRod(p, n);
    for (var i = 0; i < n; i++)
    {
        var x = y[i][n];
        Console.WriteLine($"{x}");
        n -= x;
    }
}

var x = new[] {1, 5, 8, 9, 10};

PrintCutRodSolution(x,5);