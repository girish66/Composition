﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace Composition
{
    [Export(typeof(ICustomerRepository))]
    public class InMemoryCustomerRepository : InMemoryQueryableRepositoryBase<Customer>, ICustomerRepository
    {
    }
}
