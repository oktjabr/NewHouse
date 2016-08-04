using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgectThird
{
    class Handler
    {
        IHouseObjectInterface boiler;
        IHouseObjectInterface tv;
        IHouseObjectInterface fridge;

        IHouseObjectInterface[] houseObjectArray = null;

        private int possition = -1;

        private string objectControl;
        public Handler(IHouseObjectInterface boiler, IHouseObjectInterface tv, IHouseObjectInterface fridge)
        {
            houseObjectArray = new IHouseObjectInterface[3];
            this.boiler = boiler;
            this.tv = tv;
            this.fridge = fridge;

            houseObjectArray[0] = boiler;
            houseObjectArray[1] = tv;
            houseObjectArray[2] = fridge;

        }

        public void SelectedObjectControl()
        {
            Console.WriteLine("Выберите обьект использования: бойлер, тв, холодильник");
            switch (Console.ReadLine())
            {
                case "бойлер":
                    possition = 0;
                    break;
                case "тв":
                    possition = 1;
                    break;
                case "холодильник":
                    possition = 2;
                    break;
                default:
                    Console.WriteLine("Вы выбрали неверный обьект использования");
                    break;
            }

        }

        public void RepairBoiler()
        {

            houseObjectArray[possition].Repair();

        }
        public void TurnOnBoiler()
        {

            houseObjectArray[possition].TurnOn();


        }
        public void SelectTemperatureBoiler()
        {

            houseObjectArray[possition].SelectMode();

        }
        public void StatusBoiler()
        {

            houseObjectArray[possition].Status();

        }
        public void UseBoiler()
        {

            houseObjectArray[0].UseObject();
        }
    }
}
