class Program
{
     static void Main()
     {
          int n=int.Parse(Console.ReadLine());
          Console.WriteLine(feb(n));
     }
     public static long feb(int n)
     {
          if(n<=2)
          {
               return 1;
          }
          return feb(n-1)+feb(n-2);
     }
}
