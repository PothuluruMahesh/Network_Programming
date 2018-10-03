using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using System.Threading;

namespace NetworkClient
{
    class Program
    { 
        static void Main(string[] args)
        {
           try
            { 
                TcpClient client=new TcpClient("127.0.0.1", 800);
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                string s = string.Empty;
                while(!s.Equals("Exit"))
                {    
                    Console.WriteLine("Enter Data :");
                    s = Console.ReadLine();
                    Console.WriteLine();
                    writer.WriteLine(s);
                    writer.Flush();
                    string sw = reader.ReadLine();
                    Console.WriteLine(sw);
                }
                reader.Close();
                writer.Close();
                client.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           
        }
    }
}
