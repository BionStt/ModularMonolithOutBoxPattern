using Inventory.Dto;
using Inventory.DtoMapping;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ModularMonolithOutBoxPattern.MVC.Controllers
{
    public class MasterBarangController : Controller
    {
        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MasterBarangController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator=mediator;
            _httpContextAccessor=httpContextAccessor;
        }

        [HttpGet]
        public IActionResult Create()
        {
            // ViewData["UserId"] = _userId;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateMasterBarangRequest MasterBarangViewModel)
        {
            var xx = MasterBarangViewModel.ToCommand();
            await _mediator.Send(xx);

            return RedirectToAction(nameof(MasterBarangController.Create), "MasterBarang");

            //if (ModelState.IsValid)
            //{
            //    var xx = MasterBarangViewModel.ToCommand();
            //    await _mediator.Send(xx);

            //    return RedirectToAction(nameof(MasterBarangController.Create), "MasterBarang");
            //}
            //return View(MasterBarangViewModel);
        }
    }
}
