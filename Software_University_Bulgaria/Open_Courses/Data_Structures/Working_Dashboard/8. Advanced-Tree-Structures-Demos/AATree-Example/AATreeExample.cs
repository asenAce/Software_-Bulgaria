﻿using System;

class AATreeExample
{
    public static void Main()
    {
        var tree = new AATree<int, string>();
        Console.WriteLine("The AA tree created.");
        var nums = new[] { -5, 20, 14, 11, 8, -3, 111, 7, 100, -55 };
        for (int i = 0; i < nums.Length; i++)
        {
            AddNumber(tree, nums[i], "value " + nums[i]);
        }
    }

    public static void AddNumber(AATree<int, string> tree, int key, string value)
    {
        tree.Add(key, value);
        Console.WriteLine("Added " + key);

        DisplayTree(tree.Root, string.Empty);
        Console.WriteLine("----------------------");
    }

    private static void DisplayTree(AATree<int, string>.Node node, string intend)
    {
        Console.WriteLine(intend + node.key + " (level:" + node.level + ")");
        if (node.left.level != 0)
        {
            DisplayTree(node.left, intend + "  ");
        }
        if (node.right.level != 0)
        {
            DisplayTree(node.right, intend + "  ");
        }
    }
}
