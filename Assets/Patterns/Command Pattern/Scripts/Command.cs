namespace ProgrammingPatterns.Patterns.Command_Pattern.Scripts
{
    public abstract class Command
    {
        protected IEntity _entity;

        public Command(IEntity entity)
        {
            _entity = entity;
        }

        public abstract void Execute();
        public abstract void Undo();
    }
}
