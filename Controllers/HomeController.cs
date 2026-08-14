using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Text;
using WebApplication4.Logs;
using WebApplication4.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApplication4.Controllers
{
    
    delegate void MyDelegate(string message);
   // [CustomResourceFilter]
    //[ActionAttribute]
    public class HomeController : Controller
    {
        private readonly IProduct Service;
        private readonly IHostingEnvironment _HostEnvironment;
        private readonly IMapper _mapper;
       // private readonly IOptionsMonitor<EmailOptions> _options;
        private readonly Common _common;
       

        public HomeController(IProduct productService, IHostingEnvironment HostEnvironment,IMapper mapper,Common common)
        {
            Service = productService;
            _HostEnvironment = HostEnvironment;
           
            _mapper = mapper;
            //_options = options;
            _common = common;
        }
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public (string Name, int Age) GetEmployee()
        {
            return ("Vivek", 28);
        }
        public IActionResult Login()
        {
            //throw new Exception("Database connection failed");
            int i = 1;
            for (; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
           
            string strName = "VivekParikh";
            string LastChar = strName[^1].ToString();
            if (strName[0] == 'V' && strName[^1] == 'h')
            {
                Console.WriteLine("String Start With 'V' And End With 'h' ");
            }
            MyDelegate del = PrintMessage;
            del("Hello .NET Core");
            // Partial Class Demo
            Employee employee1 = new Employee();
            employee1.GetName();
            employee1.SaveName();
            HashSet<int> ints = new HashSet<int>();
            ints.Add(2);
            ints.Add(2);
            var fdfd = new Empytee("John", "Doe", "sfsdfdsf"); // Primary

            (string Name, int Experience) employee =
    ("Vivek", 8);
            // Timestemp Wise GUID UNIX TimeStemp
            var id1 = Guid.CreateVersion7();
            Thread.Sleep(1000);
            var id2 = Guid.CreateVersion7();

            //int p1 = _common.GetSMTPPort();

            //Thread.Sleep(20000); // wait 20 sec

            //int p2 = _common.GetSMTPPort();
            // Defined Basic Tupple
            var person = ("Vivek", 28);

            //Get Value From Tupple
            string Name = person.Item1;
            int Age = person.Item2;

            var ssd = (Name: "Vivek", Age: 28);
            Name = ssd.Name;
            Age = ssd.Age;
            List<int> Vs = new List<int>
            {
                10,
                20,
                30,
                40,
                50
            };
            var Dicroty = Vs.CountBy(x => x);
            long DataNum = Vs.LongCount(x => x % 2 == 0);
            int[] strarray =
            {
                3,
                4,
                5,
                6,
                7,
                6

            };
            var Duplicate = strarray.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key).ToArray();
            var gropy = strarray.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            int[] numver = Enumerable.Range(0, 7).ToArray();
            return View();
        }
        public IActionResult Registation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registation(RegistrationModel registrationModel)
        {
            if (!ModelState.IsValid)
                return View(registrationModel);

            bool isRegister =  await Service.AddUser(registrationModel);
            if (isRegister)
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
        public IActionResult Logout()
        {
            TempData.Clear();
            return RedirectToAction("Login", "Home");
        }
        public IActionResult GetData()
        {
            //TempData.Clear();
            Response.ContentType = "application/xml";
            string xml = "";
            xml += "<xml>";
            xml += "<FirstName>Vivek</FirstName>";
            xml += "<LastName>PArikh</LastName>";
            xml += "</xml>";
            return Content(xml);
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            string Email = loginViewModel.Email switch
            {
                "Test"=>"Test Email",
                "Qa" => "QA email",
                 _   => "ddd"
            };
             

            if (!ModelState.IsValid)
                return View(loginViewModel);

            if(loginViewModel is { Email: not null and not "",Password: not null and not "" })
            {
                ViewBag.Error = "Enter Email And Password";
            }

            UsrAdmin UserData = Service.Login(loginViewModel.Email, loginViewModel.Password);
            if (UserData == null)
            {
                ViewBag.Error = "Invalid UserName And Password";
            }
            else
            {
                ////string url = "https://api.ipify.org";
                ////ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ////HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                ////request.Method = "GET";
                ////HttpWebResponse obj1 = (HttpWebResponse)request.GetResponse();
                ////Stream os1 = obj1.GetResponseStream();
                ////StreamReader _Answer = new StreamReader(os1);
                ////String strRSString = _Answer.ReadToEnd().ToString();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Login Done");
                sb.AppendLine("===========");
                sb.AppendLine("Email Adress: " + UserData.Email);
                sb.AppendLine("Email Adress: " + HttpContext.Connection.RemoteIpAddress?.ToString());
                sb.AppendLine("Login Date Time: " + System.DateTime.Now);

                var UploadFolder = Path.Combine(_HostEnvironment.WebRootPath, "Logs");
                if (!System.IO.Directory.Exists(UploadFolder))
                    System.IO.Directory.CreateDirectory(UploadFolder);

                string FileName = "log.txt";
                string filePath = Path.Combine(UploadFolder, FileName);
                System.IO.File.AppendAllText(filePath, sb.ToString());
                TempData["UserID"] = UserData.UserId;
                TempData["UserName"] = UserData.UserName;
                return RedirectToAction("FileUploadDemo", "Home");
            }
            return View(loginViewModel);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FileUploadDemo()
        {            
            return View();
        }
        // Upload File With Ajax FormData And Create hash Passord For User Tbl
        public async Task<IActionResult> SaveHomewAyData()
        {           
            foreach (var file in Request.Form.Files)
            {
                var UploadFolder = Path.Combine(_HostEnvironment.WebRootPath, "Images");

                if (!System.IO.Directory.Exists(UploadFolder))
                    System.IO.Directory.CreateDirectory(UploadFolder);
                string FileName = Guid.CreateVersion7(DateTime.Now).ToString() + "_" + file.FileName;
                string filePath = Path.Combine(UploadFolder, FileName);
                await using var stream = new FileStream(filePath, FileMode.Create);
                await file.CopyToAsync(stream);
            }
            return Json(true);
        }
        // Upload File With Razor FormData
        [HttpPost]
        public async Task<IActionResult> Index(NewPrdocut newPrdocut)
        {
            if(newPrdocut.Photo != null)
            {                
                var UploadFolder = Path.Combine(_HostEnvironment.WebRootPath, "Images");
                if (!System.IO.Directory.Exists(UploadFolder))
                    System.IO.Directory.CreateDirectory(UploadFolder);
                string FileName = Guid.CreateVersion7(DateTime.Now).ToString() + "_" + newPrdocut.Photo.FileName;
                string filePath = Path.Combine(UploadFolder, FileName);
                await using var stream = new FileStream(filePath, FileMode.Create);
                await newPrdocut.Photo.CopyToAsync(stream);
            }            
            return View("Index");
        }
        [AcceptVerbs("GET", "POST")]
        public IActionResult CheckEmail(string UserEmail)
        {
            bool CheckEmail = Service.CheckUser(UserEmail);
            if (CheckEmail)
            {
                return Json(true);
            }
            else
            {
                return Json("Email Adress Alredy Exists");
            }            
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(ProductViewModel product)
        {
            Product productNew = _mapper.Map<Product>(product);
            bool IsResult = Service.AddProduct(productNew);
            return RedirectToAction("ProductList");
        }
        public IActionResult DeleteProduct(int id)
        {
            bool IsResult = Service.DeleteProduct(id);
            return RedirectToAction("ProductList");
        }
    }
}
