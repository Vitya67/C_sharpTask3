        Console.Write("Введіть граничне число: ");
        int limit = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int sum = 0;
        int count = 0;

        while (a < limit)
        {
            sum += a;
            count++;

            
            int next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine("Сума чисел Фібоначчі менших за " + limit + ": " + sum);
        Console.WriteLine("Кількість елементів: " + count);
    

