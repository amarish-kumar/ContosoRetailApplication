﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ContosoRetail.SharedKernel.DataAccess.DataLoader
{
    public class SortExpressionCompiler<T> : ExpressionCompiler
    {

        public SortExpressionCompiler(bool guardNulls)
            : base(guardNulls)
        {
        }

        public Expression Compile(Expression target, IEnumerable<SortingInfo> clientExprList)
        {
            var dataItemExpr = CreateItemParam(typeof(T));
            var first = true;

            foreach (var item in clientExprList)
            {
                var selector = item.Selector;
                if (String.IsNullOrEmpty(selector))
                    continue;

                var accessorExpr = CompileAccessorExpression(dataItemExpr, selector);

                target = Expression.Call(typeof(Queryable), Utils.GetSortMethod(first, item.Desc), new[] { typeof(T), accessorExpr.Type }, target, Expression.Lambda(accessorExpr, dataItemExpr));
                first = false;
            }

            return target;
        }


    }
}
