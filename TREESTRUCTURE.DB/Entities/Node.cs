using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TREESTRUCTURE.DB.Entities.Shared;

namespace TREESTRUCTURE.DB.Entities
{
    public class Node : BaseObject
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; protected set; }
        
        public virtual List<Node> ChildNodes { get; protected set; }
        public long? ParentId { get; protected set; }
        public virtual Node Parent { get; protected set; }
        public Node(string name, long? parentId)
        {
            CreatedAt = DateTime.Now;
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
            ParentId = parentId;
        }
        public void Update(string name, long? parentId)
        {
            this.ModifiedAt = DateTime.Now;
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
            ParentId = parentId;
        }
    }
}
