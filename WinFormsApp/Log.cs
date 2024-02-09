namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private Stack<string> mensagensDeErro = new();
        
        private void CapturarErro(string mensagem)
        {
            mensagensDeErro.Push($"[{DateTime.Now}] {mensagem}");
        }

        private void ExibirMensagensDeErro()
        {
            if (mensagensDeErro.Count > 0)
            {
                string mensagem = "Mensagens de erro:\n\n";
                foreach (string erro in mensagensDeErro)
                {
                    mensagem += erro + "\n";
                }

                MessageBox.Show(mensagem, "Mensagens de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Não há mensagens de erro.", "Mensagens de Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LimparErros()
        {
            mensagensDeErro.Clear();        
        }
        
        private void buttonExibirErros_Click(object sender, EventArgs e)
        {
            ExibirMensagensDeErro();
            LimparErros();
        }
    }
}
