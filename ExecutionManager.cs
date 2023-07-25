using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    public class ExecutionManager
    {
        public Dictionary<Operation, Func<int>> FuncExecute { get; set; } = new();
        private Func<int> _sumDelegate;
        private Func<int> _multiplyDelegate;
        private Func<int> _subtractDelegate;


       

        public void PopulateFunctions(Func<int> _sum, Func<int> _multiply, Func<int> _subtract)
         {
        _sumDelegate = _sum;
        _multiplyDelegate = _multiply;
        _subtractDelegate = _subtract;
        PrepareExecution();

        }
        public void PrepareExecution()
        {
            FuncExecute = new Dictionary<Operation, Func<int>>();
            FuncExecute.Add(Operation.Sum, _sumDelegate);
            FuncExecute.Add(Operation.Multiply, _multiplyDelegate);
            FuncExecute.Add(Operation.Subtract, _subtractDelegate);

        }
    }

}
