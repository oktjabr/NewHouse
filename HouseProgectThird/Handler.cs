using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgectThird
{
    class Handler
    {
      
        IHouseObjectInterface[] houseObjectArray = null;

        private int possition = -1;


        public Handler()
        {
            houseObjectArray = new IHouseObjectInterface[] { new Boiler(), new TV(), new Fridge() };
            //для добавления обьекта необходимо вносить в конструктор попробовать исправить 
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
