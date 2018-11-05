using ExpressoApi.Data;
using System.Linq;
using System.Web.Http;

namespace ExpressoApi.Controllers
{
    public class MenusController : ApiController
    {
        private ExpressoDbContext _dbContext = new ExpressoDbContext();

        public IHttpActionResult GetMenus()
        {
            var menus = _dbContext.Menus.Include("SubMenus");
            return Ok(menus);
        }

        public IHttpActionResult GetMenu(int id)
        {
            var menu = _dbContext.Menus.Include("SubMenus").FirstOrDefault(m => m.Id == id);
            if(menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }
    }
}
