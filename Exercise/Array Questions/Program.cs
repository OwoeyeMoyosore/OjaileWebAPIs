
namespace Arrays
{
    public class Program
    {
        static void Main()
        {
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                
               arr[i]  = Convert.ToInt32(Console.ReadLine());
  
                
            }
            for (int i = 0; i < arr.Length ; i++)
            {
                Console.Write( arr[i] + " ");
            }
           
            
        }
    }
}

