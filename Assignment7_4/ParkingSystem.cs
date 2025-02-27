using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_4
{
    internal class ParkingSystem
    {
        private int[] slots;
        public ParkingSystem(int big, int medium, int small)
        {
            this.slots = new int[] {0, big, medium, small};
        }
        public bool AddCar(int CarType)
        {
            if (this.slots[CarType]>0)
            {
                this.slots[CarType]--;
                return true;
            }
            return false;
        }
    }
}
