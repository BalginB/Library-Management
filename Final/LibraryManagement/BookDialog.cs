namespace LibraryManagement
{
    public partial class BookDialog : Form
    {
        // Action property determines whether the dialog is used for adding a new book or editing an existing one
        public ActionType Action { get; set; } = ActionType.New;
        public Book BookInstance { get; set; }

        public BookDialog()
        {
            InitializeComponent();
            BookInstance = new Book();
        }

        private void BookDialog_VisibleChanged(object sender, EventArgs e)
        {
            // If in edit mode, populate the text fields with the existing book details

            if (Action == ActionType.Edit)
            {
                txtTitle.Text = BookInstance.Title;
                txtAuthor.Text = BookInstance.Author;
                txtGenre.Text = BookInstance.Genre;
                txtPrice.Text = BookInstance.Price.ToString();
            }
            else
            {
                // If in add mode, clear the text fields
                txtTitle.Text = string.Empty;
                txtAuthor.Text = string.Empty;
                txtGenre.Text = string.Empty;
                txtPrice.Text = string.Empty;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtGenre.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int price;
            if (!int.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid price format. Please enter a valid number.");
                return;
            }
            // Based on the action, either create a new book instance or update the existing one
            switch (Action)
            {
                case ActionType.New:
                    BookInstance = new Book(txtTitle.Text, txtAuthor.Text, txtGenre.Text, price);
                    break;
                case ActionType.Edit:
                    BookInstance.Title = txtTitle.Text;
                    BookInstance.Author = txtAuthor.Text;
                    BookInstance.Genre = txtGenre.Text;
                    BookInstance.Price = price;
                    break;
            }

            // Set the DialogResult to OK to indicate a successful operation
            DialogResult = DialogResult.OK;
        }
    }
}
