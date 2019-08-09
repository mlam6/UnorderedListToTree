using System.Collections.Generic;
using UnorderedListToTree.Model;

namespace UnorderedListToTree.Service
{
    public class DictionaryService
    {
        public Dictionary<string, Tree> CreateDictionary(List<Flat> flatList)
        {
            Dictionary<string, Tree> dict = new Dictionary<string, Tree>();

            foreach (Flat obj in flatList)
            {
                if (dict.ContainsKey(obj.Parent))
                {
                    dict[obj.Parent].Children.Add(new Tree
                    {
                        Parent = obj.Child
                    });
                }
                else
                {
                    dict.Add(obj.Parent, new Tree
                    {
                        Parent = obj.Parent
                    });

                    if (obj.Parent != obj.Child)
                    {
                        dict[obj.Parent].Children.Add(new Tree
                        {
                            Parent = obj.Child
                        });
                    }
                }
            }

            return dict;
        }
    }
}
