using Backend.Core.Services;
using Backend.Infrastructure.Data;
using Backend.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Backend.Core.Tests
{
    public class AchievementTests
    {
        private Mock<DbSet<User>> CreateMockDbSet(IEnumerable<User> data)
        {
            var queryable = data.AsQueryable();
            var mockSet = new Mock<DbSet<User>>();
            mockSet.As<IQueryable<User>>().Setup(m => m.Provider).Returns(queryable.Provider);
            mockSet.As<IQueryable<User>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockSet.As<IQueryable<User>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mockSet.As<IQueryable<User>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator());
            return mockSet;
        }

        [Fact]
        public void Is5OwnTrainings_UserNotFound_ReturnsNull()
        {
            // Arrange
            var mockContext = new Mock<ApplicationContext>();
            var emptyData = new List<User>();
            mockContext.Setup(c => c.Users).Returns(CreateMockDbSet(emptyData).Object);

            var service = new AchievmentService(mockContext.Object);

            // Act
            var result = service.Is5OwnTrainings(1);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Is5OwnTrainings_UserFoundNoSetsOrTrainings_ReturnsNull()
        {
            // Arrange
            var mockContext = new Mock<ApplicationContext>();
            var userData = new List<User>
        {
            new User
            {
                UserId = 1,
                UserSetsOfExercises = new List<UserSetOfExercises>() // No trainings
            }
        };
            mockContext.Setup(c => c.Users).Returns(CreateMockDbSet(userData).Object);

            var service = new AchievmentService(mockContext.Object);

            // Act
            var result = service.Is5OwnTrainings(1);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Is5OwnTrainings_UserFoundLessThan5Trainings_ReturnsNull()
        {
            // Arrange
            var mockContext = new Mock<ApplicationContext>();
            var userData = new List<User>
        {
            new User
            {
                UserId = 1,
                UserSetsOfExercises = new List<UserSetOfExercises>
                {
                    new UserSetOfExercises { UserSetTrainings = new List<BasicalSetTraining> { new BasicalSetTraining(), new BasicalSetTraining() } },
                    new UserSetOfExercises { UserSetTrainings = new List<BasicalSetTraining> { new BasicalSetTraining() } }
                } // Total 3 trainings
            }
        };
            mockContext.Setup(c => c.Users).Returns(CreateMockDbSet(userData).Object);

            var service = new AchievmentService(mockContext.Object);

            // Act
            var result = service.Is5OwnTrainings(1);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Is5OwnTrainings_UserFoundExactly5Trainings_ReturnsAchievement()
        {
            // Arrange
            var mockContext = new Mock<ApplicationContext>();
            var userData = new List<User>
        {
            new User
            {
                UserId = 1,
                UserSetsOfExercises = new List<UserSetOfExercises>
                {
                    new UserSetOfExercises { UserSetTrainings = new List<UserSetTraining> { new UserSetTraining(), new UserSetTraining() } },
                    new UserSetOfExercises { UserSetTrainings = new List<UserSetTraining> { new UserSetTraining(), new UserSetTraining(), new UserSetTraining() } }
                } // Total 5 trainings
            }
        };
            mockContext.Setup(c => c.Users).Returns(CreateMockDbSet(userData).Object);

            var service = new AchievmentService(mockContext.Object);

            // Act
            var result = service.Is5OwnTrainings(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(5, result.AchievmentId);
            Assert.Equal("Finish 5 Your Own Trainings", result.Desc);
            Assert.Equal("Train On Your Own", result.Name);
        }
    }
}
