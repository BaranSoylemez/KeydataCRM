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
    public class QuoteManager : IQuoteService
    {
        IQuoteDal _quoteDal;

        public QuoteManager(IQuoteDal quoteDal)
        {
            _quoteDal = quoteDal;
        }

        public List<Quote> GetAll()
        {
            return _quoteDal.GetAll();
        }

        public void TAdd(Quote entity)
        {
            _quoteDal.Add(entity);
        }

        public Quote TGetById(int id)
        {
            return _quoteDal.GetByID(id);
        }

        public void TRemove(Quote entity)
        {
            _quoteDal.Delete(entity);
        }

        public void TUpdate(Quote entity)
        {
            _quoteDal.Update(entity);
        }
    }
}
