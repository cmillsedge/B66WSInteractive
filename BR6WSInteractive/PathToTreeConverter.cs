using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BR6WSInteractive
{
    public static class PathToTreeConverter
    {
        public static TreeNode MakeTreeFromPaths(List<string> paths, int imgIndex, string rootNodeName = "", char separator = '/')
        {
            var rootNode = new TreeNode(rootNodeName);
            foreach (var path in paths.Where(x => !string.IsNullOrEmpty(x.Trim())))
            {
                var currentNode = rootNode;
                var pathItems = path.Split(separator);
                foreach (var item in pathItems)
                {
                    var tmp = currentNode.Nodes.Cast<TreeNode>().Where(x => x.Text.Equals(item));
                    currentNode = tmp.Count() > 0 ? tmp.Single() : currentNode.Nodes.Add(item);
                    currentNode.ImageIndex = imgIndex;
                }
            }
            return rootNode;
        }
    }
}
