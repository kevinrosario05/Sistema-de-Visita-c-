using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;
using System.Net.Http.Headers;
using System.Data;
using System.Windows.Forms;

namespace capaNegocios
{
    public class caNegocios
    {
        caDatos obj = new caDatos();
        public DataTable login(caEntidad enti)
        {
            return obj.login(enti);
        }

        public void insertar(caEntidad enti)
        {
            obj.insertar(enti);
        }
        public DataTable usuarios()
        {
            return obj.usuarios();
        }
        public void editarUsuario(caEntidad enti)
        {
            obj.editarUsuario(enti);
        }
        public void ConsultarUsuario(ComboBox cb)
        {
            obj.Seleccionar(cb);
        }
        public DataTable BuscarUsuario(string user)
        {
            return obj.BuscarUsuario(user);
        }
        public void EliminarUsuario(caEntidad enti)
        {
            obj.EliminarUsuario(enti);
        }

        public void InsertarVisitas(caEntidad enti)
        {
            obj.InsertarVisitas(enti);
        }
        public void insertarEdificio(caEntidad enti)
        {
            obj.insertarEdificio(enti);

        }
        public void insertarAula(caEntidad enti)
        {
            obj.insertarAula(enti);
        }

        public void seleccionarEdificio(ComboBox cb)
        {
            obj.SelectEdificio(cb);
        }
        public void seleccionarAula(ComboBox cb)
        {
            obj.SelectAula(cb);
        }
        public DataTable ConsultarEdificios()
        {
            return obj.ConsultarEdificos();
        }
        public DataTable BuscarEdificio(caEntidad enti)
        {
            return obj.BuscarEdificos(enti);
        }
        public DataTable consultarVisitas(caEntidad enti)
        {
            return obj.ConsultarVisitas(enti);
        }
        public void seleccionarConsulta(ComboBox cb)
        {
            obj.selecionarConsulta(cb);
        }
        public void ModificarEdificio(caEntidad enti)
        {
            obj.ModificarEdificio(enti);
        }
        public DataTable VerEdificio()
        {
            return obj.verEdificios();
        }
        public DataTable verAulas()
        {
            return obj.verAulas();
        }
       public DataTable dondeEdificio(caEntidad enti)
        {
            return obj.dondeEdificio(enti);
        }
        public DataTable dondeAula(caEntidad enti)
        {
            return obj.dondeAula(enti);
        }
        public void ModificarAulas(caEntidad enti)
        {
            obj.midificarAula(enti);
        }
    }
}
