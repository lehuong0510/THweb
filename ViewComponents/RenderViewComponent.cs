using _13_09web_student.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13_09web_student.ViewComponents
{
    public class RenderViewComponent : ViewComponent
    {
        private List<MenuItem> menuItems = new List<MenuItem>();
        public RenderViewComponent()
        {
           menuItems = new List<MenuItem>()
             {
                new MenuItem(){ Id =1, Name="Branches", Link="Branches/List"},
                new MenuItem(){ Id =2, Name="Students", Link="Students/List"},
                new MenuItem(){ Id =3, Name="Subjects", Link="Subjects/List"},
                new MenuItem(){ Id =4, Name="Courses", Link="Courses/List"}
            };
        }
        public async Task<IViewComponentResult> InvoleAsync()//hien thi view theo co che bat dong bo
        {
            return View("RenderLeftMenu", menuItems);
        }
    }

}
