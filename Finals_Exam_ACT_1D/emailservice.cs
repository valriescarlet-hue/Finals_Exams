using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace Finals_Exam_ACT_1D;

class emailservices
{
    static async Task Main()
    {
        await SendEmail();
    }

    static async Task SendEmail()
    {
        // For security, store your API key in an environment variable
        var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
        var client = new SendGridClient(apiKey);

        // Define sender and recipient
        var from = new EmailAddress("sender@example.com", "Your Name");
        var to = new EmailAddress("recipient@example.com", "Recipient Name");

        var subject = "welcome this is jclmr rental company";
        var plainTextContent = "thank you for using our services to build you a plateform for your vehicles.";
        var htmlContent = "<strong> sign off jclmr</strong>";

        // Create the email message object
        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

        // Send the email and wait for the response
        var response = await client.SendEmailAsync(msg);

        // 202 Accepted means it was successfully sent to SendGrid's queue
        Console.WriteLine(response.StatusCode == System.Net.HttpStatusCode.Accepted
            ? "Email sent successfully!"
            : $"Failed to send email. Status Code: {response.StatusCode}");
    }
}
