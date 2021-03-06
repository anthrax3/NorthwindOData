﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Northwind.EntityFramework.CodeFirst.Oracle;

namespace Northwind.ModelTests.Query
{
    [TestFixture]
    public class EntityFrameworkCodeFirstOracleTests : EntityFrameworkCodeFirstTests<NorthwindContext>
    {
        public override NorthwindContext CreateContext()
        {
            return new NorthwindContext("NorthwindContext.EF.CF.Oracle");
        }

        public override void DisposeContext(NorthwindContext context)
        {
            context.Dispose();
        }
    }
}
