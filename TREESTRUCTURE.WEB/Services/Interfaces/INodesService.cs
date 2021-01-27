using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TREESTRUCTURE.WEB.Messages.DTOs;
using TREESTRUCTURE.WEB.Models;

namespace TREESTRUCTURE.WEB.Services.Shared
{
    public interface INodesService
    {
        NodeDTO GetNodeById(long id);
        List<NodeDTO> GetAllNodes();
        NodeDTO UpdateNode(NodeEditDTO request);
        List<NameTag> GetNameTags();
        NodeDTO RemoveNode(long id);
        NodeDTO AddNode(NodeAddDTO request);
    }
}
