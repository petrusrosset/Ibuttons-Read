using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LeitorIButtonLib
{
    public partial class Suntech : Form
    {
        public Suntech()
        {
            InitializeComponent();
        }

        private void Suntech_Load(object sender, EventArgs e)
        {

        }
        public void AlterarTexto(string textoBase, List<string> itens)
        {
            string textoFinal = textoBase;
            foreach (var item in itens)
            {
                textoFinal += item + ";";
            }

            // Removendo o último ";" se existir
            if (textoFinal.EndsWith(";"))
            {
                textoFinal = textoFinal.Remove(textoFinal.Length - 1);
            }

            Comando.Text = textoFinal;
        }

        private void Comando_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Comando.Text))
            {
                Clipboard.SetText(Comando.Text);
            }
        }
    }
}
