using LPP.Nodes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LPP.Helpers
{
    /// <summary>
    /// The GraphHelper class helps the main class BinaryTree to construct tree graph.
    /// </summary>
    public static class GraphHelper
    {

        /// <summary>
        /// This method generates the graph tree.png that illustrates provided Binary Tree.
        /// </summary>
        public static string GenerateGraphFromTree(BinaryTree tree)
        {
            string fileName = GenerateFileInfoAboutTree(tree);
            string imageName = "tree.png";
            Process dot = new Process();
            dot.StartInfo.FileName = @"dot.exe";
            dot.StartInfo.Arguments = $"-Tpng -o{imageName} {fileName}";
            dot.Start();
            dot.WaitForExit();
            return imageName;
        }


        /// <summary>
        /// This method generates the file tree.dot that contains information about provided Binary Tree.
        /// </summary>
        private static string GenerateFileInfoAboutTree(BinaryTree tree)
        {
            string name = "tree.dot";
            List<string> text = new List<string>();
            text.Add("graph logic {");
            text.Add("  node [ fontname = \"Arial\" ]");
            PreOrderWalk(tree.Root, ref text, 1, 1);
            text.Add("}");
            System.IO.File.WriteAllLines(name, text);
            return name;
        }

        /// <summary>
        /// This method adds to the existing description info about connection between tree 
        /// nodes in preorder walk (Root - Left child- Right child) 
        /// </summary>
        private static void PreOrderWalk(Node node, ref List<string> text, int i_parent, int i)
        {
            if(node != null)
            {
                if (i > 1)
                {
                    text.Add($"  node{i_parent} -- node{i}");
                }
                text.Add($"  node{i} [ label = \" {node.Value} \" ]");
                // the index is always even for left children and odd for right, so the won't ever repeat
                PreOrderWalk(node.leftChild, ref text, i, i * 2);
                PreOrderWalk(node.rightChild, ref text, i, i * 2 + 1);
            }
        }
    }
}
