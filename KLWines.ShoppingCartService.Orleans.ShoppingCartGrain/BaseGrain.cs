﻿using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLWines.ShoppingCartService.Orleans.ShoppingCartGrain
{
    public abstract class BaseGrain : Grain
    {
        protected readonly IEventStore EventStore;

    }
}
