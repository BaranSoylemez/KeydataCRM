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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public void TAdd(Comment entity)
        {
            _commentDal.Add(entity);
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetByID(id);
        }

        public void TRemove(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public void TUpdate(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}
