﻿﻿namespace trabalho.novo;

public partial class MainPage : ContentPage
{
    Gerenciador gerenciador;
    private int click=0;

	private int clicked3vezes=0;


    public MainPage()
    {
        InitializeComponent();
        gerenciador= new Gerenciador (labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, labelPontuacao, labelNivel);
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
 
    void retirarclicado(object sender, EventArgs args)
	{
		var ajuda = new RetiraErrada();
		ajuda.ConfiguraDesenho( buttonResposta1, buttonResposta2,  buttonResposta3,  buttonResposta4, buttonResposta5);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(sender as Button).IsVisible = false;

	}

	void universitarioclicado(object sender, EventArgs args)
	{
		var ajuda = new Universitario();
		ajuda.ConfiguraDesenho( buttonResposta1, buttonResposta2,  buttonResposta3,  buttonResposta4, buttonResposta5);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(sender as Button).IsVisible = false;

	}
    void pularclicado(object sender, EventArgs args)
	{
		gerenciador.ProximaQuestao();

		click++;

		clicked3vezes++;

       if  (click>=3)
	   {
		(sender as Button).IsVisible = false;
	   }
	   else
	   {
	   (sender as Button).IsVisible = true;
	   }

		if (clicked3vezes==1)
		{
			pular.Text="2 pula";
		}
		else if (clicked3vezes==2)
		{
			pular.Text="1 pula";
		}
		else if(clicked3vezes>=3)
		{
			(sender as Button).IsVisible = false;
		}


	}
}