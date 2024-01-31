using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data;

public static class SampleData
{
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }
    public static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>() {
            new Province() { ProvinceName="British Columbia", ProvinceCode="BC", Cities = new List<City>() },
            new Province() { ProvinceName="California", ProvinceCode="CA", Cities = new List<City>() },
            new Province() { ProvinceName="Alberta", ProvinceCode="AB", Cities = new List<City>() },
            new Province() { ProvinceName="Ontario", ProvinceCode="ON", Cities = new List<City>() },
            new Province() { ProvinceName="Florida", ProvinceCode="FL", Cities = new List<City>() },
            new Province() { ProvinceName="Illinois", ProvinceCode="IL", Cities = new List<City>() },
        };

        return provinces;
    }

    public static List<City> GetCities()
    {
        List<City> cities = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 675218,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 2,
                CityName = "Victoria",
                Population = 344615,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 3,
                CityName = "Burnaby",
                Population = 232755,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 4,
                CityName = "Surrey",
                Population = 517887,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 5,
                CityName = "Richmond",
                Population = 198309,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 6,
                CityName = "San Francisco",
                Population = 883305,
                ProvinceCode = "CA"
            },
        };
        return cities;
    }
}
