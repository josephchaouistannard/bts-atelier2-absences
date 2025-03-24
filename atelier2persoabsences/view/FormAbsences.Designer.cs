namespace atelier2persoabsences.view
{
    partial class FormAbsences
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRetourner = new System.Windows.Forms.Button();
            this.groupAjoutModif = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAjoutModif = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.comboMotif = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupAjoutModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(13, 211);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(95, 211);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(177, 211);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnRetourner
            // 
            this.btnRetourner.Location = new System.Drawing.Point(272, 211);
            this.btnRetourner.Name = "btnRetourner";
            this.btnRetourner.Size = new System.Drawing.Size(153, 23);
            this.btnRetourner.TabIndex = 4;
            this.btnRetourner.Text = "Retourner au personnel";
            this.btnRetourner.UseVisualStyleBackColor = true;
            this.btnRetourner.Click += new System.EventHandler(this.btnRetourner_Click);
            // 
            // groupAjoutModif
            // 
            this.groupAjoutModif.Controls.Add(this.button6);
            this.groupAjoutModif.Controls.Add(this.btnAjoutModif);
            this.groupAjoutModif.Controls.Add(this.lblError);
            this.groupAjoutModif.Controls.Add(this.comboMotif);
            this.groupAjoutModif.Controls.Add(this.label3);
            this.groupAjoutModif.Controls.Add(this.label2);
            this.groupAjoutModif.Controls.Add(this.dateFin);
            this.groupAjoutModif.Controls.Add(this.label1);
            this.groupAjoutModif.Controls.Add(this.dateDebut);
            this.groupAjoutModif.Location = new System.Drawing.Point(13, 241);
            this.groupAjoutModif.Name = "groupAjoutModif";
            this.groupAjoutModif.Size = new System.Drawing.Size(412, 111);
            this.groupAjoutModif.TabIndex = 5;
            this.groupAjoutModif.TabStop = false;
            this.groupAjoutModif.Text = "Ajouter";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(307, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Annuler";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnAjoutModif
            // 
            this.btnAjoutModif.Location = new System.Drawing.Point(226, 76);
            this.btnAjoutModif.Name = "btnAjoutModif";
            this.btnAjoutModif.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutModif.TabIndex = 14;
            this.btnAjoutModif.Text = "Ajouter";
            this.btnAjoutModif.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(223, 60);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 13;
            // 
            // comboMotif
            // 
            this.comboMotif.FormattingEnabled = true;
            this.comboMotif.Location = new System.Drawing.Point(226, 35);
            this.comboMotif.Name = "comboMotif";
            this.comboMotif.Size = new System.Drawing.Size(180, 21);
            this.comboMotif.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Motif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date de fin";
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(10, 76);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(184, 20);
            this.dateFin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date de début";
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(10, 36);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(184, 20);
            this.dateDebut.TabIndex = 0;
            // 
            // FormAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 362);
            this.Controls.Add(this.groupAjoutModif);
            this.Controls.Add(this.btnRetourner);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAbsences";
            this.Text = "Absences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAbsences_FormClosing);
            this.Load += new System.EventHandler(this.FormAbsences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupAjoutModif.ResumeLayout(false);
            this.groupAjoutModif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRetourner;
        private System.Windows.Forms.GroupBox groupAjoutModif;
        private System.Windows.Forms.ComboBox comboMotif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnAjoutModif;
        private System.Windows.Forms.Label lblError;
    }
}