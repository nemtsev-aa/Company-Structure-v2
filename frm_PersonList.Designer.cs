
namespace Структура_предприятия_v2
{
    partial class frm_PersonList
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_AddPerson = new System.Windows.Forms.ToolStripButton();
            this.tsb_EditPerson = new System.Windows.Forms.ToolStripButton();
            this.tsb_DelPerson = new System.Windows.Forms.ToolStripButton();
            this.dgv_Person = new System.Windows.Forms.DataGridView();
            this.idPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managementDataSet = new Структура_предприятия_v2.ManagementDataSet();
            this.personTableAdapter = new Структура_предприятия_v2.ManagementDataSetTableAdapters.PersonTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_AddPerson,
            this.tsb_EditPerson,
            this.tsb_DelPerson});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_AddPerson
            // 
            this.tsb_AddPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AddPerson.Image = global::Структура_предприятия_v2.Properties.Resources.free_icon_plus_3285480;
            this.tsb_AddPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AddPerson.Name = "tsb_AddPerson";
            this.tsb_AddPerson.Size = new System.Drawing.Size(23, 22);
            this.tsb_AddPerson.ToolTipText = "Добавить физическое лицо";
            this.tsb_AddPerson.Click += new System.EventHandler(this.tsb_AddPerson_Click);
            // 
            // tsb_EditPerson
            // 
            this.tsb_EditPerson.CheckOnClick = true;
            this.tsb_EditPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EditPerson.Image = global::Структура_предприятия_v2.Properties.Resources.free_icon_paper_sheet_5607410;
            this.tsb_EditPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_EditPerson.Name = "tsb_EditPerson";
            this.tsb_EditPerson.Size = new System.Drawing.Size(23, 22);
            this.tsb_EditPerson.Text = "toolStripButton2";
            this.tsb_EditPerson.ToolTipText = "Корректировать данные";
            this.tsb_EditPerson.Click += new System.EventHandler(this.tsb_EditPerson_Click);
            // 
            // tsb_DelPerson
            // 
            this.tsb_DelPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_DelPerson.Image = global::Структура_предприятия_v2.Properties.Resources.free_icon_cancel_179429;
            this.tsb_DelPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DelPerson.Name = "tsb_DelPerson";
            this.tsb_DelPerson.Size = new System.Drawing.Size(23, 22);
            this.tsb_DelPerson.Text = "toolStripButton3";
            this.tsb_DelPerson.ToolTipText = "Удалить физическое лицо";
            this.tsb_DelPerson.Click += new System.EventHandler(this.tsb_DelPerson_Click);
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
            this.dgv_Person.Location = new System.Drawing.Point(0, 25);
            this.dgv_Person.Name = "dgv_Person";
            this.dgv_Person.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Person.Size = new System.Drawing.Size(800, 425);
            this.dgv_Person.TabIndex = 1;
            this.dgv_Person.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Person_CellClick);
            // 
            // idPersonDataGridViewTextBoxColumn
            // 
            this.idPersonDataGridViewTextBoxColumn.DataPropertyName = "idPerson";
            this.idPersonDataGridViewTextBoxColumn.HeaderText = "№ п/п";
            this.idPersonDataGridViewTextBoxColumn.Name = "idPersonDataGridViewTextBoxColumn";
            this.idPersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
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
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // frm_PersonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Person);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_PersonList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник физических лиц";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_PersonList_FormClosing);
            this.Load += new System.EventHandler(this.frm_PersonList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Person)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_AddPerson;
        private System.Windows.Forms.ToolStripButton tsb_EditPerson;
        private System.Windows.Forms.ToolStripButton tsb_DelPerson;
        private System.Windows.Forms.DataGridView dgv_Person;
        private ManagementDataSet managementDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private ManagementDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
    }
}