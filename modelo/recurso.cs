public class Recurso {
    private string? nome;
    private string? tipo;
    private int? quantidade;
    private string? descricao;
    private string? unidade;
    private string? disponibilidadeHorario;
    private string? dataCriacao;
    
    public string? getNome() {
        return this.nome;
    }
    public void setNome(string? nome){
        this.nome = nome;
    }
    public string? getTipo(){
        return this.tipo;
    }
    public int? getQuantidade() {
        return this.quantidade;
    }
    public void setQuantidade(int? quantidade){
        this.quantidade = quantidade;
    }
    public string? getDescricao() {
        return this.descricao;
    }
    public void setDescricao(string? descricao){
        this.descricao = descricao;
    }
    public string? getUnidade() {
        return this.unidade;
    }
    public void setUnidade(string? unidade){
        this.unidade = unidade;
    }
    public string? getDisponibilidadeHorario() {
        return this.disponibilidadeHorario;
    }
    public void setDisponibilidadeHorario(string? disponibilidadeHorario){
        this.disponibilidadeHorario = disponibilidadeHorario;
    }
    public string? getDataCriacao() {
        return this.dataCriacao;
    }
    public void setDataCriacao(string? dataCriacao){
        this.dataCriacao = dataCriacao;
    }

    public Recurso(){}

    public Recurso(string? nome, string? tipo, int? quantidade, string? descricao, string? unidade, string? disponibilidadeHorario, string? dataCriacao){
        this.nome = nome;
        this.tipo = tipo;
        this.quantidade = quantidade;
        this.descricao = descricao;
        this.unidade = unidade;
        this.disponibilidadeHorario = disponibilidadeHorario;
        this.dataCriacao = dataCriacao;
    }
}