using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworkers_2._0
{
    class Repository
    {
        //// создаем массив с данными по рабочим
        //private Worker[] workers;


        //// добавляем путь к файлу для данных
        //private string path;


        //// добавляем название заголовков и номер строки
        //int index;
        //string[] titles;

        //public Repository(string Path)
        //{
        //    this.path = Path;
        //    this.index = 0;
        //    this.titles = new string[6];
        //    this.workers = new Worker[2]; 
        //}


        //// при добавлении новых сотрудников добавляет места при необходимости
        //private void Resize(bool Flag)
        //{
        //    if (Flag)
        //    {
        //        Array.Resize(ref this.workers, this.workers.Length * 2);
        //    }
        //}

        //// добавление новых мест в массиве
        //public void Add(Worker ConcreteWorker)
        //{
        //    this.Resize(index >= this.workers.Length);
        //    this.workers[index] = ConcreteWorker;
        //    this.index++;
        //}

        //public void Load() 
        //{
        //    using (StreamReader db = new StreamReader(this.path))
        //    {
        //        titles = db.ReadLine().Split(',');

        //        while (!db.EndOfStream)
        //        {
        //            string[] args = db.ReadLine().Split(',');

        //            Add(new Worker(args[0], args[1], args[2], args[3], args[4], args[5], args[6]));
        //        }
        //    }
        //}

        //// печать в консоль данных
        //public void PrintDbToConsole()
        //{
        //    Console.WriteLine($"{this.titles[0],15} {this.titles[1],15} {this.titles[2],15} {this.titles[3],15} {this.titles[4],15} {this.titles[5],15} {this.titles[6]}");

        //    for (int i = 0; i< index; i++)
        //    {
        //        Print(this.workers[i]));
        //    }
        //}

        //// проверка количества мест
        //public int Count { get { return this.index; } }

        //public Worker GetAllWorkers()
        //public Worker GetWorkerById(int id)
        //{
        //    // происходит чтение из файла, возвращается Worker
        //    // с запрашиваемым ID
        //}
    }
}
