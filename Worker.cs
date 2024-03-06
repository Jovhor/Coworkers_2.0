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
        public int ID 
        { 
            get { return ID; } 
            set { ID = value; } 
        }

        /// <summary>
        /// Время добавления сотрудника 
        /// </summary>
        private string AddTime 
        { 
            get { return AddTime; } 
            set { AddTime = DateTime.Now.ToString(); } 
        } 

        /// <summary>
        /// ФИО 
        /// </summary>
        public string FIO 
        { 
            get { return FIO; } 
            set { FIO = value; } 
        }

        /// <summary>
        /// Возраст 
        /// </summary>
        public int Age 
        { 
            get { return Age; } 
            set { Age = value; } 
        }

        /// <summary>
        /// Рост сотрудника
        /// </summary>
        public int Height 
        { 
            get { return Height; } 
            set { Height = value; } 
        }

        /// <summary>
        /// Дата рождения сотрудника
        /// </summary>

        public string DayOfBirht
        {
            get { return DayOfBirht; }
            set { DayOfBirht = value; }
        }
        public string MonthOfBirht
        {
            get { return MonthOfBirht; } 
            set { MonthOfBirht = value; } 
        }
        public string YearOfBirth 
        {
            get { return YearOfBirth; }
            set { YearOfBirth = value; } 
        }

        /// <summary>
        /// Дата рождения сотрудника
        /// </summary>

        private string BirthDay 
        {
            get { return $"{DayOfBirht}.{MonthOfBirht}.{YearOfBirth}"; } 
        }         
        
        /// <summary>
        /// Место рождения 
        /// </summary>
        public string PlaceOfBirth 
        {
            get { return PlaceOfBirth; }
            set { PlaceOfBirth = value; }
        }

        public string Print()  // вывод данных о сотруднике
        {
            return $"Номер по порядку: {ID} " +
                $"\n Время добавления записи: {AddTime}" +
                $"\nФ.И.О.: {FIO} " +
                $"\nВозраст: {Age} " +
                $"\nРост: {Height} " +
                $"\nДата рождения: {BirthDay}" +
                $"\nМесто рождения: {PlaceOfBirth}";
        }
    }
}
