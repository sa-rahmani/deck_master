using WebSec3_IPN.Models;
using SendGrid;
using System.Threading.Tasks;

namespace WebSec3_IPN.Data.Services

{
    public interface IEmailService
    {
        Task<Response> SendSingleEmail(ComposeEmailModel payload);
    }
}
