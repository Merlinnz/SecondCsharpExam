int n,p=1,sum=1;
n = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=n; i++)
{
    p*=2;
    sum+=p;
}

Console.WriteLine(sum);