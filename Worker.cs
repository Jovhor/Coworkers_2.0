using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Coworkers_2._0
{
    struct Worker
    {
        /// <summary>
        /// Номер по списку
        /// </summary>
        private int ID { get; set; }

        /// <summary>
        /// Время добавления сотрудника 
        /// </summary>
        private string AddTime { get { return AddTime; } set { AddTime = DateTime.Now.ToString(); } } 

        /// <summary>
        /// ФИО 
        /// </summary>
        public string FIO { get; set; }

        /// <summary>
        /// Возраст 
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Рост сотрудника
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Дата рождения сотрудника
        /// </summary>
        public DateTime BirthDay { get; set; } 

        /// <summary>
        /// Место рождения (place of birth) 
        /// </summary>
        public string PoB { get; set; } 

        public string Print()  // вывод данных о сотруднике
        {
            return $"Номер по порядку: {ID} " +
                $"\n Время добавления записи: {AddTime}" +
                $"\nФ.И.О.: {FIO} " +
                $"\nВозраст: {Age} " +
                $"\nРост: {Height} " +
                $"\nДата рождения: {BirthDay.ToShortDateString()}" +
                $"\nМесто рождения: {PoB}";
        }
    }
}
