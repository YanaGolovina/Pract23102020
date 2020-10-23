using System;

namespace Lab23102020
{
    class Program
    {
        static string marks;
        static int quantity;
        static string nameOfDisciplines;
        static string name;
        static int discipline;


        static void Main(string[] args)
        {
            string[][] shedule = AddStudentsQuantity();
            InitializTheList(shedule);

        }
        static string[][] AddStudentsQuantity()
        {
            Console.WriteLine("Сколько студентов?");
            quantity = int.Parse(Console.ReadLine());
            string[][] shedule = new string[quantity][];
            return shedule;
        }

        static void AddDisciplinesQuantity(string[][] shedule, int i)
        {
            Console.WriteLine("Скажите количество дисциплин");
            discipline = int.Parse(Console.ReadLine());
            shedule[i] = new string[discipline];
        }

        static void AddMarks(string[][] shedule, int i, int j)
        {
            Console.WriteLine("Скажите оценки");
            marks = Console.ReadLine();
            shedule[i][j] = marks;
        }

        static double GetAverageMark(string[][] shedule, int i,int j)
        {
            int summ = 0, count = 0, number = 0;
            double result = 0;
            foreach (char value in shedule[i][j])
                shedule[i][j] = shedule[i][j].Replace(" ", null);
            

            for (int s = 0; s < shedule[i][j].Length; s++)
            {
                number = Convert.ToInt32((shedule[i][j])[s]);
                summ += number - 48;
                count++;
            }
           
            return
             result = Math.Abs(Math.Round((double)summ / count));
        }

        static void InitializTheList(string[][] shedule)
        {
            for (int i = 0; i < quantity; i++)
            {
               Console.WriteLine("Введите имя");
               name = Console.ReadLine();
               

                AddDisciplinesQuantity(shedule, i);
                 for (int j = 0; j < discipline; j++)
                 {
                    Console.WriteLine("Введите дисциплину");
                    nameOfDisciplines = Console.ReadLine();
                    

                    AddMarks(shedule, i, j);
                    Console.WriteLine(GetAverageMark(shedule, i, j));
                 }
            }
        }

    }
}

