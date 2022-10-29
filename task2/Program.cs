int n = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [n];
for(int i=0; i<n; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine()); 
}

var min = numbers[0];
int ind1 = 0;
for(int i=0; i<n; i++)
{
    if(min>numbers[i])
    {
        min = numbers[i];
        ind1 = i;
    }
}

var max = numbers[0];
int ind2 = 0;
for(int i=0; i<n; i++)
{
    if(max<=numbers[i])
    {
        max = numbers[i];
        ind2 = i;
    }
}

for(int i=Math.Min(ind1,ind2); i<=Math.Max(ind1,ind2); i++)
{
    System.Console.Write(numbers[i]+ " ");
}