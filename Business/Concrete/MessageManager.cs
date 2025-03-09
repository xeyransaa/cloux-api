using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MessageManager: IMessageManager
    {
        private readonly IMessageDal _dal;

        public MessageManager(IMessageDal dal)
        {
            _dal = dal;
        }

        public void Add(Message message)
        {
            _dal.Add(message);
        }

        public List<Message> GetAllMessages()
        {
            return _dal.GetMessages();
        }

       

        public void Update(int id, Message message)
        {
            _dal.UpdateMessage(id, message);
        }

        Task<Message> IMessageManager.GetById(int messageId)
        {
            return _dal.GetById(messageId);
        }
    }
}
