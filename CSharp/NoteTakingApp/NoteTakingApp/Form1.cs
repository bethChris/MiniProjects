using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NoteTakingApp
{
    public partial class Form1 : Form
    {

        DataTable table;
        int currentNote;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBody_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Body", typeof(String));

            noteGrid.DataSource = table;
            currentNote = -1;

            noteGrid.Columns["Body"].Visible = false;
            noteGrid.Columns["Title"].Width = 212;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtBody.Clear();

            saveStatus.Text = "Not Saved";

            currentNote = -1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (currentNote != -1)
            {
                table.Rows[currentNote].SetField("Title", txtTitle.Text);
                table.Rows[currentNote].SetField("Body", txtBody.Text);
            }
            else
            {
                table.Rows.Add(txtTitle.Text, txtBody.Text);
                currentNote = table.Rows.Count - 1;
            }

            String timestamp = DateTime.Now.ToString("HH:mm:ss tt");
            saveStatus.Text = "Saved at " + timestamp;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            int index = noteGrid.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtBody.Text = table.Rows[index].ItemArray[1].ToString();

                currentNote = index;
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = noteGrid.CurrentCell.RowIndex;

            if (index > -1)
            {
                table.Rows.RemoveAt(index);

                //if currently displayed note got deleted, clear screen
                if (index == currentNote)
                {
                    newButton_Click(this, new EventArgs());
                }
                else //else if it was less than the current note, decrement
                {
                    if (index < currentNote)
                    {
                        currentNote -= 1;
                    }
                }
            }

        }

        private void saveStatus_Click(object sender, EventArgs e)
        {

        }

        private void noteGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
