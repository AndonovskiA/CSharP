﻿
int i = 0;

bool uvjet = i > 0;

if (uvjet)
{
    Console.WriteLine("01: Veće od 0");
}

// koristiti ćemo ovu sintaksu
if (i > 0)
{
    Console.WriteLine("02: Opet veće od 0");
}

// jedna od većih grešaka - NE KORISTITI
if (uvjet == true)
{

}

//ako se if odnosi na jednu linu ne trebaju {}
if (!uvjet)
    Console.WriteLine("03: Nije veće od 0");
Console.WriteLine("04: Ovo isto ne bi trebalo biti veće od 0");

// koristiti ćemo uvijek {}


// opcionalna sintaksa
string grad = "Osijek";

if (grad == "Osijek")
{
    Console.WriteLine("05: SUPER");
}
else
{
    Console.WriteLine("06: OK");
}


int b = 0;
if (grad != "Zagreb")
{
    b = b + 1; // broj b se uvećava za 1
}
else if (grad == "Split")
{
    b += 1; // broj b se uvećava za 1
}
else if (grad == "Osijek")
{
    b += 2; // broj b se uvećava za 2
}
else
{
    b++; // broj b se uvećava za 1
}
Console.WriteLine("07: " + b);

// if možemo ugnjezditi
i = 0; b = 2;

if (i > 0)
{
    if (b == 2)
    {
        Console.WriteLine("08: Oba uvjeta su zadovoljena");
    }
}


// korištenje logičkih operatora
if (i > 0 && b == 2)
{
    Console.WriteLine("09: Oba uvjeta su zadovoljena");
}

if (i == 4 || b < 0)
{

}

int g = 10;

if (g % 2 == 0)
{
    Console.WriteLine("10: Broj je paran");
}
else
{
    Console.WriteLine("11: Broj je neparan");
}


// ? operator - inline if
// ovaj jedan red je istovjetan linijama 85 - 92
Console.WriteLine("12: Broj je " + (g % 2 == 0 ? "" : "ne") + "paran");


// 1. zadatak
// Korisnik unosi cijeli broj
// Za broj manji od 10
// ispisuje se Osijek
// inače se ispisuje Donji Miholjac



// 2. zadatak
// Korisnik unosi cijeli broj
// Program ispisuje da li je 
// paran ili nije


// 3. zadatak
// Za dva unesena cijela broja
// program ispisuje Osijek
// ako je zbroj veći od 10
// inače ispisuje Edunova


// Domaća zadaća

// Za unesena dva cijela broj
// program ispisuje veći
// 3 i 5 -> 5
// 5 i 3 -> 3
// 5 i 5 ->


// Za upisana 3 cijela broja
// program ispisuje najveći

// program unosi broj između 
// 1 i 999
// U slučaju da je izvan tog raspona
// ispisati grešku i prekinuti program
// Program ispisuje 1. znamenku upisanog broja

// -5 greška
// 1067 greška
// 456 4
// 6 6
// 89 8

// Program unosi 2 broja
// Ako su oba broja parni
// ispisuje njihov zbroj
// inače ispisuje njihovu razliku






//switch


int i = 2;

if (i == 1)
{
    Console.WriteLine("Dobro");
}
else if (i == 2)
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("Ostalo");
}

// višestruko grananje
int ocjena = 3;

switch (ocjena)
{
    case 1:
        Console.WriteLine("Nedovoljan");
        break;
    case 2:
        Console.WriteLine("Dovoljan");
        break;
    case 3:
        Console.WriteLine("Dobar");
        break;
    case 4:
        Console.WriteLine("Vrlo dobar");
        break;
    case 5:
        Console.WriteLine("Izvrstan");
        break;
    default:
        Console.WriteLine("Nije ocjena");
        break;
}


// 1. Zadatak
// Program unosi ime mjesta iz jedne od 4 slavonske županije
// Za uneseno ime mjesta program ispisuje ime županije
