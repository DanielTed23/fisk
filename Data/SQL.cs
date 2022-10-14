using System.Data.SqlClient;

namespace H1AfsluttendeOpgaveSuperVigtig.Data
{
    public class SQL
    {
        private SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FISKKK;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
           
        public List<Fish> ReadFish()
        {
            conn.Open();
            List<Fish> fishList = new List<Fish>();
            SqlCommand command = new SqlCommand("Select * from [Fish]", conn);
        
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Fish fish = new()
                    {
                        Navn = (reader["Navn"],
                        Farve = (reader["item"]))
                       
                    };
                    fishList.Add(fish);

                    Console.WriteLine(String.Format("{0}", reader["id"]));
                }
            }
            conn.Close();
            return fishList;
        }

    }
}
