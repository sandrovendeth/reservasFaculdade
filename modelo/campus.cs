public class Campus {
    private string? nome;
    private string? direcao;
    private string? dataCriacao;


    public string? getNome() {
        return this.nome;
    }
    public void setNome(string? nome){
        this.nome = nome;
    }
    public string? getDirecao() {
        return this.direcao;
    }
    public void setDirecao(string? direcao){
        this.direcao = direcao;
    }
    public string? getDataCriacao() {
        return this.dataCriacao;
    }
    public void setDataCriacao(string? dataCriacao){
        this.dataCriacao = dataCriacao;
    }

    public Campus (){}

    public Campus (string? nome, string? direcao, string? dataCriacao){
        this.nome = nome;
        this.direcao = direcao;
        this.dataCriacao = dataCriacao;
    }
}