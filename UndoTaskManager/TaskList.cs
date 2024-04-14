using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoTaskManager
{
    public class TaskList
    {
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(string task)
        {
            tasks.Remove(task);
        }

        public TaskMemento Save()
        {
            return new TaskMemento(tasks);
        }

        public void Restore(TaskMemento memento)
        {
            if (memento != null)
            {
                tasks = memento.Tasks;
            }
        }

        public void DisplayTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }

}
