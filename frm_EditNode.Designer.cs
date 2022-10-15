
namespace Структура_предприятия_v2
{
    partial class frm_EditNode
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
            this.cb_NodeType = new System.Windows.Forms.ComboBox();
            this.b_OK = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.lab_NodeType = new System.Windows.Forms.Label();
            this.lab_NodeName = new System.Windows.Forms.Label();
            this.txt_NodeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_NodeType
            // 
            this.cb_NodeType.FormattingEnabled = true;
            this.cb_NodeType.Location = new System.Drawing.Point(104, 12);
            this.cb_NodeType.Name = "cb_NodeType";
            this.cb_NodeType.Size = new System.Drawing.Size(170, 21);
            this.cb_NodeType.TabIndex = 0;
            this.cb_NodeType.SelectedValueChanged += new System.EventHandler(this.cb_NodeType_SelectedValueChanged);
            // 
            // b_OK
            // 
            this.b_OK.Location = new System.Drawing.Point(104, 83);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 23);
            this.b_OK.TabIndex = 1;
            this.b_OK.Text = "ОК";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Location = new System.Drawing.Point(199, 83);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 23);
            this.b_Cancel.TabIndex = 2;
            this.b_Cancel.Text = "Отмена";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // lab_NodeType
            // 
            this.lab_NodeType.AutoSize = true;
            this.lab_NodeType.Location = new System.Drawing.Point(7, 12);
            this.lab_NodeType.Name = "lab_NodeType";
            this.lab_NodeType.Size = new System.Drawing.Size(61, 13);
            this.lab_NodeType.TabIndex = 3;
            this.lab_NodeType.Text = "Тип ветки:";
            // 
            // lab_NodeName
            // 
            this.lab_NodeName.AutoSize = true;
            this.lab_NodeName.Location = new System.Drawing.Point(7, 48);
            this.lab_NodeName.Name = "lab_NodeName";
            this.lab_NodeName.Size = new System.Drawing.Size(86, 13);
            this.lab_NodeName.TabIndex = 4;
            this.lab_NodeName.Text = "Наименование:";
            // 
            // txt_NodeName
            // 
            this.txt_NodeName.Location = new System.Drawing.Point(104, 45);
            this.txt_NodeName.Name = "txt_NodeName";
            this.txt_NodeName.Size = new System.Drawing.Size(170, 20);
            this.txt_NodeName.TabIndex = 5;
            this.txt_NodeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NodeName_KeyDown);
            // 
            // frm_EditNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 122);
            this.Controls.Add(this.txt_NodeName);
            this.Controls.Add(this.lab_NodeName);
            this.Controls.Add(this.lab_NodeType);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.cb_NodeType);
            this.Name = "frm_EditNode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение ветки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_EditNode_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.Label lab_NodeType;
        private System.Windows.Forms.Label lab_NodeName;
        public System.Windows.Forms.ComboBox cb_NodeType;
        public System.Windows.Forms.TextBox txt_NodeName;
    }
}