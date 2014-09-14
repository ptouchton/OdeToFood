using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    //public class ReviewsController : Controller
    //{
    //    [ChildActionOnly]
    //    public ActionResult BestReview()
    //    {
    //        var best = from r in _reviews
    //            orderby r.Rating descending
    //            select r;

    //        return PartialView("_Review", best.First());
    //    }
    //    //
    //    // GET: /Reviews/

    //    public ActionResult Index()
    //    {
    //        var model =
    //            from r in _reviews
    //            //orderby r.City
    //            select r;
    //        return View(model);
    //    }

    //    //
    //    // GET: /Reviews/Details/5

    //    public ActionResult Details(int id)
    //    {
    //        return View();
    //    }

    //    //
    //    // GET: /Reviews/Create

    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    //
    //    // POST: /Reviews/Create

    //    [HttpPost]
    //    public ActionResult Create(FormCollection collection)
    //    {
    //        try
    //        {
    //            // TODO: Add insert logic here

    //            return RedirectToAction("Index");
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }

    //    //
    //    // GET: /Reviews/Edit/5

    //    public ActionResult Edit(int id)
    //    {
    //        var model = _reviews.Single(r => r.Id == id);
    //        return View(model);
    //    }

    //    //
    //    // POST: /Reviews/Edit/5

    //    [HttpPost]
    //    public ActionResult Edit(int id, FormCollection collection)
    //    {

    //        var review = _reviews.Single(r => r.Id == id);
    //        if (TryUpdateModel(review))
    //        {
    //            return RedirectToAction("Index");
    //        }

    //        return View(review);

    //    }

    //    //
    //    // GET: /Reviews/Delete/5

    //    public ActionResult Delete(int id)
    //    {
    //        return View();
    //    }

    //    //
    //    // POST: /Reviews/Delete/5

    //    [HttpPost]
    //    public ActionResult Delete(int id, FormCollection collection)
    //    {
    //        try
    //        {
    //            // TODO: Add delete logic here

    //            return RedirectToAction("Index");
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }

    //    private List<RestaurantReview> _reviews = new List<RestaurantReview>
    //    {
    //        new RestaurantReview
    //        {
    //            Id = 1,
    //            Name = "City Grille",
    //            City = "London",
    //            Country = "UK",
    //            Rating = 9
    //        },
    //        new RestaurantReview
    //        {
    //            Id = 2,
    //            Name = "Literal Bella",
    //            City = "Portland",
    //            Country = "OR",
    //            Rating = 10
    //        },
    //        new RestaurantReview
    //        {
    //            Id = 3,
    //            Name = "Ellie's Tavern",
    //            City = "Beaverton",
    //            Country = "OR",
    //            Rating = 8
    //        },


    //    };
    //}
}
