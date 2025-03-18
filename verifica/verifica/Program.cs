//VOID
//ESERCIZO A
void popolaVendite(int[,] matrice)
{
    Random rnd = new Random();
    for (int i = 0; i < matrice.GetLength(0); i++)
    {
        for (int j = 0; j < matrice.GetLength(1); j++)
        {
            if (i == 0)
            {
                matrice[i, j] = rnd.Next(100, 1000);

            }
            else
            {
                matrice[i, j] = 0;
            }

        }
    }

}
//ESERCIZO B
void cumulativa(int[,] matrice)
{
    int cumulativo = 0;
    for (int i = 0; i < matrice.GetLength(1); i++)
    {
        for (int j = 0; j < matrice.GetLength(0); j++)
        {
            if (j == 0)
            {
                cumulativo+= matrice[j,i];
            }
            else
            {
                matrice[j, i] = cumulativo;
            }
           
        }
    }
}
int trovamese(int[,] matrice)
{
    int mese = 0;
    Console.WriteLine("Dimmi il valore: ");
    int valore=int.Parse(Console.ReadLine());
    for (int i = 0; i < matrice.GetLength(0); i++)
    {
        for (int j = 0; j < matrice.GetLength(1); j++)
        {
            if (i == 1)
            {
                if (matrice[i, j] >= valore)
                {
                    mese = j + 1;
                    j = matrice.GetLength(1);
                    i = matrice.GetLength(0);
                }
            }

        }
    }
    return mese;

}
//ESERCIZIO C
string contieneStringa(string parola)
{
    string lettere="";
    bool nonTrovato = false;
    parola = parola.Trim();
    for(int i = 0; i < parola.Length; i++)
    {
        
        if (parola[i]!=' ')
        {
            if (lettere.Length != 0)
            {
                for (int j = 0; j < lettere.Length; j++)
                {
                    if (lettere[j] != parola[i])
                    {
                        nonTrovato = true;
                    }
                    else
                    {
                        nonTrovato= false;
                        j = lettere.Length;
                    }
                }
            }
            else
            {
                lettere += parola[i];
            }

           
        }
        if (nonTrovato == true)
        {
            lettere += parola[i];
        }
        nonTrovato= false;

    }
    lettere = lettere.ToUpper();
    return lettere;

}
//ESERCIZIO D   
bool verifica(string parola)
{
    parola = parola.Trim();
    int cont = 0;
    bool trovato = false;
    for(int i = 0; i < parola.Length; i++)
    {
        for(int j = 0; j < parola.Length; j++)
        {
            if (parola[j] == parola[i])
            {
                cont++;
            }
        }
        if (cont == 1)
        {
            trovato = true;
            cont = 0;
        }
        else
        {
            trovato = false;
            return trovato;
        }
    }
    return trovato;

}



//MAIN
int[,] vendite = new int[2, 12];
//ESERCIZO A
popolaVendite(vendite);
for (int i = 0; i < vendite.GetLength(0); i++)
{
    for (int j = 0; j < vendite.GetLength(1); j++)
    {
        Console.Write("[" + vendite[i, j] + "]");

    }
    Console.WriteLine();
}
Console.WriteLine();
//ESERCIZIO B
cumulativa(vendite);
for (int i = 0; i < vendite.GetLength(0); i++)
{
    for (int j = 0; j < vendite.GetLength(1); j++)
    {
        Console.Write("[" + vendite[i, j] + "]");

    }
    Console.WriteLine();
}
int mese=trovamese(vendite);
if (mese == 0)
{
    Console.WriteLine("Non è stato superato il valore inserito" );
}
else
{
    Console.WriteLine("Il mese in cui è stato eguagliato e superato il valore è: " + mese);
}
Console.WriteLine();
//ESERCIZIO C
Console.WriteLine("Dimmi la parola");
string parola = Console.ReadLine();
string lettere=contieneStringa(parola);
Console.WriteLine(lettere);
Console.WriteLine();
//ESERCIZIO D
Console.WriteLine("Dimmi la parola");
string parola1 = Console.ReadLine();
bool trovato=verifica(parola1);
if (trovato == true)
{
    Console.WriteLine("le lettere non si ripetono");
}
else
{
    Console.WriteLine("le lettere si ripetono");
}