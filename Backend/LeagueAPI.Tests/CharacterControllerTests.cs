using Xunit;
using NSubstitute;
using System.Collections.Generic;
using System.Linq;
using LeagueAPI.Controllers;
using LeagueAPI.Models;
using LeagueAPI.Repositories;

namespace LeagueAPI.Tests
{
    public class CharacterControllerTests
    {
        private CharacterController underTest;
        IRepository<Character> characterRepo;

        public CharacterControllerTests()
        {
            characterRepo = Substitute.For<IRepository<Character>>();
            underTest = new CharacterController(characterRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Characters()
        {
            var expectedCharacters = new List<Character>()
            {
                new Character(1, "Title", 1, "image", "label", "thing"),
                new Character(1, "Title",1,  "image", "label","thing"),
        };
            characterRepo.GetAll().Returns(expectedCharacters);

            var result = underTest.Get();

            Assert.Equal(expectedCharacters, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Character()
        {
            var newCharacter = new Character(1, "Title", 1, "string", "image", "label" );
            var CharacterList = new List<Character>();

            characterRepo.When(t => t.Create(newCharacter))
                .Do(t => CharacterList.Add(newCharacter));

            characterRepo.GetAll().Returns(CharacterList);

            var result = underTest.Post(newCharacter);

            Assert.Contains(newCharacter, result);
        }

        [Fact]
        public void Delete_Removes_Character()
        {
            var CharacterId = 1;
            var deletedCharacter = new Character(1, "Title", 1, "image", "label", "thing");
            var CharacterList = new List<Character>()
            {
                deletedCharacter,
                new Character(1, "Title", 1, "image", "label", "thing" )
        };

            characterRepo.GetById(CharacterId).Returns(deletedCharacter);
            characterRepo.When(d => d.Delete(deletedCharacter))
                .Do(d => CharacterList.Remove(deletedCharacter));
            characterRepo.GetAll().Returns(CharacterList);

            var result = underTest.Delete(CharacterId);

            Assert.DoesNotContain(deletedCharacter, result); /*Does not work in all cases*/
            //Assert.All(result, item => Assert.Contains("Second item", item.Title));
        }

        [Fact]
        public void Put_Updates_Character()
        {
            var originalCharacter = new Character(1, "Title", 1, "image", "label", "thing");
            var expectedCharacters = new List<Character>()
            {
                originalCharacter
            };
            var updatedCharacter = new Character(1, "Title", 1, "image", "label", "thing");

            characterRepo.When(t => characterRepo.Update(updatedCharacter))
                .Do(Callback.First(t => expectedCharacters.Remove(originalCharacter))
                .Then(t => expectedCharacters.Add(updatedCharacter)));
            characterRepo.GetAll().Returns(expectedCharacters);

            var result = underTest.Put(updatedCharacter);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }
    }
}
