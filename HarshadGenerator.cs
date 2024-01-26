using System;
using System.Collections.Generic;    
using System.Linq;

class Program{
  static void HarshadGenerator()
  {
      while (true) {                                                                  // Loops forever until the program is closed
          try
          {
              for(int ferdi = 0; ferdi < 7; ferdi++)
              {
                Console.WriteLine(" ");                                            // Prints blank spaces 7 times
              }
              Console.WriteLine(" ");
              Console.WriteLine("==============  Menu  ==============");
              Console.WriteLine(" ");
              Console.WriteLine(" 1. Generate a Harshad Number ");
              Console.WriteLine(" 2. Display the Harshad Numbers");
              Console.WriteLine("  ");
              Console.WriteLine("====================================");
              Console.WriteLine(" ");
              Console.WriteLine("Enter the number: ");
              string option = Console.ReadLine();
              Console.WriteLine("------------------------------------");
              while(option != "1" && option != "2") 
              {                                                                 // Menu and also only allows integers 1 and 2 to be entered
                  for(int ferdi = 0; ferdi < 7; ferdi++)
                  {
                    Console.WriteLine(" ");                                            // Prints blank spaces 7 times    
                  }
                  Console.WriteLine(" ");
                  Console.WriteLine("==============  Menu  ==============");
                  Console.WriteLine(" ");
                  Console.WriteLine(" 1. Generate a Harshad Number ");
                  Console.WriteLine(" 2. Display the Harshad Numbers");
                  Console.WriteLine("  ");
                  Console.WriteLine("====================================");
                  Console.WriteLine(" ");
                  Console.WriteLine("Enter the number: ");
                  option = Console.ReadLine();
                  Console.WriteLine("------------------------------------");
              }
  
              if (option == "1")
              {
                  List<int> harshads = new List<int>();                                   // Holds all Harshad numbers up to limit
                  Console.WriteLine(" ");
                  Console.WriteLine("Generate which Harshad Number?: ");
                  int limit = Convert.ToInt32(Console.ReadLine());
                  for(int ferdi = 0; ferdi < 7; ferdi++)
                  {
                    Console.WriteLine(" ");
                  }
                  int h = 1;
                  bool earlybreak = false;                                             // This is so i know if it defaulted to the pre written statements for 1, 2 or 3
                  while (harshads.Count != limit)                                      // Carrys on creating and inserting the harshad numbers until the list length = limit
                  {
                      if(limit == 1)
                      {
                        Console.WriteLine("The 1st Harshad Number is: 1");
                        earlybreak = true;
                        break;
                      }
                      if(limit == 2)
                      {
                        Console.WriteLine("The 2nd Harshad Number is: 2");
                        earlybreak = true;
                        break;
                      }
                      if(limit == 3)
                      {
                        Console.WriteLine("The 3rd Harshad Number is: 3");
                        earlybreak = true;
                        break;
                      }
                      int divisor = 0;                                                // This will be the number that will be added up and divided to check the Harshadness of "h"
                      string tempstr = h.ToString();                                  // To be able to mannipulate each digit individually
                      char[] harsh = tempstr.ToCharArray();
                      foreach (char hn in harsh)
                      {
                          int tempint = (int)Char.GetNumericValue(hn);                          // Adds up all the digits and assigns them to divisor, i needed to do this get numebric method becuase it would return the ASCII value of the char
                          divisor += tempint;
                      }
                      if (h % divisor == 0)
                      {
                          harshads.Add(h);                                            // Adds harshad number to the list
                      }
                      h++;                                                            // Incremrents to the next integer to check for "harshadity"
                  }

                if(earlybreak == false && limit.ToString().Last() == '1' && limit.ToString()[limit.ToString().Length -2] != '1')         // Checks if the number does not end in 11
                {
                  Console.WriteLine("The {0}st Harshad Numbers is: {1}",limit,harshads.Last());   
                }

                else if(earlybreak == false && limit.ToString().Last() == '2')
                {
                  Console.WriteLine("The {0}nd Harshad Numbers is: {1}",limit,harshads.Last());   
                }

                else if(earlybreak == false && limit.ToString().Last() == '3')
                {
                  Console.WriteLine("The {0}rd Harshad Numbers is: {1}",limit,harshads.Last());   
                }
                
                else if(earlybreak == false )
                {
                  Console.WriteLine("The {0}th Harshad Numbers is: {1}",limit,harshads.Last());        // Prints the last harshad number in the list
                }

              }
  
              else if (option == "2")
              {
                  List<int> harshads = new List<int>();                                   // This will be the list of the numbers displayed
                  Console.WriteLine(" ");
                  Console.WriteLine("Enter the limit of numbers displayed: ");
                  int limit = Convert.ToInt32(Console.ReadLine());
                  for(int ferdi = 0; ferdi < 7; ferdi++)
                  {
                    Console.WriteLine(" ");
                  }
                  Console.WriteLine("The {0} Harshad Numbers are: ",limit);
                  int h = 1;
                  int position = 1;                                                    // For when printing out the harshads this ill be the index
                  while (harshads.Count != limit)                                      // Carrys on creating and inserting the harshad numbers until the list length = limit
                  {
                      int divisor = 0;                                                // This will be the number that will be added up and divided to check the Harshadness of "h"
                      string tempstr = h.ToString();                                  // To be able to mannipulate each digit individually
                      char[] harsh = tempstr.ToCharArray();
                      foreach (char hn in harsh)
                      {
                          int tempint = (int)Char.GetNumericValue(hn);                          // Adds up all the digits and assigns them to divisor, i needed to do this get numebric method becuase it would return the ASCII value of the char
                          divisor += tempint;
                      }
                      if (h % divisor == 0)
                      {
                          harshads.Add(h);                                            // Adds harshad number to the list
                          Console.WriteLine("{0}: {1}",position,h);                                       // Displays the Harshads
                          position++;
                      }
                      h++;                                                            // Incremrents to the next integer to check for "harshadity"
                  }
              }
          }
  
          catch (Exception ex)
          {
              Console.WriteLine(ex.Message);
          }
      }
  }
  
  public static void Main(string[] args)
  {
    HarshadGenerator();
  }
}
