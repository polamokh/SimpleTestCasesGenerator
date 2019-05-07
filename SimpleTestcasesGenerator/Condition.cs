using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestcasesGenerator
{
    class Condition
    {
        string type;
        string left;
        string right;
        string opera;
        string body;

        public Condition(string _type, string _opera)
        {
            type = _type;
            opera = _opera;
        }

        public Condition(string _type,string _left, string _opera, string _right)
        {
            type = _type;
            left = _left;
            opera = _opera;
            right = _right;
        }

        public string Type { get => type; set => type = value; }
        public string Left { get => left; set => left = value; }
        public string Right { get => right; set => right = value; }
        public string Opera { get => opera; set => opera = value; }
        public string Body { get => body; set => body = value; }
    }
}
