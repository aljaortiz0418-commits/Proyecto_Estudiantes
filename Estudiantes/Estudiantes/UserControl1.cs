using System;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class UserControl1 : UserControl
    {
        public object ActiveForm { get; private set; }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Clave_Click(object sender, EventArgs e)
        {

        }

        private void formulario_Enter(object sender, EventArgs e)
        {

        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            formulario.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mujer;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.hombre;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void estadocivil_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 10)
                progressBar1.Value -= 10;
            else
                MessageBox.Show("Error llegó a 0.", "Ventana de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value <= 90)
                progressBar1.Value += 10;
            else
                MessageBox.Show("No insista, ya está en el límite");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = this.FindForm();
            formulario.Close();
        }
    }
}
