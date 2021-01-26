using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TREESTRUCTURE.DB.Entities.Shared
{
    public class BaseObject
    {
        [Key]
        public long Id { get; protected set; }
        [Required]
        public DateTime CreatedAt { get; protected set; }
        public DateTime ModifiedAt { get; protected set; }

    }
}
