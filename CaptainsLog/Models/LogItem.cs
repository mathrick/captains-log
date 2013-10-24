using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CaptainsLog.Models
{
    /// <summary>
    /// LogItems are specific goods (such as a game, a book, or a film). 
    /// They represent the generic concept of content (such as "Lord of the Rings"), 
    /// without reference to specific instances like editions, formats, or particular copies.
    /// </summary>
    public class LogItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<ItemLink> links { get; set; }
    }

    public class LogItemDBContext : DbContext
    {
        public DbSet<LogItem> items { get; set; }
    }
}