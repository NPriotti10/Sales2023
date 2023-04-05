using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
            await CheckCategoriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Argentina",
                    States = new List<State>
                    {
                        new State
                        {   Name = "Cordoba",
                            Cities = new List<City>
                            {
                                new City {Name = "Brinkmann"},
                                new City {Name = "San Francisco"},
                                new City {Name = "Morteros"}
                            },
                        },
                        new State
                        {
                            Name = "Santa Fe",
                            Cities = new List<City>
                            {
                                new City {Name = "Santa Fe"},
                                new City {Name = "Rosario"},
                                new City {Name = "San Javier"}
                            },
                        },
                        new State
                        {
                            Name = "Mendoza",
                            Cities = new List<City>
                            {
                                new City {Name = "Mendoza"},
                                new City {Name = "Las Leñas"},
                                new City {Name = "Penitentes"}
                            },
                        }
                    }
                });

                _context.Countries.Add(new Country
                {
                    Name = "Brasil",
                    States = new List<State>
                    {
                        new State
                        {   Name = "Rio Grande do Sul",
                            Cities = new List<City>
                            {
                                new City {Name = "Camboriu"},
                                new City {Name = "Porto Alegre"},
                                new City {Name = "Florianopolis"}
                            },
                        },
                        new State
                        {
                            Name = "Rio de Janeiro",
                            Cities = new List<City>
                            {
                                new City {Name = "Buzios"},
                                new City {Name = "Cabo Frio"},
                                new City {Name = "Rio de Janeiro"}
                            },
                        },
                        new State
                        {
                            Name = "Parana",
                            Cities = new List<City>
                            {
                                new City {Name = "Porto de galinha"},
                                new City {Name = "Fortaleza"},
                                new City {Name = "Parana"}
                            },
                        }
                    }
                });

                _context.Countries.Add(new Country
                {
                    Name = "Colombia",
                    States = new List<State>
                    {
                        new State
                        {   Name = "Antioquia",
                            Cities = new List<City>
                            {
                                new City {Name = "Medellin"},
                                new City {Name = "Bello"},
                                new City {Name = "Copacabana"}
                            },
                        },
                        new State
                        {
                            Name = "Bogota",
                            Cities = new List<City>
                            {
                                new City {Name = "Cali"},
                                new City {Name = "Bogota"}
                            },
                        },
                        new State
                        {
                            Name = "Bolivar",
                            Cities = new List<City>
                            {
                                new City {Name = "Cartagena"},
                                new City {Name = "Ni puta idea"},
                                new City {Name = "Colorado"}
                            },
                        }
                    }
                });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Comida" });
                _context.Categories.Add(new Category { Name = "Bebida" });
                _context.Categories.Add(new Category { Name = "Combos" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
