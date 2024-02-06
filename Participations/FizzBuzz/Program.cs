//This is a program that will, for all number between 1 and 900, print 'Fizz' if the number is divisible by 3,
//'Buzz' if the number is divisible by 5, and 'FizzBuzz' if the number is divisible by both 3 and 5.
//If the number is not divisible by either 3 or 5, the program will print the number itself.

Console.WriteLine("Enter a number between 1 and 900: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(
    number % 3 == 0 && number % 5 == 0 ? "FizzBuzz" :
       number % 3 == 0 ? "Fizz" :
          number % 5 == 0 ? "Buzz" :
             number.ToString()
             );
