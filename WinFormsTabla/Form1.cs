namespace WinFormsTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }
        private void muestraTabla()
        {
            int num = Convert.ToInt32(this.textBoxNum.Text);
            string tabla = " ";
            for (int i = 1; i <= 10; i++)
            {
                tabla = tabla + num + " * " + i + " = " + (num * i) + "\n";

            }
            this.richTextBoxResultados.AppendText(tabla);
        }

        private void richTextBoxResultados_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
