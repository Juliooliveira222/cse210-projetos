public class GeradorPerguntas
{
    private List<string> _perguntas = new List<string>()
    {
        "Qual foi a melhor parte do seu dia?",
        "O que você aprendeu hoje?",
        "Qual desafio você enfrentou hoje?",
        "Por qual pessoa você é grato hoje?",
        "O que fez você sorrir hoje?"
    };

    public string ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int indice = random.Next(_perguntas.Count);

        return _perguntas[indice];
    }
}
