using LeagueAPI.Controllers;
using LeagueAPI.Models;
using LeagueAPI.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeagueAPI.Tests
{
    public class PositionControllerTests
    {
        private PositionController underTest;
        IRepository<Position> PositionRepo;

        public PositionControllerTests()
        {
            PositionRepo = Substitute.For<IRepository<Position>>();
            underTest = new PositionController(PositionRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Positions()
        {
            var expectedPositions = new List<Position>()
            {
                new Position(1, "Name", "image"),
                new Position(1, "Name", "image")
        };
            PositionRepo.GetAll().Returns(expectedPositions);

            var result = underTest.Get();

            Assert.Equal(expectedPositions, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Position()
        {
            var newPosition = new Position(1, "Name", "image");
            var PositionList = new List<Position>();

            PositionRepo.When(t => t.Create(newPosition))
                .Do(t => PositionList.Add(newPosition));

            PositionRepo.GetAll().Returns(PositionList);

            var result = underTest.Post(newPosition);

            Assert.Contains(newPosition, result);
        }

        [Fact]
        public void Delete_Removes_Position()
        {
            var PositionId = 1;
            var deletedPosition = new Position(1, "Name", "image");
            var PositionList = new List<Position>()
            {
                deletedPosition,
                new Position(1, "Name", "image")
        };

            PositionRepo.GetById(PositionId).Returns(deletedPosition);
            PositionRepo.When(d => d.Delete(deletedPosition))
                .Do(d => PositionList.Remove(deletedPosition));
            PositionRepo.GetAll().Returns(PositionList);

            var result = underTest.Delete(PositionId);

            Assert.DoesNotContain(deletedPosition, result); /*Does not work in all cases*/
            //Assert.All(result, item => Assert.Contains("Second item", item.Name));
        }

        [Fact]
        public void Put_Updates_Position()
        {
            var originalPosition = new Position(1, "Name", "image"); ;
            var expectedPositions = new List<Position>()
            {
                originalPosition
            };
            var updatedPosition = new Position(1, "Name", "image");

            PositionRepo.When(t => PositionRepo.Update(updatedPosition))
                .Do(Callback.First(t => expectedPositions.Remove(originalPosition))
                .Then(t => expectedPositions.Add(updatedPosition)));
            PositionRepo.GetAll().Returns(expectedPositions);

            var result = underTest.Put(updatedPosition);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }
    }
}
