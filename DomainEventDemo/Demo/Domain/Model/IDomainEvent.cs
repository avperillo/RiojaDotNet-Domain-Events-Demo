﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Model
{
    public interface IDomainEvent
    {
        DateTime OcurredOn { get; }
    }
}
