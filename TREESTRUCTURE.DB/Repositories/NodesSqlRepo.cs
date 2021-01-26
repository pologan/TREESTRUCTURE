using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TREESTRUCTURE.DB.DAL;
using TREESTRUCTURE.DB.Entities;
using TREESTRUCTURE.DB.Repositories.Shared;

namespace TREESTRUCTURE.DB.Repositories
{
    public class NodesSqlRepo : INodesRepo
    {
        private TreeContext _context;
        public NodesSqlRepo(TreeContext context)
        {
            _context = context;
        }

        public void CreateNode(Node node)
        {
            _context.Nodes.Add(node);
        }

        public void DeleteNode(Node node)
        {
            _context.Nodes.Remove(node);
        }

        public IEnumerable<Node> GetAllNodes()
        {
            return _context.Nodes.ToList();
        }

        public Node GetNodesById(long id)
        {
            return _context.Nodes.Find(id);
        }

        public bool SaveChanges()
        {
            _context.SaveChanges();
            return true;
        }

        public void UpdateNode(Node node)
        {
            _context.Nodes.Update(node);
        }
    }
}
