﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AngouriMath
{
    internal static class Const
    {
        internal static readonly int PRIOR_SUM = 2;
        internal static readonly int PRIOR_MINUS = 2;
        internal static readonly int PRIOR_MUL = 4;
        internal static readonly int PRIOR_DIV = 4;
        internal static readonly int PRIOR_POW = 6;
        internal static readonly int PRIOR_FUNC = 8;
        internal static readonly int PRIOR_VAR = 10;
        internal static readonly int PRIOR_NUM = 2;
        internal static readonly string ARGUMENT_DELIMITER = ",";
        internal static OperatorEntity FuncIfSum(Entity child)
        {
            return new OperatorEntity("mulf", Const.PRIOR_MUL)
            {
                Children = new List<Entity> {
                    -1,
                    child
                    }
            };
        }
    }
}
