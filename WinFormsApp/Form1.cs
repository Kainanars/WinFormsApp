namespace WinFormsApp

{
    public partial class Form1 : IObserver
    {
        private Notifier _notifier = new();

        string _database = "../../../database.csv";
        
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
            CarregarDadosDeArquivoCsv();
            _notifier.RegisterObserver(this);
        }
        

        private List<Pessoa> _pessoas = new();
        

        private void InitializeListView()
        {
            listView.View = View.Details;
            listView.Columns.Add("Nome", 150);
            listView.Columns.Add("Sobrenome", 150);
            listView.Columns.Add("E-mail", 200);
        }
        
        private void SalvarDadosEmArquivoCsv()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_database))
                {
                    writer.WriteLine("Nome,Sobrenome,Email");

                    foreach (var pessoa in _pessoas)
                    {
                        writer.WriteLine($"{pessoa.Nome},{pessoa.Sobrenome},{pessoa.Email}");
                    }
                }
            }
            catch (IOException ex)
            {
                CapturarErro(ex.Message);
            }
        }
        
        private void CarregarDadosDeArquivoCsv()
        {
            if (!File.Exists(_database))
            {
                _notifier.NotifyObservers($"Arquivo de banco de dados não encontrado em: {_database}");
                CapturarErro("Erro ao buscar arquivo de banco de dados");
                return;
            }

            try
            {
                _pessoas.Clear();

                using (StreamReader reader = new StreamReader(_database))
                {
                    reader.ReadLine(); // Ignora o cabeçalho

                    string linha;
                    while ((linha = reader.ReadLine()!) != null)
                    {
                        string[] campos = linha.Split(',');
                        if (campos.Length == 3)
                        {
                            _pessoas.Add(new Pessoa(campos[0], campos[1], campos[2]));
                        }
                    }
                }

                AtualizarListView();
            }
            catch (IOException ex)
            {
                CapturarErro(ex.Message);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            AdicionarPessoa();
            
            nomeTextBox.Clear();
            sobrenomeTextBox.Clear();
            emailTextBox.Clear();
        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filtro = comboBoxSearch.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(pesquisaTextBox.Text))
            {
                AtualizarListView();
                resumoLabel.Visible = true;
            }
            else
            {
                var propriedade = typeof(Pessoa).GetProperty(filtro);
                if (propriedade != null)
                {
                    var resultadosPesquisa = _pessoas.Where(p => propriedade.GetValue(p)!.ToString()!.IndexOf(pesquisaTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                    AtualizarListViewComFiltro(resultadosPesquisa);
                    resumoLabel.Visible = true;
                }
            }
        }



        private void AtualizarListViewComFiltro(List<Pessoa> pessoasFiltradas)
        {
            listView.Items.Clear();
            foreach (var pessoa in pessoasFiltradas)
            {
                listView.Items.Add(new ListViewItem(new[] { pessoa.Nome, pessoa.Sobrenome, pessoa.Email }));
            }
            AtualizarResumo();
        }

        
        private void AdicionarPessoa()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(nomeTextBox.Text) && 
                    !string.IsNullOrWhiteSpace(sobrenomeTextBox.Text) && 
                    !string.IsNullOrWhiteSpace(emailTextBox.Text))
                {
                    var pessoa = new Pessoa(nomeTextBox.Text, sobrenomeTextBox.Text, emailTextBox.Text);

                    _pessoas.Add(pessoa);
                    SalvarDadosEmArquivoCsv();
                    AtualizarListView();
                
                    _notifier.NotifyObservers($"Usuário adicionado: {pessoa.Nome} {pessoa.Sobrenome}");

                }
                else
                {
                    CapturarErro("Erro ao adicionar pessoa. Necessário preencher todos os campos antes de adicionar uma pessoa.");
                    MessageBox.Show("Por favor, preencha todos os campos antes de adicionar uma pessoa.");
                }
            }
            catch (Exception ex)
            {
                CapturarErro(ex.Message);
                throw;
            }
        }

        
        private void AtualizarListView()
        {
            try
            {
                listView.Items.Clear();
                foreach (var pessoa in _pessoas)
                {
                    listView.Items.Add(new ListViewItem(new[] { pessoa.Nome, pessoa.Sobrenome, pessoa.Email }));
                }
            
                listView.Columns[0].Width = 100;
                listView.Columns[1].Width = 100;
                listView.Columns[2].Width = 230;
                AtualizarResumo();
            }
            catch (Exception ex)
            {
                CapturarErro(ex.Message);
                throw;
            }
        }

        private void AtualizarResumo()
        {
            resumoLabel.Text = $"Resumo: Total de usuários: {listView.Items.Count}";
        }
        
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem != null)
            {
                var opcaoSelecionada = comboBox.SelectedItem.ToString()!;
                MessageBox.Show($"Opção selecionada: {opcaoSelecionada}");
            }

        }
        
        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedItem != null)
            {
                var opcaoSelecionada = comboBoxSearch.SelectedItem.ToString()!;
                MessageBox.Show($"Opção selecionada: {opcaoSelecionada}");
                buttonBuscar.Text = $"Buscar por {opcaoSelecionada}";
                pesquisaTextBox.PlaceholderText = $"Pesquisar por {opcaoSelecionada}";

            }
        }
        
        private void ascendenteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox.SelectedItem != null)
                {
                    var itemsOrdenados = listView.Items.Cast<ListViewItem>()
                        .OrderBy(item => item.SubItems[comboBox.SelectedIndex].Text)
                        .ToList();
        
                    listView.Items.Clear();
        
                    foreach (var item in itemsOrdenados)
                    {
                        listView.Items.Add(item);
                    }
                    _notifier.NotifyObservers($"Lista em ordem ascendente de {comboBox.SelectedItem}s");
                }
            }
            catch (Exception ex)
            {
                CapturarErro(ex.Message);
            }
        }

        private void descendenteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox.SelectedItem != null)
                {
                    var itemsOrdenados = listView.Items.Cast<ListViewItem>()
                        .OrderByDescending(item => item.SubItems[comboBox.SelectedIndex].Text)
                        .ToList();
        
                    listView.Items.Clear();
        
                    foreach (var item in itemsOrdenados)
                    {
                        listView.Items.Add(item);
                    }
                    _notifier.NotifyObservers($"Lista em ordem descendente de {comboBox.SelectedItem}s");
                }
            }
            catch (Exception ex)
            {
                CapturarErro(ex.Message);
            }

        }
        
        public void Update(string message)
        {
            MessageBox.Show(message);
        }
    }
    

}
