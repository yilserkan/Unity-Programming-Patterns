using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputReader))]
[RequireComponent(typeof(CommandProcessor))]
public class Entity : MonoBehaviour, IEntity
{
    private InputReader _inputReader;
    private CommandProcessor _commandProcessor;
    void Awake()
    {
        _inputReader = GetComponent<InputReader>();
        _commandProcessor = GetComponent<CommandProcessor>();
    }

  
    void Update()
    {
        Vector3 direction = _inputReader.ReadInput();
        if (direction != Vector3.zero)
        {
            MoveCommand moveCommand = new MoveCommand(this, direction);
            _commandProcessor.ExecuteCommand(moveCommand);
        }

        if (_inputReader.ReadUndo())
        {
            _commandProcessor.UndoCommand();
        }

        int scaleInput = _inputReader.ReadScale();
        if (scaleInput != 0)
        {
            ScaleCommand scaleCommand = new ScaleCommand(this, scaleInput);
            _commandProcessor.ExecuteCommand(scaleCommand);
        }
    }
    
    public void MoveFromTo(Vector3 startPosition, Vector3 endPosition)
    {
        throw new System.NotImplementedException();
    }
}
