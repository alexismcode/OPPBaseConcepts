using OOPConcepts.Logica;

namespace OPPConcept.Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_validarFecha_Click(object sender, EventArgs e)
        {
            if (txt_year.Text.Length == 0)
            {
                MessageBox.Show("El año ingresado esta vacio", "WARNING!");
                return;
            }
            if (txt_month.Text.Length == 0)
            {
                MessageBox.Show("El mes ingresado esta vacio", "WARNING!");
                return;
            }
            if (txt_day.Text.Length == 0)
            {
                MessageBox.Show("El dia ingresado esta vacio", "WARNING!");
                return;
            }

            try
            {
                var year = Convert.ToInt32(txt_year.Text);
                var month = Convert.ToInt32(txt_month.Text);
                var day = Convert.ToInt32(txt_day.Text);

                var fecha = new Date(year, month,day);
                MessageBox.Show($"La fecha ingresada: {fecha}, es correcta", "SUCCESFULL!");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "FAIL!");
            }

            
        }
    }
}