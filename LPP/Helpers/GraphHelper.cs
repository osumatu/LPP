using LPP.Nodes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LPP.Helpers
{
    public class GraphHelper
    {

        public string GenerateGraphFromTree(BinaryTree tree)
        {
            string fileName = this.GenerateFileInfoAboutTree(tree);
            string imageName = "tree.png";
            Process dot = new Process();
            dot.StartInfo.FileName = @"dot.exe";
            dot.StartInfo.Arguments = $"-Tpng -o{imageName} {fileName}";
            dot.Start();
            dot.WaitForExit();
            return imageName;
        }

        private string GenerateFileInfoAboutTree(BinaryTree tree)
        {
            string name = "tree.dot";
            Node node = tree.Root;
            List<string> text = new List<string>();
            text.Add("graph logic {");
            text.Add("  node [ fontname = \"Arial\" ]");
            this.PreOrderWalk(tree.Root, ref text, 1, 1);
            text.Add("}");
            System.IO.File.WriteAllLines(name, text);
            return name;
        }

        private void PreOrderWalk(Node node, ref List<string> text, int i_parent, int i)
        {
            if(node != null)
            {
                if (i > 1)
                {
                    text.Add($"  node{i_parent} -- node{i}");
                }
                text.Add($"  node{i} [ label = \" {node.Value} \" ]");
                PreOrderWalk(node.leftChild, ref text, i, i * 2);
                PreOrderWalk(node.rightChild, ref text, i, i * 2 + 1);
            }
        }
    }
}
