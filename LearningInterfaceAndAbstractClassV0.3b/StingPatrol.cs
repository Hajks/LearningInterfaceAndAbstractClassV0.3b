﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._3b
{
    public class StingPatrol: Worker, IStingPatrol
    {
        public void Alert()
        {
            int x = 5;
        }
    }
}
