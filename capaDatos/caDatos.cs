using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using capaEntidad;
using System.Windows.Forms;

namespace capaDatos
{


    public class caDatos
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        SqlCommand cmd;

        public DataTable login(caEntidad enti)
        {
            con.Open();


            cmd = new SqlCommand("sp_loguear", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", enti.user);
            cmd.Parameters.AddWithValue("@contrasena", enti.contrasena);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public void insertar(caEntidad enti)
        {
            con.Open();

            cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", enti.user);
            cmd.Parameters.AddWithValue("@contrasena", enti.contrasena);
            cmd.Parameters.AddWithValue("@tipo_usuario", enti.tipo_usuario);
            cmd.Parameters.AddWithValue("@nombre", enti.Nombre);
            cmd.Parameters.AddWithValue("@apellido", enti.Apellido);
            cmd.Parameters.AddWithValue("@fecha", enti.Fecha);
            cmd.ExecuteNonQuery();



            con.Close();

        }

        public DataTable usuarios()
        {

            cmd = new SqlCommand("sp_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void editarUsuario(caEntidad enti)
        {
            con.Open();
            cmd = new SqlCommand("editarUsiario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", enti.id);
            cmd.Parameters.AddWithValue("@usuario", enti.user);
            cmd.Parameters.AddWithValue("@contrasena", enti.contrasena);
            cmd.Parameters.AddWithValue("@tipo_usuario", enti.tipo_usuario);
            cmd.Parameters.AddWithValue("@nombre", enti.Nombre);
            cmd.Parameters.AddWithValue("@apellido", enti.Apellido);
            cmd.Parameters.AddWithValue("@fechaNacimiento", enti.Fecha);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Seleccionar(ComboBox cb)
        {
            cb.Items.Clear();
            con.Open();
            cmd = new SqlCommand("sp_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }
            con.Close();
            cb.Items.Insert(0, "Seleccione el Usuario");
            cb.SelectedIndex = 0;
        }
        public DataTable BuscarUsuario(string user)
        {
            con.Open();
            cmd = new SqlCommand("buscarUsuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Usuario", user));
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public void EliminarUsuario(caEntidad enti)
        {
            con.Open();
            cmd = new SqlCommand("EliminarUsuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Usuario", enti.user));
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void InsertarVisitas(caEntidad enti)
        {
            con.Open();
            cmd = new SqlCommand("sp_visitantes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@nombre", enti.Nombre));
            cmd.Parameters.Add(new SqlParameter("@apellido", enti.Apellido));
            cmd.Parameters.Add(new SqlParameter("@carrera", enti.carrera));
            cmd.Parameters.Add(new SqlParameter("@correo", enti.correo));
            cmd.Parameters.Add(new SqlParameter("@fecha", enti.Fecha));
            cmd.Parameters.Add(new SqlParameter("@edifico", enti.edificio));
            cmd.Parameters.Add(new SqlParameter("@aula", enti.aula));
            cmd.Parameters.Add(new SqlParameter("@motivo", enti.motivo));
            cmd.Parameters.Add(new SqlParameter("@matricula", enti.matricula));
            cmd.Parameters.Add(new SqlParameter("@hora", enti.hora));
            cmd.Parameters.Add(new SqlParameter("@tipo", enti.tipo_usuario));
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void insertarEdificio(caEntidad enti)
        {
            con.Open();
            cmd = new SqlCommand("insertarEdificios", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@edificio", enti.edificio));
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void insertarAula(caEntidad enti)
        {
            con.Open();
            cmd = new SqlCommand("insertarAulas", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@aula", enti.aula));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SelectEdificio(ComboBox cb)
        {
            cb.Items.Clear();
            con.Open();
            cmd = new SqlCommand("sp_edificios", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }
            con.Close();
            cb.Items.Insert(0, "Edificio");
            cb.SelectedIndex = 0;
        }
        public void SelectAula(ComboBox cb)
        {
            cb.Items.Clear();
            con.Open();
            cmd = new SqlCommand("sp_Aula", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }
            con.Close();
            cb.Items.Insert(0, "Aula");
            cb.SelectedIndex = 0;
        }

        public DataTable ConsultarEdificos()
        {
            cmd = new SqlCommand("SP_ConsultarAulas", con);
           cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable BuscarEdificos(caEntidad enti)
        {
            cmd = new SqlCommand("SP_BuscarEdificio", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@edificio", enti.edificio));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ConsultarVisitas(caEntidad enti)
        {
            cmd = new SqlCommand("sp_Visitas", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@edificio", enti.edificio));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void selecionarConsulta(ComboBox cb)
        {
            cb.Items.Clear();
            con.Open();
            cmd = new SqlCommand("visitas", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[6].ToString());
            }
            con.Close();
            cb.Items.Insert(0, "Edificio");
            cb.SelectedIndex = 0;
        }
        public void ModificarEdificio(caEntidad enti)
        {
            con.Open();
            cmd = new SqlCommand("ModificarEdificio", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@edificio", enti.edificio));
            cmd.Parameters.Add(new SqlParameter("@id", enti.id));

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable verEdificios()
        {
            cmd = new SqlCommand("sp_edificios", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable verAulas()
        {
            cmd = new SqlCommand("sp_Aula", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable dondeEdificio(caEntidad enti)
        {
            cmd = new SqlCommand("dondeEdificio", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@edificio", enti.edificio));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable dondeAula(caEntidad enti)
        {
            cmd = new SqlCommand("dondeAula", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@aula", enti.aula));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void midificarAula(caEntidad enti)
        {
            con.Open();
            cmd = new SqlCommand("ModificarAula", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@aula", enti.aula));
            cmd.Parameters.Add(new SqlParameter("@id", enti.id));

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
