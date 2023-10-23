using System;
using System.Text;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Marigolds;

public partial class MainWindow : Window
{
  private List<PassType> Options;

  private enum PassType
  {
    NUMBER,
    LETTER,
    SYMBOL
  }

  public MainWindow()
  {
      InitializeComponent();
      Options = new();
  }

  public void Generate(object sender, RoutedEventArgs args)
  {
    StringBuilder Password = new();

    if (Numbers.IsChecked ?? false)
    {
      Options.Add(PassType.NUMBER);
    }

    if (Letters.IsChecked ?? false)
    {
      Options.Add(PassType.LETTER);
    }

    if (Symbols.IsChecked ?? false)
    {
      Options.Add(PassType.SYMBOL);
    }

    for (int i = 0; i < Length.Value; i++)
    {
      switch (Options[new Random().Next(0, Options.Count)])
      {
        case PassType.NUMBER:
          Password.Append(new Random().GetDigit());
        break;

        case PassType.LETTER:
          Password.Append(new Random().GetLetter());
        break;

        case PassType.SYMBOL:
          Password.Append(new Random().GetSymbol());
        break;
      }
    }

    Clipboard.SetTextAsync(Password.ToString());
  }
}
