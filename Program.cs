using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;
namespace Problem01
{
    class Program
    {
        static byte[] Data_Global = new byte[1000000000];
        static long Sum_Global = 0;
        static long Sum_Global_th1 = 0;
        static long Sum_Global_th2 = 0;
        static long Sum_Global_th3 = 0;
        static long Sum_Global_th4 = 0;
        static long Sum_Global_th5 = 0;
        static long Sum_Global_th6 = 0;
        static long Sum_Global_th7 = 0;
        static long Sum_Global_th8 = 0;
        static long Sum_Global_th9 = 0;
        static long Sum_Global_th10 = 0;
        
        static string time = "0";

        static int ReadData()
        {
            int returnData = 0;
            FileStream fs = new FileStream("Problem01.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                Data_Global = (byte[])bf.Deserialize(fs);
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
        /*static void sum()
        {
            if (Data_Global[G_index] % 2 == 0)
            {
                Sum_Global -= Data_Global[G_index];
            }
            else if (Data_Global[G_index] % 3 == 0)
            {
                Sum_Global += (Data_Global[G_index] * 2);
            }
            else if (Data_Global[G_index] % 5 == 0)
            {
                Sum_Global += (Data_Global[G_index] / 2);
            }
            else if (Data_Global[G_index] % 7 == 0)
            {
                Sum_Global += (Data_Global[G_index] / 3);
            }
            Data_Global[G_index] = 0;
            G_index++;
        }*/
        static void Thread1()
        {
            int i;
            Console.Write("\n\nWorking...");
            for (i = 0; i < 100000000; i++)
            {
               
                if (Data_Global[i] % 2 == 0)
                {
                    Sum_Global_th1 -= Data_Global[i];
                }
                else if (Data_Global[i] % 3 == 0)
                {
                    Sum_Global_th1 += (Data_Global[i] * 2);
                }
                else if (Data_Global[i] % 5 == 0)
                {
                    Sum_Global_th1 += (Data_Global[i] / 2);
                }
                else if (Data_Global[i] % 7 == 0)
                {
                    Sum_Global_th1 += (Data_Global[i] / 3);
                }
                Data_Global[i] = 0;
            }
        }
        static void Thread2()
        {
            int i;
            for (i = 100000000; i < 200000000; i++)
            {
                
                if (Data_Global[i] % 2 == 0)
                {
                    Sum_Global_th2 -= Data_Global[i];
                }
                else if (Data_Global[i] % 3 == 0)
                {
                    Sum_Global_th2 += (Data_Global[i] * 2);
                }
                else if (Data_Global[i] % 5 == 0)
                {
                    Sum_Global_th2 += (Data_Global[i] / 2);
                }
                else if (Data_Global[i] % 7 == 0)
                {
                    Sum_Global_th2 += (Data_Global[i] / 3);
                }
                Data_Global[i] = 0;
            }
        }
        static void Thread3()
        {
            int i;
            for (i = 200000000; i < 300000000; i++)
            {
                if (Data_Global[i] % 2 == 0)
                {
                    Sum_Global_th3 -= Data_Global[i];
                }
                else if (Data_Global[i] % 3 == 0)
                {
                    Sum_Global_th3 += (Data_Global[i] * 2);
                }
                else if (Data_Global[i] % 5 == 0)
                {
                    Sum_Global_th3 += (Data_Global[i] / 2);
                }
                else if (Data_Global[i] % 7 == 0)
                {
                    Sum_Global_th3 += (Data_Global[i] / 3);
                }
                Data_Global[i] = 0;
            }
        }
        static void Thread4()
        {
            int i;
            for (i = 300000000; i < 400000000; i++)
            {
                
                if (Data_Global[i] % 2 == 0)
                {
                    Sum_Global_th4 -= Data_Global[i];
                }
                else if (Data_Global[i] % 3 == 0)
                {
                    Sum_Global_th4 += (Data_Global[i] * 2);
                }
                else if (Data_Global[i] % 5 == 0)
                {
                    Sum_Global_th4 += (Data_Global[i] / 2);
                }
                else if (Data_Global[i] % 7 == 0)
                {
                    Sum_Global_th4 += (Data_Global[i] / 3);
                }
                Data_Global[i] = 0;
            }
        }
        static void Thread5()
        {
            int i;
            for (i = 400000000; i < 500000000; i++)
            {
                
                if (Data_Global[i] % 2 == 0)
                {
                    Sum_Global_th5 -= Data_Global[i];
                }
                else if (Data_Global[i] % 3 == 0)
                {
                    Sum_Global_th5 += (Data_Global[i] * 2);
                }
                else if (Data_Global[i] % 5 == 0)
                {
                    Sum_Global_th5 += (Data_Global[i] / 2);
                }
                else if (Data_Global[i] % 7 == 0)
                {
                    Sum_Global_th5 += (Data_Global[i] / 3);
                }
                Data_Global[i] = 0;
            }
        }
        static void Thread6()
        {
            int i;
            for (i = 500000000; i < 600000000; i++)
            {
                
                if (Data_Global[i] % 2 == 0)
                {
                    Sum_Global_th6 -= Data_Global[i];
                }
                else if (Data_Global[i] % 3 == 0)
                {
                    Sum_Global_th6 += (Data_Global[i] * 2);
                }
                else if (Data_Global[i] % 5 == 0)
                {
                    Sum_Global_th6 += (Data_Global[i] / 2);
                }
                else if (Data_Global[i] % 7 == 0)
                {
                    Sum_Global_th6 += (Data_Global[i] / 3);
                }
                Data_Global[i] = 0;
            }
        }
        static void Thread7()
        {
            int i;
            for (i = 600000000; i < 700000000; i++)
            {
                
                if (Data_Global[i] % 2 == 0)
                {
                    Sum_Global_th7 -= Data_Global[i];
                }
                else if (Data_Global[i] % 3 == 0)
                {
                    Sum_Global_th7 += (Data_Global[i] * 2);
                }
                else if (Data_Global[i] % 5 == 0)
                {
                    Sum_Global_th7 += (Data_Global[i] / 2);
                }
                else if (Data_Global[i] % 7 == 0)
                {
                    Sum_Global_th7 += (Data_Global[i] / 3);
                }
                Data_Global[i] = 0;
            }
        }
        static void Thread8()
        {
            int i;
            for (i = 700000000; i < 800000000; i++)
            {
                
                if (Data_Global[i] % 2 == 0)
                {
                    Sum_Global_th8 -= Data_Global[i];
                }
                else if (Data_Global[i] % 3 == 0)
                {
                    Sum_Global_th8 += (Data_Global[i] * 2);
                }
                else if (Data_Global[i] % 5 == 0)
                {
                    Sum_Global_th8 += (Data_Global[i] / 2);
                }
                else if (Data_Global[i] % 7 == 0)
                {
                    Sum_Global_th8 += (Data_Global[i] / 3);
                }
                Data_Global[i] = 0;
            }
        }
        static void Thread9()
        {
            int i;
            for (i = 800000000; i < 900000000; i++)
            {
                
                if (Data_Global[i] % 2 == 0)
                {
                    Sum_Global_th9 -= Data_Global[i];
                }
                else if (Data_Global[i] % 3 == 0)
                {
                    Sum_Global_th9 += (Data_Global[i] * 2);
                }
                else if (Data_Global[i] % 5 == 0)
                {
                    Sum_Global_th9 += (Data_Global[i] / 2);
                }
                else if (Data_Global[i] % 7 == 0)
                {
                    Sum_Global_th9 += (Data_Global[i] / 3);
                }
                Data_Global[i] = 0;
            }
        }
        static void Thread10()
        {
            int i;
            for (i = 900000000; i < 1000000000; i++)
            {
                
                if (Data_Global[i] % 2 == 0)
                {
                    Sum_Global_th10 -= Data_Global[i];
                }
                else if (Data_Global[i] % 3 == 0)
                {
                    Sum_Global_th10 += (Data_Global[i] * 2);
                }
                else if (Data_Global[i] % 5 == 0)
                {
                    Sum_Global_th10 += (Data_Global[i] / 2);
                }
                else if (Data_Global[i] % 7 == 0)
                {
                    Sum_Global_th10 += (Data_Global[i] / 3);
                }
                Data_Global[i] = 0;
            }
        }


        static void Main(string[] args)
        {
            int y;
            Stopwatch sw = new Stopwatch();
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
             /* Console.Write("\n\nWorking...");
              sw.Start();
              for (int i = 0; i < 100; i++){
                  sum();
                sw.Stop();
              }
              
              Console.WriteLine("Done.");*/
            
            Thread th1 = new Thread(Thread1);
            Thread th2 = new Thread(Thread2);
            Thread th3 = new Thread(Thread3);
            Thread th4 = new Thread(Thread4);
            Thread th5 = new Thread(Thread5);
            Thread th6 = new Thread(Thread6);
            Thread th7 = new Thread(Thread7);
            Thread th8 = new Thread(Thread8);
            Thread th9 = new Thread(Thread9);
            Thread th10 = new Thread(Thread10);
            
            sw.Start();
            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();
            th5.Start();
            th6.Start();
            th7.Start();
            th8.Start();
            th9.Start();
            th10.Start();

            th1.Join();
            th2.Join();
            th3.Join();
            th4.Join();
            th4.Join();
            th5.Join();
            th6.Join();
            th7.Join();
            th8.Join();
            th9.Join();
            th10.Join();
            

            sw.Stop();
            time = sw.ElapsedMilliseconds.ToString();
            Console.WriteLine("Done.");
            /* Result */
            long SumationAll = Sum_Global_th1+Sum_Global_th2+Sum_Global_th3+Sum_Global_th4+Sum_Global_th5+Sum_Global_th6+Sum_Global_th7+Sum_Global_th8+Sum_Global_th9+Sum_Global_th10;
            Console.WriteLine("Summation result: {0}", SumationAll);
            Console.WriteLine("Time used: " + time + "ms");
        }
    }
}

// Sum_Global_th1+Sum_Global_th2 but seq.. run
// Working...Done.
// Summation result: 888701676
// Time used: 50025ms


//Pararel  == 2
// Working...Done.
// Summation result: 888701676
// Time used: 24747ms


//Pararel  == 4
// Working...Done.
// Summation result: 888701676
// Time used: 10964ms


//Pararel  == 10
// Working...Done.
// Summation result: 888701676
// Time used: 7374ms