using Amazon.SQS.Model;
using Amazon.SQS;
using Amazon;

var client = new AmazonSQSClient(RegionEndpoint.USEast1);
var request = new SendMessageRequest()
{
    QueueUrl = "https://sqs.us-east-1.amazonaws.com/207567769079/teste",
    MessageBody = "aaa ze da manga"
};

await client.SendMessageAsync(request);
