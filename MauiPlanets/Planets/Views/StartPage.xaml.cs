namespace Planets.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()

	{

		base.OnAppearing();

		if (this.AnimationIsRunning("TransitionAnimation"))
		{
			return;
		}
		var parentAnimation = new Animation();
		//Planets animation

		parentAnimation.Add(0.2, 0.4, new Animation(v => imgEarth.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgJupiter.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgMars.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgNeptune.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgSaturn.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgUranus.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgNeptune.Opacity = v, 0, 1, Easing.CubicIn));

        //Intro box
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgIntro.Opacity = v, 0, 1, Easing.CubicIn));

        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);


	}

	async void ExlopreNow_Clicked(System.Object sender, System.EventArgs e)
		=> Application.Current.MainPage = new NavigationPage(new PlanetsPage());
}