using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        public Formulario()
        {
            InitializeComponent();
            this.Title = "Formulario";
        }
        async void listSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var nombre = txtNombre.Text;
            var apellidos =txtApellidos.Text;
            var direccion = txtDireecion.Text;
            var telefono = txtTelefono.Text;
            var carrera = txtCarrera.Text;
            var semestre = txtSemestre.Text;
            var matricula = txtMatricula.Text;
            var correo = txtCorreo.Text;
            var git = txtGitHub.Text;
            var ans = await DisplayAlert("Recoleccion de los Datos ", "Datos Personales \n" + "Nombre: " + nombre + "\n" + "Apellidos: " + apellidos + "\n" + "Direccion: " + direccion
                + "\n" + "Telefono: " + telefono + "\n" + "Datos Escolares \n" + "Carrera: " + carrera + "\n" + "Semestre : " + semestre
                + "\n" + "Matricula: " + matricula + "\n" + "Datos Sociales \n" + "Correo: " + correo + "\n" + "GitHub: " + git, "Yes", "No");
            if (ans == true)
            {
                await Navigation.PushAsync(new Calculadora());
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtCarrera.Text = "";
                txtDireecion.Text = "";
                txtTelefono.Text = "";
                txtCarrera.Text = "";
                txtSemestre.Text = "";
                txtMatricula.Text = "";
                txtCorreo.Text = "";
                txtGitHub.Text = "";
            }
            else
            {
                
            }
        }
    }
}