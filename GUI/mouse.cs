using Cosmos.System;
using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using Sys = Cosmos.System;

namespace guos.GUI
{
    public class mouse
    {
        private readonly Canvas _canvas;
        private readonly Pen pen;
        private Bitmap cursor;
        [ManifestResourceStream(ResourceName = "guos.res.cursor.bmp")] public static byte[] curs;
        public mouse(Canvas canvas)
        {
            _canvas = canvas;
            cursor = new Bitmap(curs);
        }
        public void DrawCursor()
        {
            MouseManager.ScreenWidth = (uint)_canvas.Mode.Columns;
            MouseManager.ScreenHeight = (uint)_canvas.Mode.Rows;

            int X = (int)MouseManager.X;
            int Y = (int)MouseManager.Y;

            _canvas.DrawImageAlpha(cursor, X, Y);
        }
    }
}
