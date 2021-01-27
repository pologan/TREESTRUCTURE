using System.Collections.Generic;

namespace TREESTRUCTURE.WEB.Messages.DTOs
{
    public class NodeEditDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public List<NodeDTO> ChildNodes { get; set; }
    }
}
