using System;
using Shared.Enums;

namespace BLL.DTOs.Task
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime Deadline { get; set; }
        public TaskStatus TaskStatus { get; set; }
        public TaskPriority TaskPriority { get; set; }
        
        public int ProjectId { get; set; }
        
        public int? UserId { get; set; }
    }
}