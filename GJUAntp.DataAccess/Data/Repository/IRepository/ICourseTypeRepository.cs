using GJUAntp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GJUAntp.DataAccess.Data.Repository.IRepository
{
    public interface ICourseTypeRepository: IRepository<CourseType>
    {
        IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GetCourseTypeListForDropDown();
        void Update(CourseType type);
        bool IsAlreadyAvailable(string typeName);
    }
}
