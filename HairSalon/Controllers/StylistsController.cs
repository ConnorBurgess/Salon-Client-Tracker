using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      System.Console.WriteLine(id);
      Stylist thisStylist = _db.Stylists.FirstOrDefault(Stylist => Stylist.StylistId == id);
      return View(thisStylist);
    }
    public ActionResult Edit(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      _db.Stylists.Remove(thisStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Find(int error)
    {
      return View(error);
    }

    [HttpPost, ActionName("Find")]
    public ActionResult Find(string stylistName)
    {
      List<Stylist> model = _db.Stylists.ToList();
      try {
      var thisStylist = _db.Stylists.First(stylist => stylist.Name == stylistName).StylistId;
      return RedirectToAction("Details", new { id = thisStylist });
      }
      catch {
      return RedirectToAction("Find", new { error = 1});
      }
      // return (thisStylist.GetType() == 1.GetType() ? RedirectToAction("Details", new { id = thisStylist }) 
      //  : RedirectToAction("Index"));
    }

  }
}