using System;
using System.Collections.Generic;
using System.Text;

namespace TREESTRUCTURE.DB.Entities.Shared
{
    public class BaseObject
    {
        public long Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime ModifiedAt { get; protected set; }

    }
}
