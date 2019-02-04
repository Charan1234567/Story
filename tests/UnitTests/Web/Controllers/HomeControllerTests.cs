using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers;
using Xunit;

using Web;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;


// Important: Make sure namespace matches folder structure
namespace Tests.UnitTests.Web.Controllers
{
    public class HomeControllerTests
    {

   // these are not async Tasks, just void methods
       [Fact]
        public  void Index_ReturnsAView()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
	
            var actual = Assert.IsAssignableFrom<IActionResult>(result);
            Assert.NotNull(actual);
        }

		

       [Fact]
        public void ShortStory_ReturnsAString()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.ShortStory();

            // Assert
	
            var contentResult = Assert.IsAssignableFrom<ContentResult>(result);
            var actual = contentResult.Content;
            var expected = "This is a very short story.";
			      Assert.Equal(expected, actual.ToString());
        }
       
		
		   #region snippet_LongStoryReturnsAString
       [Fact]
        public void LongStory_ReturnsAString()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.LongStory();

          // Assert

            var contentResult = Assert.IsAssignableFrom<ContentResult>(result);
            var actual = contentResult.Content;
            var expected = "This is a much much much longer story.";
			      Assert.Equal(expected, actual);
        }
        #endregion
    }
}