using AutoMapper;
using eTickets.BLL.Interfaces;
using eTickets.Pl.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Pl.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProducersController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var producers = _unitOfWork.ProducerRepository.GetAll();
            var mappedProducers = _mapper.Map<ProducerViewModel>(producers);

            return View(mappedProducers);
        }
    }
}
