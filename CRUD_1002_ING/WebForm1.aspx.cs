using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_1002_ING
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-53BK8BJ8;Initial Catalog=Tienda;Integrated Security=True;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            string myInsertQuery = "INSERT INTO Articulos (id, Nombre_Articulo, Precio, Existencias) Values(@id, @Nombre_Articulo, @Precio, @Existencias)";
            SqlCommand myCommand = new SqlCommand(myInsertQuery, conn);

            myCommand.Parameters.Add("@id", SqlDbType.BigInt).Value = TextBox1.Text; // ID del artículo
            myCommand.Parameters.Add("@Nombre_Articulo", SqlDbType.NVarChar).Value = TextBox2.Text; // Nombre del artículo
            myCommand.Parameters.Add("@Precio", SqlDbType.Decimal).Value = TextBox3.Text; // Precio del artículo
            myCommand.Parameters.Add("@Existencias", SqlDbType.Int).Value = TextBox4.Text; // Existencias del artículo

            conn.Open();
            try
            {
                result = myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                LabelMensaje.Text = "Ha ocurrido un error, verifique los datos";
            }

            if (result != 0)
            {
                LabelMensaje.Text = "Se insertaron los datos correctamente";
            }
            else
            {
                LabelMensaje.Text = "No se insertó el registro, verifique los datos";
            }
            conn.Close();
        }

        // Buscar un artículo por ID
        protected void Button2_Click(object sender, EventArgs e)
        {
            LabelMensaje.Text = "";
            int result = 0;
            string nombreArticulo = "", precio = "", existencias = "";

            SqlCommand cmd = new SqlCommand("SELECT Nombre_Articulo, Precio, Existencias FROM Articulos WHERE id = @id", conn);
            cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = TextBox1.Text;

            conn.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nombreArticulo = reader[0].ToString();
                    precio = reader[1].ToString();
                    existencias = reader[2].ToString();
                    result++;
                }
                reader.Close();
                conn.Close();

                TextBox2.Text = nombreArticulo;
                TextBox3.Text = precio;
                TextBox4.Text = existencias;
            }
            catch (Exception)
            {
                LabelMensaje.Text = "Ha ocurrido un error, verifique los datos";
            }

            if (result == 0)
            {
                LabelMensaje.Text = "No se encontraron los datos";
            }
        }

        // Eliminar un artículo
        protected void Button3_Click(object sender, EventArgs e)
        {
            int result = 0;

            SqlCommand cmd = new SqlCommand("DELETE FROM Articulos WHERE id = @id", conn);
            cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = TextBox1.Text;

            conn.Open();
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                LabelMensaje.Text = "Ha ocurrido un error, verifique los datos";
            }

            if (result != 0)
            {
                LabelMensaje.Text = "Se borraron los datos";
            }
            else
            {
                LabelMensaje.Text = "No se borró el registro, verifique los datos";
            }
            conn.Close();
        }

        // Actualizar un artículo
        protected void Button4_Click(object sender, EventArgs e)
        {
            int result = 0;

            string myQuery = "UPDATE Articulos SET Nombre_Articulo=@Nombre_Articulo, Precio=@Precio, Existencias=@Existencias WHERE id = @id";
            SqlCommand myCommand = new SqlCommand(myQuery, conn);

            myCommand.Parameters.Add("@Nombre_Articulo", SqlDbType.NVarChar).Value = TextBox2.Text;
            myCommand.Parameters.Add("@Precio", SqlDbType.Decimal).Value = TextBox3.Text;
            myCommand.Parameters.Add("@Existencias", SqlDbType.Int).Value = TextBox4.Text;
            myCommand.Parameters.Add("@id", SqlDbType.BigInt).Value = TextBox1.Text;

            conn.Open();
            try
            {
                result = myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                LabelMensaje.Text = "Ha ocurrido un error, verifique los datos";
            }

            if (result != 0)
            {
                LabelMensaje.Text = "Se actualizaron los datos correctamente";
            }
            else
            {
                LabelMensaje.Text = "No se actualizaron los datos, verifique los datos";
            }
            conn.Close();
        }

        
    }
}