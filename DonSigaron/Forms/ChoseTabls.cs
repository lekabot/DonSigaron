using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class ChoseTabls : Form
    {
        DBFunctions functions = new DBFunctions();
        public ChoseTabls()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void choseTebles_Load(object sender, EventArgs e)
        {
            List<string> tableNames = functions.GetTableNamesFromDatabase();
            RoundButton[,] buttons = new RoundButton[tableNames.Count, tableNames.Count];

            for (int i = 0; i < tableNames.Count; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    RoundButton button = new RoundButton();
                    button.Text = tableNames[i];
                    button.Location = new Point(10, i * 40 + 10);
                    buttons[i, j] = button;
                    button.Click += new EventHandler(button_Click);
                    this.Controls.Add(button);
                }
            }
        }

        DataGridView dataGridView = new DataGridView();
        string nameOfTable;
        Form dataForm = new Form();
        TextBox textBox = new TextBox();
        private void button_Click(object sender, EventArgs e)
        {

            RoundButton button = (RoundButton)sender;
            nameOfTable = button.Text;
            string buttonName = button.Text;

            // Создаем новую форму

            dataForm.Text = $"{buttonName}";
            dataForm.StartPosition = FormStartPosition.CenterScreen;
            dataForm.Size = new Size(816, 489);

            // Создаем DataGridView и добавляем его на форму

            dataGridView.Dock = DockStyle.Top;
            dataForm.Controls.Add(dataGridView);

            // Создаем соединение с базой данных

            SqlConnection connection = new SqlConnection(DataBase.connectionString);


            // Создаем объект SqlDataAdapter и выполняем запрос
            string query = $"SELECT * FROM {buttonName}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;

            //Геним поиск
            textBox.Size = new Size(200, 20);
            textBox.Dock = DockStyle.Bottom;
            textBox.TextChanged += new EventHandler(textBox1_TextChanged);
            dataForm.Controls.Add(textBox);

            //// Геним кнопку Обновления данных
            RoundButton updateButton = new RoundButton();
            updateButton.Dock = DockStyle.Bottom;
            updateButton.Text = "Update data";
            updateButton.Click += buttonUpdate_Click;
            dataForm.Controls.Add(updateButton);

            // Геним кнопку Insert данных
            RoundButton insertButton = new RoundButton();
            insertButton.Dock = DockStyle.Bottom;
            insertButton.Text = "Inseart data";
            insertButton.Click += buttonInsert_Click;
            dataForm.Controls.Add(insertButton);

            //Геним кнопку Delet данных
            RoundButton deletButton = new RoundButton();
            deletButton.Dock = DockStyle.Bottom;
            deletButton.Text = "Delet row";
            deletButton.Click += btnDelete_Click;
            dataForm.Controls.Add(deletButton);

            //Геним кнопку возвращения
            RoundButton backButton = new RoundButton();
            backButton.Dock = DockStyle.Bottom;
            backButton.Text = "Back";
            backButton.Click += backToChoseTable;
            dataForm.Controls.Add(backButton);

            this.Hide();
            dataForm.Show();
        }
        //Переход на прошлую форму
        private void backToChoseTable(object sender, EventArgs e)
        {
            dataForm.Hide();
            ChoseTabls choseTabls = new ChoseTabls();
            choseTabls.Show();
        }
        //Удаление данных
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Проверяем, что в DataGridView выбрана хотя бы одна строка
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Получаем значение идентификатора выбранной строки из первой колонки DataGridView
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);

                // Удаляем выбранную строку из базы данных
                string query = $"DELETE FROM {nameOfTable} WHERE id = @id";
                using (SqlConnection connection = new SqlConnection(DataBase.connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Удаляем выбранную строку из DataGridView
                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        //Поиск ёпта
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool match = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        match = true;
                        break;
                    }
                }

                row.Selected = match;
            }
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string tableName = nameOfTable;

            List<string> columns = new List<string>();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                columns.Add(column.Name);
            }

            List<string> values = new List<string>();
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                values.Add(cell.Value.ToString());
            }

            string query = "INSERT INTO " + tableName + " (";
            for (int i = 1; i < columns.Count; i++)
            {
                query += "[" + columns[i] + "]";
                if (i < columns.Count - 1)
                {
                    query += ",";
                }
            }
            query += ") VALUES (";
            for (int i = 1; i < values.Count; i++)
            {
                query += "@" + i.ToString();
                if (i < values.Count - 1)
                {
                    query += ",";
                }
            }
            query += ")";

            using (SqlConnection connection = new SqlConnection(DataBase.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                for (int i = 0; i < values.Count; i++)
                {
                    command.Parameters.AddWithValue("@" + i.ToString(), values[i]);
                }
                connection.Open();
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Data has inserted");
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Get selected rows from DataGridView 
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                selectedRows.Add(row);
            }

            // Create connection to database 
            using (SqlConnection connection = new SqlConnection(DataBase.connectionString))
            {
                connection.Open();

                // Iterate through selected rows and update data in database 
                foreach (DataGridViewRow row in selectedRows)
                {
                    // Get values of cells in the row 
                    List<object> values = new List<object>();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        values.Add(cell.Value);
                    }

                    // Construct SQL query to update data in database 

                    string primaryKeyColumnName = "id";
                    string primaryKeyValue = row.Cells[primaryKeyColumnName].Value.ToString();

                    StringBuilder sb = new StringBuilder();
                    sb.Append($"UPDATE {nameOfTable} SET ");

                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        string columnName = row.Cells[i].OwningColumn.Name;
                        object value = row.Cells[i].Value;

                        if (columnName != primaryKeyColumnName)
                        {
                            sb.Append($"{columnName} = @{columnName}, ");
                        }
                    }

                    sb.Remove(sb.Length - 2, 2); // Remove trailing comma and space 
                    sb.Append($" WHERE {primaryKeyColumnName} = '{primaryKeyValue}'");

                    string query = sb.ToString();

                    // Create SqlCommand object with query and parameters 
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            string columnName = row.Cells[i].OwningColumn.Name;
                            object value = row.Cells[i].Value;

                            if (columnName != primaryKeyColumnName)
                            {
                                command.Parameters.AddWithValue($"@{columnName}", value);
                            }
                        }

                        // Execute command to update data 
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Data has udpate");
            }
        }
    }
}
