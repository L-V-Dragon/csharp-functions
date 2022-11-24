int[] arrayInt;

Console.WriteLine("Quanti valori vuoi inserire?");
int array = int.Parse(Console.ReadLine());
arrayInt = new int[array];


Console.WriteLine("Quali valori vuoi inserire?");
Valori(arrayInt);


StampaArrayInteri(arrayInt);

StampaArrayInteri(ElevaArrayAlQuadrato(arrayInt));

StampaArrayInteri(arrayInt);

Console.WriteLine(sommaElementiArray(arrayInt));

Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(arrayInt)));


void Valori(int[]arrayInt)
{
    int valore;
    for(int i = 0; i < arrayInt.Length; i++)
    {
        arrayInt[i] = int.Parse(Console.ReadLine());
    }
}


void StampaArrayInteri(int[] arrayInt)
{
    Console.Write("[");
    for (int i = 0; i < arrayInt.Length; i++)
    {

        if (i == arrayInt.Length - 1)
        {
            Console.Write(arrayInt[i]);
        }
        else
        {
            Console.Write(arrayInt[i] + ",");
        }

    }
    Console.WriteLine("]");
}

int StampaQuadrato(int num)
{
    return num * num;
}


int[] ElevaArrayAlQuadrato(int[] arrayInt)
{
    int[] copiaArray = (int[])arrayInt.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = StampaQuadrato(copiaArray[i]);
    }
    return copiaArray;
}

int sommaElementiArray(int[] arrayInt)
{
    int somma = arrayInt.Sum();
    return somma;
}
