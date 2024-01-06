using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanExamOOP
{
    /* 
     * Cannot get the Icomparable to work
     */
    internal abstract class BudgetItem : IComparable<DateTime> 
    {
        public int CompareTo(DateTime value)
        {
            if ()
        }
        public string[] BudgetItem 

        public string Name { get; set; }
        public decimal Amount { get; set; }

        public enum ItemType {Income, Expense }

        public DateTime Date { get; set; }

        public Boolean Recurring { get; set; }

        public BudgetItem(string name, decimal amount, Enum itemType, DateTime date, Boolean recurring)
        {
            Name = name;
            Amount = amount;           
            Date = date;
            Recurring = recurring;

        }
        /*
        public DateTime CompareTo (BudgetItem other) 
        { 
            
        }
        
        
        */
    }
   

}
