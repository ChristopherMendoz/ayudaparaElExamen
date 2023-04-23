using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca
{
    public class RegistroEstudiantes
    {

        public int NCarnet;
        public string Nombres;
        public string Apellidos;
        public string FechaDeIngreso;
        public string Direccion;
        public int Telefono;

        public RegistroEstudiantes(int nCarnet, string nombres, string apellidos, string fechaDeIngreso, string direccion, int telefono)
        {
            NCarnet = nCarnet;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaDeIngreso = fechaDeIngreso;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
    
}
