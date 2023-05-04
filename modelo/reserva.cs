public class Reserva {
    private string? titulo;
    private string? descricao;
    private DateOnly? inicio;
    private DateOnly? fim;
    
    public string? getTitulo() {
        return this.titulo;
    }
    public void setTitulo(string? titulo){
        this.titulo = titulo;
    }
    public string? getDescricao() {
        return this.descricao;
    }
    public void setDescricao(string? descricao){
        this.descricao = descricao;
    }
    public DateOnly? getInicio() {
        return this.inicio;
    }
    public void setInicio(DateOnly? inicio){
        this.inicio = inicio;
    }
    public DateOnly? getFim() {
        return this.fim;
    }
    public void setFim(DateOnly? fim){
        this.fim = fim;
    }

    public Reserva(){}

    public Reserva(string? titulo, string? descricao, DateOnly? inicio, DateOnly? fim){
        this.titulo = titulo;
        this.descricao = descricao;
        this.inicio = inicio;
        this.fim = fim;
    }
}