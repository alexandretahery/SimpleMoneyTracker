using MoneyTrackerDb.BLL;
using MoneyTrackerDb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTrackerDb
{
    public class Dataservice
    {
        //public IncomeController IncomeController { get; }
        public SpentController SpentController { get; }

        public Dataservice()
        {
            //IncomeController = new IncomeController();
            SpentController = new SpentController();
        }
    }
}
