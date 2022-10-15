
namespace Структура_предприятия_v2
{
    partial class frm_Home
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Заводоуправление");
            this.trv_Structure = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_AddNode = new System.Windows.Forms.ToolStripButton();
            this.tsb_EditNode = new System.Windows.Forms.ToolStripButton();
            this.tsb_DelNode = new System.Windows.Forms.ToolStripButton();
            this.tsb_Persons = new System.Windows.Forms.ToolStripButton();
            this.lab_Family = new System.Windows.Forms.Label();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_MiddleName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Family = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_MiddleName = new System.Windows.Forms.TextBox();
            this.dtp_AddData = new System.Windows.Forms.DateTimePicker();
            this.b_FindPerson = new System.Windows.Forms.Button();
            this.b_ClearForm = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trv_Structure
            // 
            this.trv_Structure.Location = new System.Drawing.Point(12, 28);
            this.trv_Structure.Name = "trv_Structure";
            treeNode2.Name = "General";
            treeNode2.Tag = "General";
            treeNode2.Text = "Заводоуправление";
            this.trv_Structure.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.trv_Structure.Size = new System.Drawing.Size(390, 384);
            this.trv_Structure.TabIndex = 0;
            this.trv_Structure.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_Structure_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_AddNode,
            this.tsb_EditNode,
            this.tsb_DelNode,
            this.tsb_Persons});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_AddNode
            // 
            this.tsb_AddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AddNode.Image = global::Структура_предприятия_v2.Properties.Resources.free_icon_plus_3285480;
            this.tsb_AddNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AddNode.Name = "tsb_AddNode";
            this.tsb_AddNode.Size = new System.Drawing.Size(23, 22);
            this.tsb_AddNode.ToolTipText = "Добавить/удалить компанент";
            this.tsb_AddNode.Click += new System.EventHandler(this.tsb_AddNode_Click);
            // 
            // tsb_EditNode
            // 
            this.tsb_EditNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EditNode.Image = global::Структура_предприятия_v2.Properties.Resources.free_icon_paper_sheet_5607410;
            this.tsb_EditNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_EditNode.Name = "tsb_EditNode";
            this.tsb_EditNode.Size = new System.Drawing.Size(23, 22);
            this.tsb_EditNode.ToolTipText = "Корректировать компанент";
            this.tsb_EditNode.Click += new System.EventHandler(this.tsb_EditNode_Click);
            // 
            // tsb_DelNode
            // 
            this.tsb_DelNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_DelNode.Image = global::Структура_предприятия_v2.Properties.Resources.free_icon_cancel_179429;
            this.tsb_DelNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DelNode.Name = "tsb_DelNode";
            this.tsb_DelNode.Size = new System.Drawing.Size(23, 22);
            this.tsb_DelNode.Text = "toolStripButton3";
            this.tsb_DelNode.ToolTipText = "Удалить компанент";
            this.tsb_DelNode.Click += new System.EventHandler(this.tsb_DelNode_Click);
            // 
            // tsb_Persons
            // 
            this.tsb_Persons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Persons.Image = global::Структура_предприятия_v2.Properties.Resources.free_icon_networking_1006642;
            this.tsb_Persons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Persons.Name = "tsb_Persons";
            this.tsb_Persons.Size = new System.Drawing.Size(23, 22);
            this.tsb_Persons.ToolTipText = "Список физических лиц";
            this.tsb_Persons.Click += new System.EventHandler(this.tsb_Persons_Click);
            // 
            // lab_Family
            // 
            this.lab_Family.AutoSize = true;
            this.lab_Family.Location = new System.Drawing.Point(447, 42);
            this.lab_Family.Name = "lab_Family";
            this.lab_Family.Size = new System.Drawing.Size(59, 13);
            this.lab_Family.TabIndex = 2;
            this.lab_Family.Text = "Фамилия:";
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(447, 74);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(32, 13);
            this.lab_Name.TabIndex = 3;
            this.lab_Name.Text = "Имя:";
            // 
            // lab_MiddleName
            // 
            this.lab_MiddleName.AutoSize = true;
            this.lab_MiddleName.Location = new System.Drawing.Point(447, 108);
            this.lab_MiddleName.Name = "lab_MiddleName";
            this.lab_MiddleName.Size = new System.Drawing.Size(57, 13);
            this.lab_MiddleName.TabIndex = 4;
            this.lab_MiddleName.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата принятия:";
            // 
            // txt_Family
            // 
            this.txt_Family.Location = new System.Drawing.Point(558, 39);
            this.txt_Family.Name = "txt_Family";
            this.txt_Family.Size = new System.Drawing.Size(207, 20);
            this.txt_Family.TabIndex = 6;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(558, 71);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(207, 20);
            this.txt_Name.TabIndex = 7;
            // 
            // txt_MiddleName
            // 
            this.txt_MiddleName.Location = new System.Drawing.Point(558, 105);
            this.txt_MiddleName.Name = "txt_MiddleName";
            this.txt_MiddleName.Size = new System.Drawing.Size(207, 20);
            this.txt_MiddleName.TabIndex = 8;
            // 
            // dtp_AddData
            // 
            this.dtp_AddData.Location = new System.Drawing.Point(558, 140);
            this.dtp_AddData.Name = "dtp_AddData";
            this.dtp_AddData.Size = new System.Drawing.Size(124, 20);
            this.dtp_AddData.TabIndex = 9;
            // 
            // b_FindPerson
            // 
            this.b_FindPerson.Image = global::Структура_предприятия_v2.Properties.Resources.free_icon_talent_search_2272580;
            this.b_FindPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_FindPerson.Location = new System.Drawing.Point(447, 184);
            this.b_FindPerson.Name = "b_FindPerson";
            this.b_FindPerson.Size = new System.Drawing.Size(89, 32);
            this.b_FindPerson.TabIndex = 10;
            this.b_FindPerson.Text = "Выбрать";
            this.b_FindPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_FindPerson.UseVisualStyleBackColor = true;
            this.b_FindPerson.Click += new System.EventHandler(this.b_FindPerson_Click);
            // 
            // b_ClearForm
            // 
            this.b_ClearForm.Image = global::Структура_предприятия_v2.Properties.Resources.free_icon_eraser_2661282;
            this.b_ClearForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_ClearForm.Location = new System.Drawing.Point(542, 184);
            this.b_ClearForm.Name = "b_ClearForm";
            this.b_ClearForm.Size = new System.Drawing.Size(89, 32);
            this.b_ClearForm.TabIndex = 11;
            this.b_ClearForm.Text = "Очистить";
            this.b_ClearForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_ClearForm.UseVisualStyleBackColor = true;
            this.b_ClearForm.Click += new System.EventHandler(this.b_ClearForm_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_ClearForm);
            this.Controls.Add(this.b_FindPerson);
            this.Controls.Add(this.dtp_AddData);
            this.Controls.Add(this.txt_MiddleName);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Family);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_MiddleName);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.lab_Family);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.trv_Structure);
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Структура предприятия";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_AddNode;
        private System.Windows.Forms.ToolStripButton tsb_EditNode;
        private System.Windows.Forms.ToolStripButton tsb_DelNode;
        private System.Windows.Forms.ToolStripButton tsb_Persons;
        private System.Windows.Forms.Label lab_Family;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_MiddleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_FindPerson;
        private System.Windows.Forms.Button b_ClearForm;
        public System.Windows.Forms.TreeView trv_Structure;
        public System.Windows.Forms.TextBox txt_Family;
        public System.Windows.Forms.TextBox txt_Name;
        public System.Windows.Forms.TextBox txt_MiddleName;
        public System.Windows.Forms.DateTimePicker dtp_AddData;
    }
}