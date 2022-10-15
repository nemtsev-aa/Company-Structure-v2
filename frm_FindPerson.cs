using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Структура_предприятия_v2
{
    public partial class frm_FindPerson : Form
    {
        
        String SelectionPerson;
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        List<RequestParameter> RequestParameters = new List<RequestParameter>();
        SqlConnection conn;
        public frm_FindPerson()
        {
           InitializeComponent();
        }

        private void frm_FindPerson_Load(object sender, EventArgs e)
        {
            //Создаём таблицу данных
            DT = CreateNewDataTable(new DataTable());
            //Добавляем таблицу в структуру данных
            DS.Tables.Add(DT);
            //Отображаем таблицу
            dgv_Person.DataSource = DS.Tables[0];
        }

        private void b_FindPerson_Click(object sender, EventArgs e)
        {
            if (CheckTextBox() == true)
            {
                DataTable FindResults = LoadGridFromDB(RequestParameters);
                
                if (FindResults != null)
                {
                    //Подключаем источних данных
                    dgv_Person.DataSource = FindResults;
                }
                else
                {
                    MessageBox.Show(
                                   "Поиск не дал результатов!",
                                   "Ошибка",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error,
                                   MessageBoxDefaultButton.Button1);
                }
            }

        }

        static DataTable CreateNewDataTable(DataTable SQLDataTable)
        {
            try
            {
                //Создаём таблицу данных
                 DataTable NewTable = new DataTable();
                //Названия столбцов
                string[] HeaderText = { "№ п/п", "Фамилия", "Имя", "Отчество" };
                //Добавляем столбцы с нужными названиями
                foreach (string iColumn in HeaderText)
                {
                    NewTable.Columns.Add(iColumn);
                }
                //Загружаем данные из MS SQL в таблицу
                //Заполняем таблицу данными

                for (int iRow = 0; iRow <= SQLDataTable.Rows.Count-1; iRow++)
                {
                    NewTable.Rows.Add();
                    NewTable.Rows[iRow].ItemArray = SQLDataTable.Rows[iRow].ItemArray;
                }
                NewTable.Columns.Remove("№ п/п");

                return NewTable;
            }
            catch
            {
                return null;
            }
            
        }

        private bool CheckTextBox()
        {
            int ParametrNumber = 0;
            bool filled = true;
            // Cоздаем переменные для обращения к элементам форм
            frm_Home frm_Home;

            foreach (Control iControl in this.Controls)
            {
                if (iControl is TextBox)
                {
                    //Текстовые поля
                    if (string.IsNullOrEmpty(iControl.Text) == true)
                    {
                        filled = true;
                    }
                    else
                    {
                        filled = false;
                        break;
                    }
                }
            }

            if (filled == true)
            {
                MessageBox.Show(
                    "Отсутствуют данные для поиска",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                RequestParameters.Clear();
                //Проходим по всем элементам формы и записываем данные из текстбоксов в массив
                foreach (Control iControl in this.Controls)
                {
                    if (iControl is TextBox)
                    {
                        //Текстовые поля
                        if (string.IsNullOrEmpty(iControl.Text) == true)
                        {
                            //Коллекция заполненных параметров
                            RequestParameter rp = new RequestParameter();
                            //Название параметра
                            rp.Name = iControl.Name.Substring(4, iControl.Name.Length - 4);
                            //Значение параметра
                            rp.Value = "'%'";

                            RequestParameters.Add(rp);
                        }
                        else
                        {
                            
                            //Коллекция заполненных параметров
                            RequestParameter rp = new RequestParameter();
                            //Название параметра
                            rp.Name = iControl.Name.Substring(4, iControl.Name.Length -4);
                            //Значение параметра
                            rp.Value = iControl.Text;

                            RequestParameters.Add(rp);
                        }
                        ParametrNumber++;
                    }    
                }
            return true;
            }
        }

        private bool GetConnect()
        {
            try
            {
                //string Server = "ARTEM\SQLEXPRESS";
                //string DataBase1 = "Management";
                //string UserName = "test";
                //string Password = "123";
                 
                conn = new SqlConnection(@"Data Source = ARTEM\SQLEXPRESS; Initial Catalog = Management; Integrated Security = True");
                conn.Open();
                return true;
            }
            catch
            {
                MessageBox.Show(
                    "Ошибка подключения к SQL БД",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        private DataTable LoadGridFromDB(List<RequestParameter> requestParameters)
        {
            try
            {
                SqlConnection ContactMgmt;
                SqlCommand cmd;
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                string sql;
                SqlCommandBuilder builder;

                //Производим подключение к SQL серверу
                //Если подключение неудачное - завершаем процедуру
                if (GetConnect() == false)
                {
                    return null;
                }

                ContactMgmt = conn;
                dt.Rows.Clear();

                if (RequestParameters.Count == 1)
                {
                    //Строка запроса
                    sql = "Select * From Person";
                    //Инициализируем запрос
                    cmd = new SqlCommand(sql, ContactMgmt);
                }
                else
                {
                    //Строка запроса
                    sql = "Select * From Person Where Family Like @Family Or Name LIKE @Name Or Patronymic LIKE @Patronymic";
                    //Инициализируем запрос
                    cmd = new SqlCommand(sql, ContactMgmt);
                    int i;
                    for (i=0; i <= RequestParameters.Count-1; i++)
                    {
                        //Название параметра
                        string ParametrName = "@" + RequestParameters[i].Name;
                        //Значение параметра
                        string ParametrValue = RequestParameters[i].Value;
                        //Добавляем параметр к запросу
                        cmd.Parameters.AddWithValue(ParametrName, ParametrValue);
                    }
                }
                //Выполняем запрос
                da.SelectCommand = cmd;
                //Увеличиваем врем запроса для обхода ошибки TimeOut
                da.SelectCommand.CommandTimeout = 5000;
                //Сохранем результат запроса в таблицу
                da.Fill(dt);
                //Корректировщик
                builder = new SqlCommandBuilder(da);
                //Закрываем соединение с БД
                conn.Close();
                //Возвращаем результат
                return dt;
            }
            catch (Exception e)
            {
                              
                MessageBox.Show(
                   "Ошибка в процедуре получения данных из SQL БД" + e.Message,
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                return null;
            }
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void b_OK_Click(object sender, EventArgs e)
        {
            frm_Home main = this.Owner as frm_Home;
            if (main != null)
            {
                //Фамилия
                main.txt_Family.Text = this.dgv_Person.SelectedRows[0].Cells[1].Value.ToString();
                //Имя
                main.txt_Name.Text = this.dgv_Person.SelectedRows[0].Cells[2].Value.ToString();
                //Отчество
                main.txt_MiddleName.Text = this.dgv_Person.SelectedRows[0].Cells[3].Value.ToString(); 
               
            }
           
            //Закрываем форму
            this.Close();
        }

    }
public class RequestParameter
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public void New()
        {
            
        }
        public void New(string sName, string sValue)
        {
            Name = sName;
            Value = sValue;
        }
    }
}