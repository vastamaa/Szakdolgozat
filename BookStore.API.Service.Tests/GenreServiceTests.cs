using AutoMapper;
using BookStore.API.Contracts;
using BookStore.API.Entities.Exceptions;
using BookStore.API.Models;
using BookStore.API.Shared.DataTransferObjects;
using FluentAssertions;
using FluentAssertions.Execution;
using Moq;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace BookStore.API.Service.Tests
{
    [ExcludeFromCodeCoverage]
    public class GenreServiceTests
    {
        private readonly Mock<IRepositoryManager> _repositoryManager;
        private readonly Mock<ILoggerManager> _logger;
        private readonly Mock<IMapper> _mapper;

        private readonly GenreService _genreService;
        private const string genreId = "49addfd8-33d4-4f00-9149-72163ab2983d";
        private readonly Genre getGenreAsyncResult = new Genre() { GenreId = Guid.NewGuid(), Name = "Sports" };

        public GenreServiceTests()
        {
            _repositoryManager = new Mock<IRepositoryManager>();
            _logger = new Mock<ILoggerManager>();
            _mapper = new Mock<IMapper>();

            _genreService = new GenreService(_repositoryManager.Object, _logger.Object, _mapper.Object);
        }

        [Fact]
        public async Task GetAllGenresAsync_ShouldReturnIEnumerableGenreDto()
        {
            // Arrange
            _repositoryManager.Setup(x => x.Genre.GetAllGenresAsync(It.IsAny<bool>())).ReturnsAsync(new List<Genre>()).Verifiable();

            _mapper.Setup(x => x.Map<IEnumerable<GenreDto>>(It.IsAny<List<Genre>>())).Returns(new List<GenreDto>()).Verifiable();

            // Act
            var result = await _genreService.GetAllGenresAsync(false);

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<List<GenreDto>>();
                _repositoryManager.Verify();
            }
        }

        [Fact]
        public async Task GetGenreAsync_ShouldReturnGenreNotFoundException()
        {
            // Arrange
            _repositoryManager.Setup(x => x.Genre.GetGenreAsync(It.IsAny<Guid>(), It.IsAny<bool>())).Verifiable();

            // Act
            var result = async () => { await _genreService.GetGenreAsync(Guid.Parse(genreId), false); };

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<Func<Task>>();
                await result.Should().ThrowAsync<GenreNotFoundException>().WithMessage($"The genre with id: {genreId} doesn't exist in the database.");
                _repositoryManager.Verify();
            }
        }

        [Fact]
        public async Task GetGenreAsync_ShouldReturnGenreObject()
        {
            // Arrange
            _repositoryManager.Setup(x => x.Genre.GetGenreAsync(It.IsAny<Guid>(), It.IsAny<bool>())).ReturnsAsync(getGenreAsyncResult).Verifiable();
            _mapper.Setup(x => x.Map<GenreDto>(It.IsAny<Genre>())).Returns(new GenreDto() { Id = Guid.Parse(genreId), Name = "Sports" }).Verifiable();

            // Act
            // https://stackoverflow.com/questions/45017295/assert-an-exception-using-xunit
            var result = await _genreService.GetGenreAsync(Guid.Parse(genreId), false);

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<GenreDto>();
                _repositoryManager.Verify();
                _mapper.Verify();
            }
        }

        [Fact]
        public async Task DeleteGenreAsyn_ShouldReturnNothing_SetupMethodsMustRunAtLeastOnce()
        {
            // Arrange
            _repositoryManager.Setup(x => x.Genre.DeleteGenre(It.IsAny<Genre>())).Verifiable();
            _repositoryManager.Setup(x => x.Genre.GetGenreAsync(It.IsAny<Guid>(), It.IsAny<bool>())).ReturnsAsync(getGenreAsyncResult).Verifiable();
            _repositoryManager.Setup(x => x.SaveAsync()).Verifiable();

            // Act
            await _genreService.DeleteGenreAsync(Guid.Parse(genreId), false);

            // Assert
            _repositoryManager.VerifyAll();
        }

        [Fact]
        public async Task CreateGenreAsync_ShouldReturnNothing_SetupMethodsMustRunAtLeastOnce()
        {
            // Arrange
            var genre = new GenreForCreationDto
            {
                Name = "Sports"
            };

            _mapper.Setup(x => x.Map<Genre>(It.IsAny<GenreForCreationDto>())).Returns(new Genre { Name = "Sports" }).Verifiable();
            _mapper.Setup(x => x.Map<GenreDto>(It.IsAny<Genre>())).Returns(new GenreDto { Id = Guid.Parse(genreId), Name = "Sports" }).Verifiable();
            _repositoryManager.Setup(x => x.Genre.CreateGenre(It.IsAny<Genre>())).Verifiable();
            _repositoryManager.Setup(x => x.SaveAsync()).Verifiable();

            // Act
            var result = await _genreService.CreateGenreAsync(genre);

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<GenreDto>();
                _mapper.VerifyAll();
                _repositoryManager.VerifyAll();
            }
        }

        [Fact]
        public async Task SaveChangesForPatchAsync_ShouldReturnNothing_SetupMethodsMustRunAtLeastOnce()
        {
            // Arrange
            var genreForUpdateDto = new GenreForUpdateDto() { Name = "Sports" };
            var genre = new Genre() { GenreId = Guid.NewGuid(), Name = "Sex" };
            _mapper.Setup(x => x.Map(It.IsAny<GenreForUpdateDto>(), It.IsAny<Genre>())).Verifiable();
            _repositoryManager.Setup(x => x.SaveAsync()).Verifiable();

            // Act
            await _genreService.SaveChangesForPatchAsync(genreForUpdateDto, genre);

            // Assert
            using (new AssertionScope())
            {
                _mapper.Verify();
                _repositoryManager.Verify();
            }
        }

        [Fact]
        public async Task UpdateGenreAsync_ShouldUpdateTheGenreAndReturnNothing_SetupMethodsMustRunAtLeastOnce()
        {
            // Arrange
            var genreForUpdate = new GenreForUpdateDto() { Name = "Sports" };
            _repositoryManager.Setup(x => x.Genre.GetGenreAsync(It.IsAny<Guid>(), It.IsAny<bool>())).ReturnsAsync(getGenreAsyncResult).Verifiable();
            _repositoryManager.Setup(x => x.SaveAsync()).Verifiable();
            _mapper.Setup(x => x.Map(It.IsAny<GenreForUpdateDto>(), It.IsAny<Genre>())).Verifiable();

            // Act
            await _genreService.UpdateGenreAsync(Guid.Parse(genreId), genreForUpdate, false);

            // Assert
            using (new AssertionScope())
            {
                _repositoryManager.VerifyAll();
                _mapper.Verify();
            }
        }

        [Fact]
        public async Task UpdateGenreAsync_ShouldReturnAnError()
        {
            // Arrange
            var genreForUpdate = new GenreForUpdateDto() { Name = "Sports" };
            _repositoryManager.Setup(x => x.Genre.GetGenreAsync(It.IsAny<Guid>(), It.IsAny<bool>())).Verifiable();

            // Act
            var result = async () => { await _genreService.UpdateGenreAsync(Guid.Parse(genreId), genreForUpdate, false); };

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<Func<Task>>();
                await result.Should().ThrowAsync<GenreNotFoundException>().WithMessage($"The genre with id: {genreId} doesn't exist in the database.");
                _repositoryManager.Verify();
            }
        }

        [Fact]
        public async Task GetGenreForPatchAsync_ShouldReturnTheGivenType()
        {
            // Arrange
            var genreForUpdate = new GenreForUpdateDto() { Name = "Sports" };
            _repositoryManager.Setup(x => x.Genre.GetGenreAsync(It.IsAny<Guid>(), It.IsAny<bool>())).ReturnsAsync(getGenreAsyncResult).Verifiable();
            _mapper.Setup(x => x.Map<GenreForUpdateDto>(It.IsAny<Genre>())).Returns(genreForUpdate).Verifiable();

            // Act
            var result = await _genreService.GetGenreForPatchAsync(Guid.Parse(genreId), false);

            // Assert
            using (new AssertionScope())
            {
                result.Should().NotBeNull();
                result.Should().BeOfType<(GenreForUpdateDto genreToPatch, Genre genreEntity)>();
                _repositoryManager.Verify();
                _mapper.Verify();
            }
        }
    }
}
