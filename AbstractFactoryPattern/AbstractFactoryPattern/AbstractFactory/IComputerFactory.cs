﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public interface IComputerFactory
    {
        IComputeType ComputeType();
        IBrand Brand();
        IProcessor Processor();
    }
}
