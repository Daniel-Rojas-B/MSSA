using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Interfaces
{
    internal abstract class AbstractClass
    {
        public void NormalMtehod()
        {

        }
        public virtual void VirtualMethod()
        {

        }
        public abstract void AbstractMethod();

    }
    class DerivedClass:AbstractClass
    {
        public override void AbstractMethod()
        {
            throw new NotImplementedException();
        }
        public override void VirtualMethod()
        {
            base.VirtualMethod();
        }

    }
    // multiple inheritance is not allowed
    class A:DerivedClass
    {

    }

}
