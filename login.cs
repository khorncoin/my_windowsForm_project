namespace WinFormsApp1
{
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            if (namebox.Text ==""|| passBox.Text=="")
            {
                message.Text = "Please Enter Name & Passwood..!";
            }
            else
            {
                this.Hide();

                Fshop re = new Fshop();
                re.Show();
            }
        }

        private void Flogin_Load(object sender, EventArgs e)
        {

        }
    }
}