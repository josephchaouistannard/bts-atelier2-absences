namespace atelier2persoabsences.view
{
    partial class FormPersonnel
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
            this.groupAjoutModif = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjoutModif = new System.Windows.Forms.Button();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.groupAjoutModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAjoutModif
            // 
            this.groupAjoutModif.Controls.Add(this.lblError);
            this.groupAjoutModif.Controls.Add(this.btnAnnuler);
            this.groupAjoutModif.Controls.Add(this.btnAjoutModif);
            this.groupAjoutModif.Controls.Add(this.comboService);
            this.groupAjoutModif.Controls.Add(this.label4);
            this.groupAjoutModif.Controls.Add(this.txtMail);
            this.groupAjoutModif.Controls.Add(this.label3);
            this.groupAjoutModif.Controls.Add(this.txtTel);
            this.groupAjoutModif.Controls.Add(this.label2);
            this.groupAjoutModif.Controls.Add(this.txtPrenom);
            this.groupAjoutModif.Controls.Add(this.label1);
            this.groupAjoutModif.Controls.Add(this.txtNom);
            this.groupAjoutModif.Controls.Add(this.lblNom);
            this.groupAjoutModif.Location = new System.Drawing.Point(13, 252);
            this.groupAjoutModif.Name = "groupAjoutModif";
            this.groupAjoutModif.Size = new System.Drawing.Size(511, 159);
            this.groupAjoutModif.TabIndex = 1;
            this.groupAjoutModif.TabStop = false;
            this.groupAjoutModif.Text = "Ajouter";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(336, 109);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 12;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(423, 123);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjoutModif
            // 
            this.btnAjoutModif.Location = new System.Drawing.Point(342, 123);
            this.btnAjoutModif.Name = "btnAjoutModif";
            this.btnAjoutModif.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutModif.TabIndex = 10;
            this.btnAjoutModif.Text = "Ajouter";
            this.btnAjoutModif.UseVisualStyleBackColor = true;
            // 
            // comboService
            // 
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(296, 80);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(202, 21);
            this.comboService.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Service";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(296, 37);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(202, 20);
            this.txtMail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mail";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(6, 125);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(231, 20);
            this.txtTel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tél";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(6, 80);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(231, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prénom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(6, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(231, 20);
            this.txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(3, 21);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(13, 223);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(94, 222);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(175, 223);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAbsences
            // 
            this.btnAbsences.Location = new System.Drawing.Point(436, 223);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(75, 23);
            this.btnAbsences.TabIndex = 5;
            this.btnAbsences.Text = "Absences";
            this.btnAbsences.UseVisualStyleBackColor = true;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(13, 11);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(99, 13);
            this.lblTop.TabIndex = 6;
            this.lblTop.Text = "Liste de personnel :";
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(13, 28);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.RowHeadersVisible = false;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(511, 188);
            this.dgvPersonnel.TabIndex = 7;
            // 
            // FormPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 420);
            this.Controls.Add(this.dgvPersonnel);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupAjoutModif);
            this.Name = "FormPersonnel";
            this.Text = "Personnel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPersonnel_FormClosed);
            this.Load += new System.EventHandler(this.FormPersonnel_Load);
            this.groupAjoutModif.ResumeLayout(false);
            this.groupAjoutModif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupAjoutModif;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjoutModif;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
    }
}