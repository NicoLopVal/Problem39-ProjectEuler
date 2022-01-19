Dictionary<int,int> perimeters = new();

for(double a = 1; a<=1000; a++)
{
    for (double b = 1; b <= 1000; b++)
    {
        double c = Math.Sqrt(a*a + b*b);
        if(c == (int)Math.Sqrt(a * a + b * b))
        {
            if (perimeters.ContainsKey((int)(a + b + c)) && a + b + c <= 1000)
                perimeters[(int)(a + b + c)]++;
            else if(a + b + c <= 1000)
                perimeters.Add((int)(a + b + c), 1);
        }
    }
}

int maxRepetitions = 0;
int maxPerimeter = 0;
foreach(int key in perimeters.Keys)
{
    if(perimeters[key] > maxRepetitions)
    {
        maxRepetitions = perimeters[key];
        maxPerimeter = key;
    }
}

Console.WriteLine("The value of p (p<=1000) that maximizes solutions is: " + maxPerimeter);
