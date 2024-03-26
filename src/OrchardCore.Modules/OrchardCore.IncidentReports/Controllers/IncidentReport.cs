using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrchardCore.IncidentReports.Controllers;
public class IncidentReport : Controller
{
    // GET: IncidentReport
    public ActionResult Index()
    {
        return View();
    }

    // GET: IncidentReport/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: IncidentReport/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: IncidentReport/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: IncidentReport/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: IncidentReport/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: IncidentReport/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: IncidentReport/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
