using System;
using System.Collections.Generic;
using System.Text;
using TREESTRUCTURE.DB.Entities;

namespace TREESTRUCTURE.DB.Repositories.Interfaces
{
    public interface INodesRepo
    {
        bool SaveChanges();

        IEnumerable<Node> GetAllNodes();
        Node GetNodeById(long id);
        void CreateNode(Node node);
        void UpdateNode(Node node);
        void DeleteNode(Node node);
        IEnumerable<Node> GetNames();
    }
}
