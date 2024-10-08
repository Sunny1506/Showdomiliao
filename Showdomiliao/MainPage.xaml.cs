namespace Showdomiliao;

public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;

	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(Labelpergunta, Button1, Button2, Button3, Button4, Button5, labelPontuacao, labelNivel);

	}

	void OnButtonResposta01ButtonClicked(object sender, EventArgs args)
	{
		gerenciador.VerfiicaCorreto(1);
	}
	void OnButtonResposta02ButtonClicked(object sender, EventArgs args)
	{
		gerenciador.VerfiicaCorreto(2);
	}
	void OnButtonResposta03ButtonClicked(object sender, EventArgs args)
	{
		gerenciador.VerfiicaCorreto(3);
	}
	void OnButtonResposta04ButtonClicked(object sender, EventArgs args)
	{
		gerenciador.VerfiicaCorreto(4);
	}
	void OnButtonResposta05ButtonClicked(object sender, EventArgs args)
	{
		gerenciador.VerfiicaCorreto(5);
	}
	private void ButtonVoltarButtonClicked(object sender, EventArgs args)
	{

		Application.Current.MainPage = new Telainicial();

	}

	int pulou = 0;
	async void OnAjudaPulaClicked(object s, EventArgs E)
	{
		if (await DisplayAlert("PULAR QUESTÃO!", "Deseja mesmo pular a questão, depois não será possível usar esse recurso", "PULAR QUESTÃO", "CANCELAR"))
		{
			if (pulou == 2)
			{
				(s as Button).IsVisible = false;
			}

			else if (pulou == 0)
			{
				gerenciador.ProximaQuestao();
				pulou++;
				(s as Button).Text = "Pular " + 2.ToString() + "x";
			}
				else if (pulou == 1)
			{
				gerenciador.ProximaQuestao();
				pulou++;
				(s as Button).Text = "Pular " + 1.ToString() + "x";

			}



		}

	}
	async void OnAjudaRetirarClicked(object s, EventArgs e)
	{
		if (await DisplayAlert("CARTAS 🃏!", "Deseja mesmo usar o recurso das cartas, depois não será possível usar esse recurso", "USAR AS CARTAS", "CANCELAR"))
		{
			var ajuda = new RetiraErradas();
			ajuda.ConfiguraDesenho(Button1, Button2, Button3, Button4, Button5);
			ajuda.RealizaAjuda(gerenciador.GetQuestaoAtual());
			(s as ImageButton).IsVisible = false;
		}

	}
	async void OnAjudaUniversitariosClicked(object s, EventArgs e)
	{
		if (await DisplayAlert("UNIVERSITÁRIOS! 🎓", "Deseja mesmo usar o recurso dos universitários, depois não será possível usar esse recurso", "USAR AJUDA DOS UNIVERSITÁRIOS", "CANCELAR"))
		{
			var ajuda = new Universitarios();
			ajuda.ConfiguraDesenho(Button1, Button2, Button3, Button4, Button5);
			ajuda.RealizaAjuda(gerenciador.GetQuestaoAtual());
			(s as ImageButton).IsVisible = false;
		}

	}
}