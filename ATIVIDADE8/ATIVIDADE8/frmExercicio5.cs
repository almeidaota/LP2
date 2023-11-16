using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE8
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[10];
            int[] caracteresNomes = new int[10];
            string auxiliar = "";
            for(var i=0;i<10;i++)
            {
                auxiliar = auxiliar = Interaction.InputBox($"Digite o nome:", "Entrada de nome");
                nomes[i] = auxiliar;

                caracteresNomes[i] = auxiliar.Replace(" ","").Length;
                //listBox1.Items.Add($"O nome: {nomes[i]}, tem {caracteresNomes} caracteres");

            }
            for (var i = 0; i < 10;i++)
                 listBox1.Items.Add($"O nome: {nomes[i]}, tem {caracteresNomes[i]} caracteres");

        }
    }
}
