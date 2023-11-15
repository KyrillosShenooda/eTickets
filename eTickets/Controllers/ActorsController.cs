using AutoMapper;
using eTickets.BLL.Interfaces;
using eTickets.Pl.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Pl.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ActorsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var actors = _unitOfWork.ActorRepository.GetAll();
            var mappedActors = _mapper.Map<ActorViewModel>(actors);
            return View(mappedActors);
        }
    }
}
