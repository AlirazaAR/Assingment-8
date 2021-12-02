using System;
namespace Marks
{
    public class Marks
    {
      public int a;
      public int b;
      public int c;
      public int sum(int a, int b, int c){
          int total = a + b + c;
          return total;
          }
          public float avrg(int a, int b, int c){
              float average = (a + b + c)/3.0F;
              return average;
          }
      }  
}