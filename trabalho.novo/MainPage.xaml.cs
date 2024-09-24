﻿﻿namespace trabalho.novo;

public partial class MainPage : ContentPage
{
    Gerenciador gerenciador;
    private Label labelPergunta;
    private object labelPontuacao;
    private object labelNivel1;

    public MainPage()
    {
        InitializeComponent();
        gerenciador= new Gerenciador(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, labelPontuacao, labelNivel1);
    }   

    void ButtonResposta1Clicked(object sender, EventArgs args)
	{
	    gerenciador.VerificaCorreta(1);
	}
	void ButtonResposta2Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(2);
	}
	void ButtonResposta3Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(3);
	}
	void ButtonResposta4Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(4);
	}
	void ButtonResposta5Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(5);
	}

}