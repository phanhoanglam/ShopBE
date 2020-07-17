using MyProject.Application.Services.Product.Dto;
using MyProject.Core.IRepository;
using System.Threading.Tasks;

namespace MyProject.Application.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public Task<Core.Entity.Product> CreateProduct(ProductDto input)
        {
            throw new System.NotImplementedException();
        }
    }
}