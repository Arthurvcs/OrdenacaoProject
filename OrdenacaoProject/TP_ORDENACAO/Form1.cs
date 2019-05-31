using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace OrdenacaoProject
{
    public partial class Form1 : Form
    {
        Stopwatch timer = new Stopwatch();
        int tamanho;
        int[] vetCrescente, vetDecrescente, vetSemiOrdenado, vetAleatorio;

        public Form1()
        { InitializeComponent(); }

        private void bt_quickSort_Click(object sender, EventArgs e)
        {
            CleanUp();
            if (cb_tempos.SelectedItem == null)
            { MessageBox.Show("Selecione o tamnho do vetor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            {
                tamanho = int.Parse(cb_tempos.SelectedItem.ToString());

                vetCrescente = ArrayGenerator.Crescente(tamanho);
                vetDecrescente = ArrayGenerator.Decrescente(tamanho);
                vetSemiOrdenado = ArrayGenerator.SemiOrdenado(tamanho);
                vetAleatorio = ArrayGenerator.Random(tamanho);

                timer.Start();
                Operacoes.OrdenarQuickSort(vetAleatorio);
                timer.Stop();

                aux_aleatorio.Text = TimeText();
                aux_aleatorio.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarQuickSort(vetSemiOrdenado);
                timer.Stop();

                aux_semiOrdenado.Text = TimeText();
                aux_semiOrdenado.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarQuickSort(vetCrescente);
                timer.Stop();

                aux_Crescente.Text = TimeText();
                aux_Crescente.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarQuickSort(vetDecrescente);
                timer.Stop();

                aux_decrescente.Text = TimeText();
                aux_decrescente.Visible = true;
                timer.Reset();
            }
        }

        private void bt_selecao_Click(object sender, EventArgs e)
        {
            if (cb_tempos.SelectedItem == null)
            { MessageBox.Show("Selecione o tamnho do vetor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            {
                CleanUp();
                tamanho = int.Parse(cb_tempos.SelectedItem.ToString());

                vetCrescente = ArrayGenerator.Crescente(tamanho);
                vetDecrescente = ArrayGenerator.Decrescente(tamanho);
                vetSemiOrdenado = ArrayGenerator.SemiOrdenado(tamanho);
                vetAleatorio = ArrayGenerator.Random(tamanho);

                timer.Start();
                Operacoes.OrdenarSelecao(vetAleatorio);
                timer.Stop();

                aux_aleatorio.Text = TimeText();
                aux_aleatorio.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarSelecao(vetSemiOrdenado);
                timer.Stop();

                aux_semiOrdenado.Text = TimeText();
                aux_semiOrdenado.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarSelecao(vetCrescente);
                timer.Stop();

                aux_Crescente.Text = TimeText();
                aux_Crescente.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarSelecao(vetDecrescente);
                timer.Stop();

                aux_decrescente.Text = TimeText();
                aux_decrescente.Visible = true;
                timer.Reset();
            }
        }

        private void bt_bubbleSort_Click(object sender, EventArgs e)
        {
            CleanUp();
            if (cb_tempos.SelectedItem == null)
            { MessageBox.Show("Selecione o tamnho do vetor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            {
                tamanho = int.Parse(cb_tempos.SelectedItem.ToString());

                vetCrescente = ArrayGenerator.Crescente(tamanho);
                vetDecrescente = ArrayGenerator.Decrescente(tamanho);
                vetSemiOrdenado = ArrayGenerator.SemiOrdenado(tamanho);
                vetAleatorio = ArrayGenerator.Random(tamanho);

                timer.Start();
                Operacoes.OrdenarBubbleSort(vetAleatorio);
                timer.Stop();

                aux_aleatorio.Text = TimeText();
                aux_aleatorio.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarBubbleSort(vetSemiOrdenado);
                timer.Stop();

                aux_semiOrdenado.Text = TimeText();
                aux_semiOrdenado.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarBubbleSort(vetCrescente);
                timer.Stop();

                aux_Crescente.Text = TimeText();
                aux_Crescente.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarBubbleSort(vetDecrescente);
                timer.Stop();

                aux_decrescente.Text = TimeText();
                aux_decrescente.Visible = true;
                timer.Reset();
            }
        }

        private void btn_insercao_Click(object sender, EventArgs e)
        {
            CleanUp();
            if (cb_tempos.SelectedItem == null)
            { MessageBox.Show("Selecione o tamnho do vetor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            {
                tamanho = int.Parse(cb_tempos.SelectedItem.ToString());

                vetCrescente = ArrayGenerator.Crescente(tamanho);
                vetDecrescente = ArrayGenerator.Decrescente(tamanho);
                vetSemiOrdenado = ArrayGenerator.SemiOrdenado(tamanho);
                vetAleatorio = ArrayGenerator.Random(tamanho);

                timer.Start();
                Operacoes.ordenaInsercao(vetAleatorio);
                timer.Stop();

                aux_aleatorio.Text = TimeText();
                aux_aleatorio.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.ordenaInsercao(vetSemiOrdenado);
                timer.Stop();

                aux_semiOrdenado.Text = TimeText();
                aux_semiOrdenado.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.ordenaInsercao(vetCrescente);
                timer.Stop();

                aux_Crescente.Text = TimeText();
                aux_Crescente.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.ordenaInsercao(vetDecrescente);
                timer.Stop();

                aux_decrescente.Text = TimeText();
                aux_decrescente.Visible = true;
                timer.Reset();
            }
        }

        private void bt_MergeSort_Click(object sender, EventArgs e)
        {
            CleanUp();
            if (cb_tempos.SelectedItem == null)
            { MessageBox.Show("Selecione o tamnho do vetor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            {
                tamanho = int.Parse(cb_tempos.SelectedItem.ToString());

                vetCrescente = ArrayGenerator.Crescente(tamanho);
                vetDecrescente = ArrayGenerator.Decrescente(tamanho);
                vetSemiOrdenado = ArrayGenerator.SemiOrdenado(tamanho);
                vetAleatorio = ArrayGenerator.Random(tamanho);

                timer.Start();
                Operacoes.OrdenarMergeSort(vetAleatorio);
                timer.Stop();

                aux_aleatorio.Text = TimeText();
                aux_aleatorio.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarMergeSort(vetSemiOrdenado);
                timer.Stop();

                aux_semiOrdenado.Text = TimeText();
                aux_semiOrdenado.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarMergeSort(vetCrescente);
                timer.Stop();

                aux_Crescente.Text = TimeText();
                aux_Crescente.Visible = true;
                timer.Reset();

                timer.Start();
                Operacoes.OrdenarMergeSort(vetDecrescente);
                timer.Stop();

                aux_decrescente.Text = TimeText();
                aux_decrescente.Visible = true;
                timer.Reset();
            }
        }
        /// <summary>
        /// Método para limpar os dados do tempo
        /// </summary>
        private void CleanUp()
        {
            aux_aleatorio.Visible = false;
            aux_Crescente.Visible = false;
            aux_decrescente.Visible = false;
            aux_semiOrdenado.Visible = false;
        }
        /// <summary>
        /// Método para preencher a label que exibe os resultados
        /// </summary>
        /// <returns>O texto contendo o tempo de execução</returns>
        private string TimeText()
        {
            string aux = timer.Elapsed.TotalMilliseconds.ToString() + " ms";
            return aux;
        }
    }
}
