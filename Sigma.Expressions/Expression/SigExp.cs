﻿using Sigma.Model;

namespace Sigma.Expressions
{
    /// <summary>
    ///     Defines Expression class interface
    /// </summary>
    public class SigExp
    {
        /// <summary>
        ///     Shortcut to build AND tree
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode And(IFormulaNode left, IFormulaNode right)
        {
            // create new logical node and return
            return new Logical
            {
                OpCode = OpCodes.And,
                Children = ChildrenBuilder.Transform(left, right)
            };
        }

        /// <summary>
        ///     Shortcut to build OR tree
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode Or(IFormulaNode left, IFormulaNode right)
        {
            // create new logical node and return
            return new Logical
            {
                OpCode = OpCodes.Or,
                Children = ChildrenBuilder.Transform(left, right)
            };
        }


        /// <summary>
        ///     Shortcut to build NOT tree
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode Not(IFormulaNode right)
        {
            return new Logical
            {
                OpCode = OpCodes.Not,
                Children = ChildrenBuilder.Transform(right)
            };
        }

        /// <summary>
        ///     Shortcut to build Equal predicate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode Equal(object left, object right)
        {
            return new Predicate
            {
                OpCode = OpCodes.Equal,
                Children = ChildrenBuilder.Transform(left, right)
            };
        }

        /// <summary>
        ///     Shortcut to build NotEqual predicate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode NotEqual(object left, object right)
        {
            return new Predicate
            {
                OpCode = OpCodes.NotEqual,
                Children = ChildrenBuilder.Transform(left, right)
            };
        }

        /// <summary>
        ///     Shortcut to build Less predicate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode Less(object left, object right)
        {
            return new Predicate
            {
                OpCode = OpCodes.Less,
                Children = ChildrenBuilder.Transform(left, right)
            };
        }

        /// <summary>
        ///     Shortcut to build Greater predicate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode Greater(object left, object right)
        {
            return new Predicate
            {
                OpCode = OpCodes.Greater,
                Children = ChildrenBuilder.Transform(left, right)
            };
        }

        /// <summary>
        ///     Shortcut to build LessOrEqual predicate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode LessOrEqual(object left, object right)
        {
            return new Predicate
            {
                OpCode = OpCodes.LessOrEqual,
                Children = ChildrenBuilder.Transform(left, right)
            };
        }

        /// <summary>
        ///     Shortcut to build GreaterOrEqual predicate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode GreaterOrEqual(object left, object right)
        {
            return new Predicate
            {
                OpCode = OpCodes.GreaterOrEqual,
                Children = ChildrenBuilder.Transform(left, right)
            };
        }

        /// <summary>
        ///     Shortcut to build HasSubstring predicate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode HasSubstring(object left, object right)
        {
            return new Predicate
            {
                OpCode = OpCodes.HasSubstring,
                Children = ChildrenBuilder.Transform(left, right)
            };
        }

        /// <summary>
        ///     Shortcut to build IsSubstring predicate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode IsSubstring(object left, object right)
        {
            return new Predicate
            {
                OpCode = OpCodes.IsSubstring,
                Children = ChildrenBuilder.Transform(left, right)
            };
        }

        /// <summary>
        ///     Shortcut to build In predicate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static IFormulaNode In(object left, object right)
        {
            return new Predicate
            {
                OpCode = OpCodes.In,
                Children = ChildrenBuilder.Transform(left, right)
            };
        }

        /// <summary>
        ///     Shortcut to build Between predicate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static IFormulaNode In(object left, object start, object end)
        {
            return new Predicate
            {
                OpCode = OpCodes.Between,
                Children = ChildrenBuilder.Transform(left, start, end)
            };
        }


        /// <summary>
        ///     Shortcut to build IsZero predicate
        /// </summary>
        /// <param name="left"></param>
        /// <returns></returns>
        public static IFormulaNode IsZero(object left)
        {
            return new Predicate
            {
                OpCode = OpCodes.IsZero,
                Children = ChildrenBuilder.Transform(left)
            };
        }

        /// <summary>
        ///     Shortcut to build Thruth predicate
        /// </summary>
        /// <returns></returns>
        public static IFormulaNode Truth()
        {
            return new Predicate
            {
                OpCode = OpCodes.Truth
            };
        }

        /// <summary>
        ///     Shortcut to build Falsehood predicate
        /// </summary>
        /// <returns></returns>
        public static IFormulaNode Falsehood()
        {
            return new Predicate
            {
                OpCode = OpCodes.Falsehood
            };
        }

        /// <summary>
        ///     Shortcut to build variable node
        /// </summary>
        /// <param name="variable"></param>
        /// <returns></returns>
        public static IFormulaNode Var(object variable)
        {
            return new Variable
            {
                Value = variable
            };
        }

        /// <summary>
        ///     Shortcut to build constant (literal) node
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IFormulaNode Const(object value)
        {
            return new Variable
            {
                Value = value
            };
        }
    }
}