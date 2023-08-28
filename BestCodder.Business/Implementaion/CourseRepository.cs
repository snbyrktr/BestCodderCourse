using AutoMapper;
using BestCodder.Business.Contracts;
using BestCodder.Common;
using BestCodder.DataAccess.Data;
using BestCodder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestCodder.Business.Implementaion
{
    public class CourseRepository : ICourseRepository
    {

        private readonly BestCodderCourseContext _ctx;
        private readonly IMapper _mapper;

        public CourseRepository(BestCodderCourseContext ctx,IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }



        public Task<Result<CourseDto>> CreateCourse(CourseDto courseDto)
        {
            throw new NotImplementedException();
        }

        public Task<Result<int>> DeleteCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<CourseDto>>> GetAllCourse()
        {
            throw new NotImplementedException();
        }

        public Task<Result<CourseDto>> GetCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<CourseDto>> UpdateCourse(int courseId, CourseDto courseDto)
        {
            throw new NotImplementedException();
        }
    }
}
