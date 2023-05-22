using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Maxicycles.Services;

public class EmailSender : IEmailSender
{
    // Define an instance of a logger.
    private readonly ILogger _logger;

    // Constructor, that uses dependency injection to inject the key and a logger.
    public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor, ILogger<EmailSender> logger)
    {
        Options = optionsAccessor.Value;
        _logger = logger;
    }
    
    // Define the options property.
    public AuthMessageSenderOptions Options { get; } // Set with secrets manager.

    // Define a function to send an email.
    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        
        // If the secret key string is null or empty.
        if (string.IsNullOrEmpty(Options.SendGridKey))
        {
            throw new Exception("Null SendGridKey");
        }
        
        // Asynchronously send a html message to the chosen email.
        await Execute(Options.SendGridKey, subject, htmlMessage, email);
    }
    
    public async Task Execute(string apiKey, string subject, string message, string toEmail)
    {
        // Define the client.
        var client = new SendGridClient(apiKey);
        
        // Create an variable to store the send grid message.
        var msg = new SendGridMessage()
        {
            From = new EmailAddress("Support@em6724.maxicycles.co.uk", "Maxicycles"),
            Subject = subject,
            PlainTextContent = message,
            HtmlContent = message
        };
        msg.AddTo(new EmailAddress(toEmail));

        // Disable click tracking.
        // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
        msg.SetClickTracking(false, false);
        
        // Send the email and store the response in a variable.
        var response = await client.SendEmailAsync(msg);
        
        _logger.LogInformation(response.IsSuccessStatusCode 
            ? $"Email to {toEmail} queued successfully!"
            : $"Failure Email to {toEmail}");
    }
}