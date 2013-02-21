using System.Collections.Generic;
using System.Dynamic;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Linq;
using Test_Project.Models;
using Test_Project.ViewModel;
namespace Test_Project.Controllers
{
    public class TestJsonPassingController : Controller
    {
        private ScenarioPriceData _scenarioPriceData;

        public TestJsonPassingController()
        {
            _scenarioPriceData = new ScenarioPriceData();
        }
        //
        // GET: /TestJSONPassing/
        // ToDo: Replace with more concrete implementation
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult GetPricingData()
        {
            IEnumerable<dynamic> viewData = _scenarioPriceData.GetScenarioPriceData();
            return View(viewData);
        }

        public ActionResult TestMethod(string sample)
        {
            if (!string.IsNullOrEmpty(sample))
            {
                var js = new JavaScriptSerializer();
                var editedValues = js.Deserialize<List<TestViewModel>>(sample);
            }
            return View(sample);
        }
    }




}
