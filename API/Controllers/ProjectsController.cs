﻿using System.Threading.Tasks;
using BLL.DTOs.Project;
using BLL.Exceptions;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    /// <summary>
    /// <c>ProjectsController</c> is a class.
    /// Contains all http methods for working with projects.
    /// </summary>
    /// <remarks>
    /// This class can get, create, delete, edit category and other staff for this entity.
    /// </remarks>
    
    // api/projects
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }
       
        
        /// <summary>
        /// This method returns all projects
        /// </summary>
        /// <response code="200">Returns all categories</response>

        //GET api/categories
        [HttpPost("user")]
        public ActionResult AddUserToProject(AddUserToProjectDto addUserToProjectDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                
                _projectService.AddUserToProject(addUserToProjectDto);
               
               return Ok(HttpContext.User.Claims);
            }
            catch (DbQueryResultNullException e)
            {
                return NotFound(e.Message);
            }
        }

        
        /*/// <summary>
        /// This method returns category that has an inputted Id property
        /// </summary>
        /// <response code="200">Returns category that has an inputted Id property</response>
        /// <response code="404">Returns message that nothing was found, if message wasn't returned than id inputted incorrectly</response>
        
        //GET api/categories/{id}
        [HttpGet("{id:int}", Name = "GetCategoryById")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            try
            {
                var category = await _categoryService.GetByIdAsync(id);
                return Ok(category);
            }
            catch (DbQueryResultNullException e)
            {
                return NotFound(e.Message);
            }
        }
        
        
        /// <summary>
        /// This method returns category that was created and path to it
        /// </summary>
        /// <response code="201">Returns category that was created and path to it</response>
        /// <response code="400">Returns message why model is invalid</response>
        /// <response code="404">Returns message if something had gone wrong</response>

        //POST api/categories 
        [HttpPost]
        [ProducesResponseType(typeof(CategoryDto), 201)]
        public async Task<IActionResult> CreateCategory(CategoryDto categoryDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                if (categoryDto.Id != 0)
                    return BadRequest("The Id should be empty");
               
                var createdCategory = await _categoryService.CreateAsync(categoryDto);
            
                //Fetch the category from data source
                return CreatedAtRoute("GetCategoryById", new {id = createdCategory.Id}, createdCategory);
            }
            catch (DbQueryResultNullException e)
            {
                return NotFound(e.Message);
            }
        }
        

        /// <summary>
        /// This method changes category
        /// </summary>
        /// <response code="204">Returns nothing, category was successfully changed</response>
        /// <response code="400">Returns message why model is invalid</response>
        /// <response code="404">Returns message that category was not found, if message wasn't returned than id inputted incorrectly</response>
        
        //PUT api/categories
        [HttpPut]
        [ProducesResponseType(204)]
        public IActionResult UpdateCategory(CategoryDto categoryDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                
                _categoryService.Update(categoryDto);
                return NoContent();
            }
            catch (DbQueryResultNullException e)
            {
                return NotFound(e.Message);
            }
        }
        
        
        /// <summary>
        /// This method deletes category
        /// </summary>
        /// <response code="204">Returns nothing, category was successfully deleted</response>
        /// <response code="404">Returns message that category was not found</response>
        
        //DELETE api/categories/{id}
        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        public IActionResult DeleteCategory(int id)
        {
            try
            {
                _categoryService.Remove(id);
                return NoContent();
            }
            catch (DbQueryResultNullException e)
            {
                return NotFound(e.Message);
            }
        }*/
    }
}