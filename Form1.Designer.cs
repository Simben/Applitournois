namespace ApliTournoi
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_region = new System.Windows.Forms.TextBox();
            this.TB_PD = new System.Windows.Forms.TextBox();
            this.TB_PP = new System.Windows.Forms.TextBox();
            this.TB_PPaint = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Team = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Region = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pts_Dou = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pts_Dou_Norm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pts_Pou = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pts_Paint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pts_Tot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter Team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Team:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit team";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(446, 19);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(135, 20);
            this.TB_Nom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Region :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pts Doublette :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pts peinture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pts Poutre :";
            // 
            // TB_region
            // 
            this.TB_region.Location = new System.Drawing.Point(446, 42);
            this.TB_region.Name = "TB_region";
            this.TB_region.Size = new System.Drawing.Size(135, 20);
            this.TB_region.TabIndex = 9;
            // 
            // TB_PD
            // 
            this.TB_PD.Location = new System.Drawing.Point(446, 68);
            this.TB_PD.Name = "TB_PD";
            this.TB_PD.Size = new System.Drawing.Size(135, 20);
            this.TB_PD.TabIndex = 10;
            // 
            // TB_PP
            // 
            this.TB_PP.Location = new System.Drawing.Point(446, 93);
            this.TB_PP.Name = "TB_PP";
            this.TB_PP.Size = new System.Drawing.Size(135, 20);
            this.TB_PP.TabIndex = 11;
            // 
            // TB_PPaint
            // 
            this.TB_PPaint.Location = new System.Drawing.Point(446, 117);
            this.TB_PPaint.Name = "TB_PPaint";
            this.TB_PPaint.Size = new System.Drawing.Size(135, 20);
            this.TB_PPaint.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(579, 370);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 149);
            this.textBox1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Team,
            this.Region,
            this.Pts_Dou,
            this.Pts_Dou_Norm,
            this.Pts_Pou,
            this.Pts_Paint,
            this.Pts_Tot});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(12, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(540, 295);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Team
            // 
            this.Team.Text = "Team";
            // 
            // Region
            // 
            this.Region.Text = "Region";
            // 
            // Pts_Dou
            // 
            this.Pts_Dou.Text = "Pts Dou.";
            // 
            // Pts_Dou_Norm
            // 
            this.Pts_Dou_Norm.Text = "Pts Dou. Norm.";
            // 
            // Pts_Pou
            // 
            this.Pts_Pou.Text = "Pts Pou.";
            // 
            // Pts_Paint
            // 
            this.Pts_Paint.Text = "Pts Peint.";
            // 
            // Pts_Tot
            // 
            this.Pts_Tot.Text = "Pts_ Tot.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TB_PPaint);
            this.Controls.Add(this.TB_PP);
            this.Controls.Add(this.TB_PD);
            this.Controls.Add(this.TB_region);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_region;
        private System.Windows.Forms.TextBox TB_PD;
        private System.Windows.Forms.TextBox TB_PP;
        private System.Windows.Forms.TextBox TB_PPaint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Team;
        private System.Windows.Forms.ColumnHeader Region;
        private System.Windows.Forms.ColumnHeader Pts_Dou;
        private System.Windows.Forms.ColumnHeader Pts_Dou_Norm;
        private System.Windows.Forms.ColumnHeader Pts_Pou;
        private System.Windows.Forms.ColumnHeader Pts_Paint;
        private System.Windows.Forms.ColumnHeader Pts_Tot;
        private System.Windows.Forms.Button button3;
    }
}

