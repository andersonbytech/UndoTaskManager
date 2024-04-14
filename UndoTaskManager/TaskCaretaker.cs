using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoTaskManager
{
    public class TaskCaretaker
    {
        private List<TaskMemento> savedStates = new List<TaskMemento>();
        private int currentIndex = -1;

        public void SaveState(TaskList taskList)
        {
            while (savedStates.Count - 1 > currentIndex)
            {
                savedStates.RemoveAt(savedStates.Count - 1);
            }
            savedStates.Add(taskList.Save());
            currentIndex++;
        }

        public void Undo(TaskList taskList)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                taskList.Restore(savedStates[currentIndex]);
            }
        }

        public void Redo(TaskList taskList)
        {
            if (currentIndex + 1 < savedStates.Count)
            {
                currentIndex++;
                taskList.Restore(savedStates[currentIndex]);
            }
        }
    }
}
