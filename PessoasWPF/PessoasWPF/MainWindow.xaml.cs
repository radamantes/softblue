using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PessoasWPF
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {

    List<Pessoa> pessoas;

    public MainWindow()
    {
      InitializeComponent();
    }

    private void Window_Initialized(object sender, EventArgs e)
    {


      pessoas = new List<Pessoa>()
        {
          new Pessoa(){Nome="João", Sobrenome="Fernandes"},
          new Pessoa(){Nome="Diego", Sobrenome="Brito"},
          new Pessoa(){Nome="Raquel", Sobrenome="Watanabe"},
          new Pessoa(){Nome="Rafael", Sobrenome="Augusto"},
          new Pessoa(){Nome="Nathan", Sobrenome="Guimarães"}

        };


      //ADICIONANDO AO LISTBOX A LIST DE PESSOAS
      lstBox.ItemsSource = pessoas;
    }
  }
  public class Pessoa : INotifyPropertyChanged
  {

    //EVENTO QUE É DISPARADO TODA X QUE OS TEXT BOX FOREM ALTERADO
    public event PropertyChangedEventHandler PropertyChanged;

    private string nome;

    public string Nome
    {
      get { return nome; }
      set
      {
        nome = value;
        OnPropertyChanged("Nome");
        OnPropertyChanged("FullName");
      }
    }

    private string sobrenome;

    public string Sobrenome
    {
      get { return sobrenome; }

      set
      {
        sobrenome = value;
        OnPropertyChanged("Sobrenome");
        OnPropertyChanged("FullName");
      }
    }


    public string FullName
    {
      get { return Nome + " " + Sobrenome; }
    }

    private void OnPropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    //TEM QUE ESCREVER O METODO TOSTRING PARA QUE APARECA CORRETAMENTE NA LIST BOX - OU PODEMOS UTILIZAR TAMBÉM O DISPLAYMEMBERPATH NO XML PARA MOSTAR SOMENTE UM DADO
  }

}
