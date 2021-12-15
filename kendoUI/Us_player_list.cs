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
        

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //登録ボタンを押したときにデータベースに追加し、検索をかける
            dgv_player.Rows.Add(lbl_name.Text, lbl_birth.Text, lbl_rank.Text,"編集","削除");
            dgv_player.Rows[dgv_player.Rows.Count - 1].ReadOnly = true;
        }

        private void dgv_player_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //etn_editが押されたときにその行の編集を可能にする
            const int edit = 3;
            const int delete = 4;
            if (e.ColumnIndex == edit)
            {
                
                dgv_player.Rows[e.RowIndex].ReadOnly = isEditting;
                if (isEditting)
                {
                    isEditting = false;
                    dgv_player.Rows[e.RowIndex].Cells[edit].Value = "編集";
                    dgv_player.Rows[e.RowIndex].Cells[delete].Value = "削除";
                }
                else
                {
                    editting_row = e.RowIndex;
                    userTemp = dgv_player.Rows[e.RowIndex].Cells;
                    
                    dgv_player.Rows[e.RowIndex].Cells[edit].Value = "確定";
                    dgv_player.Rows[e.RowIndex].Cells[delete].Value = "戻す";
                    isEditting = true;
                }
            }

            //etn_deleteを押されたときに削除を行う
            
            if(e.ColumnIndex == delete)
            {

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
    }
}
