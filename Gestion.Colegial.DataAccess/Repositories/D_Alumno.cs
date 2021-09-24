////using Gestion.Colegial.Commons.Clases;

namespace Gestion.Colegial.DataAccess.Clases
{
    public class D_Alumno /*: Interfaces.ICRUD<tbAlumnos>*/
    {
        ////====================================================//
        ////                    INSTANCIACION
        ////====================================================//
        //private Conexion conexion = new Conexion();
        //private SqlDataReader reader;
        //private DataTable table;
        //private SqlCommand cmd;

        ////====================================================//
        ////                      METODOS   
        ////====================================================//
        //public DataTable sear(string sear)
        //{
        //    try
        //    {
        //        table = new DataTable();
        //        cmd = new SqlCommand("Alumnos_Sear");
        //        cmd.Connection = conexion.AbrirConexion();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@Buscar", sear);
        //        reader = cmd.ExecuteReader();
        //        table.Load(reader);
        //        cmd.Connection = conexion.CerrarConexion();
        //        return table;
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show($"Error: Datos/Clases/D_Alumno:Sear :--: {error.Message}");
        //        return null;
        //    }
        //}
        //public void insert(tbAlumnos entidad)
        //{
        //    try
        //    {
        //        table = new DataTable();
        //        cmd = new SqlCommand("Alumnos_Insert");
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@VAlu_PrimerNombre", entidad.Alu_PrimerNombre);
        //        cmd.Parameters.AddWithValue("@VAlu_SegundoNombre", entidad.Alu_SegundoNombre);
        //        cmd.Parameters.AddWithValue("@VAlu_PrimerApellido", entidad.Alu_PrimerApellido);
        //        cmd.Parameters.AddWithValue("@VAlu_SegundoApellido", entidad.Alu_SegundoApellido);
        //        cmd.Parameters.AddWithValue("@VAlu_Dni", entidad.Alu_Dni);
        //        cmd.Parameters.AddWithValue("@VAlu_CorreoElectronico", entidad.Alu_CorreoElectronico);
        //        cmd.Parameters.AddWithValue("@VAlu_NTelefono", entidad.Alu_NTelefono);
        //        cmd.Parameters.AddWithValue("@VAlu_Fecha_Nacimiento", entidad.Alu_Fecha_Nacimiento);
        //        cmd.Parameters.AddWithValue("@VAlu_Sexo", entidad.Alu_Sexo);
        //        cmd.ExecuteNonQuery();
        //        cmd.Connection = conexion.CerrarConexion();     
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show($"Error: Datos/Clases/D_Alumno:Insert :--: {error.Message}");
        //    }
        //}

        //public void update(tbAlumno entidad)
        //{
        //    try
        //    {
        //        table = new DataTable();
        //        cmd = new SqlCommand("Alumnos_Update");
        //        cmd.Connection = conexion.AbrirConexion();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@VAlu_PrimerNombre", entidad.Alu_PrimerNombre);
        //        cmd.Parameters.AddWithValue("@VAlu_SegundoNombre", entidad.Alu_SegundoNombre);
        //        cmd.Parameters.AddWithValue("@VAlu_PrimerApellido", entidad.Alu_PrimerApellido);
        //        cmd.Parameters.AddWithValue("@VAlu_SegundoApellido", entidad.Alu_SegundoApellido);
        //        cmd.Parameters.AddWithValue("@VAlu_Dni", entidad.Alu_Dni);
        //        cmd.Parameters.AddWithValue("@VAlu_CorreoElectronico", entidad.Alu_CorreoElectronico);
        //        cmd.Parameters.AddWithValue("@VAlu_NTelefono", entidad.Alu_NTelefono);
        //        cmd.Parameters.AddWithValue("@VAlu_Fecha_Nacimiento", entidad.Alu_Fecha_Nacimiento);
        //        cmd.Parameters.AddWithValue("@VAlu_Sexo", entidad.Alu_Sexo);
        //        cmd.ExecuteNonQuery();
        //        cmd.Connection = conexion.CerrarConexion();
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show($"Error: Datos/Clases/D_Alumno:Update :--: {error.Message}");
        //    }
        //}

        //public void delete(int delete)
        //{
        //    try
        //    {
        //        table = new DataTable();
        //        cmd = new SqlCommand("Alumnos_Delete");
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@VAlu_Id", delete);
        //        cmd.ExecuteNonQuery();
        //        cmd.Connection = conexion.CerrarConexion();
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show($"Error: Datos/Clases/D_Alumno:Delete :--: {error.Message}");
        //    }
        //}


    }
}
