namespace Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
 int[,]matris=new int[5,3];
 for (int i = 0; i < matris.GetLength(0); i++)
 {

     for (int j = 0; j < matris.GetLength(1); j++)
     {
         matris[i, j] = rnd.Next(0, 9);
         Console.Write(matris[i,j]+" ");
     }

     Console.WriteLine();
 }
 int[] sütuntoplam = new int[3];
 for(int i = 0;i < 3; i++)
 {
     //her sütun için o sütundaki satıları topluyoruz ondan satır döngüsü içte
     for(int j = 0; j < 5; j++)
     {
         sütuntoplam[i] += matris[j,i];
     }
   
 }
          
 for(int i = 0; i < sütuntoplam.Length; i++)
 {
     Console.WriteLine("Sütun" + (i+1) + ":" + sütuntoplam[i]);
 }

               

            
        }
    }
}
