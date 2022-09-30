using System.Text;

namespace Wonforms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            monthCalendar.BoldedDates = new DateTime[]
            {
                new DateTime(2022,9,24),
                new DateTime(2022,9,25),
            };



            List<string> colors = new()
            {
                "Red",
                "Green",
                "Blue",
                "Vyan",
                "Purple",
                "Pink",
                "Black",
                "White",
            };


            // // Way 1
            // listBox1.DataSource = colors;



            ///// Way 2
            listBox1.Items.AddRange(colors.ToArray());

            // listBox1.SelectedIndex = 2;

            // listBox1.SelectionMode = SelectionMode.None;
            // listBox1.SelectionMode = SelectionMode.One;
            // listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.SelectionMode = SelectionMode.MultiExtended;

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar.MaxSelectionCount = 10;

            lblStartDate.Text = e.Start.ToShortDateString();
            lblbEndDate.Text = e.End.ToShortDateString();
        }

        private void monthCalendar_MouseDown(object sender, MouseEventArgs e)
        {
            var loc = monthCalendar.HitTest(e.Location);


            if (loc.HitArea == MonthCalendar.HitArea.Date)
            {
                if (monthCalendar.BoldedDates.Contains(loc.Time))
                    monthCalendar.RemoveBoldedDate(loc.Time);
                else
                    monthCalendar.AddBoldedDate(loc.Time);

                monthCalendar.UpdateBoldedDates();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lblColor.Text = listBox1.Text;
            lblColor.Text = listBox1.SelectedIndex.ToString();

            StringBuilder sb = new();
            foreach (var item in listBox1.SelectedItems)
                sb.Append($"{item.ToString()}\n");


            lblColor.Text = sb.ToString();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Empty");
                return;
            }

            if (listBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("Already exists");
                return;
            }

            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<Student> students = new()
            {
                new("Huseyn", "Ibrahimov"),
                new("Tural", "Haci-Nebili"),
                new("Murad", "Meherremli"),
                new("Kenan", "Muradov"),
                new("Nihat", "Ekremi"),
            };

            //lBoxStudents.Items.AddRange(students.ToArray());
            lBoxStudents.DisplayMember = "Name";

            lBoxStudents.DataSource = students;
            lBoxStudents.ValueMember = "Id";

        }

        private void lBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var student = lBoxStudents.SelectedItem as Student;
            // lblStudents.Text = student?.ToString();

            lblStudents.Text = lBoxStudents.SelectedValue.ToString();
        }
    }
}