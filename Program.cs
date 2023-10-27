using BridgeDesignPattern.RendererRepo;
using BridgeDesignPattern.Shape;

namespace BridgeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VectorRenderer vectorRenderer = new VectorRenderer();
            RasterRenderer rendererRenderer = new RasterRenderer();

            Circle circle = new Circle(vectorRenderer);
            Square square = new Square(rendererRenderer);
            circle.Draw();
            square.Draw();  
            Console.WriteLine("Completed");
        }
    }
}