using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum

    public class Employee
{//Enum are name constations, enum are also the enumariator.enum has fixed set of constant.
    //using enum keyword we can difined enum.   enum are type safe, enum are imprubed type safety.
    public enum month
    {
        Jan, Fab, March,April
    }
       public  static void Main()
        {
        foreach (var item in Enum.GetName(typeof(month)))//typof operator is used to get the type at complie time, it is always oprend type or parameter, typeof operatore does not allow to overload. 
        {
            //GetName
        }
        }
    }
}
