using GJUAntp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace GJUAntp.DataAccess.Data.Repository.IRepository
{
    public class CourseTypeRepository: Repository<CourseType>, ICourseTypeRepository
    {
        public readonly ApplicationDbContext _db;
        public CourseTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;


        }

        public IEnumerable<SelectListItem> GetCourseTypeListForDropDown()
        {
            throw new NotImplementedException();
        }

        public bool IsAlreadyAvailable(string typeName)
        {
            throw new NotImplementedException();
        }

        public void Update(CourseType type)
        {
            throw new NotImplementedException();
        }
    }
}
