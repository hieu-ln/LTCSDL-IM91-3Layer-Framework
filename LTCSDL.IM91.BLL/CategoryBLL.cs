using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LTCSDL.IM91.DAL;
using LTCSDL.IM91.DTO;

namespace LTCSDL.IM91.BLL
{
    public class CategoryBLL
    {
        private CategoryDAL dal;

        public CategoryBLL()
        {
            dal = new CategoryDAL();
        }

        public List<Category> GetAll()
        {
            return dal.GetAll();
        }
    }
}
