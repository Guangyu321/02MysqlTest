using System;
using System.Data;

namespace CSharpConnectMySQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sql = "SELECT * FROM fri_data";
            DataSet dataSet = MySqlHelper.GetDataSet(sql);
            DataTable dt = dataSet.Tables[0];
            if (dt.Rows.Count > 0)
            {
                //打印所有列名
                string columnName = string.Empty;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    columnName += dt.Columns[i].ColumnName + " | ";
                }
                Console.WriteLine(columnName);
                Console.WriteLine("-------------------------");

                //打印每一行的数据
                foreach (DataRow row in dt.Rows)
                {
                    string columnStr = string.Empty;
                    foreach (DataColumn column in dt.Columns)
                    {
                        columnStr += row[column] + " | ";
                    }
                    Console.WriteLine(columnStr);
                }
            }
            Console.WriteLine("complet!"); 
            Console.WriteLine("Success!");
            Console.WriteLine("complet!");
            Console.WriteLine("Success!");
            Console.WriteLine("complet!");
            Console.WriteLine("Success!");
            Console.ReadKey();
        }
    }
}
