﻿using Foody.Business.Abstract;
using Foody.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.Presentation;

public class CategoriesController : Controller
{
   private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public IActionResult CategoryList()
     {
        var categories = _categoryService.TGetAll();
        return View(categories);
     }

     [HttpGet]
     public IActionResult CreateCategory()
     {
         return View();
     }

     [HttpPost]
     public IActionResult CreateCategory(Category category)
     {
          _categoryService.TInsert(category);
          return RedirectToAction("CategoryList");
     }
}
