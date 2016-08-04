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

        private string objectControl;
        public Handler(IHouseObjectInterface boiler, IHouseObjectInterface tv, IHouseObjectInterface fridge)
        {
            this.boiler = boiler;
            this.tv = tv;
            this.fridge = fridge;
        }

        public void SelectedObjectControl()
        {
            Console.WriteLine("Выберите обьект использования: бойлер, тв, холодильник");
            objectControl = Console.ReadLine();
        }

        public void RepairBoiler()
        {
            switch (objectControl)
            {
                case "бойлер":
                    boiler.Repair();
                    break;
            }

        }
        public void TurnOnBoiler()
        {
            switch (objectControl)
            {
                case "бойлер":
                    boiler.TurnOn();
                    break;
            }

        }
        public void SelectTemperatureBoiler()
        {
            switch (objectControl)
            {
                case "бойлер":
                    boiler.SelectMode();
                    break;
            }

        }
        public void StatusBoiler()
        {
            switch (objectControl)
            {
                case "бойлер":
                    boiler.Status();
                    break;
            }

        }
        public void UseBoiler()
        {
            switch (objectControl)
            {
                case "бойлер":
                    boiler.UseObject();
                    break;
            }

        }
    }
}
