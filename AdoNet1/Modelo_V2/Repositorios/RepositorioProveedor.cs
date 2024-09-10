using Microsoft.Data.SqlClient;
using Modelo_V2.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_V2.Repositorios
{
    public class RepositorioProveedor : Repositorio<Proveedor>
    {
        private static readonly Lazy<RepositorioProveedor> instancia = new Lazy<RepositorioProveedor>(()=>new RepositorioProveedor());
        public static RepositorioProveedor Instance=> instancia.Value;

        private RepositorioProveedor()
        {
            Recuperar();
        }

        protected override void Recuperar()
        {
            try
            {
                connection.Open();
                using var sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_RecuperarProveedores";
                var dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Proveedor proveedor = new Proveedor();
                    proveedor.Cuit = int.Parse(dr["Cuit"].ToString());
                    proveedor.RazonSocial = dr["RazonSocial"].ToString();
                    proveedor.Telefono = int.Parse(dr["Telefono"].ToString());
                    proveedor.Direccion = dr["Direccion"].ToString();

                    base.Agregar(proveedor);
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
            }
        }

        public override bool Agregar(Proveedor proveedor)
        {
            var incersion = false;
            connection.Open();
            var transaction = connection.BeginTransaction();

            try
            {
                using SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Transaction = transaction;
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_AgregarProveedor";
                sqlCommand.Parameters.Add("@Cuit",System.Data.SqlDbType.Int,15).Value=proveedor.Cuit;
                sqlCommand.Parameters.Add("@RazonSocial",System.Data.SqlDbType.NVarChar,15).Value=proveedor.RazonSocial;
                sqlCommand.Parameters.Add("@Telefono",System.Data.SqlDbType.Int,15).Value=proveedor.Telefono;
                sqlCommand.Parameters.Add("@Direccion",System.Data.SqlDbType.NVarChar,15).Value=proveedor.Direccion;
                sqlCommand.ExecuteNonQuery();

                transaction.Commit();
                connection.Close();
                base.Agregar(proveedor);
                incersion = true;
            }
            catch
            {
                transaction.Rollback();
                connection.Close();
            }
            return incersion;
        }

        public override bool Modificar(Proveedor entidad)
        {
            return false;
        }
    }
}
