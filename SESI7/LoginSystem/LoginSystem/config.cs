using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//Message Box
using System.Windows.Forms;
//Add data function and classes
using System.Data;

public class Config
{
	string ConnectionString = "";
	public MySqlConnection connection = null;
	public string server = "127.0.0.1";
	public string user = "root";
	public string password = "root";
	DataSet ds;
	DataTable dt;
	public string Table = "user_info";
	public string ConnectionType = "";
	string RecordSource = "";

	DataGridView tempdata;

	public Config()
	{

	}

	//Function to connect to the database
	public void Connect(string database_name)
    {
        try
        {
			ConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database_name + ";" + "UID=" + user + ";" + "PASSWORD=" + password + "; SslMode=none;";
			connection = new MySqlConnection(ConnectionString);
        }
        catch (Exception e)
        {
			MessageBox.Show(e.Message);
        }
    }

	//Function to execute select statements
	public void ExecuteSql(string Sql_command)
    {
		nowquiee(Sql_command);
    }

    private void nowquiee(string sql_command)
    {
        try
        {
            MySqlConnection cs = new MySqlConnection(ConnectionString);
			cs.Open();
            MySqlCommand myc = new MySqlCommand(sql_command, cs);
			myc.ExecuteNonQuery();

			cs.Close();
        }
        catch (Exception e)
        {
			MessageBox.Show(e.Message);
        }
    }

	public string Results(int ROW, string COLUMN_NAME)
    {
        try
        {
			return dt.Rows[ROW][COLUMN_NAME].ToString();
        }
        catch (Exception e)
        {
			MessageBox.Show(e.Message);
			return dt.Rows[ROW][COLUMN_NAME].ToString();
        }
    }

	public void ExecuteSelect(string Sql_command)
    {
		RecordSource = Sql_command;
		ConnectionType = Table;

		dt = new DataTable(ConnectionType);
        try
        {
            string command = RecordSource.ToUpper();
            MySqlDataAdapter da = new MySqlDataAdapter(RecordSource, connection);
            ds = new DataSet();
            da.Fill(ds, ConnectionType);
            da.Fill(dt);
            tempdata = new DataGridView();

        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }

    }

    public int Count()
    {
        return dt.Rows.Count;
    }

}
