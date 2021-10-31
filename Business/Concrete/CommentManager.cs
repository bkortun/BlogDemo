using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        public IResult Add(Comment comment)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Comment> Get()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
