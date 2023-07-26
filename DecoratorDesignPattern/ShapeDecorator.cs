namespace DecoratorDesignPattern
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape _shape;

        public ShapeDecorator(IShape shape)
        {
            _shape = shape;
        }

        public virtual void Move()
        {
            _shape.Move();
        }
    }
}
