using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System.Collections.Generic;

namespace PresentationLayer.ViewComponents
{
    public class CityList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cityValues = new List<RegisterCity>
            {
                new RegisterCity
                {
                    Id = 1,
                    CityName = "Sakarya",
                },
                new RegisterCity
                {
                    Id = 2,
                    CityName = "Kocaeli",
                },
                new RegisterCity
                {
                    Id = 3,
                    CityName = "Ankara",
                },
                new RegisterCity
                {
                    Id = 4,
                    CityName = "Manisa",
                },
                new RegisterCity
                {
                    Id = 5,
                    CityName = "Antalya",
                },
                new RegisterCity
                {
                    Id = 6,
                    CityName = "Adana",
                },
                new RegisterCity
                {
                    Id = 7,
                    CityName = "İzmir",
                },
                new RegisterCity
                {
                    Id = 8,
                    CityName = "İstanbul",
                },
                new RegisterCity
                {
                    Id = 9,
                    CityName = "Zonguldak",
                },
                new RegisterCity
                {
                    Id = 10,
                    CityName = "Düzce",
                }
            };
            return View(cityValues);
        }
    }
}
