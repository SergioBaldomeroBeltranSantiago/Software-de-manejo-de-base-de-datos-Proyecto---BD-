using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public class Conexion
    {
        public SqlConnection conexion;

        public static SqlConnection parametrizarConexion(string base_datos, string tabla_datos, string usuario, string contraseña)
        {
            string iniciador = @"Data Source = " + base_datos +
                ";Initial Catalog = " + tabla_datos +
                "; Integrated Security = True; User ID = " + usuario +
                "; Password = " + contraseña;
            return new SqlConnection(iniciador);
        }

        public static bool iniciarConexion(SqlConnection conexion)
        {
            if (conexion != null && conexion.State == ConnectionState.Closed)
            {
                try
                {
                    conexion.Open();
                    return true;
                }
                catch (Exception) {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void cerrarConexion(SqlConnection conexion)
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public static SqlDataReader obtenerRegistros(SqlConnection conexion, string tabla, string campofiltro, string filtro, string campoorden, string orden)
        {
            iniciarConexion(conexion);
            string query = "select * from " + tabla;
            if (!filtro.Equals("")) query = query + " where " + campofiltro + " = '" + filtro + "'";
            if (!orden.Equals("")) query = query + " order by " + campoorden + " " + orden;
            SqlCommand ElComando = new SqlCommand(query, conexion);
            SqlDataReader salida = ElComando.ExecuteReader();
            return salida;
        }

        public static List<string> obtenerValores(SqlConnection conexion, string tabla, string campofiltro, string filtro, string campoorden, string orden)
        {
            SqlDataReader valores = obtenerRegistros(conexion, tabla, campofiltro, filtro, campoorden, orden);
            List<string> listavalores = new List<string>();
            while (valores.Read())
            {
                for (int i = 0; i < valores.FieldCount; i++) {
                    listavalores.Add(valores[i].ToString());
                }
            }
            cerrarConexion(conexion);
            return listavalores;
        }


        public Conexion()
        {

        }

        public List<String> obtenerColumnasClientes()
        {
            var columnas = new List<String>();
            try
            {
                conexion.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='clientes'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    columnas.Add(registros.GetString(0));
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return columnas;
        }

        /*************************************************************\
        *                                                           *
        *                    Metodos de clientes                    *
        *                                                           *
        \*************************************************************/

        public SqlDataReader obtenerClientes(String filtro, String orden)
        {
            string query = "";
            string queryFiltro = "";
            string queryOrden = "";
            conexion.Open();

            if (!orden.Equals(""))
            {
                queryOrden = " order by " + orden + " asc";
                if (!filtro.Equals(""))
                {
                    queryFiltro = " WHERE " + orden + " like '%" + filtro + "%'";


                }
            }
            query = "SELECT * FROM CLIENTES" + queryFiltro + queryOrden;
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }

        // ------------------- Uso de procedimiento almacenado ---------------
        public String insertarCliente(String clave_cliente, String nombre, String direccion, String telefono)
        {
            try
            {

                conexion.Open();
                String query = "EXEC INSERTAR_CLIENTE_VALIDO '" + clave_cliente + "','" + nombre + "','" + direccion + "','" + telefono + "' , '' ";
                //string query = "INSERT INTO CLIENTES (clave_cliente, nombre, direccion, telefono)VALUES ('" + clave_cliente + "','" + nombre + "','" + direccion + "','" + telefono + "' )";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registros = comando.ExecuteReader();
                String respuesta = "Error al insertar cliente";
                while (registros.Read())
                {
                    //Regresar mensaje del procedimiento almacenado
                    respuesta = registros.GetString(0);
                }
                return respuesta;
            }
            catch (SqlException ex)
            {
                return ex.Message;
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<String> obtenerClientePorId(String clave)
        {
            var cliente = new List<String>();
            try
            {
                conexion.Open();
                string query = "select clave_cliente, nombre, direccion,telefono FROM CLIENTES WHERE clave_cliente = '" + clave + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    cliente.Add(registros["clave_cliente"].ToString());
                    cliente.Add(registros["nombre"].ToString());
                    cliente.Add(registros["direccion"].ToString());
                    cliente.Add(registros["telefono"].ToString());
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return cliente;
        }

        public String modificarCliente(String nombre, String direccion, String telefono, String clave)
        {
            try
            {
                conexion.Open();
                var query = "UPDATE CLIENTES set nombre = '" + nombre + "', direccion = '" + direccion + "', telefono = '" + telefono + "' WHERE clave_cliente = '" + clave + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                return "Cliente modificado correctamente";

            }
            catch (SqlException ex)
            {

                return ex.Message;
            }
            finally
            {
                conexion.Close();
            }
        }

        public String eliminarCliente(String clave_cliente)
        {
            try
            {

                conexion.Open();
                string query = "DELETE FROM CLIENTES WHERE clave_cliente = '" + clave_cliente + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                return "El cliente se eliminò correctamente";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    return "No sé puede eliminar este usuario debido a que está relacionado";
                }
                return ex.Message;
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        /*************************************************************\
         *                                                           *
         *                    Metodos de articulos                   *
         *                                                           *
        \*************************************************************/

        public SqlDataReader obtenerArticulos(String filtro, String orden)
        {
            string query = "";
            string queryFiltro = "";
            string queryOrden = "";
            conexion.Open();

            if (!orden.Equals(""))
            {
                queryOrden = " order by " + orden + " asc";
                if (!filtro.Equals(""))
                {
                    queryFiltro = " WHERE " + orden + " like '%" + filtro + "%'";


                }
            }
            query = "SELECT * FROM ARTICULOS" + queryFiltro + queryOrden;
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }

        public String insertarArticulo(String clave_art, String costo, String descripcion, String marca, String modelo, String stock, String depto)
        {
            try
            {
                depto = obtenerClaveDepto(depto);
                conexion.Open();

                String query = "EXEC [INSERTAR_ARTICULO_VALIDO] " + int.Parse(clave_art) + "," + double.Parse(costo) + ",'" + descripcion + "','" + marca + "','" + modelo + "'," + int.Parse(stock) + ",'" + depto + "', '' ";
                //string query = "INSERT INTO CLIENTES (clave_cliente, nombre, direccion, telefono)VALUES ('" + clave_cliente + "','" + nombre + "','" + direccion + "','" + telefono + "' )";
                SqlCommand comando = new SqlCommand(query, conexion);
                Console.WriteLine(query);
                SqlDataReader registros = comando.ExecuteReader();
                String respuesta = "Error al insertar articulo";
                while (registros.Read())
                {
                    //Regresar mensaje del procedimiento almacenado
                    respuesta = registros.GetString(0);
                }
                return respuesta;
            }
            catch (SqlException ex)
            {
                return ex.Message;
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<String> obtenerColumnasArticulos()
        {
            var columnas = new List<String>();
            try
            {
                conexion.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='articulos'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    columnas.Add(registros.GetString(0));
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return columnas;
        }

        public List<String> obtenerArticuloPorId(String clave)
        {
            var cliente = new List<String>();
            try
            {
                conexion.Open();
                string query = "select * FROM ARTICULOS WHERE clave_art = '" + clave + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    cliente.Add(registros["clave_art"].ToString());
                    cliente.Add(registros["costo"].ToString());
                    cliente.Add(registros["descripcion"].ToString());
                    cliente.Add(registros["marca"].ToString());
                    cliente.Add(registros["modelo"].ToString());
                    cliente.Add(registros["stock"].ToString());
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return cliente;
        }

        public String modificarArticulo(String costo, String descripcion, String marca, String modelo, String depto, String stock, String clave)
        {
            try
            {
                depto = obtenerClaveDepto(depto);
                conexion.Open();
                var query = "UPDATE ARTICULOS set costo = " + double.Parse(costo) + ", descripcion = '" + descripcion + "', marca = '" + marca + "', modelo = '" + modelo + "', depto = '" + depto + "', stock = " + int.Parse(stock) + " WHERE clave_art = '" + clave + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                return "Articulo modificado correctamente";

            }
            catch (SqlException ex)
            {

                return ex.Message;
            }
            finally
            {
                conexion.Close();
            }
        }

        public String eliminarArticulo(String clave)
        {
            try
            {

                conexion.Open();
                string query = "DELETE FROM ARTICULOS WHERE clave_art = '" + clave + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                return "El articulo se eliminò correctamente";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    return "No sé puede eliminar este articulo debido a que está relacionado";
                }
                return ex.Message;
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        //En caso de que la conexion quede abierta cerramos la conexion
        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception)
            {

            }
        }

        public SqlDataReader obtenerDepartamentosArticulos()
        {
            string query = "";
            conexion.Open();

            query = "SELECT nombre FROM DEPARTAMENTO";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }

        public string obtenerClaveDepto(String nombre)
        {

            string clave = "";
            try
            {

                conexion.Open();
                Console.WriteLine("aqui si llega");
                string query = "SELECT depto FROM DEPARTAMENTO WHERE nombre = '" + nombre + "'";
                Console.WriteLine("el query es: " + query);
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    clave = registros["depto"].ToString();
                }
                conexion.Close();
                return clave;

            }
            catch (Exception)
            {
                return clave;
                throw;
            }


        }

        /*************************************************************\
         *                                                           *
         *                    Metodos de departamento                *
         *                                                           *
        \*************************************************************/

        public SqlDataReader obtenerDepartamentos(String filtro, String orden)
        {
            string query = "";
            string queryFiltro = "";
            string queryOrden = "";
            conexion.Open();

            if (!orden.Equals(""))
            {
                queryOrden = " order by " + orden + " asc";
                if (!filtro.Equals(""))
                {
                    queryFiltro = " WHERE " + orden + " like '%" + filtro + "%'";


                }
            }
            query = "SELECT * FROM DEPARTAMENTO" + queryFiltro + queryOrden;
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }

        public String insertarDepartamento(String clave_depto, String nombre)
        {
            try
            {
                conexion.Open();
                String query = "EXEC [INSERTAR_DEPTO_VALIDO] '" + clave_depto + "','" + nombre + "','' ";
                SqlCommand comando = new SqlCommand(query, conexion);
                Console.WriteLine(query);
                SqlDataReader registros = comando.ExecuteReader();
                String respuesta = "Error al insertar departamento";
                while (registros.Read())
                {
                    respuesta = registros.GetString(0);
                }
                return respuesta;
            }
            catch (SqlException ex)
            {
                return ex.Message;
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<String> obtenerColumnasDepartamento()
        {
            var columnas = new List<String>();
            try
            {
                conexion.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='Departamento'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    columnas.Add(registros.GetString(0));
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return columnas;
        }

        public List<String> obtenerDepartamentoPorId(String clave)
        {
            var cliente = new List<String>();
            try
            {
                conexion.Open();
                string query = "select * FROM Departamento WHERE depto = '" + clave + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    cliente.Add(registros["depto"].ToString());
                    cliente.Add(registros["nombre"].ToString());
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return cliente;
        }

        public String modificarDepartamento(String nombre, String clave)
        {
            try
            {
                conexion.Open();
                var query = "UPDATE DEPARTAMENTO set nombre = '" + nombre + "' WHERE depto = '" + clave + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                return "Departamento modificado correctamente";

            }
            catch (SqlException ex)
            {

                return ex.Message;
            }
            finally
            {
                conexion.Close();
            }
        }

        public String eliminarDepartamento(String clave)
        {
            try
            {

                conexion.Open();
                string query = "DELETE FROM DEPARTAMENTO WHERE depto = '" + clave + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                return "El departamento se eliminò correctamente";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    return "No sé puede eliminar este departamento debido a que está relacionado";
                }
                return ex.Message;
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        /*************************************************************\
         *                                                           *
         *                    Metodos de Pedidos                     *
         *                                                           *
        \*************************************************************/

        public SqlDataReader obtenerPedidos(String filtro, String orden)
        {
            string query = "";
            string queryFiltro = "";
            string queryOrden = "";
            conexion.Open();

            if (!orden.Equals(""))
            {
                queryOrden = " order by " + orden + " asc";
                if (!filtro.Equals(""))
                {
                    queryFiltro = " WHERE " + orden + " like '%" + filtro + "%'";


                }
            }
            query = "SELECT * FROM PEDIDOS" + queryFiltro + queryOrden;
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }

        public String insertarPedido(String clave_cli, String clave_art, String cantidad, String fecha)
        {
            try
            {
                conexion.Open();
                String query = "EXEC [INSERTAR_PEDIDOS_VALIDO] '" + clave_cli + "','" + clave_art + "','" + fecha + "'," + cantidad + " ,'','', '' ";
                SqlCommand comando = new SqlCommand(query, conexion);
                Console.WriteLine(query);
                SqlDataReader registros = comando.ExecuteReader();
                String respuesta = "Error al registrar el pedido";
                while (registros.Read())
                {
                    respuesta = registros.GetString(0);
                }
                return respuesta;
            }
            catch (SqlException ex)
            {
                return ex.Message;
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<String> obtenerColumnasPedidos()
        {
            var columnas = new List<String>();
            try
            {
                conexion.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='Pedidos'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    columnas.Add(registros.GetString(0));
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return columnas;
        }

        public SqlDataReader obtenerClientesPedidos()
        {
            string query = "";
            conexion.Open();

            query = "SELECT nombre FROM CLIENTES";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }

        public SqlDataReader obtenerArticulosPedidos()
        {
            string query = "";
            conexion.Open();

            query = "SELECT descripcion FROM Articulos";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }



    }
}
