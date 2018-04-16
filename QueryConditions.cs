using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LauraStuffs
{
    //Create a generic function to be used by the ExpressionPredicateBuilder to create lambda expressions
    public class QueryConditions
    {    
        public object value;
        public OperatorComparer? comparer;
        public string[] properties;

        public QueryConditions(object value, OperatorComparer? comparer, params string[] properties)
        {
            this.value = value;
            this.comparer = comparer;
            this.properties = properties;
        }
    }
}
