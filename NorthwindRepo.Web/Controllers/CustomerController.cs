using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using NorthwindRepo.Entities.Models;
using NorthwindRepo.Service;
using Repository.Pattern.Ef6;
using Repository.Pattern.Infrastructure;

namespace NorthwindRepo.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly UnitOfWork _unitOfWork;

        public CustomerController(ICustomerService customerService, UnitOfWork unitOfWork)
        {
            _customerService = customerService;
            _unitOfWork = unitOfWork;
        }

        // GET: Customer
        public async Task<ActionResult> Index()
        {
            return View(await _customerService.GetAsync());
        }

        // GET: Customer/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = await _customerService.FindAsync(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerService.Insert(customer);
                await _unitOfWork.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customer/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = await _customerService.FindAsync(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.ObjectState = ObjectState.Modified;
                _customerService.Update(customer);
                await _unitOfWork.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customer/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = await _customerService.FindAsync(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            _customerService.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}