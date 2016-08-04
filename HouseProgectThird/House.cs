using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgectThird
{
    class House
    {
        IHouseObjectInterface tv;
        IHouseObjectInterface boiler;
        IHouseObjectInterface fridge;
        Handler handler;
        GuestUser user;
        public House()
        {
            InizializedComponentHouse();
        }
        public void InizializedComponentHouse()
        {
             tv = new TV();
            boiler = new Boiler();
            fridge = new Fridge();

            handler = new Handler(boiler,tv,fridge);
        }
        public void Identification()
        {
            // построение екземпляра в зависимовти от типа: гость, хазяин, мастер.
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
            Identification();
            handler.SelectedObjectControl();
            user.Control();
        }
    }
}
