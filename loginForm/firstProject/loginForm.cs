namespace firstProject
{
    public partial class loginForm : Form
    {

        public loginForm()
        {
            // Customize the password field appearance
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            // Event handler for the close button
            this.Close();
        }

        // Event handler for the close button hover effect
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        private void closeButton_MouseLeave_1(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        // Event handler for recording the initial mouse position on panel click
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        // Event handler for the login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = loginField.Text;
            string password = passField.Text;

            // Check if the user is valid
            if (IsValidUser(username, password))
            {
                // Open the LibraryForm if the user is valid
                OpenLibraryForm();
            }
            else
            {
                MessageBox.Show("Wrong login or password");
            }
        }

        // Check if the entered username and password are valid
        private bool IsValidUser(string username, string password)
        {

            return (username == "admin" && password == "admin");
        }

        // Open the LibraryForm and hide the current form
        private void OpenLibraryForm()
        {

            LibraryManagement.Form1 libraryForm = new LibraryManagement.Form1();
            libraryForm.Show();


            this.Hide();
        }


    }
}
