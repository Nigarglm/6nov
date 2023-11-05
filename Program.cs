using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _6nov_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conn = "server=DESKTOP-NK9HMU9\\MSSQLSERVER01;database=adotask;trusted_connection=true;integrated security=true;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            string cmd = "INSERT INTO Musics VALUES('Starboy', 434)";
            SqlCommand command = new SqlCommand(cmd, connection);

            int result= command.ExecuteNonQuery();
            if (result>0)
            {
                Console.WriteLine("Music added");
            }
            else
            {
                Console.WriteLine("Error ocurred");
            }

            connection.Close();

            connection.Open();

            string cmd2 = "INSERT INTO Artists VALUES('The Weeknd',1990.02.16 ,male)";
            SqlCommand command2 = new SqlCommand(cmd, connection);

            int result2 = command.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Artist added");
            }
            else
            {
                Console.WriteLine("Error ocurred");
            }

            connection.Close();

            connection.Open();

            string cmd3 = "DELETE FROM Musics WHERE Id=3";
            SqlCommand command3 = new SqlCommand(cmd, connection);

            int result3 = command.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Music deleted");
            }
            else
            {
                Console.WriteLine("Error ocurred");
            }

            connection.Close();

            connection.Open();

            string cmd4 = "DELETE FROM Artists WHERE Id=3";
            SqlCommand command4 = new SqlCommand(cmd, connection);

            int result4 = command.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Artist deleted");
            }
            else
            {
                Console.WriteLine("Error ocurred");
            }

            connection.Close();

            connection.Open();

            string query = "SELECT * FROM Musics";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();

            adapter.Fill(table);
            connection.Close();

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row["Id"] + " " + row["Name"]+" " + row["Duration"]);
            }

            connection.Open();

            string query2 = "SELECT * FROM Artists";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query,connection);
            DataTable table2 = new DataTable();

            adapter.Fill(table);
            connection.Close();

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row["Id"]+" " + row["Name"]+" " + row["Surname"]+" " + row["Birthday"]+" " + row["Gender"]);
            }

            connection.Open();

        }
    }
}