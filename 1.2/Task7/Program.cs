for (int i = 0; i < 10; i++)
         {
            int x = new Random().Next(-30, 30);
            Console.WriteLine(x);
            if (x > 0)
            {
                Console.Write(" положительное ");
                if (x%2 != 0)
            {
                Console.WriteLine(" нечетное ");
            }
            else
            {
                Console.WriteLine(" чётное ");
            }
            }
         }