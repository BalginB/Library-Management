namespace LibraryManagement
{
    // Enum representing possible actions for a reader dialog (New or Edit)
    public enum ActionType { New, Edit };

    public partial class ReaderDialog : Form
    {
        // Properties to store the action and the reader instance
        public ActionType Action { get; set; } = ActionType.New;
        public Reader ReaderInstance { get; set; }

        public ReaderDialog()
        {
            InitializeComponent();
        }



        // Event handler triggered when the visibility of the dialog changes
        private void ReaderDialog_VisibleChanged_1(object sender, EventArgs e)
        {
            // Populate dialog fields based on the action
            if (Action == ActionType.Edit)
            {
                txtFirstName.Text = ReaderInstance.FirstName;
                txtLastName.Text = ReaderInstance.LastName;
                txtAddress.Text = ReaderInstance.Address;
                Age.Value = ReaderInstance.Age;
            }
            else
            {
                txtFirstName.Text = String.Empty;
                txtLastName.Text = String.Empty;
                txtAddress.Text = String.Empty;
                Age.Value = 18;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Update or create a new reader instance based on the action
            switch (Action)
            {
                case ActionType.New:
                    ReaderInstance = new Reader(txtFirstName.Text, txtLastName.Text, txtAddress.Text, (int)Age.Value);
                    break;
                case ActionType.Edit:
                    ReaderInstance.FirstName = txtFirstName.Text;
                    ReaderInstance.LastName = txtLastName.Text;
                    ReaderInstance.Address = txtAddress.Text;
                    ReaderInstance.Age = (int)Age.Value;
                    break;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
