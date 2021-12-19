using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace kendoUI
{
    class Dbctl
    {
        
        /// <summary>
        /// 選手の検索処理
        /// </summary>
        /// <returns>選手の検索結果のデータテーブル</returns>
        public static DataTable searchPlayers()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(loadConnectString()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT name,RowId FROM player;", conn))
                {
                    SQLiteDataAdapter sda = new SQLiteDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    
                }
            }
            return dt;
        }

        /// <summary>
        /// ConnectionStringsを返却する処理
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ConnectionStrings</returns>
        private static String loadConnectString(String id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
