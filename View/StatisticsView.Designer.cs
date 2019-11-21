namespace View
{
    partial class StatisticsView
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
            this.lv_Characters = new System.Windows.Forms.ListView();
            this.lv_Rounds = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lv_Characters
            // 
            this.lv_Characters.HideSelection = false;
            this.lv_Characters.Location = new System.Drawing.Point(13, 13);
            this.lv_Characters.Name = "lv_Characters";
            this.lv_Characters.Size = new System.Drawing.Size(359, 425);
            this.lv_Characters.TabIndex = 0;
            this.lv_Characters.UseCompatibleStateImageBehavior = false;
            this.lv_Characters.View = System.Windows.Forms.View.Details;
            // 
            // lv_Rounds
            // 
            this.lv_Rounds.HideSelection = false;
            this.lv_Rounds.Location = new System.Drawing.Point(429, 13);
            this.lv_Rounds.Name = "lv_Rounds";
            this.lv_Rounds.Size = new System.Drawing.Size(359, 425);
            this.lv_Rounds.TabIndex = 1;
            this.lv_Rounds.UseCompatibleStateImageBehavior = false;
            this.lv_Rounds.View = System.Windows.Forms.View.Details;
            // 
            // StatisticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_Rounds);
            this.Controls.Add(this.lv_Characters);
            this.Name = "StatisticsView";
            this.Text = "StatisticsView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Characters;
        private System.Windows.Forms.ListView lv_Rounds;
    }
}