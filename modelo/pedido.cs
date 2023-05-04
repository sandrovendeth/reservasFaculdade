public class Pedido{
    private Usuario? solicitante;
    private string? reserva;
    private string? solicitanteNome;
    private string? solicitanteContato;
    private string? status;
    private string? dataCriacao;
    private string? usuarioAvaliador;

    public Usuario? getSolicitante()
    {
        return (Usuario) this.solicitante;
    }
    public void setSolicitante(Usuario? solicitante)
    {
        this.solicitante = solicitante;
    }
        public string? getReserva()
    {
        return this.reserva;
    }
     public string? getSolicitanteNome()
    {
        return this.solicitanteNome;
    }
    public void setSolicitanteNome(string? solicitanteNome)
    {
        this.solicitanteNome = solicitanteNome;
    }
    public string? getSolicitanteContato()
    {
        return this.solicitanteContato;
    }
    public void setSolicitanteContato(string? solicitanteContato)
    {
        this.solicitanteContato = solicitanteContato;
    }
    public string? getStatus()
    {
        return this.status;
    }
    public void setStatus(string? status)
    {
        this.status = status;
    }
     public string? getDataCriacao()
    {
        return this.dataCriacao;
    }
    public void setDataCriacao(string? dataCriacao)
    {
        this.dataCriacao = dataCriacao;
    }
     public string? getUsuarioAvaliador()
    {
        return this.usuarioAvaliador;
    }
    public void setUsuarioAvaliador(string? usuarioAvaliador)
    {
        this.usuarioAvaliador = usuarioAvaliador;
    }

    public Pedido(){}

    public Pedido(Usuario? solicitante, string? reserva, string? solicitanteNome, string? solicitanteContato, string? status, string? dataCriacao, string? usuarioAvaliador) {
        this.solicitante = solicitante;
        this.reserva = reserva;
        this.solicitanteNome = solicitanteNome;
        this.solicitanteContato = solicitanteContato;
        this.status = status;
        this.dataCriacao = dataCriacao;

    }

}