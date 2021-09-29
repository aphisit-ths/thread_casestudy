using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace thread_casestudy
{
    class Program
    {
        static byte[] Data_Global = new byte[1000000000];

        static long Sum_Global = 0;

        static int G_index = 0;

        static int ReadData()
        {
            int returnData = 0;
            FileStream fs = new FileStream("Problem01.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                Data_Global = (byte[]) bf.Deserialize(fs);
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Read Failed:" + se.Message);
                returnData = 1;
            }
            finally
            {
                fs.Close();
            }

            return returnData;
        }

        static void sum()
        {
            if (Data_Global[G_index] % 2 == 0)
            {
                long before = Sum_Global;
                Console.WriteLine("1 before : {0} **************************** >",before);
                Sum_Global -= Data_Global[G_index];
                Console.WriteLine("if Data : {0}  % 2 == 0 ,",Data_Global[G_index]);
                Console.WriteLine("Sum_Global : {0} - {1}:Data_Global",before ,Data_Global[G_index]);
                Console.WriteLine("1 =================================================== Result  : {0}",Sum_Global);
            }
            else if (Data_Global[G_index] % 3 == 0)
            {   
                long before = Sum_Global;
                Console.WriteLine("2 before : {0} **************************** >",before);
                Sum_Global += (Data_Global[G_index] * 2);
                Console.WriteLine("if Data : {0}  % 3 == 0 ,",Data_Global[G_index]);
                Console.WriteLine("Sum_Global : {0} + {1} x 2:Data_Global",before ,Data_Global[G_index]);
                Console.WriteLine("2 =================================================== Result : {0}",Sum_Global);
            }
            else if (Data_Global[G_index] % 5 == 0)
            {
                long before = Sum_Global;
                Console.WriteLine("3 before : {0} **************************** >",before);
                Sum_Global += (Data_Global[G_index] / 2);
                Console.WriteLine("if Data : {0}  % 5 == 0 ,",Data_Global[G_index]);
                Console.WriteLine("Sum_Global : {0} + {1} / 2:Data_Global",before ,Data_Global[G_index]);
                Console.WriteLine("3 =================================================== Result : {0}",Sum_Global);
            }
            else if (Data_Global[G_index] % 7 == 0)
            {   
                long before = Sum_Global;
                Console.WriteLine("4 before : {0} **************************** >",before);
                Sum_Global += (Data_Global[G_index] / 3);
                Console.WriteLine("if Data : {0}  % 7 == 0 ,",Data_Global[G_index]);
                Console.WriteLine("Sum_Global : {0} + {1} / 3:Data_Global",before ,Data_Global[G_index]);
                Console.WriteLine("4 =================================================== Result : {0}",Sum_Global);
                 
            }
            Data_Global[G_index] = 0;
            G_index++;
        }

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int i,y;
            /* Read data from file */
            Console.Write("Data read...");
            y = ReadData();
            
            if (y == 0)
            {
                Console.WriteLine("Complete.");
            }
            else
            {
                Console.WriteLine("Read Failed!");
            }
            /* Start */
            Console.WriteLine("\n\nWorking...");
            sw.Start();
            for (i = 0; i < 1000; i++) sum();
            sw.Stop();
            Console.WriteLine("Done.");

            /* Result */
            Console.WriteLine("Summation result: {0}", Sum_Global);
            Console.WriteLine("Time used: " +sw.ElapsedMilliseconds.ToString() +"ms");
        }
    }
}
