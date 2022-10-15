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
    public partial class frm_Home : Form
    {
        public static TreeNode SelectionNode;
        public static string Operation;
        
        public frm_Home()
        {
            InitializeComponent();
        }

        private void tsb_AddNode_Click(object sender, EventArgs e)
        {
            //Присваиваем значения переменным
            SelectionNode = this.trv_Structure.SelectedNode;
            Operation = "Add";
            // Cоздаем переменные для обращения к элементам форм
            frm_EditNode frm_EditNode = new frm_EditNode();
            frm_EditNode.Owner = this;
            switch (this.trv_Structure.SelectedNode.Tag.ToString())
            {
                case "General":
                    //Переходи на форму "Корректировка узла"
                    frm_EditNode.cb_NodeType.Enabled = true;
                    //Добавляем узел одного из типов
                    //Предоставляем пользователю выбор типа узла
                    frm_EditNode.cb_NodeType.Items.AddRange(new string[] { "[Выберите значение]", "Подразделение", "Должность"});
                    frm_EditNode.cb_NodeType.Text = "[Выберите значение]";
                    frm_EditNode.txt_NodeName.Text = "";
                    frm_EditNode.ShowDialog();
                    break;
                case "Подразделение":
                    //Переходи на форму "Корректировка узла"
                    frm_EditNode.cb_NodeType.Enabled = true;
                    //Добавляем узел одного из типов
                    //Предоставляем пользователю выбор типа узла
                    frm_EditNode.cb_NodeType.Items.AddRange(new string[] { "[Выберите значение]", "Подразделение", "Должность" });
                    frm_EditNode.cb_NodeType.Text = "[Выберите значение]";
                    frm_EditNode.txt_NodeName.Text = "";
                    frm_EditNode.ShowDialog();
                    break;
                case "Должность":
                    MessageBox.Show(
                          "Дальнейшее ветвление невозможно!",
                          "Ошибка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error,
                          MessageBoxDefaultButton.Button1,
                          MessageBoxOptions.DefaultDesktopOnly);
                  
                    break;
            }
        }
        private void tsb_EditNode_Click(object sender, EventArgs e)
        {
            //Присваиваем значения переменным
            SelectionNode = this.trv_Structure.SelectedNode;
            Operation = "Edit";
            // Cоздаем переменные для обращения к элементам форм
            frm_EditNode frm_EditNode = new frm_EditNode();
            switch (this.trv_Structure.SelectedNode.Tag.ToString())
            {
                case "Подразделение":
                    //Переходи на форму "Корректировка узла"
                    frm_EditNode.cb_NodeType.Enabled = false;
                    //Добавляем узел одного из типов
                    //Предоставляем пользователю выбор типа узла
                    frm_EditNode.cb_NodeType.Text = SelectionNode.Tag.ToString();
                    frm_EditNode.txt_NodeName.Text = "";
                    frm_EditNode.ShowDialog();
                    break;
                case "Должность":
                    //Переходи на форму "Корректировка узла"
                    frm_EditNode.cb_NodeType.Enabled = false;
                    //Добавляем узел одного из типов
                    //Предоставляем пользователю выбор типа узла
                    frm_EditNode.cb_NodeType.Text = SelectionNode.Tag.ToString();
                    frm_EditNode.txt_NodeName.Text = "";
                    frm_EditNode.ShowDialog();
                    break;
                case "General":
                    MessageBox.Show(
                          "Изменение корневого объекта невозможно!",
                          "Ошибка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error,
                          MessageBoxDefaultButton.Button1,
                          MessageBoxOptions.DefaultDesktopOnly);
                    break;
            }
        }
        private void tsb_DelNode_Click(object sender, EventArgs e)
        {
            //Присваиваем значения переменным
            SelectionNode = this.trv_Structure.SelectedNode;
            Operation = "Del";
            
            switch (this.trv_Structure.SelectedNode.Tag.ToString())
            {
                case "Подразделение":
                    //Удаляем вбранный узел
                    this.trv_Structure.SelectedNode.Remove();
                    break;
                case "Должность":
                    //Удаляем вбранный узел
                    this.trv_Structure.SelectedNode.Remove();
                    break;
                case "General":
                    MessageBox.Show(
                           "Удаление корневого объекта невозможно!",
                           "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error,
                           MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.DefaultDesktopOnly);
                    break;
            }
        }
        private void trv_Structure_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Присваиваем значения переменным
            SelectionNode = this.trv_Structure.SelectedNode;
            switch (SelectionNode.Tag.ToString())
            {
                case "General":
                    InputControl(false);
                    break;
                case "Подразделение":
                    InputControl(false);
                    break;
                case "Должность":
                    InputControl(true);
                    break;
            }
                
        }
        private void InputControl(Boolean iValue)
        {
            //Проходим по всем элементам формы и меняем их доступность
            foreach (Control iControl in this.Controls)
            {
                if (iControl is TextBox)
                {
                    //Текстовые поля
                    ((TextBox)iControl).Enabled = iValue;
                }
                else if (iControl is Button)
                {
                    //Кнопки
                    ((Button)iControl).Enabled = iValue;
                }
                else if(iControl is DateTimePicker)
                {
                    //Выбор даты
                    ((DateTimePicker)iControl).Enabled = iValue;
                }
            }
        }
        private void b_FindPerson_Click(object sender, EventArgs e)
        {
            //Переходи на форму "Выбор физического лица"
            frm_FindPerson frm_FindPerson = new frm_FindPerson();
            frm_FindPerson.Owner = this;
            frm_FindPerson.Show(); 
        }

        private void tsb_Persons_Click(object sender, EventArgs e)
        {
            //Переходи на форму "Справочник физических лиц"
            frm_PersonList frm_PersonList = new frm_PersonList();
            frm_PersonList.Owner = this;
            frm_PersonList.Show(); 
        }

        private void b_ClearForm_Click(object sender, EventArgs e)
        {
            //Проходим по всем элементам формы и обнуляем их значения
            foreach (Control iControl in this.Controls)
            {
                if (iControl is TextBox)
                {
                    //Очищаем текстовые поля
                    ((TextBox)iControl).Text = null;
                }
                else if (iControl is DateTimePicker)
                    //Очищаем выбор даты
                    ((DateTimePicker)iControl).Text = DateTime.Now.ToString();
            }
        }

        
    }
}
