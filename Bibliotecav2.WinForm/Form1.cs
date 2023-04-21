using Bibliotecav2.Data;
using Bibliotecav2.Data.Model;
using System.Dynamic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bibliotecav2.WinForm
{
    public partial class Form1 : Form
    {
        BibliotecaContext bibliotecaContext = new BibliotecaContext();


        public Form1()
        {

            InitializeComponent();
            actualizarLibrosEliminar();
            ActualizarListaLibros();
            /* foreach (var libro in bibliotecaContext.Libros)
             {
                 if (libro.Autor == "Pepe")
                 {
                     libro.Autor = "María";
                     Libro cambioLibro = new Libro();
                     cambioLibro.Autor = libro.Autor;
                     bibliotecaContext.Libros.Update(cambioLibro);
                  }
                 MessageBox.Show(libro.Autor);
             }
             Libro nuevoLibro = new Libro();
             nuevoLibro.Autor = "Pepe";
             bibliotecaContext.Libros.Add(nuevoLibro);
             bibliotecaContext.SaveChanges();*/

        }

        private void actualizarLibrosEliminar()
        {
            librosParaEliminar.Items.Clear();
            foreach (var libro in bibliotecaContext.Libros)
            {
                librosParaEliminar.Items.Add(libro.NombreLibro);
            }
            ActualizarListaLibros();
        }

        private void ActualizarListaLibros()
        {
            listaLibrosActualizar.Items.Clear();
            foreach (var item in bibliotecaContext.Libros)
            {
                listaLibrosActualizar.Items.Add(item.NombreLibro);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarTodosLibros_Click(object sender, EventArgs e)
        {
            boxListaLibros.Items.Clear();
            foreach (var item in bibliotecaContext.Libros.Include(libro => libro.Genero))
            {
                boxListaLibros.Items.Add($"Libro: {item.NombreLibro}. Autor: {item.Autor}. " +
                    $"Año: {item.Annio.Year}. Género: {item.Genero.Nombre}");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(libro.Text) & !string.IsNullOrEmpty(autor.Text) &
                !string.IsNullOrEmpty(anni.Text))
            {
                Libro nuevoLibro = new Libro();
                nuevoLibro.NombreLibro = libro.Text;
                nuevoLibro.Autor = autor.Text;
                nuevoLibro.Annio = DateTime.ParseExact(anni.Text, "yyyy", null);
                // nuevoLibro.GeneroId = bibliotecaContext.Generos = from genero in bibliotecaContext.Generos where genero.Nombre == listaGeneros.Text select genero.GeneroId;
                switch (listaGeneros.Text)
                {
                    case "Fantasía":
                        nuevoLibro.GeneroId = 1;
                        break;
                    case "Terror":
                        nuevoLibro.GeneroId = 2;
                        break;
                    case "Comedia":
                        nuevoLibro.GeneroId = 3;
                        break;
                    case "Drama":
                        nuevoLibro.GeneroId = 4;
                        break;
                    case "Ciencia Ficción":
                        nuevoLibro.GeneroId = 5;
                        break;
                    default:
                        nuevoLibro.GeneroId = 6;
                        break;

                }
                bibliotecaContext.Libros.Add(nuevoLibro);
                bibliotecaContext.SaveChanges();
                boxListaLibros.Items.Clear();
                boxListaLibros.Items.Add("Nuevo libro añadido");
            }
            else
            {
                boxListaLibros.Items.Clear();
                boxListaLibros.Items.Add("No se pueden dejar campos vacíos");
            }
            actualizarLibrosEliminar();
        }

        private void EliminarLibro_Click(object sender, EventArgs e)
        {
            string titulo = librosParaEliminar.Text;
            if (!string.IsNullOrEmpty(titulo))
            {
                var eliminar = bibliotecaContext.Libros.FirstOrDefault(lbr => lbr.NombreLibro == titulo);
                if (eliminar != null)
                {
                    bibliotecaContext.Libros.Remove(eliminar);
                    bibliotecaContext.SaveChanges();
                }
                else
                {
                    MessageBox.Show("No es un libro válido");
                }

            }
            boxListaLibros.Items.Clear();
            boxListaLibros.Items.Add("Se ha eliminado libro");
            actualizarLibrosEliminar();
        }

        private void librosParaEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectUpdate_Click(object sender, EventArgs e)
        {

            string titulo = listaLibrosActualizar.Text;
            if (!string.IsNullOrEmpty(titulo))
            {
                var libro = bibliotecaContext.Libros.FirstOrDefault(lbr => lbr.NombreLibro == titulo);
                if (libro != null)
                {
                    libroUpdate.Clear();
                    libroUpdate.Text = libro.NombreLibro;
                    autorUpdate.Clear();
                    autorUpdate.Text = libro.Autor;
                    annioUpdate.Clear();
                    annioUpdate.Text = libro.Annio.Year.ToString();

                    switch (libro.GeneroId)
                    {
                        case 1:
                            listaGenerosUpdate.Text = "Fantasía";
                            break;
                        case 2:
                            listaGenerosUpdate.Text = "Terror";
                            break;
                        case 3:
                            listaGenerosUpdate.Text = "Comedia";
                            break;
                        case 4:
                            listaGenerosUpdate.Text = "Drama";
                            break;
                        case 5:
                            listaGenerosUpdate.Text = "Ciencia Ficción";
                            break;
                        default:
                            listaGenerosUpdate.Text = "No género";
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("No es un libro válido");
                }
                actualizarLibrosEliminar();
                listaGenerosUpdate.Items.Clear();
                listaGeneros.Items.Clear(); 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(libroUpdate.Text) & !string.IsNullOrEmpty(autorUpdate.Text) &
                !string.IsNullOrEmpty(annioUpdate.Text) & !string.IsNullOrEmpty(listaGenerosUpdate.Text))
            {

                var libroUpd = bibliotecaContext.Libros.FirstOrDefault(lbr => lbr.NombreLibro == listaLibrosActualizar.Text);
                libroUpd.NombreLibro = libroUpdate.Text;
                libroUpd.Autor = autorUpdate.Text;
                libroUpd.Annio = DateTime.ParseExact(annioUpdate.Text, "yyyy", null);
                switch (listaGenerosUpdate.Text)
                {
                    case "Fantasía":
                        libroUpd.GeneroId = 1;
                        break;
                    case "Terror":
                        libroUpd.GeneroId = 2;
                        break;
                    case "Comedia":
                        libroUpd.GeneroId = 3;
                        break;
                    case "Drama":
                        libroUpd.GeneroId = 4;
                        break;
                    case "Ciencia Ficción":
                        libroUpd.GeneroId = 5;
                        break;
                    default:
                        libroUpd.GeneroId = 6;
                        break;

                }
                bibliotecaContext.SaveChanges();
                boxListaLibros.Items.Clear();
                listaGenerosUpdate.Items.Clear();
                listaGeneros.Items.Clear(); 
                boxListaLibros.Items.Add("Libro actualizado");
                actualizarLibrosEliminar();
            }
        }

        
    }
}