using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konspiration
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            StringBuilder input = new StringBuilder();
          
            
            for(int i=0;i<n;i++)
            {
                input.Append(Console.ReadLine());
                input.Append("\n");
            }

            string[] lines = input.ToString().Split('\n');

            List<string> methods = new List<string>();
            StringBuilder inOneMethod = new StringBuilder();
            bool inMethod = false;

            for(int i =0;i<lines.Length;i++)
            {

               
                string[] k = lines[i].Split(new string[]{"static"},StringSplitOptions.RemoveEmptyEntries);


                if (lines[i].Contains("static")&&k.Length == 0 && !inMethod)
                    continue;
                else
                    if (lines[i].Contains("static"))
                    {
                        string[] findNameMethod = k[1].Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                        string methodName = findNameMethod[1].Split('(')[0];
                        if(inOneMethod.Length>0)
                        {
                            methods.Add(inOneMethod.ToString().TrimEnd(','));
                        inOneMethod.Clear();

                        }
                        inOneMethod.Append(methodName);
                        inOneMethod.Append(" ->");
                        inMethod = true;

                    }
                    else
                        if(inMethod)
                        {
                            if (lines[i].Contains('.'))
                            {
                                string[] getInvoke = lines[i].Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);

                                for (int j = 1; j < getInvoke.Length; j++)
                                {
                                    string p = getInvoke[j].Split(new char[] { '(' }, StringSplitOptions.RemoveEmptyEntries)[0];
                                    if (!p.Equals(""))
                                    {
                                        inOneMethod.Append(" ");
                                        inOneMethod.Append(p);
                                        inOneMethod.Append(',');
                                    }
                                }
                            }

                        }


            }
            methods.Add(inOneMethod.ToString());

            foreach(string k in methods)
            {

                Console.WriteLine(k);
            }


        }
    }
}
