using DBC27API1.Entities;
using SecondProject.Entities;
using SecondProject.Models;

namespace DBC27API1.Repo
{
    public interface IRepository
    {
        public String AddProgramme(Programme programme);
        public Programme GetProgramme(int id);
        public IEnumerable<Programme> GetAllProgramme();
        public Programme UpdateProgramme(int id, Programme programme);
        public void DeleteProgramme(int id);
    }

    public class Repository : IRepository
    {
        private readonly AppDbContext _appDbContext;

        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public string AddProgramme(Programme programme)
        {
            try
            {
                var model = _appDbContext.Programmes.Add(programme);
                _appDbContext.SaveChanges();
                return "Inserted Successfully";
            }
            catch
            {
                return "error happened";
            }
        }

        public void DeleteProgramme(int id)
        {
            var model = _appDbContext.Programmes.FirstOrDefault(x => x.ProgrammeID == id);
            _appDbContext.Programmes.Remove(model);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Programme> GetAllProgramme()
        {
            var model = _appDbContext.Programmes.ToList();
            return model;
        }

        public Programme GetProgramme(int id)
        {
            var model = _appDbContext.Programmes.FirstOrDefault(x => x.ProgrammeID == id);
            return model;
        }

        public Programme UpdateProgramme(int id, Programme programme)
        {
            var model = _appDbContext.Programmes.FirstOrDefault(x => x.ProgrammeID == programme.ProgrammeID);
            _appDbContext.Programmes.Update(programme);
            _appDbContext.SaveChanges();
            return programme;
        }
    }
}
