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
    class Dbctl : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        

        /// <summary>
        /// 選手の検索処理
        /// </summary>
        /// <returns>選手の検索結果のデータテーブル</returns>
        public DataTable searchPlayers(string name,string birth,string rank)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(loadConnectString()))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT name,ROWID,birth,rank FROM player "+
                        @"where name like '%" + name + @"%'"+
                        @" and birth like '%" + birth + @"%'"+
                        @" and rank like '%" + rank + @"%';";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// 選手追加
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birth"></param>
        /// <param name="rank"></param>
        public void insertPlayer(string name,int birth,string rank)
        {
            using (SQLiteConnection conn = new SQLiteConnection(loadConnectString()))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into player (name,birth,rank) values(@name,@birth,@rank)";
                    SQLiteParameter prm_name = new SQLiteParameter();
                    SQLiteParameter prm_birth = new SQLiteParameter();
                    SQLiteParameter prm_rank = new SQLiteParameter();
                    prm_name.ParameterName = "name";
                    prm_birth.ParameterName = "birth";
                    prm_rank.ParameterName = "rank";
                    prm_name.Value = name;
                    prm_birth.Value = birth;
                    prm_rank.Value = rank;
                    cmd.Parameters.Add(prm_name);
                    cmd.Parameters.Add(prm_birth);
                    cmd.Parameters.Add(prm_rank);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 選手削除
        /// </summary>
        /// <param name="rowid"></param>
        public void deletePlayer(int rowid)
        {
            using (SQLiteConnection conn = new SQLiteConnection(loadConnectString()))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from player where ROWID = " + rowid + ";";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// ConnectionStringsを返却する処理
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ConnectionStrings</returns>
        private String loadConnectString(String id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
