using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {
        }

        public new void Draw()
        {
            base.decoratedShape.Draw();
            SetRedBorder(base.decoratedShape);
        }

        private void SetRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
