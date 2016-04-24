using AutoMapper;
using MvcValidation.ControllersViewModels.Customer;
using MvcValidation.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcValidation.Controllers
{
    public class CustomerController : Controller
    {
        private MvcValidationDbContext db;
        private IMapper mapper;

        public CustomerController(MvcValidationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = db.Customers.ToList();
            CustomerIndexVM vm = new CustomerIndexVM() { Customers = mapper.Map<List<CustomerIndexItemVM>>(customers) };

            return View("Index", vm);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View("Create", new CustomerCreateVM());
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(CustomerCreateVM vm)
        {
            if (ModelState.IsValid)
            {
                return Redirect("Index");
            }

            return View("Create", vm);
        }

        public ActionResult ValidateEmail(string email)
        {
            return Json(!db.Customers.Any(c => c.Email == email), JsonRequestBehavior.AllowGet);
        }
    }
}