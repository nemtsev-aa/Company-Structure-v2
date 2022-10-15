using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Структура_предприятия_v2
{
    public partial class frm_EditNode : Form
    {
        // Cоздаем переменные для обращения к элементам форм
        frm_Home frm_Home = new frm_Home();
        public frm_EditNode()
        {
            InitializeComponent();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            switch (frm_Home.Operation)
            {
                case "Add":
                    NewNodeAdd();
                    break;

                case "Edit":
                    EditNode();
                    break; 
            }
        }

        private void NewNodeAdd()
        {
            if (this.cb_NodeType.SelectedItem.ToString() == "[Выберите значение]")
            {
                MessageBox.Show(
                            "Тип ветки не выбран!",
                            "Ошибка",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                if (this.txt_NodeName.Text == "")
                {
                    MessageBox.Show(
                            "Наименование не введено!",
                            "Ошибка",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
                //Создаём новую ветвь
                TreeNode NewNode = new TreeNode(this.txt_NodeName.Text);
                //Присваиваем тип ветви в тэг
                NewNode.Tag = this.cb_NodeType.SelectedItem.ToString();
                //Добавляем ветвь к выделенному узлу
                frm_Home.SelectionNode.Nodes.Add(NewNode);
                //Выделяем добавленный узел
                frm_Home main = this.Owner as frm_Home;
                main.trv_Structure.SelectedNode = NewNode;
                //Скрываем форму выбора
                this.Hide();
            }
        }
        private void EditNode()
        {
            //Если наименование не введено
            if (this.txt_NodeName.Text == "")
            {
                //Сообщаем об ошибке
                MessageBox.Show(
                        "Наименование не введено!",
                        "Ошибка",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            //Редактируем узел/ветвь
            frm_Home.SelectionNode.Text = this.txt_NodeName.Text;
            //Скрываем форму редактирования
            this.Hide();
        }
       
        private void cb_NodeType_SelectedValueChanged(object sender, EventArgs e)
        {
            //Переводим фокус по окончании выбора типа узла
            this.txt_NodeName.Focus(); 
        }

        private void txt_NodeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                b_OK.PerformClick();
            }
        }
        private void b_Cancel_Click(object sender, EventArgs e)
        {
            //Закрываем такущую форму
            this.Close();
        }

        private void frm_EditNode_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Закрываем такущую форму
            this.Close();
        }
    }
}
