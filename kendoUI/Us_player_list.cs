using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kendoUI
{
    public partial class Us_player_list : UserControl
    {
        bool isEditting = false;
        int editting_row = -1;
        
        DataGridViewCellCollection userTemp;

        public Us_player_list()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// 選手登録ボタンを押したときの処理
        /// </summary>
        /// <remarks>わっしょい</remarks>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            //登録ボタンを押したときにデータベースに追加する
            dgv_player.Rows.Add(lbl_name.Text, "",lbl_birth.Text, lbl_rank.Text,"編集","削除");
            dgv_player.Rows[dgv_player.Rows.Count - 1].ReadOnly = true;
            using (Dbctl db = new Dbctl())
            {
                db.insertPlayer(lbl_name.Text,int.Parse(lbl_birth.Text), lbl_rank.Text);
            }
        }

        private void dgv_player_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //etn_editが押されたときにその行の編集を可能にする
            if (dgv_player.Columns[e.ColumnIndex].Name == "btn_edit")
            {
                
                dgv_player.Rows[e.RowIndex].ReadOnly = isEditting;
                if (isEditting)
                {
                    isEditting = false;
                    dgv_player.Rows[e.RowIndex].Cells["btn_edit"].Value = "編集";
                    dgv_player.Rows[e.RowIndex].Cells["btn_delete"].Value = "削除";

                }
                else
                {
                    editting_row = e.RowIndex;
                    userTemp = dgv_player.Rows[e.RowIndex].Cells;
                    
                    dgv_player.Rows[e.RowIndex].Cells["btn_edit"].Value = "確定";
                    dgv_player.Rows[e.RowIndex].Cells["btn_delete"].Value = "戻す";
                    isEditting = true;
                }
            }

            //etn_deleteを押されたときに削除を行う
            
            if(dgv_player.Columns[e.ColumnIndex].Name == "btn_delete")
            {
                if (isEditting)
                {

                }
                else
                {
                    //変更状態でない→削除ボタンを押したとき
                    using (Dbctl db = new Dbctl())
                    {
                        db.deletePlayer((int)dgv_player.Rows[e.RowIndex].Cells["rowId"].Value);
                    }
                    dgv_player.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dgv_player_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //データベースを編集する

            //編集していた行のreadOnlyをtrueにする
            
        }

        private void dgv_player_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(!(e.RowIndex == editting_row))
            {
                dgv_player.Rows[e.RowIndex].ReadOnly = true;
                editting_row = -1;
            }
        }

        private void update_player()
        {
            DataTable players;
            using (Dbctl db = new Dbctl())
            {
                players = db.searchPlayers(textBox_search_name.Text,
                    textBox_serch_years.Text,
                    textBox_search_rank.Text);
            }

            //ボタンのテキストがいい感じに入れれなかったためやむなくfor文・・・
            for (int i = 0; i < players.Rows.Count; i++)
            {
                dgv_player.Rows.Add(
                    players.Rows[i]["name"]
                    , players.Rows[i]["ROWID"]
                    , players.Rows[i]["birth"]
                    , players.Rows[i]["rank"]
                    , "編集", "削除");
                dgv_player.Rows[i].ReadOnly = true;
            }
        }

        private void Us_player_list_Load(object sender, EventArgs e)
        {
            update_player();
        }

        private void textBox_search_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
