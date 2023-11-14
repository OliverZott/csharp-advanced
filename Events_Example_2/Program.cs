// See https://aka.ms/new-console-template for more information

using Events_Example_2;

var video = new Video
{
    Title = "Donnie Darko",
    Year = 2001
};
var videoEncoder = new VideoEncoder();
var smsMessage = new SmsMessage(); // Subscriber
var mailMessage = new MailMessage(); // Subscriber
var simpleMessage = new SimpleMessage(); // Subscriber

// Assign event-handler (rhs) to publisher.event (lhs)
videoEncoder.VideoEncoded += smsMessage.VideoEncodedMessage;
videoEncoder.VideoEncoded += mailMessage.VideoEncodedMessage;
videoEncoder.VideoEncodedSimple += simpleMessage.VideoEncodedMessage;

// Do stuff and raise event
videoEncoder.Encode(video);