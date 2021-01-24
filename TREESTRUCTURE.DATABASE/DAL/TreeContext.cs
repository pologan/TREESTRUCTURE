using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TREESTRUCTURE.DATABASE.Entities;

namespace TREESTRUCTURE.DATABASE.DAL
{
    class TreeContext : DbContext
    {
        public TreeContext(DbContextOptions<TreeContext> opt) : base(opt) { }

        public DbSet<Node> Nodes { get; set; }
    }
}
