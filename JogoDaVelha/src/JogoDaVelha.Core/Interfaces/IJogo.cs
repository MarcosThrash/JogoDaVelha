using JogoDaVelha.Core.Enums;

namespace JogoDaVelha.Core.Interfaces
{
    public interface IJogo
    {
        SituacaoJogo AdicionarJogada(int posicao, string rotulo);
    }
}
