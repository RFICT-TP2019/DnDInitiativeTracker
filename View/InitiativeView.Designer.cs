namespace View
{
    partial class InitiativeView
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
            this.btn_ShowCharacters = new System.Windows.Forms.Button();
            this.lv_Initiative = new System.Windows.Forms.ListView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.tb_BattleDuration = new System.Windows.Forms.TextBox();
            this.tb_RoundDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TurnDuration = new System.Windows.Forms.TextBox();
            this.tb_TurnDurationLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ShowCharacters
            // 
            this.btn_ShowCharacters.Location = new System.Drawing.Point(214, 12);
            this.btn_ShowCharacters.Name = "btn_ShowCharacters";
            this.btn_ShowCharacters.Size = new System.Drawing.Size(100, 30);
            this.btn_ShowCharacters.TabIndex = 1;
            this.btn_ShowCharacters.Text = "Characters";
            this.btn_ShowCharacters.UseVisualStyleBackColor = true;
            this.btn_ShowCharacters.Click += new System.EventHandler(this.btn_ShowCharacters_Click);
            // 
            // lv_Initiative
            // 
            this.lv_Initiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Initiative.FullRowSelect = true;
            this.lv_Initiative.GridLines = true;
            this.lv_Initiative.HideSelection = false;
            this.lv_Initiative.Location = new System.Drawing.Point(12, 48);
            this.lv_Initiative.Name = "lv_Initiative";
            this.lv_Initiative.Size = new System.Drawing.Size(301, 292);
            this.lv_Initiative.TabIndex = 2;
            this.lv_Initiative.UseCompatibleStateImageBehavior = false;
            this.lv_Initiative.View = System.Windows.Forms.View.List;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 30);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(12, 346);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(150, 30);
            this.btn_Left.TabIndex = 4;
            this.btn_Left.Text = "Left Button";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(163, 346);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(150, 30);
            this.btn_Right.TabIndex = 5;
            this.btn_Right.Text = "Right Button";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // tb_BattleDuration
            // 
            this.tb_BattleDuration.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BattleDuration.Location = new System.Drawing.Point(224, 379);
            this.tb_BattleDuration.Name = "tb_BattleDuration";
            this.tb_BattleDuration.ReadOnly = true;
            this.tb_BattleDuration.Size = new System.Drawing.Size(89, 27);
            this.tb_BattleDuration.TabIndex = 6;
            this.tb_BattleDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_RoundDuration
            // 
            this.tb_RoundDuration.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RoundDuration.Location = new System.Drawing.Point(224, 407);
            this.tb_RoundDuration.Name = "tb_RoundDuration";
            this.tb_RoundDuration.ReadOnly = true;
            this.tb_RoundDuration.Size = new System.Drawing.Size(89, 27);
            this.tb_RoundDuration.TabIndex = 7;
            this.tb_RoundDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Battle Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Round Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Turn Duration";
            // 
            // tb_TurnDuration
            // 
            this.tb_TurnDuration.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TurnDuration.Location = new System.Drawing.Point(224, 435);
            this.tb_TurnDuration.Name = "tb_TurnDuration";
            this.tb_TurnDuration.ReadOnly = true;
            this.tb_TurnDuration.Size = new System.Drawing.Size(89, 27);
            this.tb_TurnDuration.TabIndex = 10;
            this.tb_TurnDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_TurnDurationLimit
            // 
            this.tb_TurnDurationLimit.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TurnDurationLimit.Location = new System.Drawing.Point(12, 435);
            this.tb_TurnDurationLimit.Name = "tb_TurnDurationLimit";
            this.tb_TurnDurationLimit.Size = new System.Drawing.Size(89, 27);
            this.tb_TurnDurationLimit.TabIndex = 12;
            this.tb_TurnDurationLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InitiativeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 474);
            this.Controls.Add(this.tb_TurnDurationLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_TurnDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_RoundDuration);
            this.Controls.Add(this.tb_BattleDuration);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lv_Initiative);
            this.Controls.Add(this.btn_ShowCharacters);
            this.Name = "InitiativeView";
            this.Text = "InitiativeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ShowCharacters;
        private System.Windows.Forms.ListView lv_Initiative;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.TextBox tb_BattleDuration;
        private System.Windows.Forms.TextBox tb_RoundDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TurnDuration;
        private System.Windows.Forms.TextBox tb_TurnDurationLimit;
    }
}