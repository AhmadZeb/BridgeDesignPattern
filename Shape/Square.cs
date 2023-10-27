using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeDesignPattern.Interfaces;
using BridgeDesignPattern.Interfaces.ShapeInterface;

namespace BridgeDesignPattern.Shape
{
    public class Square : IShape
    {
        private readonly IRenderer _renderer;
        public Square(IRenderer renderer) 
        {
         _renderer = renderer;
        } 
        public void Draw()
        {
            Console.WriteLine("Drawing a Square");
            _renderer.Render();
        }
    }
}
