﻿int[] niz ={ 2,3,3,4,5,5};

for (int i = 0; i< niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}

//unazad
for (int i = niz.Length -1; i >= 0; i--)
{
    Console.WriteLine(niz[i]);
}

//ako zelimo ici of prvog do zadnjeg

foreach (int en in niz)
{
    Console.WriteLine(en);
}


//ugnjezdjivanje, nastavak i prekidanje jednako kao na for, while i do

