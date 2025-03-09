using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClouxApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageManager _messageManager;
       
        public MessageController(IMessageManager messageManager)
        {
            _messageManager = messageManager;
  
            
        }

        // GET: api/<platformController>
        [HttpGet]

        public List<Message> GetMessage()
        {
            var messages = _messageManager.GetAllMessages();
           
            return messages;

        }

        
        // GET api/<platformController>/5
        [HttpGet("id")]

        public async Task<JsonResult> GetMessagebyId(int? id)
        {
            JsonResult res = new(new { });
            if (!id.HasValue)
            {
                res.Value = new { status = 404, message = "Message not found" };
                return res;
            }
            var message = await _messageManager.GetById(id.Value);
           
            res.Value = new { status = 200, data = message };
            return res;
        }

       

        // POST api/<platformController>
        [HttpPost]

        public JsonResult Add(Message message)
        {
            JsonResult res = new(new { });
            try
            {
                

                _messageManager.Add(message);
                
                res.Value = new { status = 201, message = "Message created succesfully"};
                return res;
            }
            catch (Exception)
            {

                res.Value = new { status = 403, message = "Error" };
                return res;
            }

        }
       

        // PUT api/<platformController>/5
        [HttpPut("{id}")]
        public JsonResult Put(int? id, [FromBody] Message message)
        {

            JsonResult res = new(new { });
            if (id == null)
            {
                res.Value = new { status = 403, message = "Id is required" };
                return res;
            };
           
            _messageManager.Update(id.Value, message);


            res.Value = new { status = 200, message = "Successfully updated" };
            return res;
        }

        // DELETE api/<platformController>/5

        

    }
}
