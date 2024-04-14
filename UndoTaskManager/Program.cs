namespace UndoTaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskList taskList = new TaskList();
            TaskCaretaker caretaker = new TaskCaretaker();

            while (true)
            {
                Console.WriteLine("Escolha uma opção: Add (A), Remove (R), Undo (U), Redo (D), Show (S), Exit (E)");
                string command = Console.ReadLine().ToUpper();

                switch (command)
                {
                    case "A":
                        Console.WriteLine("Digite a tarefa para adicionar:");
                        string newTask = Console.ReadLine();
                        taskList.AddTask(newTask);
                        caretaker.SaveState(taskList);
                        break;
                    case "R":
                        Console.WriteLine("Digite a tarefa para remover:");
                        string removeTask = Console.ReadLine();
                        taskList.RemoveTask(removeTask);
                        caretaker.SaveState(taskList);
                        break;
                    case "U":
                        caretaker.Undo(taskList);
                        break;
                    case "D":
                        caretaker.Redo(taskList);
                        break;
                    case "S":
                        taskList.DisplayTasks();
                        break;
                    case "E":
                        return; // Sair do programa
                    default:
                        Console.WriteLine("Comando inválido!");
                        break;
                }
            }




        }
    }
}
