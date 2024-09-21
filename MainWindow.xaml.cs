using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RBGroup_Example
{
	public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }
    Color cStart = Colors.Red;
    Color cStop = Colors.Blue;
    private void spStartColor_Click(object sender, RoutedEventArgs e)
    {
      RadioButton rbSource = (RadioButton)e.Source;// as RadioButton;
      if (rbSource == rbSBlue)
      {
        cStart = Colors.Blue;
      }
      if (rbSource == rbSGreen)
      {
        cStart = Colors.Green;
      }
      if (rbSource == rbSRed)
      {
        cStart = Colors.Red;
      }
      rtSample.Fill = new LinearGradientBrush(cStart, cStop, 0.0);
    }

    private void spEndColor_Click(object sender, RoutedEventArgs e)
    {
      RadioButton rbSource = (RadioButton)e.Source;
      if (rbSource == rbEBlue)
      {
        cStop = Colors.Blue;
      }
      if (rbSource == rbEGreen)
      {
        cStop = Colors.Green;
      }
      if (rbSource == rbERed)
      {
        cStop = Colors.Red;
      }
      rtSample.Fill = new LinearGradientBrush(cStart, cStop, 0.0);
    }
  }

}
