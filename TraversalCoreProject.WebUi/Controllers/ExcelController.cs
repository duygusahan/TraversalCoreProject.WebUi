using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.DataAccessLayer.Concrete;
using TraversalCoreProject.EntityLayer.Concrete;
using TraversalCoreProject.WebUi.Models;

namespace TraversalCoreProject.WebUi.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
           return View();
        }

        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using(var c =new TraversalContext())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    TourName= x.TourName,
                    Price= x.Price,
                    Capacity= x.Capacity,
                    DayNight= x.DayNight,
                }).ToList();
            }
            return destinationModels;

        }

        public IActionResult StaticExcelReport()
        {

            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");


        }

        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";
                int rowCount = 2;
                foreach(var item in DestinationList())
                {
                    workSheet.Cell(rowCount,1).Value= item.TourName;
                    workSheet.Cell(rowCount,2).Value= item.Price;
                    workSheet.Cell(rowCount,3).Value= item.Capacity;
                    workSheet.Cell(rowCount,4).Value= item.DayNight;
                    rowCount++;

                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);   
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "yeniListe.xlsx");
                }
            }
        }
    }
}
