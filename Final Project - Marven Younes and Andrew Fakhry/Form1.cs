using System.Data;
using System.Windows.Forms;

namespace Final_Project___Marven_Younes_and_Andrew_Fakhry
{
    public partial class GMS : System.Windows.Forms.Form
    {


        private DataTable studentData = new DataTable();

        public GMS()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void ApplyData_Click(object sender, EventArgs e)
        {
            string name = StudentName.Text;
            string semester = EnrollmentYear.Text;
            if (double.TryParse(StudentGrade.Text, out double grade) && grade >= 0 && grade <= 100)
            {
                studentData.Rows.Add(name, semester, grade, DBNull.Value);
            }
            else
            {
                MessageBox.Show("Please enter a valid grade between 0 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void InitializeDataTable()
        {
            studentData.Columns.Add("Name", typeof(string));
            studentData.Columns.Add("Semester", typeof(string));
            studentData.Columns.Add("Grade", typeof(double));
            studentData.Columns.Add("Adjusted Grade", typeof(double));
            dataGrid.DataSource = studentData;
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    studentData.Clear();
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    foreach (var line in lines.Skip(1)) // Skip header row
                    {
                        string[] values = line.Split(',');
                        studentData.Rows.Add(
                        values[0],
                        values[1],
                        string.IsNullOrWhiteSpace(values[2]) ? 0.0 : double.Parse(values[2]),
                        values.Length > 3 && !string.IsNullOrWhiteSpace(values[3]) ? double.Parse(values[3]) : (object)DBNull.Value
);

                    }
                }
            }
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.WriteLine("Name,Semester,Grade,Adjusted Grade");
                        foreach (DataRow row in studentData.Rows)
                        {
                            sw.WriteLine(string.Join(",", row.ItemArray));
                        }
                    }
                }
            }
        }

        private void CalculateStats_Click(object sender, EventArgs e)
        {
            var grades = studentData.AsEnumerable().Select(row => row.Field<double>("Grade")).ToList();
            if (grades.Count > 0)
            {
                double average = grades.Average();
                double max = grades.Max();
                double min = grades.Min();
                MessageBox.Show($"Class Average: {average:F2}\nMax Grade: {max}\nMin Grade: {min}", "Statistics");
            }
            else
            {
                MessageBox.Show("No grades available to calculate statistics.", "Error");
            }
        }

        private void CountPassFail_Click(object sender, EventArgs e)
        {
            int passing = studentData.AsEnumerable().Count(row => row.Field<double>("Grade") >= 50);
            int failing = studentData.Rows.Count - passing;
            MessageBox.Show($"Passing: {passing}\nFailing: {failing}", "Pass/Fail Count");
        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnrollmentYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentGrade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            LoadData_Click(sender, e);
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            studentData.Clear();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveData_Click(sender, e);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GMS_Load(object sender, EventArgs e)
        {

        }

        private void ApplyRaise_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the raise value from the NumericUpDown control
                double raiseAmount = (double)RaiseValue.Value;

                // Loop through all rows and update the "Adjusted Grade" column
                foreach (DataRow row in studentData.Rows)
                {
                    if (row["Grade"] != DBNull.Value && double.TryParse(row["Grade"].ToString(), out double originalGrade))
                    {
                        // Apply raise and cap at 100
                        double adjustedGrade = originalGrade + raiseAmount;
                        if (adjustedGrade > 100)
                        {
                            adjustedGrade = 100;
                        }

                        // Update the "Adjusted Grade" column
                        row["Adjusted Grade"] = adjustedGrade;
                    }
                }

                MessageBox.Show("Grades successfully adjusted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void RaiseValue_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
