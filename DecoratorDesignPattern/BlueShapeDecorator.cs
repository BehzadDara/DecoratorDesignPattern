namespace DecoratorDesignPattern
{
    public class BlueShapeDecorator : ShapeDecorator
    {
        public BlueShapeDecorator(IShape shape) : base(shape)
        {
        }

        public override void Move()
        {
            Console.Write("blue shape: ");
            base.Move();
        }
    }
}
