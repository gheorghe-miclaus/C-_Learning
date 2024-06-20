using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dog_class
{
    public class Dog
    {
        private string _name;
        private string _breed;
        private int _weight;

        public Dog(string name, string breed, int weight)
        {
            _name = name;
            _breed = breed;
            _weight = weight;
        }

        public Dog(string name, int weight)
        {   _name = name;
            _weight = weight;
            _breed = "mixed-breed";
         }

        public string Describe()
        {
            string description;

            switch (_weight)
            {
                case < 5:
                    description = "tiny";
                    break;
                case < 30:
                    description = "medium";
                    break;
                default:
                    description = "large";
                    break;
            }

            

            
            return string.Format("This dog is named {0}, it's a {1}, and it weighs {2} kilograms, so it's a {3} dog.", _name, _breed, _weight, description);
        }
    }
}
