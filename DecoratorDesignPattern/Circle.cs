﻿namespace DecoratorDesignPattern
{
    public class Circle : IShape
    {
        public void Move()
            => Console.WriteLine("circle moved");
    }
}
