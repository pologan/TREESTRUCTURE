using System;
using System.Collections.Generic;
using System.Text;
using TREESTRUCTURE.DATABASE.Entities.Shared;

namespace TREESTRUCTURE.DATABASE.Entities
{
    public class Node : BaseObject
    {
        public string Name { get; protected set; }
        public virtual List<Node> ChildNodes { get; protected set; }
        public long? ParentId { get; protected set; }
        public virtual Node ParentNode { get; protected set; }
        public Node(string name, long? parentId)
        {
            CreatedAt = DateTime.Now;
            ChangeName(name);
            ChangeParentId(parentId);
        }

        private void ChangeParentId(long? parentId)
        {
            throw new NotImplementedException();
        }

        private void ChangeName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
