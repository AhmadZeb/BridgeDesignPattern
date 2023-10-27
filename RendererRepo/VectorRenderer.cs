using BridgeDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.RendererRepo
{
    public class VectorRenderer : IRenderer
    {
        public void Render()
        {
            Console.WriteLine("Rendering as Vector");
        }
    }
}
