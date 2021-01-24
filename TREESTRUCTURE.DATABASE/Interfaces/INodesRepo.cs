using System;
using System.Collections.Generic;
using System.Text;
using TREESTRUCTURE.DATABASE.Entities;

namespace TREESTRUCTURE.DATABASE.Interfaces
{
    public interface INodesRepo
    {
        bool SaveChanges();

        IEnumerable<Node> GetAllNodes();
        Node GetNodesById(long id);
        void CreateNode(Node node);
        void UpdateNode(Node node);
        void DeleteNode(Node node);
    }
}
