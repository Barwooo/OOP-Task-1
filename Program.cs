using System;

class Program
{
    static void Main()
    {
      string thisFishState = "Fish";
      int thisFishSize = 1;
      System.Console.WriteLine($"{thisFishState} is of size {thisFishSize}");
      while (thisFishState != "FISH")
      {
         Feed(ref thisFishState, ref thisFishSize);
      }
      Console.WriteLine($"It now a big {thisFishState}");

    }
static void Feed(ref string state, ref int size)
{
   size = size + 1;
   System.Console.WriteLine("fish fed");
   if (size == 5)
   {
      state = "FISH";
   }
}
}