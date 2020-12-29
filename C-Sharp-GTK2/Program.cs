using System;
using Gtk;

namespace CSharpGTK2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            moveWindowToCenter(win);
            win.Show();

            Application.Run();
        }

        public static void moveWindowToCenter(Window window)
        {
            var screen = window.GdkWindow.Screen;
            window.GdkWindow.GetSize(out int windowWidth, out int windowHeight);
            int positionX = (screen.Width / 2) - (windowWidth / 2);
            int positionY = (screen.Height / 2) - (windowHeight / 2);
            window.Move(positionX, positionY);

        }
    }

}
