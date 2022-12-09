class Program
{
     static void Main()
     {
          int n=int.Parse(Console.ReadLine());
          int temp=0;
          temp=n;
          Console.WriteLine("Number Pattern :");
          for(int i=1;i<=n;i++)
          {
               if(i<=temp)
               for(int j=1;j<=i;j++)
               {
                    
                    Console.Write(j+" ");
               }
               if(i>temp)
               for(int j=1;j<=(2*n)-i-n;j++)
               {
                    Console.Write(j+" ");
               }
               if(i==5)
               {
                    n=2*n;
               }
               Console.WriteLine();

          }
     }
}
