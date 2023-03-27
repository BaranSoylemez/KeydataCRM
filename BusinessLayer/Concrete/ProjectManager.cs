using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public List<Project> GetAll()
        {
            return _projectDal.GetAll();
        }

        public void TAdd(Project entity)
        {
            _projectDal.Add(entity);    
        }

        public Project TGetById(int id)
        {
           return _projectDal.GetByID(id);
        }

        public void TRemove(Project entity)
        {
            _projectDal.Delete(entity);
        }

        public void TUpdate(Project entity)
        {
            _projectDal.Update(entity);
        }
    }
}
