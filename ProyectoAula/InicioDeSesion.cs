using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoAula
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
            configuracionInicioSesion();
        }
        
        private void configuracionInicioSesion()
        {
            txtUsername.Enter += (s, e) => { if (txtUsername.Text == "Username") txtUsername.Text = ""; };
            txtUsername.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtUsername.Text)) txtUsername.Text = "Username"; };
            txtUsername.Text = "Username";

            txtPassword.Enter += (s, e) => { if (txtPassword.Text == "Password") { txtPassword.Text = ""; txtPassword.UseSystemPasswordChar = true; } };
            txtPassword.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtPassword.Text)) { txtPassword.Text = "Password"; txtPassword.UseSystemPasswordChar = false; } };
            txtPassword.Text = "Password";
            txtPassword.UseSystemPasswordChar = false;

        }

        private void InicioDeSesion_Load(object sender, EventArgs e)
        {
            // Personaliza los botones
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.Paint += (s, ev) => RedondearBoton(s as Button, ev.Graphics, 20);
            btnExit.Paint += (s, ev) => RedondearBoton(s as Button, ev.Graphics, 20);

        }

        private void RedondearBoton(Button button, Graphics graphics, int radius)
        {
            Rectangle rect = new Rectangle(0, 0, button.Width, button.Height);
            GraphicsPath path = new GraphicsPath();

            // Crear bordes redondeados
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Dibujar el botón con bordes redondeados
            button.Region = new Region(path);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.Gray, 2))
            {
                graphics.DrawPath(pen, path);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            iniciarSesion();
        }

        private void salir()
        {
            Application.Exit();
        }

        private void iniciarSesion()
        {
            if (validarEntradas())
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "12345")
                {
                    FormMapa formMapa = new FormMapa();
                    this.Hide();
                    formMapa.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validarEntradas()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("El campo de usuario no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("El campo de contraseña no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }
    }
}
