using GJUAntp.DataAccess.Data.Repository.IRepository;

namespace GJUAntp.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            this._db = db;
            CourseType = new CourseTypeRepository(db);
            Course = new CourseRepository(db);
        }
        public ICourseTypeRepository CourseType { get; private set; }
        public ICourseRepository Course { get; private set; }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
