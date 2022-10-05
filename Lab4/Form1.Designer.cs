namespace Lab4
{
    partial class Form1
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
            this.tbFILM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAssessment = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdFilm = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.TextBox();
            this.infobutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFILM
            // 
            this.tbFILM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFILM.Location = new System.Drawing.Point(532, 73);
            this.tbFILM.Margin = new System.Windows.Forms.Padding(2);
            this.tbFILM.MaximumSize = new System.Drawing.Size(451, 22);
            this.tbFILM.Name = "tbFILM";
            this.tbFILM.Size = new System.Drawing.Size(123, 20);
            this.tbFILM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID фильма:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оценка фильму";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название:";
            // 
            // tbPoint
            // 
            this.tbAssessment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAssessment.Location = new System.Drawing.Point(532, 109);
            this.tbAssessment.Margin = new System.Windows.Forms.Padding(2);
            this.tbAssessment.MaximumSize = new System.Drawing.Size(451, 22);
            this.tbAssessment.Name = "tbPoint";
            this.tbAssessment.Size = new System.Drawing.Size(123, 20);
            this.tbAssessment.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(37, 331);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить фильм";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChange.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChange.Location = new System.Drawing.Point(275, 331);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(114, 32);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Изменить по id";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(155, 331);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удаление по id";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdFilm
            // 
            this.grdFilm.AllowUserToAddRows = false;
            this.grdFilm.AllowUserToDeleteRows = false;
            this.grdFilm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFilm.Location = new System.Drawing.Point(37, 38);
            this.grdFilm.Margin = new System.Windows.Forms.Padding(2);
            this.grdFilm.Name = "grdFilm";
            this.grdFilm.ReadOnly = true;
            this.grdFilm.RowTemplate.Height = 24;
            this.grdFilm.Size = new System.Drawing.Size(352, 268);
            this.grdFilm.TabIndex = 5;
            this.grdFilm.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdStud_RowHeaderMouseClick_1);
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.Location = new System.Drawing.Point(532, 38);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.MaximumSize = new System.Drawing.Size(451, 22);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(123, 20);
            this.tbID.TabIndex = 0;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // infobutton
            // 
            this.infobutton.Location = new System.Drawing.Point(512, 331);
            this.infobutton.Name = "infobutton";
            this.infobutton.Size = new System.Drawing.Size(114, 32);
            this.infobutton.TabIndex = 6;
            this.infobutton.Text = "Информация ";
            this.infobutton.UseVisualStyleBackColor = true;
            this.infobutton.Click += new System.EventHandler(this.infobutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = " Хранения фильмотеки";
            // 
            // btnAll
            // 
            this.btnAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAll.Location = new System.Drawing.Point(393, 331);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(114, 32);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "Обновить таблицу";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            this.btnAll.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.btnAll_ChangeUICues);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 374);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.infobutton);
            this.Controls.Add(this.grdFilm);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAssessment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFILM);
            this.Controls.Add(this.tbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(774, 591);
            this.MinimumSize = new System.Drawing.Size(693, 413);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Лабораторная работа №4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFILM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAssessment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grdFilm;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button infobutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAll;
    }
}

