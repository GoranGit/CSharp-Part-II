using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;
namespace _05HelpDog
{
    class Program
    {
        static void Main()
        {
           

            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            string[] FxFy = Console.ReadLine().Split(' ');

            int Fx = int.Parse(FxFy[0]);
            int Fy = int.Parse(FxFy[1]);

            BigInteger[,] matrix = new BigInteger[Fx + 1, Fy + 1];

            int numEnemys = int.Parse(Console.ReadLine());

            List<Point> enemys = new List<Point>();
         
            for(int i=0;i<numEnemys;i++)
            {
                
                string[] a = Console.ReadLine().Split(' ');
                if (int.Parse(a[0]) > Fx || int.Parse(a[1]) > Fy)
                    continue;
                matrix[int.Parse(a[0]), int.Parse(a[1])] = -1;
            }

           

          


            for(int i = 1; i<= Fx;i++)
            { 
                if(matrix[i,0]==-1)
            {
                break;
            }
                else
                matrix[i,0] = (BigInteger)1;

            }

            for(int i = 0;i<=Fy;i++)
            {
               if(matrix[0,i]==-1)
            {
                break;
            }
                else
                matrix[0,i] = (BigInteger)1;
            }

            for(int i=1;i<=Fx;i++)
            {
                for(int j=1;j<=Fy;j++)
                {
        
                        if (!(matrix[i,j]==-1))
                        {
                            matrix[i, j] = ((matrix[i - 1, j]==-1)?0:matrix[i-1,j]) +( (matrix[i, j - 1]==-1)?0:matrix[i,j-1]);
                        }
                }

            }

          
                  Console.WriteLine(matrix[Fx,Fy]);
            
        }

        }
    }

