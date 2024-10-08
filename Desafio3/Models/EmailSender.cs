using Microsoft.AspNetCore.Identity;

namespace Desafio3.Models
{
    public class EmailSender : IEmailSender<Usuario>
    {
        public Task SendConfirmationLinkAsync(Usuario user, string email, string confirmationLink)
        {
    
            return Task.CompletedTask;
        }

        public Task SendEmailAsync(Usuario user, string subject, string message)
        {
           
            return Task.CompletedTask;
        }

        public Task SendPasswordResetCodeAsync(Usuario user, string email, string resetCode)
        {
       
            return Task.CompletedTask;
        }

        public Task SendPasswordResetLinkAsync(Usuario user, string email, string resetLink)
        {
         
            return Task.CompletedTask;
        }
    }
}
