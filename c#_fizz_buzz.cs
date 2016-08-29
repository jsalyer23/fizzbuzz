using System;
class MainClass {
  public static void Main () {
  	for(int num = 1; num <= 100; num++){
  		if(num % 15 == 0){
  			Console.WriteLine("FizzBuzz");
  		}
  		else if(num % 3 == 0){
  			Console.WriteLine("Fizz");
  		}
  		else if(num % 5 == 0){
  			Console.WriteLine("Buzz");
  		}
  		else{
  			Console.WriteLine (num);
  		}
  	}
  }
}