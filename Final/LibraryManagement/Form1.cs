using System.ComponentModel;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        ReaderDialog readerDialog = new ReaderDialog();

        public Form1()
        {
            InitializeComponent();
            dgvStorage.AutoGenerateColumns = false;
            dgvBorrowed.AutoGenerateColumns = false;

            // Load readers and books from XML files
            Database.Readers = Database.Deserialize<Reader>("readers.xml");
            Database.Storage = Database.Deserialize<Book>("storage.xml");

            // Set data sources for DataGridViews
            dgvReaders.DataSource = Database.Readers;
            dgvStorage.DataSource = Database.Storage;

        }



        private void PopulateBorrowedBooks()
        {
            // Populate DataGridView with borrowed books for the selected reader
            if (dgvReaders.CurrentRow != null)
            {
                var selectedReader = dgvReaders.CurrentRow.DataBoundItem as Reader;
                if (selectedReader != null)
                {
                    dgvBorrowed.DataSource = new BindingList<Book>(selectedReader.Borrowed.ToList());
                    SetButtons();
                }
            }
        }





        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Return a borrowed book
            var r = dgvReaders.CurrentRow.DataBoundItem as Reader;
            var b = dgvBorrowed.CurrentRow.DataBoundItem as Book;
            if (r != null && b != null)
            {
                Database.Return(r, b);
                PopulateBorrowedBooks();
                SetButtons();
            }
        }

        private void btnNewReader_Click(object sender, EventArgs e)
        {
            // Open a dialog to add a new reader
            readerDialog.Action = ActionType.New;
            if (readerDialog.ShowDialog() == DialogResult.OK)
            {
                Database.Readers.Add(readerDialog.ReaderInstance);
                dgvReaders.DataSource = null;
                dgvReaders.DataSource = Database.Readers;
            }
        }

        private void btnEditReader_Click(object sender, EventArgs e)
        {
            // Open a dialog to edit an existing reader
            readerDialog.Action = ActionType.Edit;
            readerDialog.ReaderInstance = dgvReaders.CurrentRow.DataBoundItem as Reader;
            readerDialog.ShowDialog();
        }




        private void dgvReaders_SelectionChanged(object sender, EventArgs e)
        {
            // Update the borrowed books list when the selected reader changes
            PopulateBorrowedBooks();
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            // Borrow a book for the selected reader
            var r = dgvReaders.CurrentRow.DataBoundItem as Reader;
            var b = dgvStorage.CurrentRow.DataBoundItem as Book;
            Database.Borrow(r, b);
            PopulateBorrowedBooks();

            SetButtons();
        }

        private void SetButtons()
        {   // Enable or disable buttons based on available books and borrowed books
            btnBorrow.Enabled = (dgvStorage.Rows.Count > 0) ? true : false;
            btnReturn.Enabled = (dgvBorrowed.Rows.Count > 0) ? true : false;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {// Save data to XML files on form closing
            Database.Serialize();
            Application.Exit();
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            // Open a dialog to add a new book
            BookDialog bookDialog = new BookDialog();
            bookDialog.Action = ActionType.New;

            if (bookDialog.ShowDialog() == DialogResult.OK)
            {
                Database.Storage.Add(bookDialog.BookInstance);
                dgvStorage.DataSource = null;
                dgvStorage.DataSource = Database.Storage;
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {   // Open a dialog to edit an existing book
            var selectedBook = dgvStorage.CurrentRow.DataBoundItem as Book;

            if (selectedBook != null)
            {
                BookDialog bookDialog = new BookDialog();
                bookDialog.Action = ActionType.Edit;
                bookDialog.BookInstance = selectedBook;

                if (bookDialog.ShowDialog() == DialogResult.OK)
                {
                    dgvStorage.DataSource = null;
                    dgvStorage.DataSource = Database.Storage;
                }
            }
        }

        private void btnDeleteReader_Click(object sender, EventArgs e)
        {
            // Delete a selected reader
            var selectedReader = dgvReaders.CurrentRow?.DataBoundItem as Reader;

            if (selectedReader != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the user {selectedReader.FirstName} {selectedReader.LastName}?", "Deletion Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Database.Readers.Remove(selectedReader);
                    dgvReaders.DataSource = null;
                    dgvReaders.DataSource = Database.Readers;
                }
            }
            else
            {
                MessageBox.Show("Select a user to delete.");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            // Delete a selected book
            var selectedBook = dgvStorage.CurrentRow?.DataBoundItem as Book;

            if (selectedBook != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the book '{selectedBook.Title}'?", "Deletion Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Database.Storage.Remove(selectedBook);
                    dgvStorage.DataSource = null;
                    dgvStorage.DataSource = Database.Storage;
                }
            }
            else
            {
                MessageBox.Show("Select a book to delete.");
            }
        }


    }
}
