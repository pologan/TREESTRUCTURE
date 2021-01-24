using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TREESTRUCTURE.DB.Entities;

namespace TREESTRUCTURE.DB.DAL
{
    public class TreeContext : DbContext
    {
        public TreeContext(DbContextOptions<TreeContext> opt) : base(opt) { }

        public DbSet<Node> Nodes { get; set; }
    }
}
