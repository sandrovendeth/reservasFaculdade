public class Unidade {
    private string? nome;
    private string? endereco;
    private string? campus;
    private string? sede;

    public string? getNome() {
        return this.nome;
    }
    public void setNome(string? nome){
        this.nome = nome;
    }
    public string? getEndereco() {
        return this.endereco;
    }
    public void setEndereco(string? endereco){
        this.endereco = endereco;
    }
    public string? getCampus() {
        return this.campus;
    }
    public void setCampus(string? campus){
        this.campus = campus;
    }
    public string? getSede() {
        return this.sede;
    }
    public void setSede(string? sede){
        this.sede = sede;
    }

    public Unidade (){}

    public Unidade (string? nome, string? endereco, string? campus, string? sede){
        this.nome = nome;
        this.endereco = endereco;
        this.campus = campus;
        this.sede = sede;
    }
}