namespace WinFormsApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        listView = new ListView();
        nomeTextBox = new TextBox();
        sobrenomeTextBox = new TextBox();
        emailTextBox = new TextBox();
        pesquisaTextBox = new TextBox();
        buttonSalvar = new Button();
        buttonBuscar = new Button();
        buttonLog = new Button();
        ascendenteButton = new Button();
        descendenteButton = new Button();
        resumoLabel = new Label();
        cadastroLabel = new Label();
        ordenacaoLabel = new Label();
        comboBox = new ComboBox();
        comboBoxSearch = new ComboBox();
        SuspendLayout();
        // 
        // listView
        // 
        listView.Location = new Point(12, 50);
        listView.Name = "listView";
        listView.Size = new Size(450, 430);
        listView.TabIndex = 0;
        listView.UseCompatibleStateImageBehavior = false;
        // 
        // comboBoxSearch
        // 
        comboBoxSearch.Location = new Point(12, 560);
        comboBoxSearch.Name = "comboBoxSearch";
        comboBoxSearch.Size = new Size(80, 30);
        comboBoxSearch.TabIndex = 4;

        // Adiciona itens ao ComboBox
        comboBoxSearch.Items.Add("Nome");
        comboBoxSearch.Items.Add("Sobrenome");
        comboBoxSearch.Items.Add("Email");
        comboBoxSearch.SelectedIndex = 2;
        comboBoxSearch.SelectedIndexChanged += comboBoxSearch_SelectedIndexChanged;
        // 
        // pesquisaTextBox
        // 
        pesquisaTextBox.Location = new Point(100, 560);
        pesquisaTextBox.Name = "pesquisaTextBox";
        pesquisaTextBox.Size = new Size(210, 30);
        pesquisaTextBox.TabIndex = 4;
        pesquisaTextBox.PlaceholderText = "Pesquisar por e-mail";
        //
        // buttonBuscar
        // 
        buttonBuscar.Location = new Point(330, 560);
        buttonBuscar.Name = "buttonSalvar";
        buttonBuscar.Size = new Size(140, 25);
        buttonBuscar.TabIndex = 4;
        buttonBuscar.Text = "Buscar por email";
        buttonBuscar.UseVisualStyleBackColor = true;
        buttonBuscar.Click += new EventHandler(buttonSearch_Click);
        // 
        // ordenacaoLabel
        // 
        ordenacaoLabel.AutoSize = true;
        ordenacaoLabel.Location = new Point(12, 520);
        ordenacaoLabel.Name = "ordenacaoLabel";
        ordenacaoLabel.Size = new Size(50, 15);
        ordenacaoLabel.TabIndex = 6;
        ordenacaoLabel.Text = "Ordenação:";
        // 
        // ascendenteButton
        // 
        ascendenteButton.Location = new Point(170, 520);
        ascendenteButton.Name = "ascendenteButton";
        ascendenteButton.Size = new Size(75, 25);
        ascendenteButton.TabIndex = 6;
        ascendenteButton.Text = "ASC";
        ascendenteButton.UseVisualStyleBackColor = true;
        ascendenteButton.Click += new EventHandler(ascendenteButton_Click);
        // 
        // descendenteButton
        // 
        descendenteButton.Location = new Point(250, 520);
        descendenteButton.Name = "descendenteButton";
        descendenteButton.Size = new Size(75, 25);
        descendenteButton.TabIndex = 7;
        descendenteButton.Text = "DESC";
        descendenteButton.UseVisualStyleBackColor = true;
        descendenteButton.Click += new EventHandler(this.descendenteButton_Click);
        // 
        // resumoLabel
        // 
        resumoLabel.AutoSize = true;
        resumoLabel.Location = new Point(12, 480);
        resumoLabel.Name = "resumoLabel";
        resumoLabel.Size = new Size(50, 15);
        resumoLabel.TabIndex = 8;
        resumoLabel.Text = "Resumo:";
        resumoLabel.Visible = false;
        // 
        // cadastroLabel
        // 
        cadastroLabel.AutoSize = true;
        cadastroLabel.Location = new Point(500, 50);
        cadastroLabel.Name = "resumoLabel";
        cadastroLabel.Size = new Size(50, 15);
        cadastroLabel.TabIndex = 1;
        cadastroLabel.Text = "Cadastro de usuário";
        cadastroLabel.Font = new Font("Arial", 20);
        // 
        // nomeTextBox
        // 
        nomeTextBox.Location = new Point(500, 100);
        nomeTextBox.Name = "nomeTextBox";
        nomeTextBox.Size = new Size(250, 30);
        nomeTextBox.TabIndex = 1;
        nomeTextBox.PlaceholderText = "Digite seu nome";
        // 
        // sobrenomeTextBox
        // 
        sobrenomeTextBox.Location = new Point(500, 150);
        sobrenomeTextBox.Name = "sobrenomeTextBox";
        sobrenomeTextBox.Size = new Size(250, 30);
        sobrenomeTextBox.TabIndex = 2;
        sobrenomeTextBox.PlaceholderText = "Digite seu sobrenome";
        // 
        // sobrenomeTextBox
        // 
        emailTextBox.Location = new Point(500, 200);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Size = new Size(250, 30);
        emailTextBox.TabIndex = 3;
        emailTextBox.PlaceholderText = "Digite seu email";
        //
        // buttonSalvar
        // 
        buttonSalvar.Location = new Point(585, 260);
        buttonSalvar.Name = "buttonSalvar";
        buttonSalvar.Size = new Size(75, 31);
        buttonSalvar.TabIndex = 4;
        buttonSalvar.Text = "Salvar";
        buttonSalvar.UseVisualStyleBackColor = true;
        buttonSalvar.Click += new EventHandler(buttonSubmit_Click);
        //
        // buttonLog
        // 
        buttonLog.Location = new Point(700, 560);
        buttonLog.Name = "buttonSalvar";
        buttonLog.Size = new Size(75, 25);
        buttonLog.TabIndex = 4;
        buttonLog.Text = "Logs";
        buttonLog.UseVisualStyleBackColor = true;
        buttonLog.Click += new EventHandler(buttonExibirErros_Click);
        //
        // comboBox
        // 
        comboBox.Location = new Point(80, 520);
        comboBox.Name = "comboBox";
        comboBox.Size = new Size(80, 30);
        comboBox.TabIndex = 4;

        // Adiciona itens ao ComboBox
        comboBox.Items.Add("Nome");
        comboBox.Items.Add("Sobrenome");
        comboBox.Items.Add("Email");
        comboBox.SelectedIndex = 2;
        comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 600);
        Controls.Add(resumoLabel);
        Controls.Add(cadastroLabel);
        Controls.Add(ordenacaoLabel);
        Controls.Add(comboBox);
        Controls.Add(comboBoxSearch);
        Controls.Add(descendenteButton);
        Controls.Add(ascendenteButton);
        Controls.Add(pesquisaTextBox);
        Controls.Add(buttonLog);
        Controls.Add(buttonSalvar);
        Controls.Add(buttonBuscar);
        Controls.Add(emailTextBox);
        Controls.Add(sobrenomeTextBox);
        Controls.Add(nomeTextBox);
        Controls.Add(listView);
        Name = "Form1";
        Text = "Formulário";
        ResumeLayout(false);
        PerformLayout();
    }


    #endregion
    
    private ListView listView;
    private TextBox nomeTextBox;
    private TextBox sobrenomeTextBox;
    private TextBox emailTextBox;
    private Button buttonBuscar;
    private Button buttonSalvar;
    private Button ascendenteButton;
    private Button descendenteButton;
    private Button buttonLog;
    private ComboBox comboBox;
    private ComboBox comboBoxSearch;
    private Label cadastroLabel;
    private Label resumoLabel;
    private Label ordenacaoLabel;
    private TextBox pesquisaTextBox;

}