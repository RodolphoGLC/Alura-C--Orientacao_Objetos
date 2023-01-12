using System;

public abstract class Autenticavel
{
    protected Autenticavel(double salario, string cpf)
    {
    }
    public string Senha { get; set; }
    public string Login { get; set; }
    public bool Autenticar(string login, string senha)
    {
        return (Senha == senha && Login == login);
    }
}
