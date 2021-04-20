using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace lesson_6
{
    class ProgramManager
    {


        public int Scan(Program[] a, int id)

        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Id == id)
                {
                    Console.WriteLine($"ID процесса {a[i].Id} {a[i].Name}");
                    return i;
                }
            }
            return -1;
        }
        private void Exit(Program[] a, int b, int i)
        {
            switch (i)
            {
                case 1:
                    Process[] kill = Process.GetProcessesByName((string)a[b].Name);
                    foreach (Process worker in kill)
                    {
                        worker.Kill();
                    }
                    break;
                case 2:
                    Process[] kill2 = Process.GetProcessesByName((string)a[b].Name);
                    foreach (Process worker in kill2)
                    {
                        worker.CloseMainWindow();
                    }
                    break;
            }
        }
        public void RunWorkProcess()
        {
            Console.WriteLine("Задание 1");
            Program[] ProgramMass = new Program[Process.GetProcesses().Length];
            int a = 0;
            foreach (Process pro in Process.GetProcesses())
            {
                ProgramMass[a] = new Program(pro.Id,pro.ProcessName);
                a++;
            }
            for (int i = 0; i < ProgramMass.Length; i++)
            {
                Console.WriteLine($"ID процесса {ProgramMass[i].Id} {ProgramMass[i].Name} ");
            }
            Console.Write("Введите ID процесса: ");
            int id = Convert.ToInt32(Console.ReadLine());

            int innum = Scan(ProgramMass, id);
            if (innum == -1)
                Console.WriteLine("Процесс не найден");
            Console.Write("Как завершить процесс 1 жестко или 2 просто закрыть ");
            int exit = Convert.ToInt32(Console.ReadLine());
            Exit(ProgramMass, innum, exit);
            Console.ReadKey();

        }
    }
}
