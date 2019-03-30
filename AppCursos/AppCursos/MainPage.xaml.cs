using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCursos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            string dbPath = Path.
                Combine(Environment.
                GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "CursosDB.db3");

            Database db = new Database(dbPath);

            Curso nuevoCurso = new Curso
            {
                Nombre= NameEntry.Text,
                Formato = lblFormatoEntry.Text
            };

            // Registrar a la tabla cursos el nuevo registro.
          int resultado =  db.InsertarCurso(nuevoCurso);
            if (resultado > 0)
            {
                DisplayAlert("Ok", "Registro guardado", "Ok");
            }
        }
    }
}
