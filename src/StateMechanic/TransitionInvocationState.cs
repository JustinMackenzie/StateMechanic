﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMechanic
{
    internal struct TransitionInvocationState
    {
        public readonly int EventFireCount;

        public TransitionInvocationState(int eventFireCount)
        {
            this.EventFireCount = eventFireCount;
        }
    }
}