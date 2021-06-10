using System.Collections.Generic;

namespace BLL.DTOs.Task
{
    public class TasksOfProject
    {
        public double PercentageOfCompletion { get; set; }
        public IEnumerable<TaskDto> Tasks { get; set; }
    }
}