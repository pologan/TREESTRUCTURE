using System.Collections.Generic;
using TREESTRUCTURE.WEB.Messages.DTOs.Shared;

namespace TREESTRUCTURE.WEB.Messages.DTOs
{
    public class NodeDTO : BaseDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public List<NodeDTO> ChildNodes { get; set; }
    }
}
