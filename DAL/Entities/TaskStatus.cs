using System.Collections.Generic;

namespace DAL.Entities
{
    public class TaskStatus : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}