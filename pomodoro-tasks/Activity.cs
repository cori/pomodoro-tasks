using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pomodoro_tasks
{
    class Activity
    {
        public string Description { get; set; }
        public int EstimatedPomodoros { get; set; }
        public int ActualPomodoros { get; set; }
        public int Interruptions { get; set; }
        public bool IsActiveTask { get; set; }
        public bool IsCompleted { get; set; }

        public string MakeInsertStatement()
        {
            return string.Format(
                "insert into activities (activity_desc, estimated, actual, interruptions, is_active_task, is_completed) values ('{0}', {1}, {2}, {3}, {4}, {5})",
                Description, EstimatedPomodoros, ActualPomodoros, Interruptions, IsActiveTask ? 1 : 0, IsCompleted ? 1 : 0);
        }
    }
}
