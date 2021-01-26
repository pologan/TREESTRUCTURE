using System;
using System.Collections.Generic;
using System.Text;

namespace TREESTRUCTURE.DB.Messages.DTOs
{
    class NodeEditDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public List<NodeDTO> ChildNodes { get; set; }
    }
}
