﻿using System.Collections.Generic;

namespace DPC.Model
{
    /// <summary>
    /// Class defines predicate
    /// </summary>
    public class Predicate : IFormulaNode
    {
        /// <summary>
        /// Children of predicate
        /// </summary>
        public IEnumerable<IFormulaNode> Children { get; set; }

        /// <summary>
        /// Dimention of predicate
        /// How many arguments can be be placed into the predicate
        /// </summary>
        public int Dimention { get; set; }

        /// <summary>
        /// Parent node in tree
        /// </summary>
        public IFormulaNode Parent { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parent"></param>
        public Predicate(Logical parent)
            :this()
        {
            Parent = parent;
        }

        /// <summary>
        /// Construct predicate
        /// </summary>
        public Predicate()
        {
            Children = new List<IFormulaNode>();
        }

    }
}