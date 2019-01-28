using System;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("\n2.The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("\n3.Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("\n4.Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
            Console.ReadKey();

            // write your self-reflection here as a comment

            /*This assignment is good opportunity to learn the basics of the programming. Initially, while I started the assignment, faced so many errors. But, learned the running the program without any errors. As a very beginner of programming, I feel this kind of assignment is the good way to learn the basics.
            The major challenging aspect, for me, in this assignment was calling the functions which I learned from the Prof.Clinton’s video lessons.*/


        }

        public static void printPrimeNumbers(int x, int y)
        {

            try
            {
                Console.WriteLine("1.Prime numbers between {0} and {1} are:\n", x, y);
                bool isprime = true;


                // looping the start mnumber to end number
                for (int i = x; i <= y; i++)
                {
                    for (int j = 2; j < i; j++)
                    {

                        //comparing the module of each number over intigers starting from 2.
                        if (i % j == 0)
                        {
                            //initially checking every number whether it is prime or not.
                            // if module is zero, cosidering it as non-prime.
                            isprime = false;
                            break;
                        }
                        else
                        {
                            isprime = true;

                        }
                    }
                    //if the number is prime, then it prints.
                    if (isprime == true)
                    {
                        
                        Console.WriteLine(i);
                    }
                }
                


                // Write your code here

                /*for (int i = x; i <= y; i++)

                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)

                            {
                                n++;
                            }
                        }
                        if (n == 2)

                            Console.WriteLine(i);
                        n = 0;


                    }*/

            }


            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
           
        }

        //factorial function
        public static double factorial(double n1)
        {
        
        start:
            double f = 1;

            // checkes if the number is positive
            if (n1 >= 0)

            {
                for (double i = n1; i > 0; i--)
                {
                    
                    f = f * i; //multiplies all numbers starting from 1 to given number(n1).
                }
               
            }
            else
            {
                Console.WriteLine("The number is invalid"); 
                goto start; // if the given number is invalid(negative), the it goes to start. 
            }
            //Console.ReadKey();
            return f;
        }

            public static double getSeriesResult(int n)
        {
            double r = 0;

            try
            {
               
                factorial(n); //calling the factorial function.
                
                for (int k=1; k<=n; k++)
                {
                    r = r + (Math.Pow((-1), (k + 1)) * (factorial(k) / (k + 1))); //Math.Pow(-1,(k+1)) is to get the negative terms alternatively. 

                }
                
                

                // Write your code here

            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return r;
        }

        public static long decimalToBinary(long n)
        {
            long binary = 0;
            long reminder = 0;
            long multiplier = 1;
            try
            {
          
                while (n!=0) //checks if the number is not equal to 0. 
                {
                     reminder = n % 2; 
                    n = n / 2;
                    binary = binary+ reminder*multiplier; 
                    multiplier = multiplier * 10;

                }
                
               
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }
            
            return binary;
        }

        public static long binaryToDecimal(long n)
        {
            try
            {
                int number = Convert.ToInt32(n);
                int sum = 0;
                int pow = 1;
                while (number > 0)
                {
                    int rem = number % 10; //gives the reimnder of the when divided by 10.
                    number = number / 10; //replaces the number with nubmer divided by 10.

                    sum = sum + rem * pow; //adds all the reaults of the reminder multipled with 2 powers of 2. 

                    pow = pow * 2;
                }

                return sum;
                
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }
            
            return 0;
        }

        public static void printTriangle(int n)
        {
            Console.WriteLine("\n5. Printing traingle:\n");
            try
            {
                int line;
                for (int i = 1; i <= n; i++) // looping the print till the given number of lines.
                {
                    int x = 0;
                    for (line = 1; line <= n - i; line++) // looping to print spaces.
                    {
                        Console.Write(" ");
                    }
                    while (x != 2 * i - 1)  //condition to print the * in between the given spaces.
                    {
                        Console.Write("*");
                        x++;
                    }
                    Console.WriteLine();
                   
                }

                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {

            
            Console.WriteLine("\n6. Frequency of Numbers in the given array:" );
            try
            {
                int[] frq = new int[a.Length]; // new array to count each element in the array.
               
                //foreach (int k in a)
                for ( int k =0; k <a.Length; k++)
                {
                    frq[k] = -1; //assigning -1 to every element in freq array.

                }
                for (int i = 0; i < a.Length; i++)
                {
                    int count = 1;
                    for (int j = i + 1; j < a.Length; j++)
                    {

                        if (a[i] == a[j]) //comparing two numbers
                        {
                            count++; // if two numbers are same, count increases.
                            frq[j] = 0; //and freq value changed to 0 from -1, so that the same will not count in the next loop.

                        }

                    }
                    if (frq[i] != 0)
                    {
                        frq[i] = count; // counting number of times each element repeat.
                    }
                }


                for (int m = 0; m <a.Length; m++)
                {
                    if (frq[m] != 0) //to print the counted freq of elements.
                    {
                        Console.WriteLine( a[m] + "  ->  " + frq[m] + "  times");
                    }

                    // Write your code here
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");

                Console.ReadKey();
            }
        }


        
    }
    
}
