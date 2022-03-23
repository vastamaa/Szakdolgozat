using BookStore.API.Models;
using System.Threading.Tasks;

namespace BookStore.API.Services.Interfaces
{
    public interface IMailService
    {
        Task SendEmailAsync(MailStructure mailRequest);
    }
}
