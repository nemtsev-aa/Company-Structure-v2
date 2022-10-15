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
    public partial class frm_PersonList : Form
    {
        public frm_PersonList()
        {
            InitializeComponent();
        }

        private void frm_PersonList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "managementDataSet.Person". При необходимости она может быть перемещена или удалена.
            this.personTableAdapter.Fill(this.managementDataSet.Person);
        }

        private void tsb_AddPerson_Click(object sender, EventArgs e)
        {
            //Переменная для работы с DataGridView
            DataGridView dgv = this.dgv_Person;
            //Cнимаем текущее выделение
            dgv.ClearSelection();
            DataTable dtPerson = managementDataSet.Person;
            DataRow NewRow = dtPerson.NewRow();
            //Добавляем новую строку в конец таблицы(источник данных для DGV)
            managementDataSet.Person.AddPersonRow(dtPerson.Rows.Count + 1, "", "", "");
            //Обновляем источник данных для DGV
            personTableAdapter.Update(managementDataSet.Person);
            //Перемещаем курсор на новую строку в первую ячейку
            dgv.CurrentCell = dgv[1, dgv.Rows.Count - 1];
            //Активируем режим редактирования
            this.tsb_EditPerson.Checked = true;
        }

        private void tsb_EditPerson_Click(object sender, EventArgs e)
        {
            //Если таблица не содержить записей - выходим из процедуры
            if (dgv_Person.Rows.Count == 0)
            {
                return;
            }
            else
            {
                //Управляем возможностью редактирования для выделенной строки
                DataGridViewCell cCell = dgv_Person.SelectedCells[0];
                if (tsb_EditPerson.Checked == false)
                {
                    //Закрываем возможность редактирования
                    cCell.ReadOnly = true;
                    //Обновляем данные в БД
                    personTableAdapter.Update(managementDataSet.Person);
                }
                else
                {
                    //Открываем возможность редактирования
                    cCell.ReadOnly = false;
                }
            }          
        }

        private void tsb_DelPerson_Click(object sender, EventArgs e)
        {
            //Определем строку для удаления по выбранной ячейке
            DataGridViewRow sRow = this.dgv_Person.Rows[dgv_Person.CurrentCell.RowIndex];
            //Удаляем выбранную строку
            this.dgv_Person.Rows.Remove(sRow);
            //Обновляем данные через адаптер
            personTableAdapter.Update(managementDataSet.Person);
        }    

        private void dgv_Person_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex > 0)
            {
                //Управляем возможностью редактирования для выделенной строки
                DataGridViewCell cCell = dgv_Person.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (tsb_EditPerson.Checked == false)
                    {
                        //Закрываем возможность редактирования
                         cCell.ReadOnly = true;
                    }
                else
                    {
                        //Открываем возможность редактирования
                        cCell.ReadOnly = false;
                    }
            }
        }
        private void frm_PersonList_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Обновляем данные в БД
                personTableAdapter.Update(managementDataSet.Person);
                //Сообщаем пользователю об успешном добавлении
                MessageBox.Show(
                    "Данные физических лиц успешно сохранены!",
                    "Успех",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            catch
            {
                //Сообщаем пользователю об ошибке
                MessageBox.Show(
                   "Ошибка в процедуре сохранения данных физических лиц!",
                   "Успех",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
                this.Close();
            }
        }
    }
    public class Person
    {
        public string Family { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string AddDate { get; set; }
        
        public void New(string sFamily,string sName,string sPatronymic)
        {
           Family = sFamily;
            Name = sName;
            Patronymic = sPatronymic;
        }
    }
    public class Team
    {
        public List<Person> Items = new List<Person>();

        public void Add(Person aPerson)
        {
            Items.Add(aPerson);
        }
    }
}
