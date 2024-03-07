using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Coworkers_2._0
{
    class Worker
    {
        public Worker(int ID, DateTime AddTime, string FIO, 
            int Age, int Height, DateTime BirthDay, string PlaceOfBirth)
        {
            this.ID = ID;
            this.AddTime = AddTime;
            this.Age = Age;
            this.Height = Height;
            this.BirthDay = BirthDay;
            this.PlaceOfBirth = PlaceOfBirth;
        }

        /// <summary>
        /// Номер по списку
        /// </summary>
        public int ID;
        //{ 
        //    get { return this.ID; }
        //    set { this.ID = value; }
        //}

        /// <summary>
        /// Время добавления сотрудника 
        /// </summary>
        public DateTime AddTime;
        //{ 
        //    get { return this.AddTime; } 
        //    set { this.AddTime = DateTime.Now.ToString(); } 
        //} 

        /// <summary>
        /// ФИО 
        /// </summary>
        public string FIO;
        //{ 
        //    get { return this.FIO; } 
        //    set { this.FIO = value; } 
        //}

        /// <summary>
        /// Возраст 
        /// </summary>
        public int Age;
        //{ 
        //    get { return this.Age; } 
        //    set { this.Age = value; } 
        //}

        /// <summary>
        /// Рост сотрудника
        /// </summary>
        public int Height;
        //{ 
        //    get { return this.Height; } 
        //    set { this.Height = value; } 
        //}

        /// <summary>
        /// Дата рождения сотрудника
        /// </summary>

        public string BirthDay;
        //{
        //    get { return this.BirthDay; }
        //    set { this.BirthDay = value; }
        //}

        /// <summary>
        /// Место рождения 
        /// </summary>
        public string PlaceOfBirth;
        //{
        //    get { return this.PlaceOfBirth; }
        //    set { this.PlaceOfBirth = value; }
        //}

        public void Print()  // вывод данных о сотруднике
        {
            Console.WriteLine( $"Номер по порядку: {ID} " +
                $"\nВремя добавления записи: {AddTime}" +
                $"\nФ.И.О.: {FIO} " +
                $"\nВозраст: {Age} " +
                $"\nРост: {Height} " +
                $"\nДата рождения: {BirthDay}" +
                $"\nМесто рождения: {PlaceOfBirth}");

        }

        public void AddWorker (Worker worker)
        {
            Console.Write("Введите номер по порядку:  ");    
            ID = Convert.ToInt32(Console.ReadLine());
            AddTime = DateTime.Now;
            Age = Convert.ToInt32(Console.ReadLine());
            Height = Convert.ToInt32(Console.ReadLine());
            BirthDay = Console.ReadLine();
            PlaceOfBirth = Console.ReadLine();
        }

        }
    }
}
