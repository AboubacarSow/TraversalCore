using AutoMapper;
using DTOs.TestimonialDtos;
using Entities.Models;

namespace TraversalCoreProject.Utilities.AutoMapper
{
    public class TestimonialMapper :Profile
    {
        public TestimonialMapper()
        {
            CreateMap<Testimonial, TestimonialDto>();
        }
    }
}
