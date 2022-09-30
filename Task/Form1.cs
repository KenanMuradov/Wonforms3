using System.Text.Json;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            foreach (var control in (sender as Button)?.Parent.Controls)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace((control as TextBox)?.Text))
                {
                    MessageBox.Show("All Fields Must be written", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }



            User user = new(txtName.Text, txtSurname.Text, txtEmail.Text, txtPhone.Text, birthDatePicker.Value);
            File.WriteAllText($"{ user.Name}.json", JsonSerializer.Serialize(user));

            MessageBox.Show("Added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("File name cannot be empty");
                return;
            }

            DirectoryInfo directory = new(Directory.GetCurrentDirectory());

            User user = null!;

            foreach (var file in directory.GetFiles())
            {
                if (file.Name.Contains(txtFileName.Text))
                    user = JsonSerializer.Deserialize<User>(File.ReadAllText(file.Name))!;
            }


        }
    }
}