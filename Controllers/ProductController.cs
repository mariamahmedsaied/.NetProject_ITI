using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolLibraryStore.Context;
using SchoolLibraryStore.Models;

namespace SchoolLibraryStore.Controllers
{
    public class ProductController : Controller
    {
      
            SchoolLibraryStoreContext db = new SchoolLibraryStoreContext();

            [HttpGet]
            public IActionResult Index()
            {
                var _Products = db.Products.Include(prd => prd.Category);
                return View(_Products);
            }

            [HttpGet]
            public IActionResult ViewDetails(int id)
            {
            var _Singleprd = db.Products.Include(p => p.Category).FirstOrDefault(prd => prd.CategoryId == id);
            if (_Singleprd == null)
            {
                return RedirectToAction("Index");
            }
            return View(_Singleprd);
        
             }

            [HttpGet]
            public IActionResult Create()
            {
                ViewBag._Categories = new SelectList(db.Categories, "CategoryId", "Name", "Description");
                return View();
            }

            [HttpPost]
            public IActionResult Create(Product product)
            {

                ModelState.Remove("Category");
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "All Fields Required");
                    ViewBag._Departments = new SelectList(db.Categories, "CategoryId", "Name", "Description");
                    return View();
                }


                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            [HttpGet]
            public IActionResult Edit(int id)
            {
                var _Product = db.Products.Include(p => p.Category).FirstOrDefault(prd => prd.CategoryId == id);
                if (_Product == null)
                {
                    return RedirectToAction("Index");
                }
                ViewBag._Categories = new SelectList(db.Categories, "CategoryId", "Name", "Description");
                return View(_Product);
            }
            
            [HttpPost]
            public IActionResult Edit(Product product)
            {
                ModelState.Remove("Category");
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "All Fields Required");
                    ViewBag._Categories = new SelectList(db.Categories, "CategoryId", "Name", "Description");
                    return View();
                }
                db.Products.Update(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           
            public IActionResult Delete(int id)
            {
                var _ProductToDelete = db.Products.Find(id);
                if (_ProductToDelete == null)
                {
                    return RedirectToAction("Index");
                }
                db.Products.Remove(_ProductToDelete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
        }
    }

