using Planets.Models;

namespace Planets.Views;

public partial class PlanetDetailsPage : ContentPage
{
	public PlanetDetailsPage(Planet planet)
	{
		InitializeComponent();
		this.BindingContext = planet;
	}
}