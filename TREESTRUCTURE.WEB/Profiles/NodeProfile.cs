using AutoMapper;
using TREESTRUCTURE.DB.Entities;
using TREESTRUCTURE.WEB.Messages.DTOs;
using TREESTRUCTURE.WEB.Models;

namespace TREESTRUCTURE.WEB.Profiles
{
    public class NodeProfile : Profile
    {
        public NodeProfile()
        {
            CreateMap<Node, NodeDTO>();
            CreateMap<Node, NodeEditDTO>();
            CreateMap<NodeDTO, NodeEditDTO>();
            CreateMap<Node, NameTag>();
        }
    }
}
