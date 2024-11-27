using Amazon;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

var snsClient = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USEast1);

var numbers = new List<string>
{
    "+num1",
    "+num2"
};

foreach (string n in numbers)
{

    var request = new PublishRequest()
    {
        Message = "aaa ze da manga",
        PhoneNumber = n,
    };

    await snsClient.PublishAsync(request);
}
