using System;
using System.Data;
using System.Windows.Forms;

namespace TaskProjectVSB
{
    public partial class TaskProject : Form
    {

        public TaskProject()
        {
            InitializeComponent();
        }

        private void todayDateLable_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int n = dataGridView.Rows.Add();
            dataGridView.Rows[n].Cells[0].Value = taskNameTextBox.Text;
            dataGridView.Rows[n].Cells[1].Value = minutesUpDown.Value.ToString();
            dataGridView.Rows[n].Cells[2].Value = startLineDateTime.Value.ToString();
            dataGridView.Rows[n].Cells[3].Value = deadLineDateTime.Value.ToString();
            dataGridView.Rows[n].Cells[4].Value = this.completeCheckBox.Checked;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void taskNameLable_Click(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {
            todayDate.Text = DateTime.Now.Date.ToString();
        }

        private void saveFileasXMLButton_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Navigation";
            dt.Columns.Add("UserName");
            dt.Columns.Add("Type");
            ds.Tables.Add(dt);

            DataTable dt1 = new DataTable();
            dt1.TableName = "TaskDitails";
            dt1.Columns.Add("TaskName");
            dt1.Columns.Add("Minutes");
            dt1.Columns.Add("Startline");
            dt1.Columns.Add("Deadline");
            dt1.Columns.Add("Complite");
            ds.Tables.Add(dt1);

            DataRow row = ds.Tables["Navigation"].NewRow();
            row["UserName"] = userNameTextBox.Text;
            row["Type"] = typeTextBox.Text;
            ds.Tables["Navigation"].Rows.Add(row);

            foreach(DataGridViewRow r in dataGridView.Rows)
            {
                DataRow row1 = ds.Tables["TaskDitails"].NewRow();
                row1["TaskName"] = r.Cells[0].Value.ToString();
                row1["Minutes"] = r.Cells[1].Value.ToString();
                row1["Startline"] = r.Cells[2].Value.ToString();
                row1["Deadline"] = r.Cells[3].Value.ToString();
                row1["Complite"] = r.Cells[4].Value.ToString();
                ds.Tables["TaskDitails"].Rows.Add(row1);
            }
            var FD = new System.Windows.Forms.SaveFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);
                ds.WriteXml(fileToOpen);
            }
        }

        private void typeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadProjectFileFromXMLButton_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);
                ds.ReadXml(fileToOpen);
            }
            userNameTextBox.Text = ds.Tables["Navigation"]
                                     .Rows[0][0]
                                     .ToString();
            typeTextBox.Text = ds.Tables["Navigation"]
                                 .Rows[0][1]
                                 .ToString();
            foreach (DataRow item in ds.Tables["TaskDitails"].Rows)
            {
                int n = dataGridView.Rows.Add();
                dataGridView.Rows[n].Cells[0].Value = item["TaskName"].ToString();
                dataGridView.Rows[n].Cells[1].Value = item["Minutes"].ToString();
                dataGridView.Rows[n].Cells[2].Value = item["Startline"].ToString();
                dataGridView.Rows[n].Cells[3].Value = item["Deadline"].ToString();
                dataGridView.Rows[n].Cells[4].Value = item["Complite"].ToString();
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            dataGridView.SelectedRows[0].Cells[0].Value = taskNameTextBox.Text;
            dataGridView.SelectedRows[0].Cells[1].Value = minutesUpDown.Value;
            dataGridView.SelectedRows[0].Cells[2].Value = startLineDateTime.Value;
            dataGridView.SelectedRows[0].Cells[3].Value = deadLineDateTime.Value;
            dataGridView.SelectedRows[0].Cells[4].Value = this.completeCheckBox.Checked;
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            taskNameTextBox.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            minutesUpDown.Value = decimal.Parse(dataGridView.SelectedRows[0].Cells[1].Value.ToString());
            startLineDateTime.Value = DateTime.Parse(dataGridView.SelectedRows[0].Cells[2].Value.ToString());
            deadLineDateTime.Value = DateTime.Parse(dataGridView.SelectedRows[0].Cells[3].Value.ToString());
            this.completeCheckBox.Checked = bool.Parse(dataGridView.SelectedRows[0].Cells[4].Value.ToString());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskDetailsLable_Click(object sender, EventArgs e)
        {

        }

        private void taskNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deadlineLable_Click(object sender, EventArgs e)
        {

        }

        private void compite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void minutesUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void userNameLable_Click(object sender, EventArgs e)
        {

        }

        private void typeLable_Click(object sender, EventArgs e)
        {

        }

        private void startlineLable_Click(object sender, EventArgs e)
        {

        }

        private void minutesLable_Click(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startLineDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void deadLineDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addEditTaskDetailsLable_Click(object sender, EventArgs e)
        {

        }
    }
}
