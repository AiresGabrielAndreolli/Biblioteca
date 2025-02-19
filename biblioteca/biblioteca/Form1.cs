namespace biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult simNao = MessageBox.Show(this, "Certeza?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (simNao == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
