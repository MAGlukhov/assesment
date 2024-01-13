Console.WriteLine("Введите количество элементов в массиве");
int amount = int.Parse(Console.ReadLine());

string[] array = new string[amount];

for(int i = 0; i < amount; i++)
{
    Console.WriteLine("Введите " + (i+1) + " элемент");
    array[i] = Console.ReadLine();
}

int count = 0;

for(int i = 0; i < amount; i++)
{
    if (array[i].Length <=3) count++; 
}

string[] final = new string[count];

int j = 0;

for(int i = 0; i < amount; i++)
{
    if (array[i].Length <=3) 
        {
        final[j] = array[i];
        j++;
        }
}

for(int i = 0; i < count; i++)
{
    Console.Write(final[i] + " ");
}