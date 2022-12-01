Console.WriteLine("Введите количество элементов в массиве.");
int col=Convert.ToInt32(Console.ReadLine());
int [] mas=new int [col];
Filling_manuali(mas,col);
Display(mas,col);
Koll(mas,col);

//Функция заполнения массива с клавифтуры
void Filling_manuali(int [] m, int c)
{
    for(int i=0; i<c;i++)
    {
        Console.WriteLine("Введите {0}-й элемент", i + 1);
        m[i] = Convert.ToInt32(Console.ReadLine());
    }
}

// Функция вывода массива на экран
void Display(int [] m, int c)
{
    for(int i=0;i<c;i++)
    {
        Console.WriteLine(m[i]);
    }
}

// Функция подсчёта элементов больше 0
void Koll(int [] m, int c)
{
    int k=0;
    for(int i=0;i<c;i++)
    {
        if(m[i]>0)
        {
            k++;
        }
    }
    Console.WriteLine("Количество элементов "+ k);
}