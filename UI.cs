using Terminal.Gui;

namespace TerminalGuiUwpInputBug {

  public class UI {

    public readonly Toplevel TopView;

    public UI() {
      Application.Init();

      TopView = new Toplevel() {
        X = 0,
        Y = 0,
        Width = Dim.Fill(),
        Height = Dim.Fill()
      };

      var menu = new MenuBar(new[] {
        new MenuBarItem("_File", new[] {
          new MenuItem("_Close", "", Application.RequestStop)
        })
      });

      var window1 = new Window("Window1") {
        X = 0,
        Y = Pos.Bottom(menu),
        Width = Dim.Percent(50),
        Height = Dim.Fill(),
      };
      window1.Add(new ListView(new[] {"foo", "bar", "baz"}) {
        X = 0,
        Y = 0,
        Width = Dim.Fill(),
        Height = Dim.Fill(),
        CanFocus = true
      });

      var window2 = new Window("Window2") {
        X = Pos.Right(window1),
        Y = Pos.Bottom(menu),
        Width = Dim.Fill(),
        Height = Dim.Fill()
      };
      
      TopView.Add(menu, window1, window2);
    }

    public void Run() {
      Application.Run(TopView);
    }

  }

}
