﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TREESTRUCTURE.DB.Messages.DTOs
{
    class NodeAddDTO
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
