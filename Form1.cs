namespace Ejercicio_Formulario_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtc.Enabled = false;
            txte.Enabled = false;
        }


        private void buttonc_Click(object sender, EventArgs e)

        {

            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            double n3 = Convert.ToDouble(txtn3.Text);
            double n4 = Convert.ToDouble(txtn4.Text);


            double promedio = (n1 + n2 + n3 + n4) / 4;
            txtp.Text = promedio.ToString("F2");

            if (promedio > 69)
            {
                txtf.Text = "Aprobado";
                txtc.Enabled = false;
                txte.Enabled = false;
            }
            else
            {

                txtc.Enabled = true;

                if (!string.IsNullOrEmpty(txtc.Text))
                {
                    double completivo = Convert.ToDouble(txtc.Text);
                    double notaFinal = (promedio * 0.5) + (completivo * 0.5);

                    if (notaFinal >= 70)
                    {
                        txtf.Text = "Aprobado";
                        txte.Enabled = false;
                    }
                    else
                    {

                        txte.Enabled = true;

                        if (!string.IsNullOrEmpty(txte.Text))
                        {
                            double extraordinario = Convert.ToDouble(txte.Text);
                            double notaExtra = (promedio * 0.3) + (extraordinario * 0.7);

                            txtf.Text = (notaExtra >= 70) ? "Aprobado" : "Reprobado";
                        }
                    }
                }
            }
        }



        private void label9_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void txtf_TextChanged(object sender, EventArgs e) { }

        private void txtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}





