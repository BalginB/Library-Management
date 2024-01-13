using System;

namespace LibraryManagement
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvBorrowed = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dgvReaders = new DataGridView();
            dgvStorage = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            btnBorrow = new Button();
            btnReturn = new Button();
            btnNewReader = new Button();
            btnEditReader = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnNewBook = new Button();
            btnEditBook = new Button();
            btnDeleteReader = new Button();
            btnDeleteBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReaders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStorage).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowed
            // 
            dgvBorrowed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowed.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvBorrowed.BackgroundColor = Color.Peru;
            dgvBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowed.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvBorrowed.GridColor = Color.White;
            dgvBorrowed.Location = new Point(18, 397);
            dgvBorrowed.Margin = new Padding(4, 3, 4, 3);
            dgvBorrowed.Name = "dgvBorrowed";
            dgvBorrowed.Size = new Size(443, 233);
            dgvBorrowed.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Title";
            Column1.HeaderText = "Title";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Author";
            Column2.HeaderText = "Author";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Genre";
            Column3.HeaderText = "Genre";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Price";
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            // 
            // dgvReaders
            // 
            dgvReaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReaders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvReaders.BackgroundColor = Color.Peru;
            dgvReaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReaders.Location = new Point(18, 29);
            dgvReaders.Margin = new Padding(4, 3, 4, 3);
            dgvReaders.Name = "dgvReaders";
            dgvReaders.Size = new Size(443, 268);
            dgvReaders.TabIndex = 1;
            dgvReaders.SelectionChanged += dgvReaders_SelectionChanged;
            // 
            // dgvStorage
            // 
            dgvStorage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStorage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvStorage.BackgroundColor = Color.Peru;
            dgvStorage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStorage.Columns.AddRange(new DataGridViewColumn[] { Title, Author, Genre, Price });
            dgvStorage.GridColor = SystemColors.ActiveCaption;
            dgvStorage.Location = new Point(847, 29);
            dgvStorage.Margin = new Padding(4, 3, 4, 3);
            dgvStorage.Name = "dgvStorage";
            dgvStorage.Size = new Size(450, 601);
            dgvStorage.TabIndex = 2;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.Name = "Title";
            // 
            // Author
            // 
            Author.DataPropertyName = "Author";
            Author.HeaderText = "Author";
            Author.Name = "Author";
            // 
            // Genre
            // 
            Genre.DataPropertyName = "Genre";
            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // btnBorrow
            // 
            btnBorrow.Cursor = Cursors.Hand;
            btnBorrow.Font = new Font("Times New Roman", 10.25F);
            btnBorrow.Location = new Point(626, 78);
            btnBorrow.Margin = new Padding(4, 3, 4, 3);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(105, 37);
            btnBorrow.TabIndex = 3;
            btnBorrow.Text = "Borrow Book";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnReturn
            // 
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.Font = new Font("Times New Roman", 10.25F);
            btnReturn.Location = new Point(626, 135);
            btnReturn.Margin = new Padding(4, 3, 4, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(105, 38);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnNewReader
            // 
            btnNewReader.Cursor = Cursors.Hand;
            btnNewReader.Font = new Font("Times New Roman", 10.25F);
            btnNewReader.Location = new Point(47, 303);
            btnNewReader.Margin = new Padding(4, 3, 4, 3);
            btnNewReader.Name = "btnNewReader";
            btnNewReader.Size = new Size(105, 39);
            btnNewReader.TabIndex = 5;
            btnNewReader.Text = "New Reader";
            btnNewReader.UseVisualStyleBackColor = true;
            btnNewReader.Click += btnNewReader_Click;
            // 
            // btnEditReader
            // 
            btnEditReader.Cursor = Cursors.Hand;
            btnEditReader.Font = new Font("Times New Roman", 10.25F);
            btnEditReader.Location = new Point(174, 303);
            btnEditReader.Margin = new Padding(4, 3, 4, 3);
            btnEditReader.Name = "btnEditReader";
            btnEditReader.Size = new Size(106, 39);
            btnEditReader.TabIndex = 6;
            btnEditReader.Text = "Edit Reader";
            btnEditReader.UseVisualStyleBackColor = true;
            btnEditReader.Click += btnEditReader_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.25F);
            label1.Location = new Point(26, 378);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 16);
            label1.TabIndex = 7;
            label1.Text = "Books that readers borrowed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 10.25F);
            label2.Location = new Point(26, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 16);
            label2.TabIndex = 8;
            label2.Text = "Readers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.25F);
            label3.Location = new Point(859, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 16);
            label3.TabIndex = 9;
            label3.Text = "Books in the library";
            // 
            // btnNewBook
            // 
            btnNewBook.Cursor = Cursors.Hand;
            btnNewBook.Font = new Font("Times New Roman", 10.25F);
            btnNewBook.Location = new Point(626, 397);
            btnNewBook.Margin = new Padding(4, 3, 4, 3);
            btnNewBook.Name = "btnNewBook";
            btnNewBook.Size = new Size(111, 39);
            btnNewBook.TabIndex = 10;
            btnNewBook.Text = "Add Book";
            btnNewBook.UseVisualStyleBackColor = true;
            btnNewBook.Click += btnNewBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.Cursor = Cursors.Hand;
            btnEditBook.Font = new Font("Times New Roman", 10.25F);
            btnEditBook.Location = new Point(626, 460);
            btnEditBook.Margin = new Padding(4, 3, 4, 3);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(111, 39);
            btnEditBook.TabIndex = 11;
            btnEditBook.Text = "Edit Book";
            btnEditBook.UseVisualStyleBackColor = true;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnDeleteReader
            // 
            btnDeleteReader.BackgroundImageLayout = ImageLayout.None;
            btnDeleteReader.Font = new Font("Times New Roman", 10.25F);
            btnDeleteReader.Location = new Point(302, 303);
            btnDeleteReader.Margin = new Padding(4, 3, 4, 3);
            btnDeleteReader.Name = "btnDeleteReader";
            btnDeleteReader.Size = new Size(108, 39);
            btnDeleteReader.TabIndex = 12;
            btnDeleteReader.Text = "Delete Reader";
            btnDeleteReader.UseVisualStyleBackColor = true;
            btnDeleteReader.Click += btnDeleteReader_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Times New Roman", 10.25F);
            btnDeleteBook.Location = new Point(626, 520);
            btnDeleteBook.Margin = new Padding(4, 3, 4, 3);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(111, 39);
            btnDeleteBook.TabIndex = 13;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1405, 676);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnDeleteReader);
            Controls.Add(btnEditBook);
            Controls.Add(btnNewBook);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEditReader);
            Controls.Add(btnNewReader);
            Controls.Add(btnReturn);
            Controls.Add(btnBorrow);
            Controls.Add(dgvStorage);
            Controls.Add(dgvReaders);
            Controls.Add(dgvBorrowed);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "BragarLibrary";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowed).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReaders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStorage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBorrowed;
        private System.Windows.Forms.DataGridView dgvReaders;
        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNewReader;
        private System.Windows.Forms.Button btnEditReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnDeleteReader;
        private System.Windows.Forms.Button btnDeleteBook;
    }
}

