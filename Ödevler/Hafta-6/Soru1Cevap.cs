namespace Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       Console.WriteLine("Bir sayı girin");
 int sayi=Convert.ToInt32(Console.ReadLine());
 Random rastgele=new Random();
 int[,]matris=new int[sayi,sayi];
 for(int i=0; i<sayi; i++)
 {
     
     for(int j=0; j<sayi; j++)
     {
         matris[i,j] = rastgele.Next(-9,10);
         if (matris[i,j]>=0)
         {
             Console.Write(" "+matris[i,j]+" ");
         }
         else
         {
             Console.Write(matris[i,j]+" ");
         }
     }
     Console.WriteLine(" ");
 }
 int kosegentoplam = 0;
 for(int i = 0; i < sayi; i++)
 {
    for(int j = 0; j < sayi; j++)
    {
         if (i==j)
         {
             kosegentoplam += matris[i, j];
         }
    }
 }
 Console.WriteLine("Köşegen toplamı:"+kosegentoplam);
 int yardkosegencarpim = 1;
 for(int i =0;i<sayi; i++)
 {
     for (int j = 0; j < sayi; j++)
     {
         if (i + j == sayi - 1)
         {
             yardkosegencarpim*=matris[i,j];
         }
     }
 
 }
 Console.WriteLine("Yardımcı köşegenin çarpımı:"+yardkosegencarpim);
 int negatif = 0;
 for(int i = 0;i < sayi; i++)
 {
     for( int j = 0;j < sayi; j++)
     {
         if (matris[i, j] < 0)
         {
             negatif++;
         }
     }
 }
 Console.WriteLine("Negatif sayısı:"+negatif);
 int tekrareden=matris[0,0];
 int kackeretekrar = 0;
 for(int i = 0; i < sayi; i++)
 {
     for (int j = 0; j < sayi; j++)
     {
         int eleman = matris[i, j];
         int sayac = 0;
         for(int k = 0; k < sayi; k++)
         {
             for(int l=0; l< sayi; l++)
             {
                 if (matris[k, l] == eleman)
                 {
                     sayac++;
                 }
             }
         }
         if (sayac > kackeretekrar)
         {
             tekrareden = eleman;
         }
     }

 }
 Console.WriteLine("En çok tekrar eden:"+tekrareden);
 int[,] dondu = new int[sayi, sayi];
 for(int i = 0;i < sayi; i++)
 {
     for( int j = 0;j < sayi; j++)
     {
         dondu[j,sayi-1-i]=matris[i,j];
         if (dondu[i,j] >=0)
         {
             Console.Write(" " + dondu[i,j]+" ");
         }
         else
         {
             Console.Write(dondu[i,j]+" ");
         }
     }
     Console.WriteLine();
 }
 


            
        }
    }
}
