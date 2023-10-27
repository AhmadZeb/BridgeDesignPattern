using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeDesignPattern.Interfaces;
using BridgeDesignPattern.Interfaces.ShapeInterface;

namespace BridgeDesignPattern.Shape
{
    public class Circle : IShape
    {
        private readonly IRenderer _renderer;

        public Circle(IRenderer renderer)
        {
            _renderer = renderer;
        }
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
            _renderer.Render();
        }
    }
}
