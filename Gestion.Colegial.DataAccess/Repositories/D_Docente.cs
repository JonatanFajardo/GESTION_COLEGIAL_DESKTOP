////using Gestion.Colegial.Commons.Clases;

namespace Gestion.Colegial.DataAccess.Clases
{
    public class D_Docente /*: Interfaces.ICRUD<E_Docente>*/
    {
        ////====================================================//
        ////                    INSTANCIACION
        ////====================================================//
        //private Conexion conexion = new Conexion();
        //private SqlCommand cmd;
        //private SqlDataReader reader;
        //private DataTable table;

        ////====================================================//
        ////                      METODOS   
        ////====================================================//
        //public DataTable sear(string sear)
        //{
        //    try
        //    {
        //        table = new DataTable();
        //        cmd = new SqlCommand("Catedraticos_Sear");
        //        cmd.Connection = conexion.AbrirConexion();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@Buscar", sear);
        //        reader = cmd.ExecuteReader();
        //        table.Load(reader);
        //        reader.Close();
        //        conexion.CerrarConexion();
        //        return table;
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show($"Error: Datos/Clases/D_Docente:Sear :--: {error.Message}");
        //        return null;
        //    }
        //}
        //public void delete(int delete)
        //{
        //    try
        //    {
        //        cmd = new SqlCommand("Catedraticos_Delete");
        //        cmd.Connection = conexion.AbrirConexion();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@VCat_Id", delete);
        //        cmd.ExecuteReader();
        //        cmd.Connection = conexion.CerrarConexion();
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show($"Error: Datos/Clases/D_Docente:Delete :--: {error}");
        //    }
        //}

        //public void insert(E_Docente entity)
        //{
        //    try
        //    {
        //        cmd = new SqlCommand("Catedraticos_Insert");
        //        cmd.Connection = conexion.AbrirConexion();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@VCat_PrimerNombre", entity.Cat_PrimerNombre);
        //        cmd.Parameters.AddWithValue("@VCat_SegundoNombre", entity.Cat_SegundoNombre);
        //        cmd.Parameters.AddWithValue("@VCat_PrimerApellido", entity.Cat_PrimerApellido);
        //        cmd.Parameters.AddWithValue("@VCat_SegundoApellido", entity.Cat_SegundoApellido);
        //        cmd.Parameters.AddWithValue("@VCat_Dni", entity.Cat_Dni);
        //        cmd.Parameters.AddWithValue("@VCat_CorreoElectronico", entity.Cat_CorreoElectronico);
        //        cmd.Parameters.AddWithValue("@VCat_NTelefono", entity.Cat_NTelefono);
        //        cmd.Parameters.AddWithValue("@VCat_Fecha_Nacimiento", entity.Cat_Fecha_Nacimiento);
        //        cmd.Parameters.AddWithValue("@VCat_Sexo", entity.Cat_Sexo);
        //        cmd.ExecuteNonQuery();
        //        cmd.Connection = conexion.CerrarConexion();
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show($"Error: Datos/Clases/D_Docente:Insert :--: {error.Message}");
        //    }
        //}
        //public void update(E_Docente entity)
        //{

        //    try
        //    {
        //        table = new DataTable();
        //        cmd = new SqlCommand("Catedraticos_Update");
        //        cmd.Connection = conexion.AbrirConexion();
        //        cmd.Parameters.AddWithValue("@VCat_PrimerNombre", entity.Cat_PrimerNombre);
        //        cmd.Parameters.AddWithValue("@VCat_SegundoNombre", entity.Cat_SegundoNombre);
        //        cmd.Parameters.AddWithValue("@VCat_PrimerApellido", entity.Cat_PrimerApellido);
        //        cmd.Parameters.AddWithValue("@VCat_SegundoApellido", entity.Cat_SegundoApellido);
        //        cmd.Parameters.AddWithValue("@VCat_Dni", entity.Cat_Dni);
        //        cmd.Parameters.AddWithValue("@VCat_CorreoElectronico", entity.Cat_CorreoElectronico);
        //        cmd.Parameters.AddWithValue("@VCat_NTelefono", entity.Cat_NTelefono);
        //        cmd.Parameters.AddWithValue("@VCat_Fecha_Nacimiento", entity.Cat_Fecha_Nacimiento);
        //        cmd.Parameters.AddWithValue("@VCat_Sexo", entity.Cat_Sexo);
        //        cmd.ExecuteNonQuery();
        //        cmd.Connection = conexion.CerrarConexion();
        //    }
        //    catch (Exception error)
        //    {

        //        MessageBox.Show($"Error: Datos/Clases/D_Docente:Update :--: {error.Message}");

        //    }
        //}


    }
}
