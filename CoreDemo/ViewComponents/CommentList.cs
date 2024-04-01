using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System.Collections.Generic;

namespace PresentationLayer.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username = "Test1",
                },
                new UserComment
                {
                    ID= 2,
                    Username= "Test2",
                },
                new UserComment
                {
                    ID= 3,
                    Username="Ahmet"
                },
            };
            return View(commentValues);
        }
    }
}
