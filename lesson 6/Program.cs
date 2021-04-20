using System;

namespace lesson_6
{
    class Program
    {
        private object iD;
        private string processName;

        public Program(object iD, string processName)
        {
            this.iD = iD;
            this.processName = processName;
        }

        public int Id { get; internal set; }
        public object Name { get; internal set; }
    }

    static void Main(string[] args)
    {
        ProgramManager pr = new ProgramManager();
        pr.RunWorkProcess();

        int sum = 0;
        Random random = new Random();
        string[,] sArray = new string[4, 4];

        for (int i=0; i<4; i++)
        {
            for (int j =0; j<4; j++)
            {
                sArray[i, j] = random.Next(1, 50).ToString();

            }
        }

        try
        {
            sum = sumArray(sArray);
        }
        catch (MyArraySizeExeptijn e)
        {
            Console.WriteLine(e.StackTrace);
        }
        catch (MyArrayDataExeption e)
        {
            Console.WriteLine(e.StackTrace);
        }
        Console.WriteLine(sum);
    }
    public static int sumArray(string[,] sArray)
    {
        int sum = 0;
        if (sArray.GetLength(0) != 4) throw new MyArraySizeExeptijn();
        for (int i=0; i< sArray.GetLength(0); i++)
        {
            for (int j=0; j< sArray.GetLength(1); j++)
            {
                try
                {
                    sum += Int32.Parse(sArray[i, j]);

                }
                catch (Exception e)
                {
                    throw new MyArrayDataExeption(i, j);
                }
            }
        }
        return sum;
    }
    }

