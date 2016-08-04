using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgectThird
{
    class House
    {
        //IHouseObjectInterface tv;
        //IHouseObjectInterface boiler;
        //IHouseObjectInterface fridge;
        Handler handler;
        GuestUser user;
        public House()
        {
            InizializedComponentHouse();
        }
        public void InizializedComponentHouse()
        {
            handler = new Handler();   
        }
        public void Identification()
        {
            
            Console.WriteLine("Кто вы назовитесь?хазяин,гость,мастер, или еще кто?? ");
            switch (Console.ReadLine())
            {
                case "гость":
                    user = new GuestUser(handler);
                    break;
                case "хазяин":
                    user = new OwnerUser(handler);
                    break;
                case "мастер":
                    user = new Master(handler);
                    break;

                default:
                    Console.WriteLine("Извините мы вызываем полицию");
                    //добавить сигнализацию
                    break;


            }
        }
        public void Start()
        {
            bool value = true;
            while (value)
            {
                Console.WriteLine("для выхода из программы наберите quit\nдля продолжения нажмите enter ");
                if (Console.ReadLine() == "quit")
                {
                    value = false;
                    //break;
                }
                else
                {
                    Identification();
                    handler.SelectedObjectControl();
                    user.Control();
                }
            }
        }
    }
}
