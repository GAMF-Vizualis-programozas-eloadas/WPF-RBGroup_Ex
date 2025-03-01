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
      rbSRed.Tag = Colors.Red;
			rbSBlue.Tag = Colors.Blue;
			rbSGreen.Tag = Colors.Green;
			rbERed.Tag = Colors.Red;
			rbEBlue.Tag = Colors.Blue;
			rbEGreen.Tag = Colors.Green;
		}
    Color cStart = Colors.Red;
    Color cStop = Colors.Blue;
    private void spStartColor_Click(object sender, RoutedEventArgs e)
    {
      RadioButton rbSource = (RadioButton)e.Source;// as RadioButton;
      cStart = (Color)rbSource.Tag;
      rtSample.Fill = new LinearGradientBrush(cStart, cStop, 0.0);
    }

    private void spEndColor_Click(object sender, RoutedEventArgs e)
    {
      RadioButton rbSource = (RadioButton)e.Source;
			cStop = (Color)rbSource.Tag;
      rtSample.Fill = new LinearGradientBrush(cStart, cStop, 0.0);
    }
  }

}
