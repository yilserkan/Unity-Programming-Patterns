namespace ProgrammingPatterns.Patterns.Command_Pattern.Scripts
{
    public class ScaleCommand : Command
    {
        private float _scaleInput;
    
        public ScaleCommand(IEntity entity, int scaleInput) : base(entity)
        {
            _scaleInput = scaleInput == 1f ? 1.1f : 0.9f;
        }

        public override void Execute()
        {
            _entity.transform.localScale *= _scaleInput;
        }

        public override void Undo()
        {
            _entity.transform.localScale /= _scaleInput;
        }
    }
}
