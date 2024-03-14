using System;
using System.Text.Json;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using RecipeProjectServe.Entities;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeProjectServe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        string[] arr = { "1", "1", "1" };
        public static List<Recipe> recipesList = new List<Recipe>() {};
        public RecipesController()
        {
        }


        // GET: api/<RecipesController>
        [HttpGet]
        public List<Recipe> Get()
        {
            return recipesList;
        }

        // GET api/<RecipesController>/5
        [HttpGet("{name}")]
        public Recipe Get(string name)
        {
            return recipesList.FirstOrDefault(u => u.Name == name);
        }

        // POST api/<RecipesController>
        [HttpPost]
        public ActionResult Post([FromBody] Recipe value)
        {
            Recipe recipe = new Recipe(value);
            recipesList.Add(recipe);
            return Ok();
        }

        // PUT api/<RecipesController>/5
        [HttpPut("{id}")]
        public Recipe Put(int id, [FromBody] Recipe value)
        {
            Recipe r = recipesList.FirstOrDefault(u => u.Id == id);
            if(r != null)
            {
                r.Id = value.Id;
                r.Name = value.Name;
                r.CategoryId = value.CategoryId;
                r.PreparationTimeInMinutes = value.PreparationTimeInMinutes;
                r.DifficultyLevel = value.DifficultyLevel;
                r.DateAdded = value.DateAdded;
                r.UserId = value.UserId;
                r.Image = value.Image;
                r.PreparationMethod = value.PreparationMethod;
                r.Ingredients = value.Ingredients;
            }
            return r;
        }

        // DELETE api/<RecipesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
