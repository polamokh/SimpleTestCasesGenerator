using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestcasesGenerator
{
    class Variable
    {
        string name;
        string assignmentVariable;
        bool isReturnValue;

        public Variable(string _name, string _assignemntVariable)
        {
            name = _name; assignmentVariable = _assignemntVariable; IsReturnValue = false;
        }

        public string Name { get => name; set => name = value; }
        public string AssignmentVariable { get => assignmentVariable; set => assignmentVariable = value; }
        public bool IsReturnValue { get => isReturnValue; set => isReturnValue = value; }
    }
}
