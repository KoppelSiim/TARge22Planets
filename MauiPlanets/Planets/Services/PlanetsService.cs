using Planets.Models;

namespace Planets.Services
{


    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. It is a terrestrial planet with a heavily cratered surface due to overlapping impact events. These features are well preserved since the planet has no geological activity and an extremely tenuous atmosphere called an exosphere. Despite being the smallest planet in the Solar System with a mean diameter of 4,880 km (3,030 mi), 38% of that of Earth, Mercury is dense enough to have roughly the same surface gravity as Mars. Mercury has a dynamic magnetic field with a strength about 1% of that of Earth's and has no natural satellites.",
                //AccentColorStart = Color.
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            },

            new()
            {
                Name = "Venus",
                Subtitle = "Brightest star",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun." +
                "It is a rocky planet with the densest atmosphere of all the rocky bodies in the Solar System, and the only one with a mass and size that is close to that of its orbital neighbour Earth."+
                "Orbiting inferiorly (inside of Earth's orbit), it appears in Earth's sky always close to the Sun, as either a \"morning star\" or an \"evening star\".Venus is the second planet from the Sun." + 
                "It is a rocky planet with the densest atmosphere of all the rocky bodies in the Solar System, and the only one with a mass and size that is close to that of its orbital neighbour Earth." + 
                "Orbiting inferiorly (inside of Earth's orbit), it appears in Earth's sky always close to the Sun, as either a \"morning star\" or an \"evening star\".",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/b/b2/Venus_2_Approach_Image.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Venus_globe.jpg/1024px-Venus_globe.jpg",
                    "https://dnd2oi6izkvoi.cloudfront.net/img/iea/7qOYd58Ww3/venus-might-have-oceans-of-water-trapped-inside-its-crust.jpg"
                }
            },

             new()
            {
                Name = "Earth",
                Subtitle = "Our Home",
                HeroImage = "earth.png",
                Description =  "Earth is the third planet from the Sun and the only astronomical object known to harbor life." + 
                 "This is enabled by Earth being a water world, the only one in the Solar System sustaining liquid surface water."+ 
                 "Almost all of Earth's water is contained in its global ocean, covering 70.8% of Earth's crust." + 
                 "The remaining 29.2% of Earth's crust is land, most of which is located in the form of continental landmasses within one hemisphere, Earth's land hemisphere." + 
                 "Most of Earth's land is somewhat humid and covered by vegetation, while large sheets of ice at Earth's polar deserts retain more water than Earth's groundwater, lakes, rivers and atmospheric water combined." + 
                 "Earth's crust consists of slowly moving tectonic plates, which interact to produce mountain ranges, volcanoes, and earthquakes." + 
                 "Earth has a liquid outer core that generates a magnetosphere capable of deflecting most of the destructive solar winds and cosmic radiation.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://images.unsplash.com/photo-1614730321146-b6fa6a46bcb4?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxleHBsb3JlLWZlZWR8MXx8fGVufDB8fHx8fA%3D%3D",
                    "https://akm-img-a-in.tosshub.com/indiatoday/images/story/202303/earth-4439728_960_720-sixteen_nine.jpg?VersionId=kZJbwk_Kd9K36im4Xxd08YrnS87DsQMQ"

                }
            },

              new()
            {
                Name = "Mars",
                Subtitle = "Red planet",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet and the furthest terrestrial planet from the Sun." + 
                  "The reddish color of its surface is due to finely grained iron(III) oxide dust in the soil, giving it the nickname \"the Red Planet\". " +
                  "Mars's radius is second smallest among the planets in the Solar System at 3,389.5 km (2,106 mi)." +  
                  "The Martian dichotomy is visible on the surface: on average, the terrain on Mars's northern hemisphere is flatter and lower than its southern hemisphere." + 
                  "Mars has a thin atmosphere made primarily of carbon dioxide, and two irregularly shaped natural satellites, Phobos and Deimos.",
                AccentColorStart = Color.FromArgb("#A52A2A"),
                AccentColorEnd = Color.FromArgb("#913831"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/Q4UQ2bWADBXqrRy9H3PcTo.jpg",
                    "https://c02.purpledshub.com/uploads/sites/41/2023/07/mars-thumbnail-fb84d10.jpg",
                    "https://miro.medium.com/v2/resize:fit:1358/1*2n6yiV0A8p8Lyk55gId23Q.jpeg"

                }
            }

        };


        public static List<Planet> GetFeaturedPlanet()
        {
            var random = new Random();
            var randomizedPlaents = planets.OrderBy(item => random.Next());

            return randomizedPlaents.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;

    }
}
