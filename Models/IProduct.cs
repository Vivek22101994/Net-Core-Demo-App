using Microsoft.AspNetCore.Identity;
using WebApplication4.Models;

public interface IProduct
{
    public bool AddProduct(Product product);
    public bool DeleteProduct(int  productId);

    public UsrAdmin Login(string UserName,string Pass);
    public bool CheckUser(string Email);

    public Task<bool> AddUser(RegistrationModel usrAdmin);
}