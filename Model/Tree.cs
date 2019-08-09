using System;
using System.Collections.Generic;

namespace UnorderedListToTree.Model
{
    public class Tree
    {
        public string Parent { get; set; }

        public IList<Tree> Children { get; set; } = new List<Tree>();
    }
}
