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
	public string password = "manu";
	DataSet ds;
	DataTable dt;
	public string Table = "user_info";
	public string ConnectionType = "";
	string RecordSource = "";

	DataGridView tempdata;

	public Config()
	{


	}
}
