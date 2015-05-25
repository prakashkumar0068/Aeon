using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AeonNew
{
    class ConnectionManager
    {
        public static OracleConnection getDatabaseConnection()
        {

            string connectionString = "Data Source = " +
                                         "(DESCRIPTION = " +
                                         "(ADDRESS_LIST = " +
                                         "(ADDRESS = (PROTOCOL = TCP)" +
                                         "(HOST =10.10.45.122)" +
                                         "(PORT = 1521)" +
                                         ")" +
                                         ")" +
                                         "(CONNECT_DATA = " +
                                         "(SERVICE_NAME = XE)" +
                                         ")" +
                                         ");" +
                                         "User Id = aeon;" +
                                         "password = aeon;";
                                            
            
            OracleConnection connection = new OracleConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
