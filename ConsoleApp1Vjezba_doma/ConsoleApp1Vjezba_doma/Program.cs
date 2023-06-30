

//while radi sA BOOL TIPOM PODATAKA

//beskonacna petlja
while(true)
{
    break;
}

//u fro se ne moraa uci

for(int i =0; i<0; i++)
{
    Console.WriteLine("01 nisam usao");
}

// u while se ne mora uci

while(false)
{
    Console.WriteLine("02 nisam usao");
}

int b = 0;
while(b>10)
{
    Console.WriteLine(++b);
}

int t = 2;
b = 0;
while (t==2 && b<10)
{
    Console.WriteLine(++b); 
}

b = 0;
while(true)
{
    if (b == 2)
    {
        b++;
        continue;
    }
    if (b == 5)
    {
        break;
    }
    Console.WriteLine(b++);
}

//program unosi broj izmedju 1 i 10
//program ispisuje uneseni broj

while(true)
{
    Console.Write("unesi cijeli broj: ");
    b=int.Parse(Console.ReadLine());
    if(b>0 && b<=10)
    {
        break;
    }
    Console.WriteLine("morate unijeti broj izmedju 1 i 10");
}
Console.WriteLine("unesi broj je : {0}, b");

//napisite program koji pomocu while petlje ispisuje svaki treci broj izmedju 2 i 97


//rjesenje broj 1
b = 2;
while(b<=97)
{
    Console.WriteLine(b);
    b += 3;
}

//drugo rjesenje
b = 2;
while(true)
{
    Console.WriteLine(b);
    b += 3;
    if (b>97)
    {
        break;
    }
}

//3.zadatak
//zbrojite prvih 100 brojeva s while petljom

int zbroj = 0;
b = 0;
while(b++ < 100)
{
    zbroj += b;
}
Console.WriteLine(zbroj);

//drugi nacin
zbroj = 0;
b = 1;
while(b<100)
{
    zbroj += b;
    b++;
}
 Console.WriteLine(zbroj);

//ugnjezdjivanje i prekidanje unutarnjih petlji jednako kao u for
