namespace WinFormsApp;

public class Pessoa
{
    public Pessoa(string nome, string sobrenome, string email)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Email = email;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Email { get; set; }
}