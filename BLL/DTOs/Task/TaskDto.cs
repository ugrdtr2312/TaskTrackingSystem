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
        public DateTime LastUpdate { get; set; }
        public DateTime Deadline { get; set; }
        public string TaskStatus { get; set; }
        public int TaskStatusId { get; set; }
        public string TaskPriority { get; set; }
        public int TaskPriorityId { get; set; }
        public int ProjectId { get; set; }
        public int? UserId { get; set; }
    }
}