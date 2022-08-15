﻿using DevFreela.Application.Commands.CreateProject;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.UnitTests.Application.Commands
{
    public class CreateProjectCommandHandlerTests
    {
        [Fact]
        public async Task InputDataIsOk_Executed_ReturnProjectId()
        {
            //Arrange
            var projectRepositoryMock = new Mock<IProjectRepository>();

            var createProjcetCommand = new CreateProjectCommand
            {
                Title = "Titulo de teste",
                Description = "Descrição de teste",
                TotalCost = 20000,
                IdClient = 1,
                IdFreelancer = 2,
            };

            var createProjectCommandHandler = new CreateProjectCommandHandler(projectRepositoryMock.Object);

            //Act

            var id = await createProjectCommandHandler.Handle(createProjcetCommand, new CancellationToken());

            //Assert

            Assert.True(id >= 0);

            projectRepositoryMock.Verify(pr => pr.AddAsync(It.IsAny<Project>()), Times.Once);

        }
    }
}