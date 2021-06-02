using System;

namespace DAL.Entities
{
    public class Task : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime Deadline { get; set; }

        public int TaskStatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }
        
        public int TaskPriorityId { get; set; }
        public TaskPriority TaskPriority { get; set; }
        
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int EmployeeId { get; set; }
        public User Employee { get; set; }
    }
}