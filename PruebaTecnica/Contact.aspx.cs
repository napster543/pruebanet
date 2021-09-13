using Npgsql;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI;

namespace PruebaTecnica
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            idmostrarmsg.Visible = false;
        }

       
        protected void btnconsutar_Click(object sender, EventArgs e)
        {
            try /* Select After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;

                    string sqltext = "SELECT cg.nombre as cargonombre, * FROM tipodocumento t INNER JOIN contratoslaborales c ON c.idtipodocumento = t.idtipodocumento INNER JOIN cargos cg ON cg.idcargo = c.idcargo WHERE c.numerodocumento = '"+ txtnumdoc.Text.Trim() +"' limit 1";

                    cmd.CommandText = sqltext;
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txtnumdoc.Text = dt.Rows[0]["numerodocumento"].ToString();
                        txtcontrato.Text = dt.Rows[0]["idcontrato"].ToString();
                        txtnombres.Text = dt.Rows[0]["primernombre"].ToString() + " - " + dt.Rows[0]["segundonombre"].ToString();
                        txtfechainicio.Text = dt.Rows[0]["fechainicio"].ToString();

                        string fechafinal = "";
                        if (dt.Rows[0]["fechafin"] == DBNull.Value)
                        {
                            fechafinal = "Sin fecha";  
                        }
                        else{
                            fechafinal = dt.Rows[0]["fechafin"].ToString();
                        }
                        txtfechafinal.Text = fechafinal;
                        txtriesgo.Text = dt.Rows[0]["idarl"].ToString() ;
                        txtsalario.Text = dt.Rows[0]["salario"].ToString();
                        txttipodoc.Text = dt.Rows[0]["nombre"].ToString();
                        txtcargo.Text = dt.Rows[0]["cargonombre"].ToString();
                        idmostrarmsg.Visible = false;
                    }
                    else {
                        Console.WriteLine("No se encontraron datos");
                        idmostrarmsg.Visible = true;
                        idmostrarmsg.InnerHtml = "No se encontraron datos";
                    }

                    cmd.Dispose();
                    connection.Close();


                }
            }
            catch (Exception ex) {
                idmostrarmsg.Visible = true;
                idmostrarmsg.InnerHtml = ex.Message.ToString();
            }
        }

        protected void btnGuardarData_Click(object sender, EventArgs e)
        {
            try /* Updation After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;

                    string sqltext = "INSERT INTO novedadesnomina(idcontrato, periodolaborado, horaslaboradas, horaextradiurna, horaextranocturna, horaextradominical, horaextrafestiva, descuentos, usuariocreacion) ";
                    sqltext += "VALUES(@idcontrato,@periodo,@horalaborada,@HEdiuerna,@HEnocturna,@HEdominical,@HEfestiva,@descuento,@usuario)";
                    

                    cmd.ExecuteNonQuery();
                    connection.Close();

                    limpiarNovedades();

                    idmostrarmsg.InnerHtml = "Se guarda la informacion correctamente";
                    idmostrarmsg.Visible = true; 

                }
            }
            catch (Exception ex) {
                idmostrarmsg.InnerHtml = ex.Message.ToString();
                idmostrarmsg.Visible = true;
            }
        }

        private void limpiarForm() {
            txtnumdoc.Text = "";
            txtcontrato.Text = "";
            txtnombres.Text = "";
            txtfechainicio.Text = "";            
            txtfechafinal.Text = "";
            txtriesgo.Text = "";
            txtsalario.Text = "";
            txttipodoc.Text = "";
            txtcargo.Text = "";
            idmostrarmsg.InnerHtml = "";
            idmostrarmsg.Visible = false;
        }
        private void limpiarNovedades() {
            txtperiodolaborado.Text = "";
            txthoralaborada.Text = "";
            txtdiurnas.Text = "";
            txtNocturnas.Text = "";
            txtdominicales.Text = "";
            txtfestivas.Text = "";
            txtdescuentos.Text = "";

        }

        protected void btnNewSearch_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
    }
}