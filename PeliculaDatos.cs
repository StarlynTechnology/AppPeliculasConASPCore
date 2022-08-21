using CrudAplicacion.Models;
using System.Data.SqlClient;
using System.Data;

namespace CrudAplicacion.Datos
{
    public class PeliculaModel
    {
        public List<PeliculaModel> Listar()
        {
            var oLista = new List<PeliculaModel>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Listar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new PeliculaModel() {
                            IdPelicula = Convert.ToInt32( dr["IdPelicula"]),
                            Pelicula = dr["Pelicula"].ToString(),
                            Categoria = dr["Categoria"].ToString(),
                            Actor = dr["Actor"].ToString()
                        });
                    }
                }
            }

            return oLista;
        }

        public PeliculaModel Obtener(int IdPelicula)
        {
            var oPelicula = new PeliculaModel();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Obtener", conexion);
                cmd.Parameters.AddWithValue("IdPelicula", IdPelicula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oPelicula.IdPelicula = Convert.ToInt32(dr["IdPelicula"]);
                        oPelicula.Pelicula = dr["Pelicula"].ToString();
                        oPelicula.Categoria = dr["Categoria"].ToString();
                        oPelicula.Actor = dr["Actor"].ToString();
                    }
                }
            }

            return oPelicula;
        }

        public bool Guardar(PeliculaModel oPelicula)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Guardar", conexion);
                    cmd.Parameters.AddWithValue("Pelicula", oPelicula.Pelicula);
                    cmd.Parameters.AddWithValue("Categoria", oPelicula.Categoria);
                    cmd.Parameters.AddWithValue("Actor", oPelicula.Actor);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
                rpta = true;
            }
            catch(Exception e)
            {
                string error = e.Message;
                rpta = false;
            }

            return rpta;
        }

        public bool Editar(PeliculaModel oPelicula)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Editar", conexion);
                    cmd.Parameters.AddWithValue("IdPelicula", oPelicula.IdPelicula);
                    cmd.Parameters.AddWithValue("Pelicula", oPelicula.Pelicula);
                    cmd.Parameters.AddWithValue("Categoria", oPelicula.Categoria);
                    cmd.Parameters.AddWithValue("Actor", oPelicula.Actor);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
                rpta = true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }

            return rpta;
        }

        public bool Eliminar(int IdPelicula)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Eliminar", conexion);
                    cmd.Parameters.AddWithValue("IdPelicula", IdPelicula);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
                rpta = true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }

            return rpta;
        }

    }
}





