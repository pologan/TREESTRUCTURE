using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TREESTRUCTURE.DB.Entities;
using TREESTRUCTURE.DB.Repositories.Interfaces;
using TREESTRUCTURE.WEB.Messages.DTOs;
using TREESTRUCTURE.WEB.Models;
using TREESTRUCTURE.WEB.Services.Shared;

namespace TREESTRUCTURE.WEB.Services
{
    public class NodesService : INodesService
    {
        private readonly INodesRepo _repository;
        private readonly IMapper _mapper;

        public NodesService(INodesRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public NodeDTO AddNode(NodeAddDTO node)
        {
            var newNode = new Node(node.Name, node.ParentId);

            try
            {
                _repository.CreateNode(newNode);
                _repository.SaveChanges();
            }
            catch (Exception)
            {
                return new NodeDTO { IsSuccess = false };
            }

            return new NodeDTO { IsSuccess = true };
        }

        public List<NodeDTO> GetAllNodes()
        {
            var nodes = _repository.GetAllNodes().ToList();
            return _mapper.Map<List<NodeDTO>>(nodes);
        }

        public NodeDTO GetNodeById(long id)
        {
            var node = _repository.GetNodeById(id);

            var response = _mapper.Map<NodeDTO>(node);
            response.IsSuccess = true;
            return response;
        }

        public List<NameTag> GetNameTags()
        { 
            var names = _repository.GetNames();

            return _mapper.Map<List<NameTag>>(names);
        }

        public NodeDTO RemoveNode(long id)
        {
            var node = _repository.GetNodeById(id);

            if(node == null)
            {
                return new NodeDTO { IsSuccess = false };
            }

            try
            {
                _repository.DeleteNode(node);
                _repository.SaveChanges();
            }
            catch(Exception)
            {
                return new NodeDTO { IsSuccess = false };
            }

            return new NodeDTO { IsSuccess = true };
        }

        public NodeDTO UpdateNode(NodeEditDTO node)
        {
            var updatedNode = _repository.GetNodeById(node.Id);

            if(node == null)
            {
                return new NodeDTO { IsSuccess = false };
            }

            updatedNode.Update(node.Name, node.ParentId);

            try
            {
                _repository.UpdateNode(updatedNode);
                _repository.SaveChanges();

            }
            catch (Exception)
            {
                return new NodeDTO { IsSuccess = false };
            }

            return new NodeDTO { IsSuccess = true };
        }
    }

}
