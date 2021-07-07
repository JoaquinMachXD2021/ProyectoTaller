using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();//esto cierra la ventana desde el boton "salir"
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void maxim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;//para cuando maximizamos la ventana 
            maxim.Visible = false;//esto es para alternar la visibilidad de los botones de maximizar y restaurar 
            rest.Visible = true;
        }

        private void rest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;//devuelve al estado normal de la ventana 
            rest.Visible = false;//esto es para alternar la visibilidad de los botones de maximizar y restaurar 
            maxim.Visible = true;
        }

        private void minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//minimiza la ventana 
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();//esto cierra la ventana 
        }
        //para arrastrar la ventana desde el "paneltop",esto para no usar el borde de ventana que viene por defecto.
        //lo saque de un video y no te explica bien como esta compuesto pero como funciona....
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {//para arrastar la ventana desde el "paneltop"
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        } 
        private void abrirformhijo(object formhijo) //para abrir un formulario secundario(formhijo) destro de un panel(panelcontenedor),en form1 .
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fr = formhijo as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fr);
            this.panelcontenedor.Tag = fr;
            fr.Show();
        }

        private void nuevoform_Click(object sender, EventArgs e)
        {
            abrirformhijo(new nuevoform());//muestra nuevoform al darle click en "nuevo",este formulario se abrira dentro de "panelcontenedor",que se ecuntra en form1  
        }
    }  
}
