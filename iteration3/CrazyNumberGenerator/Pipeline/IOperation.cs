﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrazyNumberGenerator.Pipeline
{
    public interface IOperation<T>
    {
        string Execute(int i);
    }
}
