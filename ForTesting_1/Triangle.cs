using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ns_Triangle
{
    public class Triangle
    {
        private int _base;
        private int _height;
        
        public Triangle(int tBase, int tHeight) 
        {
            _base = tBase;
            _height = tHeight;
        }

        public int CalculateArea() 
        {
            return ((_base * _height)/2);
        }

        public string AsString()
        {
            return string.Format("Base is {0}, height is {1}",_base,_height);
        }
    }
}
