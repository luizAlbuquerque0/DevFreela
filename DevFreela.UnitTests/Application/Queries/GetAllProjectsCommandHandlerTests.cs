using DevFreela.Application.Queries.GetAllProjetcts;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.UnitTests.Application.Queries
{
    public class GetAllProjectsCommandHandlerTests
    {
        [Fact]
        public async Task ThreeProjectsExist_Executed_ReturnThreeProjectsViewModel()
        {
            //Arrange
            var projects = new List<Project>
            {
                new Project("Nome de teste", "Descrição de teste", 1, 2, 1000),
                new Project("Nome de teste 2", "Descrição de teste 2", 1, 2, 2000),
                new Project("Nome de teste 3", "Descrição de teste 3", 1, 2, 3000),
            };

            var projectRepositoryMock = new Mock<IProjectRepository>();
            projectRepositoryMock.Setup(pr => pr.GetAllAsync().Result).Returns(projects);

            var getAllProjectsQuery = new GetAllProjectsQuery("");
            var getAllProjectsQueryHandler = new GetAllProjectsQueryHandler(projectRepositoryMock.Object);

            //Act

            var projectViewModel = await getAllProjectsQueryHandler.Handle(getAllProjectsQuery, new CancellationToken());

            //Assert
            Assert.NotNull(projectViewModel);
            Assert.NotEmpty(projectViewModel);
            Assert.Equal(projects.Count, projectViewModel.Count);

            projectRepositoryMock.Verify(pr => pr.GetAllAsync().Result, Times.Once);

        }
    }
}
