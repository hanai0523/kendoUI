namespace kendoUI
{
    partial class Us_player_list
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Us_player_list));
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.TextBox();
            this.lbl_birth = new System.Windows.Forms.TextBox();
            this.lbl_rank = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.dgv_player = new System.Windows.Forms.DataGridView();
            this.label_submit_name = new System.Windows.Forms.Label();
            this.label_submit_birthyear = new System.Windows.Forms.Label();
            this.label_submit_rank = new System.Windows.Forms.Label();
            this.label_search_rank = new System.Windows.Forms.Label();
            this.label_search_years = new System.Windows.Forms.Label();
            this.label_search_name = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search_rank = new System.Windows.Forms.TextBox();
            this.textBox_serch_years = new System.Windows.Forms.TextBox();
            this.textBox_search_name = new System.Windows.Forms.TextBox();
            this.player_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_years = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            resources.ApplyResources(this.btn_back, "btn_back");
            this.btn_back.Name = "btn_back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_name
            // 
            resources.ApplyResources(this.lbl_name, "lbl_name");
            this.lbl_name.Name = "lbl_name";
            // 
            // lbl_birth
            // 
            resources.ApplyResources(this.lbl_birth, "lbl_birth");
            this.lbl_birth.Name = "lbl_birth";
            // 
            // lbl_rank
            // 
            resources.ApplyResources(this.lbl_rank, "lbl_rank");
            this.lbl_rank.Name = "lbl_rank";
            // 
            // btn_submit
            // 
            resources.ApplyResources(this.btn_submit, "btn_submit");
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // dgv_player
            // 
            this.dgv_player.AllowUserToAddRows = false;
            this.dgv_player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_player.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.player_name,
            this.player_years,
            this.player_rank,
            this.btn_edit,
            this.btn_delete});
            resources.ApplyResources(this.dgv_player, "dgv_player");
            this.dgv_player.Name = "dgv_player";
            this.dgv_player.RowTemplate.Height = 21;
            this.dgv_player.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_player_CellContentClick);
            this.dgv_player.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_player_CellEndEdit);
            this.dgv_player.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_player_CellEnter);
            // 
            // label_submit_name
            // 
            resources.ApplyResources(this.label_submit_name, "label_submit_name");
            this.label_submit_name.Name = "label_submit_name";
            // 
            // label_submit_birthyear
            // 
            resources.ApplyResources(this.label_submit_birthyear, "label_submit_birthyear");
            this.label_submit_birthyear.Name = "label_submit_birthyear";
            // 
            // label_submit_rank
            // 
            resources.ApplyResources(this.label_submit_rank, "label_submit_rank");
            this.label_submit_rank.Name = "label_submit_rank";
            // 
            // label_search_rank
            // 
            resources.ApplyResources(this.label_search_rank, "label_search_rank");
            this.label_search_rank.Name = "label_search_rank";
            // 
            // label_search_years
            // 
            resources.ApplyResources(this.label_search_years, "label_search_years");
            this.label_search_years.Name = "label_search_years";
            // 
            // label_search_name
            // 
            resources.ApplyResources(this.label_search_name, "label_search_name");
            this.label_search_name.Name = "label_search_name";
            // 
            // button_search
            // 
            resources.ApplyResources(this.button_search, "button_search");
            this.button_search.Name = "button_search";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // textBox_search_rank
            // 
            resources.ApplyResources(this.textBox_search_rank, "textBox_search_rank");
            this.textBox_search_rank.Name = "textBox_search_rank";
            // 
            // textBox_serch_years
            // 
            resources.ApplyResources(this.textBox_serch_years, "textBox_serch_years");
            this.textBox_serch_years.Name = "textBox_serch_years";
            // 
            // textBox_search_name
            // 
            resources.ApplyResources(this.textBox_search_name, "textBox_search_name");
            this.textBox_search_name.Name = "textBox_search_name";
            // 
            // player_name
            // 
            resources.ApplyResources(this.player_name, "player_name");
            this.player_name.Name = "player_name";
            // 
            // player_years
            // 
            resources.ApplyResources(this.player_years, "player_years");
            this.player_years.Name = "player_years";
            // 
            // player_rank
            // 
            resources.ApplyResources(this.player_rank, "player_rank");
            this.player_rank.Name = "player_rank";
            // 
            // btn_edit
            // 
            resources.ApplyResources(this.btn_edit, "btn_edit");
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ReadOnly = true;
            this.btn_edit.Text = "編集";
            // 
            // btn_delete
            // 
            resources.ApplyResources(this.btn_delete, "btn_delete");
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Text = "削除";
            // 
            // Us_player_list
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_search_rank);
            this.Controls.Add(this.label_search_years);
            this.Controls.Add(this.label_search_name);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search_rank);
            this.Controls.Add(this.textBox_serch_years);
            this.Controls.Add(this.textBox_search_name);
            this.Controls.Add(this.label_submit_rank);
            this.Controls.Add(this.label_submit_birthyear);
            this.Controls.Add(this.label_submit_name);
            this.Controls.Add(this.dgv_player);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_rank);
            this.Controls.Add(this.lbl_birth);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_back);
            this.Name = "Us_player_list";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox lbl_name;
        private System.Windows.Forms.TextBox lbl_birth;
        private System.Windows.Forms.TextBox lbl_rank;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DataGridView dgv_player;
        private System.Windows.Forms.Label label_submit_name;
        private System.Windows.Forms.Label label_submit_birthyear;
        private System.Windows.Forms.Label label_submit_rank;
        private System.Windows.Forms.Label label_search_rank;
        private System.Windows.Forms.Label label_search_years;
        private System.Windows.Forms.Label label_search_name;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search_rank;
        private System.Windows.Forms.TextBox textBox_serch_years;
        private System.Windows.Forms.TextBox textBox_search_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_years;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_rank;
        private System.Windows.Forms.DataGridViewButtonColumn btn_edit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_delete;
    }
}
