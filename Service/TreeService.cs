using System.Collections.Generic;
using System.Linq;
using UnorderedListToTree.Model;

namespace UnorderedListToTree.Service
{
    public class TreeService
    {
        Tree finalTree = new Tree();

        public Tree GetTree(Dictionary<string, Tree> dict, List<Flat> flatList)
        {
            finalTree.Parent =  flatList.FirstOrDefault(a => a.Parent == a.Child).Parent;

            finalTree.Children = GetChildren(finalTree.Parent, dict, flatList);

            return finalTree;
        }

        private List<Tree> GetChildren(string parent, Dictionary<string, Tree> dict, List<Flat> flatList)
        {
            if (dict.ContainsKey(parent))
            {
                return dict[parent].Children.Select(a => new Tree
                {
                    Parent = a.Parent,
                    Children = GetChildren(a.Parent, dict, flatList)
                }).ToList();
            }

            return new List<Tree>();
        }
    }
}
