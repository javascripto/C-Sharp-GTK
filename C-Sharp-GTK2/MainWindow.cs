using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnEntry1KeyReleaseEvent(object o, KeyReleaseEventArgs args)
    {
        if (args.Event.Key == Gdk.Key.Return)
        {
            changeText();
        }
    }

    protected void changeText()
    {
        string name = entry1.Text;
        label1.Text = $"Olá, {name}. Seja bem vindo!";
        button1.Visible = entry1.Visible = false;

        #pragma warning disable CS0612 // O tipo ou membro é obsoleto
        label1.SetUposition(55, 80);
        #pragma warning restore CS0612 // O tipo ou membro é obsoleto

        Console.WriteLine(label1.Text);
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        changeText();
    }
}
