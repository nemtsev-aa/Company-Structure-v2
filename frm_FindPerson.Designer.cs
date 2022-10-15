
namespace Структура_предприятия_v2
{
    partial class frm_FindPerson
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
            this.components = new System.ComponentModel.Container();
            this.txt_Patronymic = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Family = new System.Windows.Forms.TextBox();
            this.lab_Patronymic = new System.Windows.Forms.Label();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_Family = new System.Windows.Forms.Label();
            this.b_FindPerson = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Person = new System.Windows.Forms.DataGridView();
            this.idPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managementDataSet = new Структура_предприятия_v2.ManagementDataSet();
            this.b_OK = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.personTableAdapter = new Структура_предприятия_v2.ManagementDataSetTableAdapters.PersonTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Patronymic
            // 
            this.txt_Patronymic.Location = new System.Drawing.Point(623, 12);
            this.txt_Patronymic.Name = "txt_Patronymic";
            this.txt_Patronymic.Size = new System.Drawing.Size(165, 20);
            this.txt_Patronymic.TabIndex = 14;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(339, 12);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(184, 20);
            this.txt_Name.TabIndex = 13;
            // 
            // txt_Family
            // 
            this.txt_Family.Location = new System.Drawing.Point(74, 12);
            this.txt_Family.Name = "txt_Family";
            this.txt_Family.Size = new System.Drawing.Size(207, 20);
            this.txt_Family.TabIndex = 12;
            // 
            // lab_Patronymic
            // 
            this.lab_Patronymic.AutoSize = true;
            this.lab_Patronymic.Location = new System.Drawing.Point(550, 15);
            this.lab_Patronymic.Name = "lab_Patronymic";
            this.lab_Patronymic.Size = new System.Drawing.Size(57, 13);
            this.lab_Patronymic.TabIndex = 11;
            this.lab_Patronymic.Text = "Отчество:";
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(301, 15);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(32, 13);
            this.lab_Name.TabIndex = 10;
            this.lab_Name.Text = "Имя:";
            // 
            // lab_Family
            // 
            this.lab_Family.AutoSize = true;
            this.lab_Family.Location = new System.Drawing.Point(9, 15);
            this.lab_Family.Name = "lab_Family";
            this.lab_Family.Size = new System.Drawing.Size(59, 13);
            this.lab_Family.TabIndex = 9;
            this.lab_Family.Text = "Фамилия:";
            // 
            // b_FindPerson
            // 
            this.b_FindPerson.Location = new System.Drawing.Point(13, 42);
            this.b_FindPerson.Name = "b_FindPerson";
            this.b_FindPerson.Size = new System.Drawing.Size(774, 24);
            this.b_FindPerson.TabIndex = 15;
            this.b_FindPerson.Text = "Найти";
            this.b_FindPerson.UseVisualStyleBackColor = true;
            this.b_FindPerson.Click += new System.EventHandler(this.b_FindPerson_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Person);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 332);
            this.panel1.TabIndex = 16;
            // 
            // dgv_Person
            // 
            this.dgv_Person.AllowUserToAddRows = false;
            this.dgv_Person.AutoGenerateColumns = false;
            this.dgv_Person.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Person.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Person.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn});
            this.dgv_Person.DataSource = this.personBindingSource;
            this.dgv_Person.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Person.Location = new System.Drawing.Point(0, 0);
            this.dgv_Person.Name = "dgv_Person";
            this.dgv_Person.ReadOnly = true;
            this.dgv_Person.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Person.Size = new System.Drawing.Size(801, 332);
            this.dgv_Person.TabIndex = 0;
            // 
            // idPersonDataGridViewTextBoxColumn
            // 
            this.idPersonDataGridViewTextBoxColumn.DataPropertyName = "idPerson";
            this.idPersonDataGridViewTextBoxColumn.HeaderText = "№ п/п";
            this.idPersonDataGridViewTextBoxColumn.Name = "idPersonDataGridViewTextBoxColumn";
            this.idPersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.managementDataSet;
            // 
            // managementDataSet
            // 
            this.managementDataSet.DataSetName = "ManagementDataSet";
            this.managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_OK
            // 
            this.b_OK.Image = global::Структура_предприятия_v2.Properties.Resources.free_icon_check_5610944;
            this.b_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_OK.Location = new System.Drawing.Point(623, 413);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(67, 36);
            this.b_OK.TabIndex = 17;
            this.b_OK.Text = "ОК";
            this.b_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Image = global::Структура_предприятия_v2.Properties.Resources.free_icon_cancelled_7080047;
            this.b_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Cancel.Location = new System.Drawing.Point(700, 413);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(87, 36);
            this.b_Cancel.TabIndex = 18;
            this.b_Cancel.Text = "Отмена";
            this.b_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // frm_FindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_FindPerson);
            this.Controls.Add(this.txt_Patronymic);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Family);
            this.Controls.Add(this.lab_Patronymic);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.lab_Family);
            this.Name = "frm_FindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_FindPerson";
                        this.Load += new System.EventHandler(this.frm_FindPerson_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Person)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Patronymic;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Family;
        private System.Windows.Forms.Label lab_Patronymic;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_Family;
        private System.Windows.Forms.Button b_FindPerson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Person;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_Cancel;
        private ManagementDataSet managementDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private ManagementDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
    }
}