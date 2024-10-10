using System;

class Test
{
     public static void Main(string[] args)
    {
       /* String fullName = "Ashik khan";
        int age = 26;
        double gpa = 3.71;
        bool isRegistered = true;
        Char bloodGroup = 'B';
        Console.WriteLine(fullName);
        Console.WriteLine(age);
        Console.WriteLine(gpa);
        Console.WriteLine(isRegistered);
        Console.WriteLine(bloodGroup);  */

    /*  string productName = "iPhone 16 Pro max";
        double productPrice = 320.99;
        string catagory = "smart phone";
        bool isAvailable = true;
        int productSold = 5;

        Console.WriteLine (productName);
        Console.WriteLine (productPrice);
        Console.WriteLine (catagory);
        Console.WriteLine (isAvailable);
        Console.WriteLine (productSold); */
        
         
      /*  double salary = 2526.65;
        Console.WriteLine(salary); 

        int salary2 = (int)salary;
        Console.WriteLine(salary2);  */


       /* double number = 10.5;
        int number2 = Convert.ToInt32(number);
        Console.WriteLine($"number2 {number2}");
        Console.ReadKey();  */

        

        /*
        String? StudentName;
        int StudentAge;
        double StudentGpa;
        bool isRegistered;

        Console.Write("Enter your name: "); 
        StudentName = Console.ReadLine();

        Console.Write("Enter your age: ");
        StudentAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your GPA: ");
        StudentGpa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Have you already registered: ");
        isRegistered = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Name: " + StudentName);
        Console.WriteLine("Age: " + StudentAge + " years old");
        Console.WriteLine("GPA: " + StudentGpa);
        Console.WriteLine("isRegistered: " + isRegistered);  */

        
        // int result = 25+30;
        // Console.WriteLine(result);

        // Console.WriteLine((4+3)*2);


      /*  int number1 = 10;
        int number2 = 3;
        
        int sum = number1 + number2 ;
        Console.WriteLine(sum);

        int sub = number1 - number2 ;
        Console.WriteLine(sub);

        int mul = number1 * number2 ;
        Console.WriteLine(mul);

        int div = number1 / number2 ;
        Console.WriteLine(div);

        int remainder = number1 % number2 ;
        Console.WriteLine(remainder); */


        /*
        int number1 = 10;
        int number2 = 3;
        int result;
        
        result = number1 + number2;
        Console.WriteLine(result);

        result = number1 - number2;
        Console.WriteLine(result);

        result = number1 * number2;
        Console.WriteLine(result);

        double div = (double)number1 / number2;
        Console.WriteLine(div.ToString("F3"));

        result = number1 % number2;
        Console.WriteLine(result);  */
        

        /*
        int number1, number2, number3, sum;
        double average;
        
        Console.Write("number1 = ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("number2 = ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("number3 = ");
        number3 = Convert.ToInt32(Console.ReadLine());

        sum = number1 + number2 + number3;
        Console.WriteLine($"sum = {sum} ");

        average = (double)sum /3;
        Console.WriteLine($"average = {average.ToString("F2")}");  */


      /*
        // Triangle Area = 0.5 * base * height
        double baseLenght, height, triangleArea;

        Console.WriteLine("Triangle Area Calculator");

        Console.Write("Base = ");
        baseLenght = Convert.ToDouble(Console.ReadLine());

        Console.Write("Height = ");
        height = Convert.ToDouble(Console.ReadLine());

        triangleArea = 0.5 * baseLenght * height;
        Console.WriteLine($"Triangle Area = {triangleArea.ToString("F2")}");
        */        
        
        /*
        int number = 30;
        if (number > 0)
        {
          Console.WriteLine("Positive Number");
        }

        else if (number < 0)
        {
          Console.WriteLine("Negative Number");
        }

        else (number == 0)  
        {
          Console.WriteLine("Zero");
        }  */
        
        

        
      Console.Write("Enter any digit between 0 and 9: ");

      int digit = Convert.ToInt32(Console.ReadLine());

      if (digit == 0){
        Console.WriteLine("Zero");
      }
      else if (digit == 1){
        Console.WriteLine("One");
      }
      else if (digit == 2){
        Console.WriteLine("Two");
      }
      else if (digit == 3){
        Console.WriteLine("Three");
      }
      else if (digit == 4){
        Console.WriteLine("Fore");
      }
      else if (digit == 5){
        Console.WriteLine("Five");
      }
      else if (digit == 6){
        Console.WriteLine("Six");
      }
      else if (digit == 7){
        Console.WriteLine("Seven");
      }
      else if (digit == 8){
        Console.WriteLine("Eight");
      }
      else if (digit == 9){
        Console.WriteLine("Nine");
      }
      else {
        Console.WriteLine("Not a valid digit.");
      }

       


    }
}
