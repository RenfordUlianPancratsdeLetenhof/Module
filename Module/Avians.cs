using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module
{
    public class Avians
    {

        public interface IFlyable
        {
            bool CanFly();
        }

        public interface ISwimmable
        {
            bool CanSwim();
        }

        public interface IRunnable
        {
            bool CanRun();
        }

        public class Bird
        {
            public string Type { get; set; }
        }

        public class RunningBird : Bird, IRunnable
        {
            public bool CanRun()
            {
                return true;
            }
        }

        public class SwimmingBird : Bird, ISwimmable
        {
            public bool CanSwim()
            {
                return true;
            }

        }

        public class FlyingBird : Bird, IFlyable
        {
            public bool CanFly()
            {
                return true;
            }

        }

        public class RunningSwimmingBird : Bird, IRunnable, ISwimmable
        {
            public bool CanRun()
            {
                return true;
            }

            public bool CanSwim()
            {
                return true;
            }
        }

        public class FlyingSwimmingBird : Bird, IFlyable, ISwimmable
        {
            public bool CanFly()
            {
                return true;
            }

            public bool CanSwim()
            {
                return true;
            }
        }
    }
}
