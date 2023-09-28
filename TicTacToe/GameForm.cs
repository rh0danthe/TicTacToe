namespace TicTacToe
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void Choice_button_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            string symbol = senderButton.Text;
            if (firstPlayerChoice_label.Text == "")
            {
                firstPlayerChoice_label.Text = "������ ������� ������: " + symbol;
                symbolChoice_label.Text = "������ �����, �������� ������";
            }
            else if (firstPlayerChoice_label.Text == "������ ������� ������: " + symbol)
                MessageBox.Show("���� ������ ��� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (firstPlayerChoice_label.Text != "������ ������� ������: " + symbol)
            {
                secondPlayerChoice_label.Text = "������ ������� ������: " + symbol;
                symbolChoice_panel.Visible = false;
            }
        }
    }
}