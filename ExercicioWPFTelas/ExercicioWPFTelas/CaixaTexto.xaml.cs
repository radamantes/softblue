using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExercicioWPFTelas
{
  /// <summary>
  /// Interaction logic for CaixaTexto.xaml
  /// </summary>
  public partial class CaixaTexto : Window
  {

    Brush statusBarOriginalColor;
    FontWeight statusBarOriginalWeight;

    public CaixaTexto()
    {
      InitializeComponent();

      // Grava o aspecto original do texto, para ser restaurado depois.
      statusBarOriginalColor = statusBar.Foreground;
      statusBarOriginalWeight = statusBar.FontWeight;
    }

    private void txtBlock_MouseEnter(object sender, MouseEventArgs e)
    {
      statusBar.Foreground = Brushes.Blue;
      statusBar.FontWeight = FontWeights.Bold;
    }

    private void txtBlock_MouseLeave(object sender, MouseEventArgs e)
    {
      statusBar.Foreground = statusBarOriginalColor;
      statusBar.FontWeight = statusBarOriginalWeight;
    }

    private void txtBoxDigitado_TextChanged(object sender, TextChangedEventArgs e)
    {
      txtBoxLeitura.Text = txtBoxDigitado.Text;
    }

    private void mnuSair_Click(object sender, RoutedEventArgs e)
    {
      Application.Current.Shutdown();
    }

    //statusBar.Foreground = Brushes.Blue;
    //statusBar.FontWeight = FontWeights.Bold;
  }
}
