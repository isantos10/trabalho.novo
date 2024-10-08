namespace trabalho.novo
{
    public class Gerenciador
    {
        List<Questao> ListaQuestoes = new List<Questao>();
        List<int> ListaQuestoesRespondidas = new List<int>();
        Questao QuestaoCorrente;

        Label labelPontuacao;
        Label labelNivel;

         public Questao GetQuestaoCorrente()
        {
            return QuestaoCorrente;
        }
        
        public Gerenciador(Label labelPerg, Button ButtonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5, Label labelPontuacao, Label labelNivel)

        {
            this.labelPontuacao = labelPontuacao;
            this.labelNivel = labelNivel;
            CriaPerguntas(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            ProximaQuestao();
        }

        void CriaPerguntas(Label labelPerg, Button buttonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5)
        {
            var Q1 = new Questao();
            Q1.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q1.Pergunta = "Qual evento histórico marcou o fim da Segunda Guerra Mundial na Europa?";
            Q1.Resposta1 = "A queda do Muro de Berlim";
            Q1.Resposta2 = "O ataque a Pearl Harbor";
            Q1.Resposta3 = "A rendição da Alemanha nazista";
            Q1.Resposta4 = "A explosão das bombas atômicas em Hiroshima e Nagasaki";
            Q1.Resposta5 = " A Revolução Francesa";
            Q1.Respostacorreta = 3;
            ListaQuestoes.Add(Q1);

            var Q2 = new Questao();
            Q2.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q2.Pergunta = "Qual é o maior país da América do Sul em extensão territorial?";
            Q2.Resposta1 = "Brasil";
            Q2.Resposta2 = "Argentina";
            Q2.Resposta3 = "Colômbia";
            Q2.Resposta4 = "Peru";
            Q2.Resposta5 = "Venezuela";
            Q2.Respostacorreta = 1;
            ListaQuestoes.Add(Q2);

            var Q3 = new Questao();
            Q3.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q3.Pergunta = "Qual planeta do Sistema Solar é conhecido como o Planeta Vermelho?";
            Q3.Resposta1 = "Vênus";
            Q3.Resposta2 = "Marte";
            Q3.Resposta3 = "Júpiter";
            Q3.Resposta4 = "Saturno";
            Q3.Resposta5 = "Urano";
            Q3.Respostacorreta = 2;
            ListaQuestoes.Add(Q3);

            var Q4 = new Questao();
            Q4.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q4.Pergunta = "Quem é o autor da obra 'Dom Quixote'?";
            Q4.Resposta1 = "William Shakespeare";
            Q4.Resposta2 = "Miguel de Cervantes";
            Q4.Resposta3 = "Fyodor Dostoyevsky";
            Q4.Resposta4 = "Victor Hugo";
            Q4.Resposta5 = "Charles Dickens";
            Q4.Respostacorreta = 2;
            ListaQuestoes.Add(Q4);

            var Q5 = new Questao();
            Q5.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q5.Pergunta = "Qual movimento artístico se caracteriza pelo uso de cores vibrantes, formas geométricas e a busca pela representação da realidade de forma abstrata?";
            Q5.Resposta1 = "Impressionismo";
            Q5.Resposta2 = "Realismo";
            Q5.Resposta3 = "Cubismo";
            Q5.Resposta4 = "Barroco";
            Q5.Resposta5 = "Romantismo";
            Q5.Respostacorreta = 3;
            ListaQuestoes.Add(Q5);

            var Q6 = new Questao();
            Q6.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q6.Pergunta = "Quem pintou a Mona Lisa?";
            Q6.Resposta1 = "Pablo Picasso";
            Q6.Resposta2 = "Leonardo da Vinci";
            Q6.Resposta3 = "Vincent van Gogh";
            Q6.Resposta4 = "Claude Monet";
            Q6.Resposta5 = "Salvador Dalí";
            Q6.Respostacorreta = 2;
            ListaQuestoes.Add(Q6);

            var Q7 = new Questao();
            Q7.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q7.Pergunta = "Qual é a fórmula química da água?";
            Q7.Resposta1 = "H2O";
            Q7.Resposta2 = "CO2";
            Q7.Resposta3 = "O2";
            Q7.Resposta4 = "NaCl";
            Q7.Resposta5 = "C6H12O6";
            Q7.Respostacorreta = 1;
            ListaQuestoes.Add(Q7);

            var Q8 = new Questao();
            Q8.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q8.Pergunta = "Qual é o maior oceano do mundo?";
            Q8.Resposta1 = "Oceano Atlântico";
            Q8.Resposta2 = "Oceano Índico";
            Q8.Resposta3 = "Oceano Pacífico";
            Q8.Resposta4 = "Oceano Ártico";
            Q8.Resposta5 = "Oceano Antártico";
            Q8.Respostacorreta = 3;
            ListaQuestoes.Add(Q8);

            var Q9 = new Questao();
            Q9.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q9.Pergunta = "Qual é o animal mais rápido do mundo?";
            Q9.Resposta1 = "Guepardo";
            Q9.Resposta2 = "Falcão-peregrino";
            Q9.Resposta3 = "Leão";
            Q9.Resposta4 = "Antílope";
            Q9.Resposta5 = "Cavalo";
            Q9.Respostacorreta = 2;
            ListaQuestoes.Add(Q9);

            var Q10 = new Questao();
            Q10.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q10.Pergunta = "Qual é a capital da Noruega?";
            Q10.Resposta1 = "Oslo";
            Q10.Resposta2 = "Estocolmo";
            Q10.Resposta3 = "Copenhague";
            Q10.Resposta4 = "Helsinque";
            Q10.Resposta5 = "Reiquiavique";
            Q10.Respostacorreta = 1;
            ListaQuestoes.Add(Q10);

            var Q11 = new Questao();
            Q11.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q11.Pergunta = "Qual é a capital da Alemanha?";
            Q11.Resposta1 = "Berlim";
            Q11.Resposta2 = "Munique";
            Q11.Resposta3 = "Frankfurt";
            Q11.Resposta4 = "Hamburgo";
            Q11.Resposta5 = "Colônia";
            Q11.Respostacorreta = 1;
            ListaQuestoes.Add(Q11);

            var Q12 = new Questao();
            Q12.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q12.Pergunta = "Quem escreveu 'A Divina Comédia'?";
            Q12.Resposta1 = "Virgílio";
            Q12.Resposta2 = "Dante Alighieri";
            Q12.Resposta3 = "Homero";
            Q12.Resposta4 = "Goethe";
            Q12.Resposta5 = "Cervantes";
            Q12.Respostacorreta = 2;
            ListaQuestoes.Add(Q12);

            var Q13 = new Questao();
            Q13.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q13.Pergunta = "Qual é o continente mais seco do mundo?";
            Q13.Resposta1 = "África";
            Q13.Resposta2 = "Ásia";
            Q13.Resposta3 = "Antártida";
            Q13.Resposta4 = "América do Sul";
            Q13.Resposta5 = "Oceania";
            Q13.Respostacorreta = 3;
            ListaQuestoes.Add(Q13);

            var Q14 = new Questao();
            Q14.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q14.Pergunta = "Qual é o maior país do mundo em extensão territorial?";
            Q14.Resposta1 = "Canadá";
            Q14.Resposta2 = "Rússia";
            Q14.Resposta3 = "China";
            Q14.Resposta4 = "Estados Unidos";
            Q14.Resposta5 = "Brasil";
            Q14.Respostacorreta = 2;
            ListaQuestoes.Add(Q14);

            var Q15 = new Questao();
            Q15.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q15.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
            Q15.Resposta1 = "Abraham Lincoln";
            Q15.Resposta2 = "George Washington";
            Q15.Resposta3 = "Thomas Jefferson";
            Q15.Resposta4 = "Theodore Roosevelt";
            Q15.Resposta5 = "John Adams";
            Q15.Respostacorreta = 2;
            ListaQuestoes.Add(Q15);

            var Q16 = new Questao();
            Q16.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q16.Pergunta = "Qual é o principal gás responsável pelo efeito estufa?";
            Q16.Resposta1 = "Oxigênio";
            Q16.Resposta2 = "Dióxido de carbono";
            Q16.Resposta3 = "Metano";
            Q16.Resposta4 = "Nitrogênio";
            Q16.Resposta5 = "Hélio";
            Q16.Respostacorreta = 2;
            ListaQuestoes.Add(Q16);

            var Q17 = new Questao();
            Q17.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q17.Pergunta = "Qual é o nome do famoso relógio em Londres?";
            Q17.Resposta1 = "Big Ben";
            Q17.Resposta2 = "Torre Eiffel";
            Q17.Resposta3 = "Torre de Pisa";
            Q17.Resposta4 = "Torre do Relógio";
            Q17.Resposta5 = "Torre de Londres";
            Q17.Respostacorreta = 1;
            ListaQuestoes.Add(Q17);

            var Q18 = new Questao();
            Q18.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q18.Pergunta = "Quem é o deus do trovão na mitologia nórdica?";
            Q18.Resposta1 = "Thor";
            Q18.Resposta2 = "Odin";
            Q18.Resposta3 = "Loki";
            Q18.Resposta4 = "Freyr";
            Q18.Resposta5 = "Balder";
            Q18.Respostacorreta = 1;
            ListaQuestoes.Add(Q18);

            var Q19 = new Questao();
            Q19.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q19.Pergunta = "Qual é a capital da Itália?";
            Q19.Resposta1 = "Veneza";
            Q19.Resposta2 = "Milão";
            Q19.Resposta3 = "Roma";
            Q19.Resposta4 = "Nápoles";
            Q19.Resposta5 = "Florença";
            Q19.Respostacorreta = 3;
            ListaQuestoes.Add(Q19);

            var Q20 = new Questao();
            Q20.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            Q20.Pergunta = "Qual é o símbolo da paz?";
            Q20.Resposta1 = "Cruz";
            Q20.Resposta2 = "Pomba";
            Q20.Resposta3 = "Estrela";
            Q20.Resposta4 = "Coração";
            Q20.Resposta5 = "Arco-íris";
            Q20.Respostacorreta = 2;
            ListaQuestoes.Add(Q20);


        }
        public async void VerificaCorreta(int RR)
        {
            if (QuestaoCorrente.VerificaResposta(RR))
            {
                await Task.Delay(1000);
                AdicionaPontuacao(NivelAtual);
                NivelAtual++;
                ProximaQuestao();

                labelPontuacao.Text = "Pontuação:R$" + Pontuacao.ToString();
                labelNivel.Text = "Nível:" + NivelAtual.ToString();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Fim", "Você errou!", "Ok");
                Inicializar();

            }
        }

       public void ProximaQuestao()
        {
            var numAleat = Random.Shared.Next(0, ListaQuestoes.Count - 1);
            while (ListaQuestoesRespondidas.Contains(numAleat))
                numAleat = Random.Shared.Next(0, ListaQuestoes.Count - 1);
            ListaQuestoesRespondidas.Add(numAleat);
            QuestaoCorrente = ListaQuestoes[numAleat];
            QuestaoCorrente.Desenhar();
        }
        public int Pontuacao { get; private set; }
        int NivelAtual = 0;

        void Inicializar()
        {
            Pontuacao = 0;
            NivelAtual = 1;
            ProximaQuestao();

            labelPontuacao.Text = "Pontuação:R$" + Pontuacao.ToString();
            labelNivel.Text = "Nível:" + NivelAtual.ToString();
        }

        void AdicionaPontuacao(int n)
        {
            if (n == 1)
                Pontuacao = 1000;

            else if (n == 2)
                Pontuacao = 2000;

            else if (n == 3)
                Pontuacao = 5000;

            else if (n == 4)
                Pontuacao = 10000;

            else if (n == 5)
                Pontuacao = 20000;

            else if (n == 6)
                Pontuacao = 50000;

            else if (n == 7)
                Pontuacao = 100000;

            else if (n == 8)
                Pontuacao = 200000;

            else if (n == 9)
                Pontuacao = 500000;

            else Pontuacao = 1000000;

        }
    }
}

