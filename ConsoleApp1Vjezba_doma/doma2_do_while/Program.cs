
//do petlja osigurava minimalno jedno izvodjenje zasto sto je uvjet na kraju petlje

do
{
    Console.WriteLine("01 usao u petlju");
} while (false);

//ostalo sve kao u for i while

//korisnik unosi dva cijela brojaizmedju 10 i 20
//program ispisuje sve parne brojeve izmedju unesenih brojeva
// koristiti do petlju


int b = 0;
do 
{
    Console.Write("unesi prvi broj: ");
    b= int.Parse(Console.ReadLine());
    if (b>=10 && b<=20)
    {
        break;
    }
    Console.Write("nisi unio trazeni broj.");
}
while (true);


int db = 0;
do
{
    Console.Write("unesi drugi broj: ");
    db = int.Parse(Console.ReadLine());
    if (db >= 10 && db <= 20)
    {
        break;
    }
    Console.Write("nisi unio trazeni broj.");
}
while (true);

//sigurni smo da su ucitane vrijednosti varijable b i db

int manji = b > db ? b : db;

/* umjesto prve linije
if (b>db )
{
    manji = b; 
}
else 
{
    manji = db;
}*/


int veci = db < b ? db : b;

int i = manji;
do
{
    if (i % 2 ==0)
    {
        Console.WriteLine(i);  
    }

} while (++i <= veci);





