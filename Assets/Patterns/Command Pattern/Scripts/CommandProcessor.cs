using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPatterns.Patterns.Command_Pattern.Scripts
{
    public class CommandProcessor : MonoBehaviour
    {
        private List<Command> _commands = new List<Command>();
        private int currentCommandIndex;
    
        public void ExecuteCommand(Command command)
        {
            _commands.Add(command);
            command.Execute();
            currentCommandIndex = _commands.Count - 1;
        }

        public void UndoCommand()
        {
            if (_commands.Count < 1)
            {
                return;
            }
            _commands[currentCommandIndex].Undo();
            _commands.RemoveAt(currentCommandIndex);
            currentCommandIndex--;
        }
    }
}
