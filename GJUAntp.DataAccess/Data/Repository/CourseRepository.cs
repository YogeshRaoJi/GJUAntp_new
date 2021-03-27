using GJUAntp.DataAccess.Data.Repository.IRepository;
using GJUAntp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace GJUAntp.DataAccess.Data.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public readonly ApplicationDbContext _db;
        public CourseRepository(ApplicationDbContext db): base(db)
        {
            _db = db;


        }

        public IEnumerable<SelectListItem> GetCourseListForDropDown()
        {
            throw new NotImplementedException();
        }

        public bool IsAlreadyAvailable(Course Course)
        {
            throw new NotImplementedException();
        }

        public void Update(Course type)
        {
            throw new NotImplementedException();
        }
    }
}
