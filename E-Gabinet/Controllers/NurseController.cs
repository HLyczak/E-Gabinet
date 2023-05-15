
using Egabinet.Models;
using Egabinet.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Egabinet.Controllers
{
    public class NurseController : Controller
    {
        private readonly INurseService nurseService;
        private readonly IPaymentService paymentService;


        public NurseController(INurseService nurseService, IPaymentService paymentService)
        {
            this.nurseService = nurseService;
            this.paymentService = paymentService;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            NurseViewModel nurse = await nurseService.GetNurseAsync(User.Identity.Name);
            return View(nurse);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> EditNurse()
        {
            UpdateNurseViewModel viewModel = await nurseService.GetUpdateNurseViewModel(User.Identity.Name);
            return View("EditNurse", viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditNurse(UpdateNurseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await nurseService.UpdateNurseAsync(model);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public async Task<IActionResult> DeleteVisit(string id)
        {
            try
            {
                await nurseService.DeleteVisitAsync(id);
                return RedirectToAction("Index");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Visit with Id = {id} not found {e}");
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddVisit(AddVisitViewModel model)
        {
            await nurseService.AddVisit(model);
            return RedirectToAction("ShowTimesheet");
        }

        [HttpGet]
        public async Task<IActionResult> ShowTimesheet()
        {
            List<TimeSheetViewModel> viewModel = await nurseService.ShowTimesheet();
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> ShowUsers()
        {
            IEnumerable<ShowUsersViewModel> viewModelUser = await nurseService.ShowUsers();

            return View(viewModelUser);
        }


        [HttpGet]
        public async Task<IActionResult> AddVisit()
        {
            AddVisitViewModel viewModel = await nurseService.GetAddVisitViewModel();
            return View("AddVisit", viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> ShowPayments()
        {
            IEnumerable<PaymentDto> payments = await paymentService.GetAllAsync();

            return View(payments);
        }

        [HttpGet]
        public async Task<IActionResult> AddPayment()
        {
            IEnumerable<SelectListItem> viewModel = (await nurseService.ShowTimesheet()).Where(x => x.PaymentId is null).Select(x => new SelectListItem($"Patient: {x.Patient}, Doctor: {x.Doctor}, Price: {x.Amount} ", x.Id));

            AddPaymentDto addPayment = new AddPaymentDto { Timesheets = viewModel };
            return View(addPayment);
        }

        [HttpPost]
        public async Task<IActionResult> AddPayment(AddPaymentDto model)
        {

            await paymentService.AddAsync(model);
            return RedirectToAction("ShowPayments");
        }
    }
}











