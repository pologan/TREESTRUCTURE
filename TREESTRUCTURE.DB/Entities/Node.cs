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
            ChangeName(name);
            ChangeParentId(parentId);
        }
        public void Update(string name, long? parentId)
        {
            this.ModifiedAt = DateTime.Now;
            ChangeName(name);
            ChangeParentId(parentId);
        }

        private void ChangeParentId(long? parentId)
        {
            this.ParentId = parentId;
        }

        private void ChangeName(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                this.Name = name;
            }
        }
    }
}
