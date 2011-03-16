// By: Erik Hanchett
// Date:3/21/2011
// Assignment: #4
// Exercise 28.17

//This class handles the business logic as well as the prime factorization. 

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Prime
{
    public class Business
    {
        Stack stack;
        private static string PRIME_EMPTY = " is a Prime Number!";
        private static string PRIME_ONE = "Please pick a number larger than 1!";
        private static string PRIME_FACTOR_TEXT = "List of Prime Factors\n";
        private static long FIRST_FACTOR_TEST = 2;
        private static long SECOND_FACTOR_TEST = 3;
        private long num;


        public Business(long num)
        {
            stack = new Stack();
            this.num = num;

        }

        public string factor()
        {
            if (num != FIRST_FACTOR_TEST)
            {
                while (num % FIRST_FACTOR_TEST == 0)
                {
                    stack.Push(FIRST_FACTOR_TEST);
                    num /= FIRST_FACTOR_TEST;
                }
            }

            long factorNum = SECOND_FACTOR_TEST;
            while (factorNum * factorNum <= num)
            {
                if (num % factorNum == 0)
                {
                    // This is a factor.
                    stack.Push(factorNum);
                    num /= factorNum;
                }
                else
                {
                    // Go to the next odd number.
                    factorNum += FIRST_FACTOR_TEST;
                }
            }

            // If num is not 1, then whatever is left is prime.
            
            if (num > 1) stack.Push(num);


            return print();
        }

        public string print()
        {
            string temp ="";
            if (stack.Count == 0)
                return PRIME_ONE;
            if (stack.Count == 1)
                return num.ToString() + PRIME_EMPTY;
            else
                temp = PRIME_FACTOR_TEXT;
                foreach (var element in stack)
                    temp += element + "\n";
            
            
            return temp;
        }
    }

}
