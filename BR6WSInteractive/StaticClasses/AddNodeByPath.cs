using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioRails.Core.Api;
using BioRails.Core.Client;
using BioRails.Core.Model;

namespace BR6WSInteractive
{
    public static class AddNodeByPath
    {
        public static void AddPTypeNode(TreeView tview, string path, ParameterTypeAlias alias)
        {
            foreach (TreeNode tnode in tview.Nodes)
            {
                string nodePath = tnode.FullPath.Replace("\\", "/").Replace("BioRails Catalog", "");
                if (nodePath == path)
                {
                    TreeNode newNode = new TreeNode(alias.Name);
                    newNode.ImageIndex = 1;
                    newNode.Tag = alias;
                    tnode.Nodes.Add(newNode);
                    break;
                }

                checkPTypeChildren(tnode, path, alias);
            }

        }

        public static void AddProcNode(TreeView tview, string path, Folder process)
        {
            path = "/" + path;
            foreach (TreeNode tnode in tview.Nodes[0].Nodes)
            {
                string nodePath = tnode.FullPath.Replace("\\", "/").Replace("Outlines", "");
                if (nodePath == path)
                {
                    TreeNode newNode = new TreeNode(process.Name);
                    newNode.ImageIndex = 1;
                    newNode.Tag = process;
                    tnode.Nodes.Add(newNode);
                    break;
                }

            }

        }

        public static void checkPTypeChildren(TreeNode original, string path, ParameterTypeAlias alias)
        {
            foreach (TreeNode tnode in original.Nodes)
            {
                string nodePath = tnode.FullPath.Replace("\\", "/").Replace("BioRails Catalog", "");
                if (nodePath == path)
                {
                    TreeNode newNode = new TreeNode(alias.Name);
                    newNode.ImageIndex = 1;
                    newNode.Tag = alias;
                    tnode.Nodes.Add(newNode);
                    break;
                }

                checkPTypeChildren(tnode, path, alias);
            }
        }

        public static void AddLookupNode(TreeView tview, string path, Named dataElement)
        {
            foreach (TreeNode tnode in tview.Nodes)
            {
                string nodePath = tnode.FullPath.Replace("\\", "/").Replace("BioRails Catalog", "");
                if (nodePath == path)
                {
                    TreeNode newNode = new TreeNode(dataElement.Name);
                    newNode.ImageIndex = 2;
                    newNode.Tag = dataElement;
                    tnode.Nodes.Add(newNode);
                    break;
                }

                checkLookupChildren(tnode, path, dataElement);
            }

        }

        public static void checkLookupChildren(TreeNode original, string path, Named dataElement)
        {
            foreach (TreeNode tnode in original.Nodes)
            {
                string nodePath = tnode.FullPath.Replace("\\", "/").Replace("BioRails Catalog", "");
                if (nodePath == path)
                {
                    TreeNode newNode = new TreeNode(dataElement.Name);
                    newNode.ImageIndex = 2;
                    newNode.Tag = dataElement;
                    tnode.Nodes.Add(newNode);
                    break;
                }

                checkLookupChildren(tnode, path, dataElement);
            }
        }
    }
}
