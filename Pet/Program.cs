using System;

namespace Pet
{
    class Program
    {
        class pet
        {
            string name;
            int age;
            double weight;
            int lifespan;
            public Pet(string _name, double _weight)
            {
                name = _name;
                weight = _weight;
            }
            public int Lifespan
            {
                get { return lifespan; }
            }
            public double Age
            {
                get { return age; }
            }
            public void Eat()
            {
                Console.WriteLine("Eating routine");
                Console.WriteLine("Weight before: " + weight);
                weight += 0.2;
                Console.WriteLine("Weight after: " + weight);
            }
            public void Exercise()
            {
                Console.WriteLine("Exercise routine");
                Console.WriteLine("Weight before: " + weight);
                weight -= 0.1;
                Console.WriteLine("Weight after: " );

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
