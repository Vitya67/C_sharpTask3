        Console.Write("Введіть перше число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int num2 = int.Parse(Console.ReadLine());

        int gcd = FindGCD(num1, num2);

        Console.WriteLine("Найбільший спільний дільник для " + num1 + " і " + num2 + " : " + gcd);
    
       static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

