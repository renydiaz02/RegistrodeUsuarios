using RegistrodeUsuarios.BLL;
using RegistrodeUsuarios.Entidades;
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

namespace RegistrodeUsuarios.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cConsulta.xaml
    /// </summary>
    public partial class cConsulta : Window
    {
        public cConsulta()
        {
            InitializeComponent();
        }

        private void BuscarCButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Usuarios>();

            switch (FiltroComboBox.SelectedIndex)
            {
                case 0: //Listado
                    listado = UsuariosBLL.GetUsuarios();
                    break;
            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}
