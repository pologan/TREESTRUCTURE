using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TREESTRUCTURE.DB.Messages.DTOs;

namespace TREESTRUCTURE.WEB.Services.Shared
{
    public interface INodesService
    {
        Task<NodeDTO> GetByIdAsync(long id);
        Task<List<NodeDTO>> GetAllAsync();
        Task<NodeDTO> UpdateAsync(NodeEditViewModel request);
        Task<List<NodeDTO>> GetSuggestions();
        Task<NodeDTO> RemoveAsync(long id);
        Task<NodeDTO> AddAsync(NodeAddViewModel request);
    }
}
