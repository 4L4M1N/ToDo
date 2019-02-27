using System;
namespace ToDo.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  DateTime CreateDate { get; set; }
        public DateTime Time { get; set; }
        public bool Status { get; set; }

    }
}