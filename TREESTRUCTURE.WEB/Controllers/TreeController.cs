using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TREESTRUCTURE.WEB.Messages.DTOs;
using TREESTRUCTURE.WEB.Models;
using TREESTRUCTURE.WEB.Services.Shared;

namespace TREESTRUCTURE.WEB.Controllers
{
    public class TreeController : Controller
    {
        private readonly INodesService _service;
        private readonly IMapper _mapper;

        public TreeController(INodesService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<NodeDTO> GetAll()
        {

            return _service.GetAllNodes();
        }

        [HttpGet]
        public List<NameTag> GetNameTags()
        {
            return _service.GetNameTags();
        }

        [HttpGet]
        public IActionResult Delete([FromRoute] long id)
        {
            var result = _service.RemoveNode(id);

            if (!result.IsSuccess)
            {
                return BadRequest();
            }

            return Ok("Node Deleted Succesfully");
        }

        [HttpPost]
        public IActionResult Add([FromBody] NodeAddDTO node)
        {
            if (ModelState.IsValid)
            {
                var newNode = _service.AddNode(node);

                if (!newNode.IsSuccess)
                {
                    return BadRequest();
                }

                return Ok("Node added succesfully!");
            }

            return BadRequest();
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            var node = _service.GetNodeById(id);

            if (!node.IsSuccess)
            {
                return BadRequest();
            }

            var model = _mapper.Map<NodeEditDTO>(node);

            return Ok(model);
        }

        [HttpPost]
        public IActionResult Edit([FromBody] NodeEditDTO node)
        {
            if (ModelState.IsValid)
            {
                var editedNode = _service.UpdateNode(node);

                if (!editedNode.IsSuccess)
                {
                    return BadRequest();
                }

                return Ok("Node edited succesfully!");
            }

            return BadRequest();
        }
    }
}
