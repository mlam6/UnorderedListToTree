using System;
using System.Collections.Generic;
using UnorderedListToTree.Model;

namespace UnorderedListToTree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Flat> flatList = new List<Flat>()
            {
                new Flat()
                {
                    Parent = "A",
                    Child = "A"
                },
                new Flat()
                {
                    Parent = "A",
                    Child = "B"

                },
                new Flat()
                {
                    Parent = "A",
                    Child = "C"

                },
                new Flat()
                {
                    Parent = "B",
                    Child = "D"

                },
                new Flat()
                {
                    Parent = "B",
                    Child = "E"
                },
                new Flat()
                {
                    Parent = "B",
                    Child = "F"
                },
                new Flat()
                {
                    Parent = "C",
                    Child = "G"
                },
                new Flat()
                {
                    Parent = "C",
                    Child = "H"
                },
                new Flat()
                {
                    Parent = "D",
                    Child = "I"
                },
                new Flat()
                {
                    Parent = "E",
                    Child = "J"
                },
                new Flat()
                {
                    Parent = "E",
                    Child = "K"
                },
                new Flat()
                {
                    Parent = "F",
                    Child = "L"
                },
                new Flat()
                {
                    Parent = "G",
                    Child = "M"
                },
                new Flat()
                {
                    Parent = "H",
                    Child = "N"
                },
                new Flat()
                {
                    Parent = "H",
                    Child = "O"
                },
                new Flat()
                {
                    Parent = "N",
                    Child = "P"
                },
                new Flat()
                {
                    Parent = "N",
                    Child = "Q"
                }
            };

            Service.DictionaryService dictionaryService = new Service.DictionaryService();

            Service.TreeService treeService = new Service.TreeService();

            Dictionary<string, Tree> dict = dictionaryService.CreateDictionary(flatList);

            Tree root = treeService.GetTree(dict, flatList);
        }
    }
}
