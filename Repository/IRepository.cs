using SecondProject.Entities;
using SecondProject.Models;

namespace SecondProject.Repository
{
    public interface IRepository
    {
        public String AddProgramme(Programme programme);
        public Programme GetProgramme(int id);
        public IEnumerable<Programme> GetAllProgramme();
        public Programme UpdateProgramme(int id, Programme programme);
        public void DeleteProgramme(int id);


    }

    public class ProgrammeRepo : IRepository
    {
        private readonly ProjectEntities _projectEntities;

        public ProgrammeRepo(ProjectEntities projectEntities)
        {
            _projectEntities = projectEntities;
        }

        public String AddProgramme(Programme programme)
        {
            try
            {
                var model = _projectEntities.Programmes.Add(programme);
                _projectEntities.SaveChanges();
                return "Programme added successfully";
            }
            catch
            {
                return "Error adding Programme";
            }
        }

        public void DeleteProgramme(int id)
        {
            var model = _projectEntities.Programmes.FirstOrDefault(x => x.ProgrammeID == id);
            _projectEntities.Programmes.Remove(model);
            _projectEntities.SaveChanges();
        }

        public IEnumerable<Programme> GetAllProgramme()
        {
            var model = _projectEntities.Programmes.ToList();
            return model;
        }

        public Programme GetProgramme(int id)
        {
            var model = _projectEntities.Programmes.FirstOrDefault(x => x.ProgrammeID == id);
            return model;
        }

        public Programme UpdateProgramme(int id, Programme programme)
        {
            var model = _projectEntities.Programmes.FirstOrDefault(x => x.ProgrammeID == id);
            _projectEntities.Programmes.Update(programme);
            _projectEntities.SaveChanges();
            return programme;
        }
    }
}
    
