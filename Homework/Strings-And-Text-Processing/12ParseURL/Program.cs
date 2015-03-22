using System;
using System.Text;
namespace _12ParseURL
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a URL:");
            string url = Console.ReadLine();
            string protocol = url.Split(new string[] { "://" }, StringSplitOptions.None)[0];
            string server = url.Split('/')[2];
            StringBuilder resource = new StringBuilder( "/");
            string[] all = url.Split('/');

            
                for(int i = 3;i<all.Length;i++)
                {
                    resource.Append(all[i] + "/");
                }
                resource = resource.Remove(resource.Length - 1, 1);

                Console.WriteLine("[protocol] =" + protocol);
                Console.WriteLine("[server] =" + server);
                Console.WriteLine("[resource] =" + resource);

        }
    }
}
