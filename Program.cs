using System;
using System.Collections.Generic;

namespace Algo_Basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // PrintNumbers();
            // PrintOdds();
            // PrintNumSum();
            // LoopArray[1,2,3,4,5]; - Wrong
            // MaxArray(numArray[1]);  - Wrong
            // Console.WriteLine(Odd255()); - Wrong
            // Console.WriteLine(GreaterThanY[1,4,-6,7,5], 5); - Wrong
            SquareArrayValues(numbers);

        }
        ////**********************************************
        //First question: How do I print all integers from 1 to 255 in C#??
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        ////**********************************************
        //How do I print all the ODD integers from 1 to 255?
        public static void PrintOdds()
        {
            for (int i = 0; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + ",");
                }
            }
        }

        ////**********************************************
        //THIRD QUESTION: Print me the numbers from 1 to 255 AND print the SUM of the numbers you’ve gone through as you go!
        public static void PrintNumSum()

        {
            int sum = 0;

            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"i is: {i},");
                sum += i;
                Console.WriteLine($"sum is: {sum}");
            }
            // Console.Writeline("PrintNumSum is:");
        }

        ////**********************************************
        //NUMBER 4: Write me a function that would iterate through an integer array and print the values as it goes!

        public static void LoopArray(int[] numbers)
        {
            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }
        }

        ////**********************************************
        //Number FIVE: given an integer array, return me the largest number in that array!

        public static void MaxArray(int[] numArray){
            int[] numArray = new int[5];
            int max = numArray[0];
            foreach(int i in numArray){
                if(i > max){
                    max=i;
                }
            }
            Console.WriteLine(max);
        }

        ////**********************************************
        //Alright question SIX: Given an integer array, return to me the AVERAGE of all the values

        public static void AvgArr(int[] numArray){
            int sum = 0;
            foreach(int i in numArray){
                sum += i;
            }
            int avg = sum/numArray.Length;
            Console.WriteLine(avg);
        }

        ////**********************************************
        //Question SEVEN: Create a LIST (not an array like the question asks) that gives me all the ODD numbers from 1 to 255

        List<int> Odd255 = new List<int>();
        public static void Oddlist(List<int> someList){
            for (int i = 1; i <= 255; i++){
                if (i % 2 != 0) {
                    someList.Add(i);
                } 
            }
        }

        ////**********************************************
        //Number EIGHT: Write a function that, given an int array and some value y, tell me how many of the values in the array are bigger than y (ex: GreaterThanY([1,4,-6,7,5], 5) should return 3)

        public static void GreaterThanY(int[] numbers, int y)
        {
            int res = 0;
            foreach (int num in numbers)
            {
                if(num > y)
                {
                    res++;
                }
            }
            Console.WriteLine(res);
        }

        ////**********************************************
        //NUMBER NINE: Given an array of integers, return that same array but with the values squared (ex: [1,2,3,4,5] should return [1,4,9,16,25])
        public static void SquareArrayValues(int[] numbers) {

            for(int i = 0; i<numbers.Length; i++) {
                numbers[i] = numbers[i] * numbers [i];
            }
            foreach (int num in numbers) {
                Console.WriteLine(num);
            }
        }

        ////**********************************************
        //Number 10: Given an array that may contain negative numbers, return that array with all negative numbers replaced by 0 (ex: [1,-2,3-4,-4] should return [1,0,3,0,0])

        public static void NegZero(int[] arr) {
            for(int i = 0; i<arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                }
            }
        }
        
        ////**********************************************
        //ELEVEN: Given an array, return the MIN, MAX, and AVERAGE of the array

        static void noNegs(int[] arr){
                for(int i=0; i<arr.Length; i++){
                    if(arr[i] < 0){
                        arr[i] = 0;
                    }
                }
            }

        ////**********************************************
        //Question 12: Given an array, write a function that shifts each number by one to the front and adds 0 to the end. Ex: given [1,5,10,7,-2], return [5,10,7,-2,0]
        static void movetoFront(int[] arr){
                for(int i=1; i<arr.Length-1; i++){
                    arr[i-1] = arr[i];
                }
                arr[arr.Length-1] = 0;
            }

        ////**********************************************
        //QUESTION THIRTEEN: Given an integer array, return an array that replaces any negative numbers with the string “Dojo” ex: [-1,-2,3] should become [‘Dojo’, ‘Dojo’, 3] -> Think VERY carefully about how to do this in a STATICALLY TYPED language!

        public static void NumToString(int[] numbers)
        {
            object[] result = new object[numbers.Length];

            for (int i = 0; i < numbers.Length;i++) 
            {
                if(numbers[i] < 0)
                {
                    result[i] = "Dojo";
                }
                else 
                {
                    result[i] = numbers[i];
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }







    }
}
