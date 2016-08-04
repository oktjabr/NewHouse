using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgectThird
{
    class Handler
    {
        //IHouseObjectInterface boiler;
        //IHouseObjectInterface tv;
        //IHouseObjectInterface fridge;

        IHouseObjectInterface[] houseObjectArray = null;

        private int possition = -1;


        public Handler()
        {
            houseObjectArray = new IHouseObjectInterface[] { new Boiler(), new TV(), new Fridge() };
            //boiler = new Boiler();
            //tv = new TV();
            //fridge = new Fridge();

            //houseObjectArray[0] = boiler;
            //houseObjectArray[1] = tv;
            //houseObjectArray[2] = fridge;

        }

        public void SelectedObjectControl()
        {
            Console.WriteLine("Выберите обьект использования: бойлер, тв, холодильник");

            string l = Console.ReadLine();
            for (int i = 0; i < houseObjectArray.Length; i++)
            {
                if (l == houseObjectArray[i].Name)
                {
                    possition = i;
                }
        }
        //switch (Console.ReadLine())
        //{
        //    case "бойлер":
        //        possition = 0;
        //        break;
        //    case "тв":
        //        possition = 1;
        //        break;
        //    case "холодильник":
        //        possition = 2;
        //        break;
        //    default:
        //        Console.WriteLine("Вы выбрали неверный обьект использования");
        //        break;
        //}

    }

    public void RepairHandler()
    {

        houseObjectArray[possition].Repair();

    }
    public void TurnOnHandler()
    {

        houseObjectArray[possition].TurnOn();


    }
    public void SelectModeHandler()
    {

        houseObjectArray[possition].SelectMode();

    }
    public void StatusHandler()
    {

        houseObjectArray[possition].Status();

    }
    public void UseHouseObjectHandler()
    {

        houseObjectArray[possition].UseObject();
    }
}
}
