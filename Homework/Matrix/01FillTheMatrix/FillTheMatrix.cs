using System;

//Write a program that fills and prints a matrix of size (n, n) as shown below:

    class FillTheMatrix
    {
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            int n = m;
            int [,] matrix = new int[n,n];

            //a)
            int k = 1;
            for(int i=0;i<n;i++)
                for(int j=0;j<n;j++)
                {
                    matrix[j, i] = k;
                    k++;
                }
            
            
            
          
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            //

            // b)
            k = 1;
            int p = 0;
            int pom = 1;
            for (int i = 0; i < n; i ++ )// colums
            {
                for ( int j = p; j < n && j>=0; j+=pom)//rows
                {
                    matrix[j, i] = k;
                    k++;
                }

                pom *= (-1);
                if (p == 0)
                    p = n - 1;
                else
                    p = 0;

            }

            Console.WriteLine();

         
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            //

            //c
            k =1;
            int count = 1; // diagonal counter;
            for(int i=n-1;i>=0;i--,count++)  // main diagonal down part
            {
                if(count==1)
                {
                    matrix[i, 0] = k;
                    k++;
                }else
                {
                    for(int j=0;j<count;j++)
                    {
                        matrix[i + j, j] = k;
                        k++;
                    }
                }
            }
            
            count -=2;
            for (int i = 1; i < n; i++, count--)  // main diagonal up part
            {
                if (count == 1)
                {
                    matrix[0, n-1] = k;
                    k++;
                }
                else
                {
                    for (int j = 0; j < count; j++)
                    {
                        matrix[j, i+j] = k;
                        k++;
                    }
                }
            }
                Console.WriteLine();
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            //




            //d)

            int x = 0;
            int y = 0;
           
            count = n * n; // number of  elements
            int cnt = 1; // 

            while (cnt <= count)
            {

                if (n == 1)
                {
                    matrix[x, y] = cnt;
                    cnt++;
                    break;
                }



                //top left to down
                for (int i = 0; i < n - 1; i++)
                {
                    matrix[x++, y] = cnt;
                    cnt++;
                }

                //bottom left to right
                for (int i = 0; i < n - 1; i++)
                {
                    matrix[x, y++] = cnt;
                    cnt++;
                }

                //right bottom to up
                for (int i = 0; i < n - 1; i++)
                {
                    matrix[x--, y] = cnt;
                    cnt++;
                }
              

                //right top  to left
                for (int i = 0; i < n - 1; i++)
                {
                    matrix[x, y--] = cnt;
                    cnt++;
                }

             

                x++;
                y++;

                n -= 2; // cut the  rows and colums that are passed

            }

            Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }

