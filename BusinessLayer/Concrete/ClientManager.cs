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
    public class ClientManager : IClientService
    {
        IClientDal _clientDal;

        public ClientManager(IClientDal clientDal)
        {
            _clientDal = clientDal;
        }

        public List<Client> GetAll()
        {
            return _clientDal.GetAll();
        }

        public void TAdd(Client entity)
        {
            _clientDal.Add(entity);
        }

        public Client TGetById(int id)
        {
            return _clientDal.GetByID(id);
        }

        public void TRemove(Client entity)
        {
            _clientDal.Delete(entity);
        }

        public void TUpdate(Client entity)
        {
            _clientDal.Update(entity);
        }
    }
}
