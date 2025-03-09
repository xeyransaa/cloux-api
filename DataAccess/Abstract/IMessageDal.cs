using Core;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMessageDal : IEntityRepositary<Message>
    {
        List<Message> GetMessages();


        Task<Message> GetById(int id);

        public void AddMessage(Message message);
        public void UpdateMessage(int id, Message message);
     
        
    }
}
