using BraveFish.Base;
using BraveFish.SampleAPI.Exceptions;
using BraveFish.SampleAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BraveFish.SampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        [HttpPost]
        [Route("create")]
        public BaseResponseModel<Book> CreateBook([FromBody] BookCreateRequestModel createRequest)
        {
            var createdBook = new Book
            {
                Id = Guid.NewGuid(),
                Title = createRequest.Title,
                Author = createRequest.Author,
                Genres = createRequest.Genres,
                Rating = createRequest.Rating
            };
            return ResponseWrapper.WrapSuccess(createdBook);
        }

        [HttpPost]
        [Route("get")]
        public BaseResponseModel<Book> GetBook([FromBody] BookGetRequestModel getRequest)
        {
            if (getRequest.Id == Guid.Empty)
            {
                throw new RecordNotFoundException();
            }

            var foundBook = new Book
            {
                Id = getRequest.Id,
                Title = "Random Title",
                Author = "Random Author",
                Genres = new List<string> { "action", "romance" },
                Rating = 7.6f
            };
            return ResponseWrapper.WrapSuccess(foundBook);
        }

        [HttpPost]
        public BaseResponseModel<Book> GetError()
        {
            throw new StupidException();
        }
    }
}
