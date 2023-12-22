using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a positive integer: "); 
    int num = Convert.ToInt32(Console.ReadLine()); 
    for (int f = 0; f <= num; f++) 
    { 
        string str = Convert.ToString(f);
        int harshadvalue = 0;
        for(int h = 0; h < str.Length; h++){
          int number = Convert.ToInt32(str[h]);
          harshadvalue = harshadvalue + number;
        }
        if(f % harshadvalue == 0){
            Console.WriteLine(f);  /* it isnt really meant to display all of the harshad numbers, it is only meant to display the nth one so i will improve on that in the future*/
        }     
    } 
  }
}
