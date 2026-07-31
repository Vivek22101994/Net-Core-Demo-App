using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using WebApplication4.Models;

public class ProductService : IProduct
{
    private readonly MyDbContext _context;

    public ProductService(MyDbContext AplicationDbContet)
    {
        _context = AplicationDbContet;
    }
    public bool AddUser(RegistrationModel registrationModel)
    {
        bool Result = false;
        try
        {
            IPasswordHasher<UsrAdmin> passwordHasher = new PasswordHasher<UsrAdmin>();
            UsrAdmin usrAdmin = new UsrAdmin();
            usrAdmin.UniqueId = Guid.NewGuid();
            usrAdmin.UserName = registrationModel.FirstName + " " + registrationModel.LastName;
            usrAdmin.Login = registrationModel.UserEmail;
            usrAdmin.Password = passwordHasher.HashPassword(usrAdmin, registrationModel.Password);
            usrAdmin.RoleId = 1;
            usrAdmin.CreatedDate = System.DateTime.Now;
            usrAdmin.ProjectId = 10;
            usrAdmin.Email = registrationModel.UserEmail;
            usrAdmin.Lang = registrationModel.Language;
            _context.USR_ADMIN.Add(usrAdmin);
            _context.SaveChangesAsync();
            Result = true;
        }
        catch (Exception ex)
        {

        }
        return Result;       
    }
    public bool CheckUser(string Email)
    {
        bool Result = false;

        UsrAdmin usrAdmin = _context.USR_ADMIN.FirstOrDefault(X => X.Email == Email);
        if (usrAdmin == null)
        {
            Result = true;
        }
        return Result;
    }
    public UsrAdmin Login(string userName, string password)
    {
        bool Result = false;
        IPasswordHasher <UsrAdmin> passwordHasher = new PasswordHasher<UsrAdmin>();
        UsrAdmin usrAdmin = _context.USR_ADMIN.FirstOrDefault(X => X.Email == userName);
        if (usrAdmin != null)
        {
            var result = passwordHasher.VerifyHashedPassword(usrAdmin, usrAdmin.Password, password);
            if (result == PasswordVerificationResult.Success)
            {
                Result = true;
            }
        }
        return usrAdmin;
    }
    public bool AddProduct(Product product)
    {
        bool result = false;
        try
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            result = true;
        }
        catch (Exception ex)
        {

        }
        return result; 
    }
    public bool DeleteProduct(int productId)
    {
        bool result = false;
        try
        {
            Product product = _context.Products.FirstOrDefault(x => x.Id == productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            result = true;
        }
        catch (Exception ex)
        {

        }
        return result;
    }
}