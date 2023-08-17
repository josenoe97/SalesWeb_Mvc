using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            //obj.Department = _context.Department.First(); //Definição provisória para não ocorrer expcetion's
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {                       //eager loading 
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id); // Incluide precisa do namespace Microsoft.EntityFrameworkCore
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges(); // Confirma mudanças c/ entity framework
        }


    }
}
