namespace Пошив_и_ремонт_одежды
{
    using System.Windows.Forms;

    public partial class EmailMessageForm : Form
    {
        public EmailMessageForm()
        {
            InitializeComponent();
        }

        public EmailMessageForm(string subjectMessage, string textMessage)
            : this()
        {
            this.emailMessageTextBox.Text = textMessage;
            this.emailSubjectTextBox.Text = subjectMessage;
        }
    }
}