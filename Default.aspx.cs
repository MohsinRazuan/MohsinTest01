
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

//using TDBWebService;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            BindGrid();
        }
        
    }

    private void BindGrid()
    {
        string connStr = "Data Source=mrrdstest.cbaaowc2qmc3.eu-north-1.rds.amazonaws.com,1433;Initial Catalog=TestDatabase;User ID=Administrator;Password=LlvKBi*mwVo4kQ-(3mx)sC6DZHP6vAcd";
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            SqlCommand cmd = new SqlCommand("SELECT EmployeeID, FirstName, LastName, Department, Salary FROM Employees", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }

}
