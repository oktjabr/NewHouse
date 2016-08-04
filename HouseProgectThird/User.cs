using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgectThird
{
    public delegate void MyDelegate();
    class GuestUser
    {
        protected MyDelegate myDelegate = null;
        protected Handler handler;
        public GuestUser(Handler handler)
        {
            this.handler = handler;
        }

        protected virtual void UseHouseObject()
        {
             myDelegate = new MyDelegate(handler.UseHouseObjectHandler);
        }
        protected virtual void RepareHouseObject()
        {
            Console.WriteLine("Вы не можете чинить ");
            myDelegate = null;
        }
        protected virtual void TurnOnHouseObject()
        {
             myDelegate = new MyDelegate(handler.TurnOnHandler);
        }
        protected virtual void SelectHauseObjectMode()
        {
            Console.WriteLine("Вы неможете устанавливать режим ");
            myDelegate = null;
        }
        protected virtual void ShowStatuSHouseObject()
        {
             myDelegate = new MyDelegate(handler.StatusHandler);
        }
        public void Control()
        {
            Console.WriteLine("выберите действие: использовать, включить, установить режим, статус, ремонт");
            Console.WriteLine("Для выхода из режима наберите quit");
            bool value = true;
            while (value)
            {
                switch (Console.ReadLine())
                {
                    case "использовать":
                        UseHouseObject();
                        if (myDelegate != null)
                        {
                            myDelegate.Invoke();
                        }
                        break;
                    case "включить":
                        TurnOnHouseObject();
                        if (myDelegate != null)
                        {
                            myDelegate.Invoke();
                        }
                        break;
                    case "установить режим":
                        SelectHauseObjectMode();
                        if (myDelegate != null)
                        {
                            myDelegate.Invoke();
                        }
                        break;
                    case "статус":
                        ShowStatuSHouseObject();
                        if (myDelegate != null)
                        {
                            myDelegate.Invoke();
                        }
                        break;
                    case "ремонт":
                        RepareHouseObject();
                        if (myDelegate != null)
                        {
                            myDelegate.Invoke();
                        }
                        break;
                    case "quit":
                        value = false;
                        break;
                }
            }
        }

    }
    class OwnerUser : GuestUser
    {

        public OwnerUser(Handler handler)
            : base(handler)
        {

            this.handler = handler;
        }
        protected override void SelectHauseObjectMode()
        {
             myDelegate = new MyDelegate(handler.SelectModeHandler);
        }
    }
    class Master : GuestUser
    {
        public Master(Handler handler)
        : base(handler)
        {
            this.handler = handler;
            
        }
        protected override void UseHouseObject()
        {
            Console.WriteLine("Вы не можете использовать обьект");
            myDelegate = null;
        }
        protected override void SelectHauseObjectMode()
        {
            myDelegate = new MyDelegate(handler.SelectModeHandler);
        }
        protected override void RepareHouseObject()
        {
            myDelegate = new MyDelegate(handler.RepairHandler);
        }

    }
   
}
