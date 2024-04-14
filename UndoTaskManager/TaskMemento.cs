using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoTaskManager
{
    public class TaskMemento
    {
        public List<string> Tasks { get; private set; }

        public TaskMemento(List<string> tasks)
        {
            // Cria uma cópia profunda da lista de tarefas
            Tasks = new List<string>(tasks);
        }
    }
}
