using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Brackets
{
    class Program
    {
        static void Main()
        {
            int nLines = int.Parse(Console.ReadLine());
            string @indent = Console.ReadLine();
            List<string> lines = new List<string>();

            int numOfIndents = 0;

            StringBuilder resultCode = new StringBuilder();


            for(int i=0;i<nLines;i++)
            {
                string @k = Console.ReadLine();
                k = k.Trim();
                if (k.Equals(""))
                    continue;
                lines.Add(k);
            }


            for(int i =0;i<lines.Count;i++)
            {

               for(int j=0;j<lines[i].Length;j++)
               {
                   if(lines[i][j]=='{')
                   {
                       if ( resultCode.Length>0 && resultCode[resultCode.Length-1]!='\n')
                           resultCode.Append("\n");

                       for (int r = 0; r < numOfIndents; r++)
                           resultCode.Append(indent);
                       resultCode.Append("{\n");
                       numOfIndents++;

                   }else
                       if(lines[i][j]=='}')
                       {
                           if ( resultCode.Length>0 && resultCode[resultCode.Length - 1] != '\n')
                               resultCode.Append("\n");

                           numOfIndents--;
                           for (int r = 0; r < numOfIndents; r++)
                               resultCode.Append(indent);
                           resultCode.Append("}\n");
                       }
                       else
                           if(lines[i][j]==' ' )
                           {
                               if(resultCode[resultCode.Length-1]!='\n')
                               resultCode.Append(' ');
                               while (j <= (lines[i].Length - 1) && lines[i][j] == ' ')
                                   j++;
                               j--;
                           }
                           else
                           if( resultCode.Length>0 && resultCode[resultCode.Length-1]=='\n')
                           {
                               for (int r = 0; r < numOfIndents; r++)
                                   resultCode.Append(indent);
                               resultCode.Append(@lines[i][j]);

                           }else
                           {
                               resultCode.Append(lines[i][j]);
                           }
               }

               if (resultCode[resultCode.Length - 1] == ' ') // trim the  result
                   resultCode.Remove(resultCode.Length - 1, 1);

                if(resultCode[resultCode.Length-1]!='\n')
               resultCode.Append("\n");



            }

            Console.Write(resultCode);



        }
    }
}
