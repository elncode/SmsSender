using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

class Example
{
    static void Main(string[] args)
    {
        // Reemplazar con tu Account SID de Twilio
        var accountSid = "**************************";
        
        // Reemplazar con tu Auth Token de Twilio
        var authToken = "**************************";
        
        TwilioClient.Init(accountSid, authToken);

        // Reemplazar con el número de teléfono del destinatario
        var messageOptions = new CreateMessageOptions(
            new PhoneNumber("***********"));
        
        // Reemplazar con tu número de teléfono de Twilio
        messageOptions.From = new PhoneNumber("***********");
        
        messageOptions.Body = "Hello from Twilio";

        var message = MessageResource.Create(messageOptions);
        Console.WriteLine(message.Body);
    }
}
