﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgectThird
{
    interface IHouseObjectInterface
    {
        string Name
        {
            get;
        }
        void TurnOn();
        void SelectMode();
        void Repair();
        void UseObject();
        void Status();
    }

    class Boiler : IHouseObjectInterface
    {
        string name = "бойлер";
        bool onStatus = false;
        bool lifeStatus = true;
        bool useStatus = false;
        int temperature;
        public string Name
        {
            get { return name; }
        }
        public void TurnOn()
        {
            if (lifeStatus == true)
            {
                onStatus = true;
                Console.WriteLine("бойлер включен");
            }
            else
            {
                Console.WriteLine("бойлер сломан нужен мастер");
            }
        }
        public void SelectMode()
        {
            if (lifeStatus == true)
            {
                Console.WriteLine("Выберите необходимую температуру бойлера");
                temperature = Convert.ToInt32(Console.ReadLine());
                if (temperature >= 90)
                {
                    lifeStatus = false;
                    onStatus = false;
                    temperature = 0;
                }
            }

        }
        public void Repair()
        {
            Console.WriteLine("Вы отремонтировали бойлер");
            lifeStatus = true;
        }
        public void UseObject()
        {
            if (lifeStatus == true)
            {
                if (onStatus == true)
                {
                    Console.WriteLine("Вы успешно используете бойлер");
                    useStatus = true;
                }
                else
                    Console.WriteLine("вы не можете использовать бойлер он выключен");
            }
            else
                Console.WriteLine("вы не можете испльзовать бойлерон сломан");
        }
        public void Status()
        {
            Console.WriteLine("статус:\n- рабочий - {0}\n-включен - {1}\n-температура - {2}\n-бойлер используется - {3}", lifeStatus, onStatus, temperature, useStatus);
        }
    }
    class TV : IHouseObjectInterface
    {
        private bool onStatus = false;
        private bool lifeStatus = true;
        private bool useStatus = false;
        string name = "тв";
        public string Name
        {
            get { return name; }
        }
        public void TurnOn()
        {
            if (lifeStatus == true)
            {
                onStatus = true;
                Console.WriteLine("телевизор включен");
            }
            else
            {
                Console.WriteLine("телевизор сломан нужен мастер");
            }
        }
        public void SelectMode()
        {
            if (lifeStatus == true)
            {
                //придумать настройку каналов тв использовать коллекцию каналов
                
                Console.WriteLine("Каналы не настроены");
            }

        }
        public void Repair()
        {
            Console.WriteLine("Вы отремонтировали телевизор");
            lifeStatus = true;
        }
        public void UseObject()
        {
            // переделать метод для тв с учетом правки по каналам
            if (lifeStatus == true)
            {
                if (onStatus == true)
                {
                    Console.WriteLine("Вы успешно смотрите телевизор");
                    useStatus = true;
                }
                else
                    Console.WriteLine("вы не можете использовать телевизор он выключен");
            }
            else
                Console.WriteLine("вы не можете испльзовать телевизор он сломан");
        }
        public void Status()
        {
            Console.WriteLine("статус:\n- рабочий - {0}\n-включен - {1}\n-бойлер используется - {2}", lifeStatus, onStatus, useStatus);
        }
    }

    class Fridge : IHouseObjectInterface
    {
        private bool lifeStatus = true;
        private bool onStatus  = false;
        private bool useStatus = false;
        private int temperature;
        string name ="холодильник";
        public string Name
        {
            get { return name; }
        }
        public void TurnOn()
        {
            if (lifeStatus == true)
            {
                onStatus = true;
                Console.WriteLine("холодильник включен");
            }
            else
            {
                Console.WriteLine("холодильник сломан нужен мастер");
            }
        }
        public void SelectMode()
        {
            if (lifeStatus == true)
            {
                Console.WriteLine("Выберите температурный режим холодильника от +4 до -8 ");
                temperature = Convert.ToInt32(Console.ReadLine());
                if (temperature > 4 || temperature < -8)
                {
                    lifeStatus = false;
                    onStatus = false;
                    temperature = 0;
                    Console.WriteLine("Холодильник сломался");
                }
            }

        }
        public void Repair()
        {
            Console.WriteLine("Вы отремонтировали холодильник");
            lifeStatus = true;
        }
        public void UseObject()
        {
            if (lifeStatus == true)
            {
                if (onStatus == true)
                {
                    Console.WriteLine("Вы успешно используете холодильник");
                    useStatus = true;
                }
                else
                    Console.WriteLine("вы не можете использовать холодильник он выключен");
            }
            else
                Console.WriteLine("вы не можете испльзовать холодильник, он сломан");
        }
        public void Status()
        {
            Console.WriteLine("статус:\n- рабочий - {0}\n-включен - {1}\n-температура - {2}\n-холодильник используется - {3}", lifeStatus, onStatus, temperature, useStatus);
        }
    }
}
