using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.DTOs;
using System.Collections.Generic;

namespace PaparaThirdWeek.Services.Abstracts
{
    public interface ICompanyService
    {
        public IEnumerable<Company> GetAll();
        public void Add(Company company);
        public Company GetById(int Id);
        public void Update(Company company);
        public void Remove(Company company);
        public void HardRemove(Company company);
    }
}
