using AutoMapper;
using DTOs.TestimonialDtos;
using Repositories.EFCore.Contracts;
using Services.Contracts;

namespace Services.Models
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public TestimonialManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<List<TestimonialDto>> GetAllTestimonialsAsyn(bool trackChanges)
        {
            var testimonials = await _manager.Testimonial.GetAllTestimonials(trackChanges);
            return _mapper.Map<List<TestimonialDto>>(testimonials);
        }

        public async Task<TestimonialDto> GetOneTestimonialById(int id, bool trackChanges)
        {
            var testimonial = await _manager.Testimonial.GetById(id, trackChanges);
            return _mapper.Map<TestimonialDto>(testimonial);
        }
    }
}
