public class Usuario{
    private string? nome;
    private string? tipo;
    private string? dataNascimento;
    private string? telefone;
    private string? sexo;
    private string? campus;
    private string? matricula;
    private string? cpf;
    private string? profissao;
    private string? dataCriacao;
    public bool logged = false;
    private string? password;



    public string? getNome()
    {
        return this.nome;
    }

    public void setNome(string? nome)
    {
        this.nome = nome;
    }
    public string? getTipo()
    {
        return this.tipo;
    }

    public void setTipo(string? tipo)
    {
        this.tipo = tipo;
    }
    public string? getDataNascimento()
    {
        return this.dataNascimento;
    }

    public void setDataNascimento(string? dataNascimento)
    {
        this.dataNascimento = dataNascimento;
    }
    public string? getTelefone()
    {
        return this.telefone;
    }

    public void setTelefone(string? telefone)
    {
        this.telefone = telefone;
    }
    public string? getSexo()
    {
        return this.sexo;
    }

    public void setSexo(string? sexo)
    {
        this.sexo = sexo;
    }
    public string? getCampus()
    {
        return this.campus;
    }

    public void setCampus(string? campus)
    {
        this.campus = campus;
    }
    public string? getMatricula()
    {
        return this.matricula;
    }

    public void setMatricula(string? matricula)
    {
        this.matricula = matricula;
    }
     public string? getCpf()
    {
        return this.cpf;
    }

    public void setCpf(string? cpf)
    {
        this.cpf = cpf;
    }
     public string? getProfissao()
    {
        return this.profissao;
    }

    public void setProfissao(string? profissao)
    {
        this.profissao = profissao;
    }
     public string? getDataCriacao()
    {
        return this.dataCriacao;
    }

    public void setDataCriacao(string? dataCriacao)
    {
        this.dataCriacao = dataCriacao;
    }
    public string? getPassword()
    {
        return this.password;
    }
    public void setpassword(string? password) 
    {
        this.password = password;
    }   
    
    public Usuario(){}

    public Usuario(string? nome, string? tipo, string? dataNascimento, string? telefone, string? sexo, string? campus, string? matricula, string? cpf, string? profissao, string? dataCriacao, string? ativo, string? password) {
        this.nome = nome;
        this.tipo = tipo;
        this.dataNascimento = dataNascimento;
        this.telefone = telefone;
        this.sexo = sexo;
        this.campus = campus;
        this.matricula = matricula;
        this.cpf = cpf;
        this.profissao = profissao;
        this.dataCriacao = dataCriacao;
        this.password = password;

    }
    public bool isLogged(string matricula, string password)
        {
            if ((this.matricula == matricula) && (this.password == password))
            {
                this.logged = true;
                return true;
            }
            return false;
}

}