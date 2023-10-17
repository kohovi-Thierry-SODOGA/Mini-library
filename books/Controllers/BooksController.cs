using Microsoft.AspNetCore.Mvc;
using books.Contrats.books;

namespace Books.Controllers;

[ApiController]

public class BooksController : ControllerBase
{
  [HttpPost("/books")]

  public IActionResult CreateBooks(CreateBooksRequest request) 
  {
    return Ok(request);
  } 

  [HttpGet("/books/{id:guid}")]

  public IActionResult GetBooks(Guid id) 
  {
    return Ok();
  } 

  //[HttpPut("/books/{id:guid}")]
  [HttpPut("{id:guid}")]

  public IActionResult UpsertBooks(Guid id, UpsertRequest request) 
  {
    return Ok(request);
  } 

  // [HttpDelete("/books/{id:guid}")]

  // public IActionResult DeleteBooks(DeleteBooksRequest request) 
  // {
  //   return Ok(request);
  // } 
}