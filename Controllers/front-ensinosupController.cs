using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using System.Linq; 
using front_ensinosupApi.Models;
namespace front_ensinosup.Controllers
{
    [Route("api/[controller]")]     
    [ApiController]     
    public class front_ensinosupController : ControllerBase
    {        
        private readonly front_ensinosupContext _context;          
        public front_ensinosupController(front_ensinosupContext context)         
        {             
            _context = context;              
            
            if (_context.front_EnsinosupMatriculas.Count() == 0)             
            {                 
                _context.front_EnsinosupMatriculas.Add(new front_ensinosupMatriculas { ra = "Item1", nome = "joao", cpf = "000.000.000-00", email = "oi@mail.com" });                 
                _context.SaveChanges();             
            }         
        }            

        [HttpGet] 
        public ActionResult<List<front_ensinosupMatriculas>> GetAll() 
        {     
            return _context.front_EnsinosupMatriculas.ToList(); 
        } 
        
        [HttpGet("{id}", Name = "GetRA")] 
        public ActionResult<front_ensinosupMatriculas> GetById(long id) 
        {    
            var item = _context.front_EnsinosupMatriculas.Find(id);     
            if (item == null)    
            {         
                return NotFound();     
            }     
            return item; 
        }
    }
}
    

