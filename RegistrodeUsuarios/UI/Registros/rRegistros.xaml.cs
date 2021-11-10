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

namespace RegistrodeUsuarios.UI.Registros
{
    /// <summary>
    /// Interaction logic for rRegistros.xaml
    /// </summary>
    public partial class rRegistros : Window
    {
        private Usuarios usuario = new Usuarios();
        public rRegistros()
        {
            InitializeComponent();

            this.DataContext = usuario;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = UsuariosBLL.Guardar(usuario);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion exitosa!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsuariosBLL.Eliminar(Convert.ToInt32(UsuarioIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var encontrado = UsuariosBLL.Buscar(Convert.ToInt32(UsuarioIdTextBox.Text));

            if (usuario != null)
                this.usuario = encontrado;
            else
                Limpiar();

            this.DataContext = this.usuario;
        }


        private void Limpiar()
        {
            usuario = new Usuarios();
            ContrasenaPasswordBox.Password = string.Empty;
            ConfirmarContrasenaPasswordBox.Password = string.Empty;
            this.DataContext = usuario;
        }
        private bool Validar()
        {
            bool esValido = true;

            if (NombresTextBox.Text.Length == 0 || ApellidosTextBox.Text.Length == 0 || NombreUsuarioTextBox.Text.Length == 0 ||
                ContrasenaPasswordBox.Password.Length == 0 || ConfirmarContrasenaPasswordBox.Password.Length == 0)
            {
                esValido = false;
                GuardarButton.IsEnabled = false;
                MessageBox.Show("Completa el campo que está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                GuardarButton.IsEnabled = true;
            }

            if (ConfirmarContrasenaPasswordBox.Password != ContrasenaPasswordBox.Password)
            {
                esValido = false;
                GuardarButton.IsEnabled = false;
                MessageBox.Show("Las contraseñas no coiciden", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Warning);
                ConfirmarContrasenaPasswordBox.Focus();
                GuardarButton.IsEnabled = true;
            }

            return esValido;
        }

        private void NuevoButton_Click_1(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
    }
}





