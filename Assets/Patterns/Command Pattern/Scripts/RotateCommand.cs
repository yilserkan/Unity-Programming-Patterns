using UnityEngine;

namespace ProgrammingPatterns.Patterns.Command_Pattern.Scripts
{
    public class RotateCommand : Command
    {
        private int _direction;
    
        public RotateCommand(IEntity entity, int direction) : base(entity)
        {
            _direction = direction;
        }

        public override void Execute()
        {
            _entity.transform.Rotate(Vector3.forward, this._direction);
        }

        public override void Undo()
        {
            _entity.transform.Rotate(Vector3.forward, -this._direction);
        }
    }
}
