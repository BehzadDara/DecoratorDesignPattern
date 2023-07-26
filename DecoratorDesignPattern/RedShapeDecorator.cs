namespace DecoratorDesignPattern
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape shape) : base(shape)
        {
        }

        public override void Move()
        {
            Console.Write("red shape: ");
            base.Move();
        }
    }
}
