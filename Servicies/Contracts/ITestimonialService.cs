using DTOs.FeatureDtos;
using DTOs.TestimonialDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ITestimonialService
    {
        Task<List<TestimonialDto>> GetAllTestimonialsAsyn(bool trackChanges);
        Task<TestimonialDto> GetOneTestimonialById(int id, bool trackChanges);
    }
}
