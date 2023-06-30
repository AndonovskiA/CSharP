
/* uvjetno granjanje i switch*/

int i = 2;

if(i==1)
{
    Console.WriteLine("dobro");
} else if (i==2)
{
    Console.WriteLine("ok");
}
else
{
    Console.WriteLine("ostalo");
}

/* visestruko granjanje*/

int ocjena = 3;

switch(ocjena)
{
    case 1;
        Console.WriteLine("nedovoljan");
        break;
    case 2:
        Console.WriteLine("dovoljan");
        break;
    case 3:
        Console.WriteLine("dobar");
        break;
    case 4:
        Console.WriteLine("vrlo dobar");
        break;
    case 5:
        Console.WriteLine("izvrstan");
        break;
    default;
        Console.WriteLine("nije ocjena");
        break;
}

/* zadatak 
 * Program unosi ime mjesta iz jedne od 4 slavonske županije
Za uneseno ime mjesta program ispisuje ime županije*/


