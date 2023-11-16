using Cosmos.System.Graphics;
using guos.GUI;
using System.Drawing;
using Sys = Cosmos.System;

namespace guos
{
    public class Kernel : Sys.Kernel
    {
        private static Canvas canvas;
        private mouse Mouse;
        protected override void BeforeRun()
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(800, 600, ColorDepth.ColorDepth32));
            Mouse = new mouse(canvas);
        }

        protected override void Run()
        {
            canvas.Clear(Color.White);
            Mouse.DrawCursor();
            canvas.Display();
        }
    }
}
