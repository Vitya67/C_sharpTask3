        int sum = 0;

        for (int i = 2; i <= 50; i++)  
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        Console.WriteLine("Сума всіх простих чисел від 1 до 50: " + sum);
   
        static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

