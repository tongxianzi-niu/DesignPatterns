using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape decoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public void Draw()
        {
            decoratedShape.Draw();
        }
    }
}
