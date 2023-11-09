using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module
{
    interface IFlyable
    {
        bool fly();
    }

    interface ISwimmable
    {
        bool swim();
    }

    interface IRunnable
    {
        bool run();
    }
    class Bird
    {
        public string Type { get; set; }
    }

    class Flying_bird : Bird, IFlyable
    {
        public bool fly()
        {
            return true;
        }
    }

    class Runing_bird : Bird, IRunnable
    {
        public bool run()
        {
            return true;
        }

    }
    class Swiming_bird : Bird, ISwimmable
    {
        public bool swim()
        {
            return true;
        }
    }

    class Duck : Flying_bird, Swiming_bird
    {
        public Duck(string name)
        {
            Name = name;
        }
    }

}
