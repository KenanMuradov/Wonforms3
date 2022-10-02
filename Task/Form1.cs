using System.Text.Json;
using System.Text.RegularExpressions;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MessageBoxCustom(string message) => MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private DirectoryInfo directory = new($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\TaskForm");

        private void btnAddEdit_Click(object sender, EventArgs e)
        {


            foreach (var control in gbForm.Controls)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace((control as TextBox)?.Text))
                {
                    MessageBoxCustom("All Fields Must Be Written");
                    return;
                }
                else if (control is DateTimePicker && (control as DateTimePicker)?.Value > DateTime.Now)
                {
                    MessageBoxCustom("You Cannot Live In Future");
                    return;
                }
            }
            string? phonePattern = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";

            if (!Regex.Match(txtPhone.Text, phonePattern).Success)
            {
                MessageBoxCustom("Invalid Phone Number");
                return;
            }

            User user = new(txtName.Text, txtSurname.Text, txtEmail.Text, txtPhone.Text, birthDatePicker.Value);

            lbUserData.Items.Add(user);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!directory.Exists)
                Directory.CreateDirectory(directory.FullName);

            foreach (var user in lbUserData.Items)
                File.WriteAllText($@"{directory.FullName}\{(user as User)?.Name}.json", JsonSerializer.Serialize(user));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (directory.Exists)
            {
                foreach (var file in directory.GetFiles())
                    lbUserData.Items.Add(JsonSerializer.Deserialize<User>(File.ReadAllText(file.FullName))!);
            }

        }

        private void lbUserData_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFileName.Text = (lbUserData.SelectedItem as User)?.Name;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBoxCustom("File Name Cannot Be Empty");
                return;
            }

            if (!directory.Exists)
            {
                MessageBoxCustom("File Doesn't Exist");
                return;
            }

            User? user = null;

            foreach (var file in directory.GetFiles())
            {
                if (file.Name.Contains(txtFileName.Text))
                    user = JsonSerializer.Deserialize<User>(File.ReadAllText(file.FullName));
            }

            if (user != null)
            {
                txtName.Text = user.Name;
                txtSurname.Text = user.Surname;
                txtEmail.Text = user.Email;
                txtPhone.Text = user.Phone;
                birthDatePicker.Value = user.BirthDate;
                return;
            }

            MessageBoxCustom("File Doesn't Exist");

        }
    }
}