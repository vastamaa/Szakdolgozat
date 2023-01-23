using AutoMapper;
using BookStore.API.Contracts;
using BookStore.API.Entities.Exceptions;
using BookStore.API.Entities.Models;
using BookStore.API.Shared.DataTransferObjects;
using FluentAssertions;
using FluentAssertions.Execution;
using Moq;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace BookStore.API.Service.Tests
{
    [ExcludeFromCodeCoverage]
    public class AuthorServiceTest
    {
        private readonly Mock<IRepositoryManager> _repositoryManager;
        private readonly Mock<ILoggerManager> _logger;
        private readonly Mock<IMapper> _mapper;

        private readonly AuthorService _authorService;
        private const string authorId = "49addfd8-33d4-4f00-9149-72163ab2983d";
        private readonly Author getAuthorAsyncResult = new Author() { Id = Guid.Parse(authorId), Name = "Tomtom" };

        public AuthorServiceTest()
        {
            _repositoryManager = new Mock<IRepositoryManager>();
            _logger = new Mock<ILoggerManager>();
            _mapper = new Mock<IMapper>();

            _authorService = new AuthorService(_repositoryManager.Object, _logger.Object, _mapper.Object);
        }

        [Fact]
        public async Task GetAllAuthorsAsync_ShouldReturnIEnumerableAuthorDto()
        {
            // Arrange
            _repositoryManager.Setup(x => x.Author.GetAllAuthorsAsync(It.IsAny<bool>())).ReturnsAsync(new List<Author>()).Verifiable();

            // https://stackoverflow.com/questions/36074324/how-to-mock-an-automapper-imapper-object-in-web-api-tests-with-structuremap-depe
            _mapper.Setup(x => x.Map<IEnumerable<AuthorDto>>(It.IsAny<List<Author>>())).Returns(new List<AuthorDto>()).Verifiable();

            // Act
            var result = await _authorService.GetAllAuthorsAsync(false);

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<List<AuthorDto>>();
                _repositoryManager.Verify();
            }
        }

        [Fact]
        public async Task GetAuthorAsync_ShouldReturnAuthorNotFoundException()
        {
            // Arrange
            _repositoryManager.Setup(x => x.Author.GetAuthorAsync(It.IsAny<Guid>(), It.IsAny<bool>())).Verifiable();

            // Act
            // https://stackoverflow.com/questions/45017295/assert-an-exception-using-xunit
            var result = async () => { await _authorService.GetAuthorAsync(Guid.Parse(authorId), false); };

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<Func<Task>>();
                await result.Should().ThrowAsync<AuthorNotFounException>().WithMessage($"The author with id: {authorId} doesn't exist in the database.");
                _repositoryManager.Verify();
            }
        }

        [Fact]
        public async Task GetAuthorAsync_ShouldReturnAuthorObject()
        {
            // Arrange
            _repositoryManager.Setup(x => x.Author.GetAuthorAsync(It.IsAny<Guid>(), It.IsAny<bool>())).ReturnsAsync(getAuthorAsyncResult).Verifiable();
            _mapper.Setup(x => x.Map<AuthorDto>(It.IsAny<Author>())).Returns(new AuthorDto() { Id = Guid.Parse(authorId), Name = "Tomtom" }).Verifiable();

            // Act
            // https://stackoverflow.com/questions/45017295/assert-an-exception-using-xunit
            var result = await _authorService.GetAuthorAsync(Guid.Parse(authorId), false);

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<AuthorDto>();
                _repositoryManager.Verify();
                _mapper.Verify();
            }
        }

        [Fact]
        public async Task DeleteAuthorAsyn_ShouldReturnNothing_SetupMethodsMustRunAtLeastOnce()
        {
            // Arrange
            _repositoryManager.Setup(x => x.Author.DeleteAuthor(It.IsAny<Author>())).Verifiable();
            _repositoryManager.Setup(x => x.Author.GetAuthorAsync(It.IsAny<Guid>(), It.IsAny<bool>())).ReturnsAsync(getAuthorAsyncResult).Verifiable();
            _repositoryManager.Setup(x => x.SaveAsync()).Verifiable();

            // Act
            await _authorService.DeleteAuthorAsync(Guid.Parse(authorId), false);

            // Assert
            _repositoryManager.VerifyAll();
        }

        [Fact]
        public async Task CreateAuthorAsync_ShouldReturnNothing_SetupMethodsMustRunAtLeastOnce()
        {
            // Arrange
            var author = new AuthorForCreationDto
            {
                Name = "Chin Chin"
            };

            _mapper.Setup(x => x.Map<Author>(It.IsAny<AuthorForCreationDto>())).Returns(new Author { Name = "Chin Chin" }).Verifiable();
            _mapper.Setup(x => x.Map<AuthorDto>(It.IsAny<Author>())).Returns(new AuthorDto { Id = Guid.Parse(authorId), Name = "Chin Chin" }).Verifiable();
            _repositoryManager.Setup(x => x.Author.CreateAuthor(It.IsAny<Author>())).Verifiable();
            _repositoryManager.Setup(x => x.SaveAsync()).Verifiable();

            // Act
            var result = await _authorService.CreateAuthorAsync(author);

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<AuthorDto>();
                _mapper.VerifyAll();
                _repositoryManager.VerifyAll();
            }
        }

        [Fact]
        public async Task SaveChangesForPatchAsync_ShouldReturnNothing_SetupMethodsMustRunAtLeastOnce()
        {
            // Arrange
            var authorFoUpdateDto = new AuthorForUpdateDto() { Name = "TomTom" };
            var author = new Author() { Id = Guid.Parse(authorId), Name = "BomBom" };
            _mapper.Setup(x => x.Map(It.IsAny<AuthorForUpdateDto>(), It.IsAny<Author>())).Verifiable();
            _repositoryManager.Setup(x => x.SaveAsync()).Verifiable();

            // Act
            await _authorService.SaveChangesForPatchAsync(authorFoUpdateDto, author);

            // Assert
            using (new AssertionScope())
            {
                _mapper.Verify();
                _repositoryManager.Verify();
            }
        }

        [Fact]
        public async Task UpdateAuthorAsync_ShouldUpdateTheAuthorAndReturnNothing_SetupMethodsMustRunAtLeastOnce()
        {
            // Arrange
            var authorForUpdate = new AuthorForUpdateDto() { Name = "TomTom" };
            _repositoryManager.Setup(x => x.Author.GetAuthorAsync(It.IsAny<Guid>(), It.IsAny<bool>())).ReturnsAsync(getAuthorAsyncResult).Verifiable();
            _repositoryManager.Setup(x => x.SaveAsync()).Verifiable();
            _mapper.Setup(x => x.Map(It.IsAny<AuthorForUpdateDto>(), It.IsAny<Author>())).Verifiable();

            // Act
            await _authorService.UpdateAuthorAsync(Guid.Parse(authorId), authorForUpdate, false);

            // Assert
            using (new AssertionScope())
            {
                _repositoryManager.VerifyAll();
                _mapper.Verify();
            }
        }

        [Fact]
        public async Task UpdateAuthorAsync_ShouldReturnAnError()
        {
            // Arrange
            var authorForUpdate = new AuthorForUpdateDto() { Name = "TomTom" };
            _repositoryManager.Setup(x => x.Author.GetAuthorAsync(It.IsAny<Guid>(), It.IsAny<bool>())).Verifiable();

            // Act
            var result = async () => { await _authorService.UpdateAuthorAsync(Guid.Parse(authorId), authorForUpdate, false); };

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<Func<Task>>();
                await result.Should().ThrowAsync<AuthorNotFounException>().WithMessage($"The author with id: {authorId} doesn't exist in the database.");
                _repositoryManager.Verify();
            }
        }

        [Fact]
        public async Task GetAuthorForPatchAsync_ShouldReturnTheGivenType()
        {
            // Arrange
            var authorForUpdate = new AuthorForUpdateDto() { Name = "TomTom" };
            _repositoryManager.Setup(x => x.Author.GetAuthorAsync(It.IsAny<Guid>(), It.IsAny<bool>())).ReturnsAsync(getAuthorAsyncResult).Verifiable();
            _mapper.Setup(x => x.Map<AuthorForUpdateDto>(It.IsAny<Author>())).Returns(authorForUpdate).Verifiable();

            // Act
            var result = await _authorService.GetAuthorForPatchAsync(Guid.Parse(authorId), false);

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<(AuthorForUpdateDto authorToPatch, Author authorEntity)>();
                _repositoryManager.Verify();
                _mapper.Verify();
            }
        }
    }
}