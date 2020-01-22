namespace View
{
    partial class AddInitiativeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_CharacterName = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lv_Characters = new System.Windows.Forms.ListView();
            this.tb_Initiative = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_CharacterName
            // 
            this.tb_CharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CharacterName.Location = new System.Drawing.Point(12, 23);
            this.tb_CharacterName.Name = "tb_CharacterName";
            this.tb_CharacterName.Size = new System.Drawing.Size(125, 28);
            this.tb_CharacterName.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(213, 22);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 30);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lv_Characters
            // 
            this.lv_Characters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Characters.FullRowSelect = true;
            this.lv_Characters.GridLines = true;
            this.lv_Characters.HideSelection = false;
            this.lv_Characters.Location = new System.Drawing.Point(12, 77);
            this.lv_Characters.MultiSelect = false;
            this.lv_Characters.Name = "lv_Characters";
            this.lv_Characters.Size = new System.Drawing.Size(301, 292);
            this.lv_Characters.TabIndex = 5;
            this.lv_Characters.UseCompatibleStateImageBehavior = false;
            this.lv_Characters.View = System.Windows.Forms.View.List;
            this.lv_Characters.SelectedIndexChanged += new System.EventHandler(this.lv_Characters_SelectedIndexChanged);
            // 
            // tb_Initiative
            // 
            this.tb_Initiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Initiative.Location = new System.Drawing.Point(143, 23);
            this.tb_Initiative.Name = "tb_Initiative";
            this.tb_Initiative.Size = new System.Drawing.Size(64, 28);
            this.tb_Initiative.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Initiative";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(12, 54);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(47, 20);
            this.lbl_Error.TabIndex = 11;
            this.lbl_Error.Text = "Error";
            // 
            // AddInitiativeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 382);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Initiative);
            this.Controls.Add(this.tb_CharacterName);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lv_Characters);
            this.Name = "AddInitiativeView";
            this.Text = "AddInitiativeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_CharacterName;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListView lv_Characters;
        private System.Windows.Forms.TextBox tb_Initiative;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Error;
    }
}