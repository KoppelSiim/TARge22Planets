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
            },
                new()
            {
                Name = "Jupiter",
                Subtitle = "God planet",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass more than two and a half times that of all the other planets in the Solar System combined, and slightly less than one one-thousandth the mass of the Sun. Jupiter orbits the Sun at a distance of 5.20 AU (778.5 Gm) with an orbital period of 11.86 years. Jupiter is the third brightest natural object in the Earth's night sky after the Moon and Venus, and it has been observed since prehistoric times. It was named after Jupiter, the chief deity of ancient Roman religion.",
                AccentColorStart = Color.FromArgb("#A52A2A"),
                AccentColorEnd = Color.FromArgb("#913831"),
                Images = new()
                {
                    "https://t4.ftcdn.net/jpg/00/04/94/63/360_F_4946384_BOhNRo9oXd0KiN38sWXwIB72Rh8rzcv1.jpg",
                   

                }
            },
                new()
            {
                Name = "Saturn",
                Subtitle = "Ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter."+
                    "It is a gas giant with an average radius of about nine-and-a-half times that of Earth."+
                    "It has only one-eighth the average density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#808080"),
                AccentColorEnd = Color.FromArgb("#778899"),
                Images = new()
                {
                    "https://media.cnn.com/api/v1/images/stellar/prod/230210173346-hubble-saturn-rings-spokes.jpg?c=16x9&q=h_720,w_1280,c_fill",
                    "https://t3.ftcdn.net/jpg/03/41/81/22/360_F_341812269_QJzsDM9n0oN8XgL765xR1jleTdHKRhzi.jpg",
                    "https://stsci-opo.org/STScI-01EVSVE3VNSYF8J7J7AZ4P6NB8.jpg"


                }
            },
                 new()
            {
                Name = "Uranus",
                Subtitle = "Coldest planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant." + 
                     "Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which in astronomy is called 'ice' or volatiles." + 
                     "The planet's atmosphere has a complex layered cloud structure and has the lowest minimum temperature of 49 K (−224 °C; −371 °F) out of all the Solar System's planets." +
                     "It has a marked axial tilt of 97.8° with a retrograde rotation rate of 17 hours." +
                     "This means that in an 84-Earth-year orbital period around the Sun, its poles get around 42 years of continuous sunlight, followed by 42 years of continuous darkness.",
                AccentColorStart = Color.FromArgb("#808080"),
                AccentColorEnd = Color.FromArgb("#778899"),
                Images = new()
                {
                    "https://www.funkidslive.com/wp-content/uploads/2022/10/yto1u-i1pvi-1024x585.jpg",
                    "https://universemagazine.com/wp-content/uploads/2022/06/4-3.jpg",
                    "https://www.astronomy.com/wp-content/uploads/sites/2/2023/03/Uranussideways.jpg?fit=600%2C394"


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
