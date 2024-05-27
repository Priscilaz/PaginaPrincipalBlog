
using PaginaPrincipalBlog.Models;
using PaginaPrincipalBlog.Resources;
using System.Collections.ObjectModel;

namespace PaginaPrincipalBlog;

public partial class Principal : ContentPage
{
	public ObservableCollection<Facultad> Facultades { get; set; }
    //Copia de la coleccion para mostrar las imagenes en un orden diferente
    public ObservableCollection<Facultad> Facultades2 { get; set; }
    public Principal()
	{
		InitializeComponent();
        //ModificarBarraBusqueda();
        InitializeFacultades();
        BindingContext = this;
	}

    private void InitializeFacultades()
    {
        Facultades = new ObservableCollection<Facultad>
        {
            new Facultad{Name= "FICA", ReadTime= new TimeSpan(0,30,0), Image= "fica.jpg"},
            new Facultad{Name= "Facultad de Medicina", ReadTime= new TimeSpan(0,30,0), Image= "medicina.jpg"},
            new Facultad{Name= "Facultad de Derecho", ReadTime= new TimeSpan(0,30,0), Image= "derecho.jpg"},
            new Facultad{Name= "Facultad de Arquitectura", ReadTime= new TimeSpan(0,30,0), Image= "arquitectura.jpg"},
            new Facultad{Name= "NODO", ReadTime= new TimeSpan(0,30,0), Image= "nodo.jpg"},
            new Facultad{Name= "Escuela de Música", ReadTime= new TimeSpan(0,30,0), Image= "musica.jpg"}
        };
        Facultades2 = new ObservableCollection<Facultad>
        {
            new Facultad{Name= "Clínica de Odontología", ReadTime= new TimeSpan(0,30,0), Image= "odontologia.jpg"},
            new Facultad{Name= "Escuela de Gastronomía", ReadTime= new TimeSpan(0,30,0), Image= "gastronomia.jpg"},
            new Facultad{Name= "Servicios de Psicología", ReadTime= new TimeSpan(0,30,0), Image= "psicologia.jpg"},
            new Facultad{Name= "Biblioteca", ReadTime= new TimeSpan(0,30,0), Image= "economia.jpg"},
            
        };
    }

    //private void ModificarBarraBusqueda()
    //{
    //    throw new NotImplementedException();
    //}

    //private void ClickInfo(object sender, EventArgs e)
    //{
    //    Navigation.PushAsync(new Principal());
    //}

   
}