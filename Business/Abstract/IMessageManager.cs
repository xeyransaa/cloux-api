using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageManager
    {
        void Add(Message message);
        void Update(int id, Message message);
        Task<Message> GetById(int messageId);
        
        List<Message> GetAllMessages();
    }
}
