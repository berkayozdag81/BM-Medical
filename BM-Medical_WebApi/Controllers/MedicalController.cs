using System.Web.Http;



namespace BM_Medical_WebApi.Controllers
{
public class MedicalController:ApiController
{
[HttpPost]
[Route("api/BM/GetTest")]
public IHttpActionResult Medical(int id)
{
var response = "WebApi is Working...";



return Json(response);
}



[HttpGet]
[Route("api/BM/GetProduct/")]
public IHttpActionResult Get()
{
return Json(new { Message = "Service Working.success" });
}



}




}
