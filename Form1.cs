namespace pryMammanoSP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumTick_TextChanged(object sender, EventArgs e)
        {
            cbTicket.Enabled = true;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            txtNumTick.Enabled = true;
        }

        private void cbTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReg.Enabled = true;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            
            string fecha = dtpFecha.Text;
            string nTicket = txtNumTick.Text;
            string tipoTicket = cbTicket.Text;

            lstTicket.Items.Add("Fecha: " + fecha +" Numero de Ticket: " ,nTicket +" Tipo de Ticket: " , tipoTicket);

            dtpFecha.Text = null;
            txtNumTick.Clear();
            cbTicket.SelectedItem=null;

            dtpFecha.Focus();


            
        }
    }
}
