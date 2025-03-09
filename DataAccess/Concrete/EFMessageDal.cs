using Core.DataAccess.EF;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFMessageDal : EFEntityRepositary<ClouxDbContext, Message>, IMessageDal
    {

        public async Task<Message> GetById(int id)
        {
            using ClouxDbContext context = new();
            var message = context.Messages
              .FirstOrDefaultAsync();
            return await message;
        }

       
        public List<Message> GetMessages()
        {
            using ClouxDbContext context = new();
            var messages = context.Messages
              .ToList();
            return messages;
        }


        public void UpdateMessage(int id, Message message)
        {
            using ClouxDbContext context = new();
            message.Id = id;


            context.Messages.Update(message);
            context.SaveChanges();
        }

        public void AddMessage(Message message) { 
        
            using ClouxDbContext context = new();
            context.Messages.Add(message);
            context.SaveChanges();
                  
            
           
        }

         
    }
}
