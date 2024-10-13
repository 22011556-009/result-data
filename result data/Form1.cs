using System.Data;

namespace result_data
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void form1_load(object sender, EventArgs e)
        {
            table.Columns.Add("Course Code", Type.GetType("System.String"));
            table.Columns.Add("Course Title", Type.GetType("System.String"));
            table.Columns.Add("Obt. Marks", Type.GetType("System.String"));
            table.Columns.Add("Grade", Type.GetType("System.String"));
            table.Columns.Add("Status", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = textBox3.Text;
            newdata.Cells[3].Value = textBox4.Text;
            newdata.Cells[4].Value = textBox5.Text;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
