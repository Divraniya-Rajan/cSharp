using System;

//one dimensional array
class array
{
    public static void Main(string[] args)
    {
        //// example 1 //
        // int[] num = new int[] { 7, 3, 5, 7, 9 };
        //
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write("{0}\t", num[i]);
        //}

            // example 2 //

            // string[] name = new string[] {"rajan","karan","Azaad","raj","vishal","pratap"};
            //
            // for (int a = 0; a < 5; a++)
            // {
            //     Console.WriteLine(name[a]);
            // }

            // example 3 //

            //          string[] book = new string[5];
            //
            //           book[0] ="C++";
            //           book[1] ="C";
            //           book[2] ="C#";
            //           book[3] ="F#";
            //           book[4] ="Java";
            //
            //           for (int a = 0; a <= 4; a++)
            //           {
            //               Console.WriteLine("Book {0}",book[a]);
            //           }


        // example 4 //
            // multi dimensional array 
            //  int[,] num = new int[4, 5];
            //
            // for (int i = 0; i < 4; i++)
            // {
            //     for (int j = 0; j < 5; j++)
            //     {
            //         Console.Write("Enter Number : ");
            //         num[i, j] = Convert.ToInt16(Console.ReadLine());
            //     }
            //     Console.WriteLine();
            // }
            //
            // for (int i = 0; i < 4; i++)
            // {
            //     for (int j = 0; j < 5; j++)
            //     {
            //         Console.Write(num[i,j]);
            //     }
            //     Console.WriteLine();
            // }

        // exapmple  5 //

//read 10 Value and print reverse
       // int i;
       // int[] reverse = new int[10];
       //
       // for ( i = 0; i < 10; i++)
       // {
       //     Console.Write("Input integer number and print in reveres : ");
       //     reverse[i] = Convert.ToInt16(Console.ReadLine());
       // }
       //
       // for (i = 9; i>=0; i--)
       //
       // {
       //     Console.WriteLine(reverse[i]);
       // }


        // example 6 //
        //read 10 Value and calculate the sum and average //

      //  int i;
      //  float sum = 0, ave = 0.00f;
      //
      //  int[] add = new int[10];
      //
      //  for (i = 0; i < 10; i++)
      //  {
      //      Console.Write("Input values and his sum and average : ");
      //      add[i] = Convert.ToInt16(Console.ReadLine());
      //      sum = sum + add[i];
      //  }
      //
      //  Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
      //  ave = sum / 10;
      //  Console.WriteLine(" Sum is : " + sum);
      //  Console.WriteLine("average is : " + ave);

   // example 6 //
  // read number and find min and max number

    //    int i ,max,min;
    //    int[] find = new int[10];
    //
    //    for (i = 0; i < 10; i++)
    //    {
    //        Console.Write("Enter a value : ");
    //        find[i] = Convert.ToInt16(Console.ReadLine());
    //    }
    //
    //    min = find[0];
    //
    //    for (i = 0; i < 10; i++)
    //    {
    //        if (min > find[i])
    //        {
    //            min = find[i];
    //        }
    //    }
    //
    //    max = find[0];
    //
    //    for (i = 0; i < 10; i++)
    //    {
    //        if (max < find[i])
    //        {
    //            max = find[i];
    //        }
    //    }
    //    Console.WriteLine();
    //    Console.WriteLine(" Min value = "+ min);
    //
    //    Console.WriteLine();
    //    Console.WriteLine(" Max value = " + max);


//example 7
  // write a program 10 value is ascending and descending orader. 

       // int i ,j,temp;
       // int[] orader =new int[5];
       //
       // for (i = 0; i < 5; i++)
       // {
       //     Console.Write("Input a number :");
       //     orader[i] = Convert.ToInt16(Console.ReadLine());
       // }
       // Console.WriteLine();
       //
       //
       // //before value 
       //
       // Console.Write("Ascending and descending Before values ");
       // for (i = 0; i < 5; i++)
       // {
       //     Console.Write(" "+orader[i]);
       // }
       // Console.WriteLine();
       // //Ascending orader
       //j=orader[0];
       //
       // for (i = 0; i < 5; i++)
       // {
       //     for (j = i+1 ; j < 5; j++)
       //     {
       //         if (orader[i] >= orader[j])
       //         {
       //             temp = orader[i];
       //             orader[i] = orader[j];
       //             orader[j] = temp;
       //         }
       //     }
       // }
       //
       // Console.WriteLine();
       // Console.Write("Ascending orader = ");
       // for (i = 0; i < 5; i++)
       // {
       //     Console.Write(" "+orader[i]);
       // }
       //
       //
       //
       // //descending orader
       //
       //
       // j = orader[0];
       //
       // for (i = 0; i < 5; i++)
       // {
       //     for (j = i + 1; j < 5; j++)
       //     {
       //         if (orader[i] <= orader[j])
       //         {
       //             temp = orader[i];
       //             orader[i] = orader[j];
       //             orader[j] = temp;
       //         }
       //     }
       // }
       //
       // Console.WriteLine();
       // Console.Write("Descending orader = ");
       // for (i = 0; i < 5; i++)
       // {
       //     Console.Write(" " + orader[i]);
       // }


 //example 8
//read 10 element and print odd value 

        //int[] arry = new int[10];
        //Console.WriteLine("Enter 10 element :");
        //Console.WriteLine();
        //Console.WriteLine();
        //
        //
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write("Input values :");
        //    arry[i] = Convert.ToInt16(Console.ReadLine());
        //}
        //
        //Console.Clear();
        //
        //for (int i = 0; i < 10; i++)
        //{
        //    if(arry[i]%2 != 0)
        //    {
        //        Console.WriteLine("Odd Number : " + arry[i]);
        //    }
        //    else if (arry[i] % 2 == 0)
        //    {
        //        Console.WriteLine("Even number : "+ arry[i]);
        //    }
        //}

// read 10 elements and and count how many odd values ans even values 

    //    int[] arrry = new int[10];
    //
    //    int odd = 0 ,even=0,i=0;
    //
    //    for ( i = 0; i < 10; i++)
    //    {
    //        Console.Write("Input a number : ");
    //        arrry[i] = Convert.ToInt16(Console.ReadLine());
    //    }
    //    
    //    Console.Clear();
    //
    //    for ( i = 0; i < 10; i++)
    //    {
    //        if (arrry[i] % 2 != 0)
    //        {
    //            odd++;
    //            
    //        }
    //        else if (arrry[i] % 2 == 0)
    //        {
    //            even++;
    //        }
    //    }
    //
    //    Console.WriteLine("Total Odd Valus is : "+odd);
    //    Console.WriteLine("Total Even Valus is : " + even);



// read 10 element and how many 0 ans positive and  negative 

     //   int[] count = new int[10];
     //   int  positive=0, negative=0 ,zero=0;
     //
     //   for (int i = 0; i < 10; i++)
     //   {
     //       Console.Write("Input a number  = ");
     //       count[i] = Convert.ToInt16(Console.ReadLine());
     //   }
     //
     //   Console.Clear();
     //
     //   for (int i = 0; i < 10; i++)
     //   {
     //       if (0 < count[i])
     //       {
     //           positive++;
     //       }
     //       else if (0 > count[i])
     //       {
     //           negative++;
     //       }
     //       else 
     //       {
     //           zero++;
     //       }
     //   }
     //
     //   Console.WriteLine("Total of positive : "+positive);
     //   Console.WriteLine("Total of negative : " + negative);
     //   Console.WriteLine("Total of zero : " + zero);


 // read 10 element and how many times repeates number  

        //int repete = 0;
        //int[] ary = new int[10];
        //
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write("Input number : ");
        //    ary[i] = Convert.ToInt16(Console.ReadLine());
        //}
        //Console.Clear();
        //
        //for (int i = 0; i < 10;i++ )
        //{
        //    for (int j = i+1; j < 10; j++)
        //    {
        //        if (ary[j] == ary[i])
        //        {
        //            repete++;
        //        }
        //    }
        //}
        //Console.WriteLine("Total count of repete : "+ repete);

//read number and marge another
 
        int[] a = new int[5];
        int[] b = new int[5];
        int[] c = new int[10];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter A of elements :");
            a[i] = Convert.ToInt16(Console.ReadLine());
        }
         
        Console.WriteLine();

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Enter B of elements :");
            b[i] = Convert.ToInt16(Console.ReadLine());
        }


        for (int i = 0; i <a.Length; i++)
        {
            c[i] = a[i];

            
           Console.WriteLine("Elemets of C :"+c[i]);
         
        }

        for (int i = 0; i < a.Length; i++)
        {
            c[i] = b[i];


            Console.WriteLine("Elemets of C : " + c[i]);

        }

            Console.Read();
        }

}
