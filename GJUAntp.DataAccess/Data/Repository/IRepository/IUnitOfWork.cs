using System;
using System.Collections.Generic;
using System.Text;

namespace GJUAntp.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        public ICourseTypeRepository CourseType { get; }
        public ICourseRepository Course { get; }
        void Save();
    }
}
