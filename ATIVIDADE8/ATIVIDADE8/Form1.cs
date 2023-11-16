using Microsoft.VisualBasic;
using System.Security.Permissions;
using System.Collections;

namespace ATIVIDADE8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";
            string saida = "";

            for (var i = 0; i < 20; i++)
            {
                auxiliar = Interaction.InputBox($"Digite o {i + 1}o número", "Entrada de dados");

                if (auxiliar == "")
                    return; //sai de tudo

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Valor invalido!");
                    i--;
                }
                else
                {
                    saida = vetor[i] + saida;
                }
                MessageBox.Show(saida);

            }
            Array.Reverse(vetor);
            auxiliar = "";
            foreach (var data in vetor)
            {
                auxiliar += data + "\n";
            }
            MessageBox.Show(auxiliar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string auxiliar = "";
            double media = 0;
            Double[,] matriz = new double[20, 3];
            for (var aluno = 0; aluno < 20; aluno++)
            {
                for (var nota = 0; nota < 3; nota++)
                {
                    auxiliar = Interaction.InputBox($"digite a {nota + 1}a nota do {aluno + 1}o aluno");
                    if (!double.TryParse(auxiliar, out matriz[aluno, nota]))
                    {
                        MessageBox.Show("Valor Invalido");
                        nota--;
                    }


                }
            }
            for (var aluno = 0; aluno < 20; aluno++)
            {
                for (var nota = 0; nota < 3; nota++)
                {
                    media = media + matriz[aluno, nota];
                }
                media = media / 3;
                MessageBox.Show($"Aluno {aluno + 1} | Media {media}");
                media = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior",
                                "Leonardo", "Jose", "Nelma", "Tobby"};
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }
            MessageBox.Show(Total.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList alunos = new ArrayList();
            string nome = "";

            alunos.Add("Ana");
            alunos.Add("André");
            alunos.Add("Débora");
            alunos.Add("Fátima");
            alunos.Add("João");
            alunos.Add("Janete");
            alunos.Add("Otávio");
            alunos.Add("Marcelo");
            alunos.Add("Pedro");
            alunos.Add("Thais");

            alunos.Remove("Otávio");
          

            for(var i=0; i < 9;i++)
            {
                nome = alunos[i].ToString();
                MessageBox.Show(nome);

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio2"].Activate();
            }
            else
            {
                frmExercicio5 obj = new frmExercicio5();
                obj.Show();
            }
        }
    }
}