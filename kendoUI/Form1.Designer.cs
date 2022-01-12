namespace kendoUI
{
    partial class menu
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_player = new System.Windows.Forms.Button();
            this.button_game = new System.Windows.Forms.Button();
            this.button_organization = new System.Windows.Forms.Button();
            this.us_player_list = new kendoUI.Us_player_list();
            this.SuspendLayout();
            // 
            // button_player
            // 
            this.button_player.Location = new System.Drawing.Point(320, 90);
            this.button_player.Name = "button_player";
            this.button_player.Size = new System.Drawing.Size(150, 90);
            this.button_player.TabIndex = 0;
            this.button_player.Text = "選手";
            this.button_player.UseVisualStyleBackColor = true;
            this.button_player.Click += new System.EventHandler(this.button_player_Click);
            // 
            // button_game
            // 
            this.button_game.Enabled = false;
            this.button_game.Location = new System.Drawing.Point(200, 230);
            this.button_game.Name = "button_game";
            this.button_game.Size = new System.Drawing.Size(150, 90);
            this.button_game.TabIndex = 1;
            this.button_game.Text = "試合";
            this.button_game.UseVisualStyleBackColor = true;
            // 
            // button_organization
            // 
            this.button_organization.Enabled = false;
            this.button_organization.Location = new System.Drawing.Point(440, 230);
            this.button_organization.Name = "button_organization";
            this.button_organization.Size = new System.Drawing.Size(150, 90);
            this.button_organization.TabIndex = 2;
            this.button_organization.Text = "団体";
            this.button_organization.UseVisualStyleBackColor = true;
            // 
            // us_player_list
            // 
            this.us_player_list.Location = new System.Drawing.Point(-1, -1);
            this.us_player_list.Name = "us_player_list";
            this.us_player_list.Size = new System.Drawing.Size(800, 450);
            this.us_player_list.TabIndex = 3;
            this.us_player_list.Visible = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.us_player_list);
            this.Controls.Add(this.button_organization);
            this.Controls.Add(this.button_game);
            this.Controls.Add(this.button_player);
            this.Name = "menu";
            this.Text = "剣道試合記録アプり";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_player;
        private System.Windows.Forms.Button button_game;
        private System.Windows.Forms.Button button_organization;
        private Us_player_list us_player_list;
    }
}

