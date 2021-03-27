using GJUAntp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GJUAntp.DataAccess.Data.Repository.IRepository
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GetCourseListForDropDown();
        void Update(Course type);
        bool IsAlreadyAvailable(Course Course);
    }
}
