using System.Collections.Generic;
using TitiShop.Data.Infrastructure;
using TitiShop.Data.Repositories;
using TitiShop.Model.Models;

namespace TitiShop.Service
{
    public interface IProductService
    {
        Product Add(Product ProductCategory);

        void Update(Product ProductCategory);

        Product Delete(int id);

        IEnumerable<Product> GetAll();

        IEnumerable<Product> GetAll(string keyword);

        Product GetById(int id);

        void Save();
    }

    public class ProductService : IProductService
    {
        private IProductRepository _ProductRepository;
        private IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository ProductRepository, IUnitOfWork unitOfWork)
        {
            this._ProductRepository = ProductRepository;
            this._unitOfWork = unitOfWork;
        }

        public Product Add(Product ProductCategory)
        {
            return _ProductRepository.Add(ProductCategory);
        }

        public Product Delete(int id)
        {
            return _ProductRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _ProductRepository.GetAll();
        }

        public IEnumerable<Product> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                return _ProductRepository.GetMulti(x => x.Name.Contains(keyword) || x.Description.Contains(keyword) || x.Alias.Contains(keyword));
            }
            else
            {
                return _ProductRepository.GetAll();
            }
        }

        public Product GetById(int id)
        {
            return _ProductRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _ProductRepository.Update(product);
        }
    }
}