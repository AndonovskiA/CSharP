
//for loop

using System.Reflection.Metadata.Ecma335;

for (int i=0; i<10; i++)
{
    Console.WriteLine("Osijek");
}

int j;
for(j=0; j<10; j++)
{
    Console.WriteLine("Osijek");
}

for(j=0; j<10; j++)
{
    Console.WriteLine("osijek");
}

for(int k=10; j>0; j--)
{
    Console.WriteLine("osijek");
}

for(int k =0; k<20; k+=2)
{
    Console.WriteLine("osijek");
}

for(int x=0; x<10; x++)
{
    Console.WriteLine(x+1);
}
bool uvjet = true;
for(int x=1; uvjet;  x++)
{
    Console.WriteLine(x+1);
    uvjet = x < 10;
}

/*ugnjezdivanje petlje*/

for(int i=0; i<10; i++)
{
    for(int j=0; j<10; j++)
    {
        Console.WriteLine("{0}", (i+1)*(j+1));
    }
    Console.WriteLine();
}

string s;
for(int i =0; i<10; i++)
{
    for(int m =0; m<10; m++)
    {
        var b = (i + 1) * (m + 1);
        s = "  " + b;
        Console.WriteLine("{0}", s[ˇ|..]) ;
    }
    Console.WriteLine() ;
}

/*izlaz iz petlje-break -labela*/

for(int i =0; i<10; i++)
{
    if (i==3)
    {
        break;
    }
    Console.WriteLine(i);
}

for(int i=0; i<5; i++)
{
    for (int g=0; g<5; g++)
    {
        if (g==2)
        {
            goto labela;
        }
        Console.WriteLine("i={0},g={1}", i, g);
    }
    
}
labela:;

/*continue -- nastvak izvodjenja*/

for(int i=0; i<10; i++)
{
    if(i==3)
    {
        continue;
    }
    Console.WriteLine(i);
}

for (int i=0; i<5;i++)
{
    for (int h=0; h<5; h++)
    { 
        if (h==2)
        {
            goto labela;
        }
        Console.WriteLine("i={0},h={1}", i, h);
}

    /*while radi sa bool tipom podataka*/

    /*bool uvjet1 = true;
    int l = 0;
    while(uvjet1)
    {
        Console.WriteLine("osijek");
        uvjet1 = +l < 10;
    } ne znam sto se ovdje crveni }*/

    int v = 0;
    while(v++<10)
    {
        Console.WriteLine("osijek");
    }

    /* do radi sa bool sve dok vrijednost ima true uvjet*/

    int ab = 0;
    do
    {
        Console.WriteLine("osijek");
    }
    while (ab++ < 10);


    /* infinity petlja*/
    do
    {

    }
    while (true);


    /* foreach*/

    int[] niz = { 5, 4, 5, 4, 3, 4, 3 };
    for (int t=0; t<niz.Lenght; t++)
    {
        Console.WriteLine(niz[t]);
    }


    foreach (int t in niz)
    {
        Console.WriteLine(t);
    }




    



