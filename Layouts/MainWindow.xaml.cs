using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Layouts;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
  }

  private void Window_Loaded(object sender, RoutedEventArgs e)
  {
    InitToolbar();
    InitToolbox();
  }

  private void InitToolbox()
  {
    Toolbox.Children.Clear();
    var label = new Label()
    {
      Content = "Toolbox",
    };
    Grid.SetColumnSpan(label, 2);
    Toolbox.Children.Add(label);


    for (int i = 1; i < 6; i++)
    {
      var leftArrow = new Image()
      {
        Source = new BitmapImage(new Uri("Images\\left.png", UriKind.Relative)),
        Width = 20,
        Height = 20,
      };
      Grid.SetRow(leftArrow, i);
      Grid.SetColumn(leftArrow, 0);
      Toolbox.Children.Add(leftArrow);
    }


    createLabel("Label", 1, 1);
    createLabel("Button", 2, 1);
    createLabel("TextBox", 3, 1);
    createLabel("Image", 4, 1);
    createLabel("ListBox", 5, 1);

  }

  private void createLabel(string Text, int Row, int Column)
  {

    var label = new Label()
    {
      Content = Text,
      VerticalAlignment = VerticalAlignment.Center,
      HorizontalAlignment = HorizontalAlignment.Left,
    };
    Grid.SetRow(label, Row);
    Grid.SetColumn(label, Column);
    Toolbox.Children.Add(label);
  }

  private void InitToolbar()
  {
    ToolbarTop.Children.Clear();
    ToolbarTop.Children.Add(new Button()
    {
      Content = new Image() { Source = new BitmapImage(new Uri("Images\\left.png", UriKind.Relative)) },
      Width = 30,
      Height = 30,
      Margin = new Thickness(3),
    });
    ToolbarTop.Children.Add(new Button()
    {
      Content = new Image() { Source = new BitmapImage(new Uri("Images\\right.png", UriKind.Relative)) },
      Width = 30,
      Height = 30,
      Margin = new Thickness(3),
    });
    ToolbarTop.Children.Add(new Button()
    {
      Content = new Image() { Source = new BitmapImage(new Uri("Images\\open.png", UriKind.Relative)) },
      Width = 30,
      Height = 30,
      Margin = new Thickness(3),
    });
    ToolbarTop.Children.Add(new Button()
    {
      Content = new Image() { Source = new BitmapImage(new Uri("Images\\save.png", UriKind.Relative)) },
      Width = 30,
      Height = 30,
      Margin = new Thickness(3),
    });
    ToolbarTop.Children.Add(new Button()
    {
      Content = new Image() { Source = new BitmapImage(new Uri("Images\\save_all.png", UriKind.Relative)) },
      Width = 30,
      Height = 30,
      Margin = new Thickness(3),
    });
  }
}
