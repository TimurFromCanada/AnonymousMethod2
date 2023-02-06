using System;

namespace AnonymousMethod2
{

    public delegate int MyDelegate2(int a, int b);

    public delegate int MyDelegate(MyDelegate2[]delegates);


    class Program
    {
        static void Main(string[] args)
        {
            var array = new MyDelegate2[3];

            for (var i = 0; i <array.Length; i++)
            {
                array[i] = delegate (int a, int b) { return a * b; };
            }

            MyDelegate averageSum = delegate (MyDelegate2[] myDelegates)
            {
                double average = 0;
                var random = new Random();

                for (var i = 0; i < myDelegates.Length; i++)
                {
                    average += myDelegates[i](random.Next(0, 10), random.Next(0, 10));
                }
                return (int)(average / myDelegates.Length);
            };

            Console.WriteLine(averageSum(array));
        }
    }
}
