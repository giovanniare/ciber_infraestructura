using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        // Aqui se define el regex que va a evaluar las condiciones para una contraseña valida.
        private const string PATRON = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^a-zA-Z\d])";
        public Form1()
        {
            InitializeComponent();
        }

        // Evento que evalua los campos de texto y valida si son iguales
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtiene los valores de los campos de texto y elimina los espacios en blanco al inicio y al final
            string contrasenia_base = textBoxBase.Text.Trim();
            string contrasenia_confirmar = textBoxConfirmar.Text.Trim();

            // Evaluacion de la contraseña en base a los requisitos.
            bool contrasenia_cumple_requeriminetos = Regex.IsMatch(contrasenia_base, PATRON);
            if (!contrasenia_cumple_requeriminetos) {
                MessageBox.Show("La contraseña no cumple con los requisitos de seguridad.");
                return;
            }

            // Comparacion de contraseñas para verificar si son iguales
            if (contrasenia_base != contrasenia_confirmar) {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            MessageBox.Show("La contraseña ha sido validada.");
            return;
        }

    }
}
